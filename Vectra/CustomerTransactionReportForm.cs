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




namespace Vectra
{
    public partial class CustomerTransactionReportForm : Form
    {
        public CustomerTransactionReportForm()
        {
            InitializeComponent();
        }
        //case when customer_trans.t_type = 'Payment' then customer_trans.t_amount else customer_trans.t_amount end
        string sqlcmd = @"SELECT    customer_trans.t_id, customer_trans.t_type, customer_trans.t_cust_id, customer_trans.t_src_id, customer_trans.t_ref_id, customer_trans.t_date, 
                                    customer_trans.t_note, customer_trans.t_timestamp,case when customer_trans.t_type = 'Payment' then 0-customer_trans.t_amount else customer_trans.t_amount end as t_amount , customer_trans.t_unpaid, customer_trans.t_no_print, 
                                    customer_trans.t_finished, customer_trans.t_week_id, customer_trans.t_src_dckt_id, configuration.acnt_period
                        FROM        customer_trans, configuration
                        WHERE       (customer_trans.t_unpaid > 0) AND (customer_trans.t_type = 'Invoice') OR
                                    (customer_trans.t_week_id = configuration.acnt_period)
                        ";




        private void CustomerTransactionReportForm_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt;
            
            using (Devart.Data.SQLite.SQLiteConnection myConn = new Devart.Data.SQLite.SQLiteConnection(myConfig.connstr))
            {
                using (SQLiteCommand myCmd = new SQLiteCommand(sqlcmd, myConn))
                {
                    myConn.Open();
                    using (SQLiteDataReader myReader = myCmd.ExecuteReader())
                    {
                        dataSet2.customer_trans.Load(myReader);
                        myConn.Close();
                    }
                }
            }
            
            this.customerTableAdapter1.Fill(this.dataSet2.customer);
            this.configurationTableAdapter1.Fill(this.dataSet2.configuration);

            CustomerTransactionReport rpt = new CustomerTransactionReport();
            rpt.SetDataSource(this.dataSet2);

            cryRpt = new ReportDocument();
            cryRpt.Load(rpt.FileName.ToString());
            cryRpt.SetDataSource(this.dataSet2);
            cryRpt.ExportToDisk(ExportFormatType.PortableDocFormat, ReportFolder.reportFolderName + @"\CustomerTransactions.pdf");            
        }
    }
}
