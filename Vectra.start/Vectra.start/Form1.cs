using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Vectra.start
{
    public partial class Form1 : Form
    {
        PerformanceCounter myRam;
        PerformanceCounter myDisk;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.task' table. You can move, or remove it, as needed.
            this.taskTableAdapter.Fill(this.dataSet1.task);
            this.MinimumSize = this.Size;
            this.MaximumSize = this.MinimumSize;
            getPerformance();
        }
        
        private void taskDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {            
            this.Validate();
            this.taskBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }

        private void taskDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {         
            this.Validate();
            this.taskBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }
         
        private void getPerformance()
        {
            myRam = new PerformanceCounter();
            myRam.CategoryName = "Memory";
            myRam.CounterName = "Available Mbytes";
            myRam.InstanceName = null;
            long availRam = myRam.RawValue;
            toolStripStatusLabel1.Text = string.Format("Available RAM {0}MB", availRam);
            timer1.Enabled = true;

            myDisk = new PerformanceCounter();
            myDisk.CategoryName = "LogicalDisk";
            myDisk.CounterName = "% Free Space";
            myDisk.InstanceName = "_Total";
            long availDisk = (myDisk.RawValue / 1024);
            toolStripStatusLabel2.Text = string.Format("Free Diskspace {0}GB", availDisk);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getPerformance();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            getPerformance();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            getPerformance();
        }


        private void ar_Click(object sender, EventArgs e)
        {
            AppDomain arDomain = AppDomain.CreateDomain("ar");
            arDomain.ExecuteAssembly("vectra.ar.exe");
            AppDomain.Unload(arDomain);
        }

        private void ap_Click(object sender, EventArgs e)
        {
            AppDomain apDomain = AppDomain.CreateDomain("ap");
            apDomain.ExecuteAssembly("vectra.ap.exe");
            AppDomain.Unload(apDomain);
        }

        private void gl_Click(object sender, EventArgs e)
        {
            AppDomain glDomain = AppDomain.CreateDomain("gl");
            glDomain.ExecuteAssembly("vectra.gl.exe");
            AppDomain.Unload(glDomain);
        }

        private void taskBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taskBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

    }
}
