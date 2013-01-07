using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vectra
{
    public partial class Backup : Form
    {
        public bool ExitOrClose;
        public Backup()
        {
            InitializeComponent();            
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            this.btnBackup.Enabled = false;
            this.toolStripStatusLabel1.Text = "Copying...";
            Refresh();
            BackupSimple.doBackup(0);
            this.toolStripStatusLabel1.Text = "Done.";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {   
            if (checkBox1.Checked == true)
            {
                this.toolStripStatusLabel1.Text = "Ready";
                this.panel1.Enabled = true;
                this.btnCopy.Enabled = true;

            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxLocation.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnCopy.Enabled = false;
                this.toolStripStatusLabel1.Text = "Copying...";
                Refresh();
                BackupSimple.Copy2Drive(tbxLocation.Text);
                this.toolStripStatusLabel1.Text = "Done.";
                Refresh();
            }
            catch (Exception ex)
            {
                this.toolStripStatusLabel1.Text = "Error";
                MessageBox.Show(ex.Message.ToString(), "Attempting to Copy to External Drive");
                this.toolStripStatusLabel1.Text = "Ready, Try Again";
                this.btnCopy.Enabled = true;
                Refresh();
            }
        }
    }
}
