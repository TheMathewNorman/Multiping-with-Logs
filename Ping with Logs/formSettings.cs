using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
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
                cbLogErrorsToSeparateFile.Visible = true;
            }
            else
            {
                cbLogTimestamps.Visible = false;
                cbLogErrorsToSeparateFile.Visible = false;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HostnameOrIP hi = new HostnameOrIP();
            string address;
       
            // Validate the users input
            if (hi.TryParse(textAddressInput.Text, out address))
                listLocations.Items.Add(address);
            else
                MessageBox.Show(textAddressInput.Text + " is not a valid IP address or hostname.", "Error");

            // Clear the input box
            textAddressInput.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Remove the currently selected item from the locations list
            listLocations.Items.Remove(listLocations.SelectedItem);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Empty the locations list
            listLocations.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
