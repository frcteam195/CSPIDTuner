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

        public frmSettings()
        {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            selectedPort = (int)numPort.Value;
            ipAddress = txtIPAddress.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
