using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LiveCharts; //Core of the library
using LiveCharts.Geared;
using LiveCharts.Wpf; //The WPF controls
using LiveCharts.WinForms; //the WinForm wrappers
using System.Windows.Media;
using System.Threading;
using SharpOSC;

namespace CSPIDTuner
{
    public partial class frmMain : Form
    {
        private const int PORT = 5800; 

        private bool runThread = true;
        private static Mutex messageMutex = new Mutex();
        private ConstrainedGearedValues<double> actualPoints = new ConstrainedGearedValues<double>(100);
        private ConstrainedGearedValues<double> requestedPoints = new ConstrainedGearedValues<double>(100);
        private Queue<OscMessage> messageQueue = new Queue<OscMessage>();

        private void frmMain_Load(object sender, EventArgs e)
        {

            new Thread(() =>
            {
                var listener = new UDPListener(PORT);
                OscMessage messageReceived = null;
            
                while (runThread == true)
                {
                    messageReceived = (OscMessage)listener.Receive();
                    if (messageReceived != null)
                    {
                        messageMutex.WaitOne();
                        messageQueue.Enqueue(messageReceived);
                        messageMutex.ReleaseMutex();
                    }
                }

                listener.Close();
            }).Start();

            new Thread(() =>
            {
                while (runThread == true)
                {
                    OscMessage messageReceived = null;
                    messageMutex.WaitOne();
                    if (messageQueue.Count > 0)
                        messageReceived = messageQueue.Dequeue();
                    messageMutex.ReleaseMutex();

                    if (messageReceived != null)
                    {
                        switch (messageReceived.Address)
                        {
                            case "/bullshit":
                                actualPoints.Add((double)(float)messageReceived.Arguments[0]);
                                requestedPoints.Add((double)(float)messageReceived.Arguments[1]);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }).Start();

            pidChart.Hoverable = false;
            pidChart.DisableAnimations = true;
            pidChart.DataTooltip = null;
        }



        public frmMain()
        {
            InitializeComponent();

            pidChart.Series = new SeriesCollection
            {
                new GLineSeries
                {
                    Title = "Actual Output",
                    Values = actualPoints,
                    PointGeometry = null,
                },
                new GLineSeries
                {
                    Title = "Requested Output",
                    Values = requestedPoints,
                    PointGeometry = null,
                }
            };

            pidChart.AxisX.Add(new Axis
            {
                Title = "Time",
                MaxWidth = 100,
            });

            pidChart.AxisY.Add(new Axis
            {
                Title = "Value",
                MaxWidth = 100,
            });

            pidChart.LegendLocation = LegendLocation.Right;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            runThread = false;
        }
    }
}
