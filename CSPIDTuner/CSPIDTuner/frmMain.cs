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
        private readonly int PORT; 
        private readonly string ROBOT_IP;

        private bool runThread = true;
        private ConstrainedGearedValues<double> actualPoints = new ConstrainedGearedValues<double>(100);
        private ConstrainedGearedValues<double> requestedPoints = new ConstrainedGearedValues<double>(100);
        private MovingAverage averageError = new MovingAverage(20);
        private UDPSender oscSender;
        private bool initCompleted = false;


        private int sleepRate = 20;
        private long messageCounter = 0;
        private Thread updateThread;

        private void frmMain_Load(object sender, EventArgs e)
        {
            updateThread = new Thread(() =>
            {
                var listener = new UDPListener(PORT);
                OscMessage messageReceived = null;

                int nameUpdateCounter = 0;

                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                while (runThread == true)
                {
                    /**
                     * Tuning Packet Descriptor
                     * Actual Value, Requested Value, IAccum, System Name
                     */
                    if (!initCompleted)
                    {
                        //Initialize the connection
                        sendIAccumReset();
                        initCompleted = true;
                    }

                    messageReceived = (OscMessage)listener.Receive();
                    if (messageReceived != null)
                    {
                        switch (messageReceived.Address)
                        {
                            case "/PIDData":
                                try
                                {
                                    double actualVal = (double)messageReceived.Arguments[0];
                                    double requestedVal = (double)messageReceived.Arguments[1];
                                    actualPoints.Add(actualVal);
                                    requestedPoints.Add(requestedVal);
                                    if (stopWatch.ElapsedMilliseconds > 200)
                                    {
                                        //Update TextBox UI Every 200ms to avoid slowing down the app
                                        double iAccum = (double)messageReceived.Arguments[2];
                                        double err = requestedVal - actualVal;
                                        averageError.AddNumber(err);
                                        txtActualVal.Invoke((MethodInvoker)delegate { txtActualVal.Text = actualVal.ToString("0.####"); });
                                        txtDesiredVal.Invoke((MethodInvoker)delegate { txtDesiredVal.Text = requestedVal.ToString("0.####"); });
                                        txtDeviation.Invoke((MethodInvoker)delegate { txtDeviation.Text = err.ToString("0.####"); });
                                        txtAverageDev.Invoke((MethodInvoker)delegate { txtAverageDev.Text = averageError.GetAverage().ToString("0.####"); });
                                        txtIAccum.Invoke((MethodInvoker)delegate { txtIAccum.Text = iAccum.ToString("0.####"); });

                                        if (nameUpdateCounter++ % 5 == 0)
                                            txtSysName.Invoke((MethodInvoker)delegate { txtSysName.Text = (string)messageReceived.Arguments[3]; });

                                        if (messageCounter > 200)
                                            sleepRate = 0;
                                        else
                                            sleepRate = (int)((200.0 / messageCounter) / 2.0);
                                        messageCounter = 0;
                                        stopWatch.Restart();
                                    }
                                }
                                catch (Exception) { }
                                break;
                            default:
                                break;
                        }

                        messageCounter++;
                    }

                    if (sleepRate > 0)
                        Thread.Sleep(sleepRate);
                }

                listener.Close();
            });
            updateThread.Start();

            pidChart.Hoverable = false;
            pidChart.DisableAnimations = true;
            pidChart.DataTooltip = null;

            numkP.LostFocus += sendPIDUpdate;
            numkI.LostFocus += sendPIDUpdate;
            numkD.LostFocus += sendPIDUpdate;
            numkF.LostFocus += sendPIDUpdate;
            numAccel.LostFocus += sendPIDUpdate;
            numVel.LostFocus += sendPIDUpdate;
            numRamp.LostFocus += sendPIDUpdate;
            numIZone.LostFocus += sendPIDUpdate;
            numSetpoint.LostFocus += sendPIDUpdate;
            numMaxIAccum.LostFocus += sendPIDUpdate;

            numkP.KeyDown += checkEnter_Pressed;
            numkI.KeyDown += checkEnter_Pressed;
            numkD.KeyDown += checkEnter_Pressed;
            numkF.KeyDown += checkEnter_Pressed;
            numAccel.KeyDown += checkEnter_Pressed;
            numVel.KeyDown += checkEnter_Pressed;
            numRamp.KeyDown += checkEnter_Pressed;
            numIZone.KeyDown += checkEnter_Pressed;
            numSetpoint.KeyDown += checkEnter_Pressed;
            numMaxIAccum.KeyDown += checkEnter_Pressed;
        }



        public frmMain()
        {
            InitializeComponent();

            frmSettings settingsLoader = new frmSettings();
            if (settingsLoader.ShowDialog() != DialogResult.OK)
                Environment.Exit(0);

            PORT = settingsLoader.selectedPort;
            ROBOT_IP = settingsLoader.ipAddress;
            try
            {
                oscSender = new UDPSender(ROBOT_IP, PORT);
            } catch (Exception)
            {
                MessageBox.Show("Error creating UDP Sender. Make sure your IP Address and port settings are correct!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }

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
                Title = "Sample",
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
            if (updateThread != null)
                updateThread.Join(1000);
            Environment.Exit(0);
        }

        private void checkEnter_Pressed(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                sendPIDUpdate(sender, e);
            }
        }

        private void cmdApply_Click(object sender, EventArgs e)
        {
            sendPIDUpdate(sender, e);
        }

        private void cmdClearIAccum_Click(object sender, EventArgs e)
        {
            sendIAccumReset();
        }

        private void sendPIDUpdate(object sender, EventArgs e)
        {
            var message = new OscMessage("/PIDUpdate",
                (double)numkP.Value,
                (double)numkI.Value,
                (double)numkD.Value,
                (double)numkF.Value,
                (double)numAccel.Value,
                (double)numVel.Value,
                (double)numRamp.Value,
                (double)numIZone.Value,
                (double)numSetpoint.Value,
                (double)numMaxIAccum.Value);
            oscSender.Send(message);
        }

        private void sendIAccumReset()
        {
            sendIAccumReset(0);
        }

        private void sendIAccumReset(double sendVal)
        {
            var message = new OscMessage("/IReset", sendVal);
            oscSender.Send(message);
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            sendIAccumReset();
        }
    }
}
