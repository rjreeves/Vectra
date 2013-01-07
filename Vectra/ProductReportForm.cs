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
    public partial class ProductReportForm : Form
    {
        public ProductReportForm()
        {
            InitializeComponent();
        }

        private void ProductReportForm_Load(object sender, EventArgs e)
        {             
            this.productsTableAdapter.Fill(this.dataSet2.products);            
            this.configurationTableAdapter1.Fill(this.dataSet2.configuration);
            ProductReport rpt = new ProductReport();
            rpt.SetDataSource(this.dataSet2);
            crystalReportViewer1.ReportSource = rpt;
        }
          
    }
}
