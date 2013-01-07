using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using Devart.Data.SQLite;
using Devart.Data;

namespace Vectra
{
    public partial class SalesSummaryReportForm : Form
    {
        public SalesSummaryReportForm()
        {
            InitializeComponent();
                             
        }


        private void SalesSummaryReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.ProductSalesSummary' table. You can move, or remove it, as needed.
           // DataSet2 dataSet2 = new DataSet2();
           // Vectra.DataSet2TableAdapters.configurationTableAdapter configurationTableAdapter1 = new Vectra.DataSet2TableAdapters.configurationTableAdapter();
           // Vectra.DataSet2TableAdapters.ProductSalesSummaryTableAdapter ProductSalesSummaryTableAdapter1 = new Vectra.DataSet2TableAdapters.ProductSalesSummaryTableAdapter();
            runCreateSummaryTable();

            ReportDocument cryRpt;

            configurationTableAdapter1.Fill(this.dataSet2.configuration);
            productSalesSummaryTableAdapter.Fill(this.dataSet2.ProductSalesSummary);

            SalesSummaryReport rpt = new SalesSummaryReport();
            rpt.SetDataSource(dataSet2);

            cryRpt = new ReportDocument();
            cryRpt.Load(rpt.FileName.ToString());
            cryRpt.SetDataSource(dataSet2);
            cryRpt.ExportToDisk(ExportFormatType.PortableDocFormat, ReportFolder.reportFolderName + @"\ProductSalesSummary.pdf");

        }       

 
        void runCreateSummaryTable()
        {
            /* Replaced with DELETE -- in build 1.0.10
            xeqSQL(@"DROP TABLE IF EXISTS ProductSalesSummary");
             */
            xeqSQL(@"CREATE TABLE IF NOT EXISTS ProductSalesSummary
                  (
                    t_id  TEXT,
                    t_desc  TEXT,
                    t_qty  REAL,
                    t_qtyp  REAL,
                    t_whgt  REAL,
                    t_whgtp  REAL,
                    t_avg  REAL,
                    t_amt  REAL,
                    t_amtp  REAL
                    t_current 
                  )"
                  );
             
            xeqSQL(@"Delete from ProductSalesSummary");
            xeqSQL(@"insert into ProductSalesSummary 
            select  a.prod_id, b.desc, 
            sum(a.qty), 0, 
            sum(a.weight), round( a.weight/( select sum(a.weight) from ProductSalesSummary )*100,2 ),
            (sum(a.weight)/sum(a.qty)), 
            sum(a.amount), round( a.amount/( select sum(a.amount) from ProductSalesSummary )*100,2 ) 
            from invoice_items a join products b on a.prod_id = b.prod_id 
            where current_flag = '1'
            group by a.prod_id");
            xeqSQL(@"Update ProductSalesSummary set t_qtyp = round( t_qty/( select sum(t_qty) from ProductSalesSummary )*100,2 ),
                                                    t_whgtp = round( t_whgt/( select sum(t_whgt) from ProductSalesSummary )*100,2 ),
                                                    t_amtp = round( t_amt/( select sum(t_amt) from ProductSalesSummary )*100,2 )
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
