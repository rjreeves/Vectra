using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vectra.Update
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            sqLiteConnection1.Open();
            sqLiteCommand1.ExecuteNonQuery();
            sqLiteCommand2.ExecuteNonQuery();
            sqLiteConnection1.Close();
            this.label1.Text = "Finished.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Ready...";
        }
    }
}
