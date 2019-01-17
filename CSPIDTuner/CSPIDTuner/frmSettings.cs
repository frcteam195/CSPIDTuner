using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSPIDTuner
{
    public partial class frmSettings : Form
    {
        public int selectedPort { get; private set; }
        public string ipAddress { get; private set; }

        private static RegistryKey SoftwareKey = Registry.CurrentUser.CreateSubKey("Software");
        private static RegistryKey ManufacturerKey = SoftwareKey.CreateSubKey(Application.CompanyName);

        public frmSettings()
        {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            selectedPort = (int)numPort.Value;
            ipAddress = txtIPAddress.Text;

            using (RegistryKey Settings = ManufacturerKey.CreateSubKey(Application.ProductName))
            {
                Settings.SetValue("IPAddress", ipAddress);
                Settings.SetValue("SelectedPort", selectedPort);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            using (RegistryKey Settings = ManufacturerKey.CreateSubKey(Application.ProductName))
            {
                if (Settings != null)
                {
                    string[] vals = Settings.GetValueNames();
                    foreach (string s in vals)
                    {
                        try
                        {
                            if (s == "IPAddress")
                            {
                                txtIPAddress.Text = Settings.GetValue(s).ToString();
                            }
                            else if (s == "SelectedPort")
                            {
                                numPort.Value = Convert.ToInt32(Settings.GetValue(s).ToString());
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }

                }
            }
        }
    }
}
