using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using Devart.Data.SQLite;
using Devart.Data;

namespace Vectra
{
    public partial class SalesProdReportForm : Form
    {
        public SalesProdReportForm()
        {
            InitializeComponent();

        }


        private void SalesProdReportForm_Load(object sender, EventArgs e)
        {
            this.configurationTableAdapter.Fill(this.dataSet2.configuration);
            runCreateSummaryTable();

            ReportDocument cryRpt;

            productSalesReportTableAdapter.Fill(this.dataSet2.ProductSalesReport);
            
            SalesProdReport rpt = new SalesProdReport();
            rpt.SetDataSource(dataSet2);

            cryRpt = new ReportDocument();
            cryRpt.Load(rpt.FileName.ToString());
            cryRpt.SetDataSource(dataSet2);
            cryRpt.ExportToDisk(ExportFormatType.PortableDocFormat, ReportFolder.reportFolderName + @"\ProductSalesDetails.pdf");

        }

        void runCreateSummaryTable()
        {
            xeqSQL(@"delete from ProductSalesReport");
            xeqSQL(@"insert into ProductSalesReport 
            select p.prod_id, p.desc, a.t_date, ih.docket_number, 
		            ih.cust_id, it.qty, it.weight, it.rate, it.amount, 
		            case when (it.qty is null or it.weight is null or it.qty = 0) 
			            then 0 
	              else 
			            weight / it.qty 
		            end as avg_weight
            from invoice_header ih, invoice_items it, products p,
			            acnt_period a, configuration b
            where it.invoice_number = ih.invoice_number
            and p.prod_id = it.prod_id
            and it.current_flag = '1'
            and b.acnt_period = a.t_week_id 
            and substr(ih.invoice_date, 1, 10) 
                = substr(a.t_date, 9, 2) || '/' || substr(a.t_date, 6, 2) || '/' || substr(a.t_date, 1, 4) 
            ");
        }

        void xeqSQL(string script)
        {
            Devart.Data.SQLite.SQLiteConnection sqLiteConnection1 = new SQLiteConnection();

            sqLiteConnection1.ConnectionString = myConfig.connstr;
                
            SQLiteCommand sqLiteCommand1 = new SQLiteCommand();
            sqLiteCommand1.CommandText = script;
            sqLiteCommand1.CommandType = CommandType.Text;
            sqLiteCommand1.Connection = sqLiteConnection1;
            sqLiteConnection1.Open();
            sqLiteCommand1.ExecuteNonQuery();
            sqLiteConnection1.Close();
        }


    }
}
