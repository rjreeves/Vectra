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
    public partial class ExceptionForm : Form
    {
        public Exception excpt;
        string reportHeading = @"Vectra reported an unhandled exception on";
        public ExceptionForm(Exception ex)
        {
            excpt = ex;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExceptionForm_Load(object sender, EventArgs e)
        {
            tbxDetails.Text = String.Format(
                "{0}\r\n{1} - {2}\r\nMessage:- {3}\r\nSource:- {4}\r\nTarget:- {5}\r\nStackTrace:- {6}\r\n\r\nEndOfReport",
                reportHeading,
                DateTime.Now.ToLongDateString(),
                DateTime.Now.ToLongTimeString(),
                excpt.Message,
                excpt.Source,
                excpt.TargetSite,
                excpt.StackTrace);

        }
    }
}
