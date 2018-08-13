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
using System.Diagnostics;

namespace CSPIDTuner
{
    public partial class frmMain : Form
    {
        private const int PORT = 5800; 

        private bool runThread = true;
        private ConstrainedGearedValues<double> actualPoints = new ConstrainedGearedValues<double>(100);
        private ConstrainedGearedValues<double> requestedPoints = new ConstrainedGearedValues<double>(100);

        private int sleepRate = 0;
        private long messageCounter = 0;

        private void frmMain_Load(object sender, EventArgs e)
        {

            new Thread(() =>
            {
                var listener = new UDPListener(PORT);
                OscMessage messageReceived = null;

                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                while (runThread == true)
                {
                    /**
                     * Tuning Packet Descriptor
                     * Actual Value, Requested Value, IAccum
                     */
                    messageReceived = (OscMessage)listener.Receive();
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

                        messageCounter++;

                        if (stopWatch.ElapsedMilliseconds > 200)
                        {
                            //Update TextBox UI Every 200ms to avoid slowing down the app
                            //txtActualVal.Invoke((MethodInvoker)delegate { textBox.Text = newValue; });

                            if (messageCounter > 200)
                                sleepRate = 0;
                            else
                                sleepRate = (int) ((200.0 / messageCounter) / 2.0);
                            messageCounter = 0;
                            stopWatch.Restart();
                        }

                    }

                    if (sleepRate != 0)
                        Thread.Sleep(sleepRate);
                }

                listener.Close();
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

        private void cmdApply_Click(object sender, EventArgs e)
        {

        }

        private void cmdResetAverage_Click(object sender, EventArgs e)
        {

        }
    }
}
