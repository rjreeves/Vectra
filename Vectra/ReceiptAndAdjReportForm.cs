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
    public partial class ReceiptAndAdjReportForm : Form
    {
        public ReceiptAndAdjReportForm()
        {
            InitializeComponent();
        }



        private void ReceiptAndAdjReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.PaymentAdjustRpt' table. You can move, or remove it, as needed.
            this.paymentAdjustRptTableAdapter.Fill(this.dataSet2.PaymentAdjustRpt);
            // TODO: This line of code loads data into the 'dataSet2.configuration' table. You can move, or remove it, as needed.
            this.configurationTableAdapter.Fill(this.dataSet2.configuration);
            this.configurationTableAdapter.Fill(this.dataSet2.configuration);
            runCreateSummaryTable();

            ReportDocument cryRpt;
                 
            this.paymentAdjustRptTableAdapter.Fill(this.dataSet2.PaymentAdjustRpt);

            ReceiptAndAdjReport rpt = new ReceiptAndAdjReport();
            rpt.SetDataSource(dataSet2);

            cryRpt = new ReportDocument();
            cryRpt.Load(rpt.FileName.ToString());
            cryRpt.SetDataSource(dataSet2);
            cryRpt.ExportToDisk(ExportFormatType.PortableDocFormat, ReportFolder.reportFolderName + @"\ReceiptAndAdjustments.pdf");

        }

        void runCreateSummaryTable()
        {
            xeqSQL(@"delete from PaymentAdjustRpt");
            xeqSQL(@"insert into PaymentAdjustRpt
                select substr(ct.t_date, 1, 10) t_date, ct.t_type, 
                       c.cust_id, c.contact_name, c.name_address_1, ct.t_amount, t_id
                from   customer_trans ct, customer c, configuration conf
                where  c.cust_id = ct.t_cust_id
                and    t_type != 'Invoice'
                and    conf.acnt_period = ct.t_week_id");
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

        private void configurationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.configurationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }


    }
}
