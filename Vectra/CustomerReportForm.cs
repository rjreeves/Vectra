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
    public partial class CustomerReportForm : Form
    {
        public CustomerReportForm()
        {
            InitializeComponent();
        }

        private void CustomerReportForm_Load(object sender, EventArgs e)
        {
            this.customerTableAdapter1.Fill(this.dataSet2.customer);
            this.configurationTableAdapter1.Fill(this.dataSet2.configuration);
            CustomerReport rpt = new CustomerReport();
            rpt.SetDataSource(this.dataSet2);
            crystalReportViewer1.ReportSource = rpt;
        }


    }
}
