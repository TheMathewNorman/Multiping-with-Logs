using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ping_with_Logs
{
    public partial class formSettings : Form
    {
        public formSettings()
        {
            InitializeComponent();
        }

        private void cbGenerateLogs_CheckedChanged(object sender, EventArgs e)
        {
            // Update dependant option visibility.
            if (cbGenerateLogs.Checked)
            {
                cbLogTimestamps.Visible = true;
                cbErrorsToSeparateFile.Visible = true;
            }
            else
            {
                cbLogTimestamps.Visible = false;
                cbErrorsToSeparateFile.Visible = false;
            }


        }

        private void cbCustomTimeout_CheckedChanged(object sender, EventArgs e)
        {
            // Update dependant option visibility.
            if (cbCustomTimeout.Checked)
            {
                nudTimeout.Visible = true;
            }
            else
            {   
                nudTimeout.Visible = false;
            }
        }
    }
}
