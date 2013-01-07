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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();            
        }

        private void Test_Load(object sender, EventArgs e)
        {
            string connstr = myConfig.connstr;
            string[] strElements = connstr.Split('=');
            label1.Text = strElements[1].ToString();
            label2.Text = Properties.Settings.Default.BackupFolder.ToString();



        }

    }
}
