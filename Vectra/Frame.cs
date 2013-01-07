using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Devart.Common;
using Devart.Data;
using Devart.Data.SQLite;

namespace Vectra
{
    public partial class Frame : Form
    {
        public bool quickExit = false;
        public TextWriter logFile;

        public bool demandBackup=true;

        public void activateForm(Form f, FormWindowState ws, FormStartPosition fs)
        {
            demandBackup = true;
            foreach (Form each in MdiChildren)
            {
                if ((string)each.Tag != "1")
                {
                    each.Close();
                }
            }
            
            if (fs == FormStartPosition.Manual)
            {
                f.StartPosition = FormStartPosition.Manual;
                int w = this.Width;
                int h = this.Height;
                f.Left = (w - f.Width) / 4;
                f.Top = (h - f.Height) / 6;
            }
            else
            {
                f.StartPosition = fs;
            }
            f.WindowState = ws;
            f.MdiParent = this;
            f.ControlBox = false;
            f.Show();
        }

        public void monitor_TraceEvent(object sender, Devart.Common.MonitorEventArgs e)
        {            
            if (e.TracePoint == MonitorTracePoint.BeforeEvent)
            {
                logFile.WriteLine(e.Description);
            }
            else if (e.EventType == MonitorEventType.Error)
            {
                logFile.WriteLine("Error: " + e.Description);
            }
            logFile.Flush();
        }


        public Frame()
        {
            InitializeComponent();
                     
            sqLiteMonitor1.IsActive = true;            
            sqLiteMonitor1.TraceEvent += new Devart.Common.MonitorEventHandler(this.monitor_TraceEvent);
            logFile = new StreamWriter("vectra.log");
           
            Form f = new Home();
            activateForm(f, FormWindowState.Normal, FormStartPosition.Manual);
        }


        private void Frame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (demandBackup == true && quickExit == false)
            {
                DialogResult res = MessageBox.Show("Do you wish to local backup now", "Vectra Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    BackupSimple.doBackup(0);
                    demandBackup = false;
                }
            }
        }

        //Menus
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Products();
            activateForm(f, FormWindowState.Normal, FormStartPosition.Manual);
        }

        private void HomeMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new Home();
            activateForm(f, FormWindowState.Normal, FormStartPosition.Manual);

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBox1 fmAbout = new AboutBox1())
            {
                fmAbout.ShowDialog();
            }
        }

 

        // - Buttons
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form f = new Home();
            activateForm(f, FormWindowState.Normal, FormStartPosition.Manual);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form f = new CustomerInterface();
            activateForm(f, FormWindowState.Normal, FormStartPosition.CenterScreen);
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            Form f = new Products();
            activateForm(f, FormWindowState.Normal, FormStartPosition.Manual);
        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new EndOfWeek();
            activateForm(f, FormWindowState.Normal, FormStartPosition.Manual);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new CustomerReportForm();
            activateForm(f, FormWindowState.Normal, FormStartPosition.Manual);

        }

        private void productsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           Form f = new ProductReportForm();
           activateForm(f, FormWindowState.Normal, FormStartPosition.Manual);
            
        }

        private void invoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new StatementReportForm();            
            activateForm(f, FormWindowState.Normal, FormStartPosition.Manual);

        }

        private void salesAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ;
        }

        private void salesSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form f = new SalesSummaryReportForm();
           activateForm(f, FormWindowState.Normal, FormStartPosition.Manual);            
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Configuration();
            activateForm(f, FormWindowState.Normal, FormStartPosition.Manual);
        }

        private void agedTrialBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ATBReportForm();
            activateForm(f, FormWindowState.Normal, FormStartPosition.Manual);
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new CustomerTransactionReportForm();
            activateForm(f, FormWindowState.Normal, FormStartPosition.Manual);
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Backup();
            activateForm(f, FormWindowState.Normal, FormStartPosition.Manual);
            demandBackup = false;
        }

        private void Frame_Load(object sender, EventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                this.quickExitToolStripMenuItem.Visible = true;
            }
            else
            {
                this.quickExitToolStripMenuItem.Visible = false;
            }

        }

        private void quickExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quickExit = true;
            Close();
        }

        private void tablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new dbase();
            activateForm(f, FormWindowState.Normal, FormStartPosition.Manual);
        }
 
    }
}
