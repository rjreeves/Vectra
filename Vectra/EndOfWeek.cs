using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Devart.Data.SQLite;
using Devart.Data;
using Vectra.DataSet2TableAdapters;

namespace Vectra
{
    public partial class EndOfWeek : Form
    {
        public EndOfWeek()
        {
            InitializeComponent();
        }

        private void EndOfWeek_Load(object sender, EventArgs e)
        {
            sqLiteConnection1.ConnectionString = myConfig.connstr;
            listBox1.Items.Clear();
            acntPeriodText.Text = getAcntPeriod();
            processDateTime.Value = getFridaysDate();
            ReportFolder.setReportFolder(processDateTime.Value);
            label2.Text = ReportFolder.reportFolderName;
            // TODO: This line of code loads data into the 'dataSet2.debtors_summary' table. You can move, or remove it, as needed.
            this.debtors_summaryTableAdapter.Fill(this.dataSet2.debtors_summary);
            toolStripStatusLabel1.Text = "Ready..";
            this.customer_transTableAdapter.FillBy1(this.dataSet2.customer_trans);
        }
        
        private string getAcntPeriod()
        {
            Vectra.DataSet2TableAdapters.configurationTableAdapter da = new Vectra.DataSet2TableAdapters.configurationTableAdapter();
            return da.getCurrentAcntPeriod().ToString();
        }

        private DateTime getFridaysDate()
        {
            SQLiteCommand sqLiteCommand1 = new SQLiteCommand();
            sqLiteCommand1.CommandText = @"select t_date from acnt_period a, configuration b 
                                           where b.acnt_period = a.t_week_id 
                                           and t_Day_of_week = 6;";
            sqLiteCommand1.CommandType = CommandType.Text;
            sqLiteCommand1.Connection = sqLiteConnection1;
            sqLiteConnection1.Open();            
            return DateTime.Parse(sqLiteCommand1.ExecuteScalar().ToString());            
        }

        private void logProgress(string msg)
        {
            toolStripStatusLabel1.Text = msg;
            listBox1.Items.Add(msg);
            Refresh();
        }


        private void bntProcess_Click(object sender, EventArgs e)
        {                     

            // Disable button, to avoid repeat pressing.
            this.btnCloseBooks.Enabled = false;
            this.bntProcess.Enabled = false;
            Vectra.DataSet2TableAdapters.configurationTableAdapter da = new Vectra.DataSet2TableAdapters.configurationTableAdapter();
            da.UpdateStatementDate(getFridaysDate().ToString("dd-MMM-yyyy"));
            da.Update(this.dataSet2);

            //-- Backup before updating
            logProgress("Daily backup");
            BackupSimple.doBackup(1);  // The 1 for daily

            try
            {
                logProgress("Processing Transactions");
                doWeeklyUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
            }

            logProgress("Prepare Statements");            
            using (Form f = new StatementReportForm())
            {
                f.WindowState = FormWindowState.Minimized;
                f.Show();
            }

            logProgress("Prepare Aged-Trial-Balance");
            using (Form f = new ATBReportForm())
            {
                f.WindowState = FormWindowState.Minimized;
                f.Show();
            }

            logProgress("Prepare Product Sales Details");
            using (Form f = new SalesProdReportForm())
            {
                f.WindowState = FormWindowState.Minimized;
                f.Show();
            }
            
            logProgress("Prepare Sales Summary");           
            using (Form f = new SalesSummaryReportForm())
            {
                f.WindowState = FormWindowState.Minimized;
                f.Show();
            }

            logProgress("Prepare Receipts And Adjustments");
            using (Form f = new ReceiptAndAdjReportForm())
            {
                f.WindowState = FormWindowState.Minimized;
                f.Show();
            }

            logProgress("Prepare Customer Transaction");
            using (Form f = new CustomerTransactionReportForm())
            {
                f.WindowState = FormWindowState.Minimized;
                f.Show();
            }          
            


            if (btnCloseBooks.Checked) // This closing the books.
            {
                logProgress("Reset Accounting Period");
                resetAccountingPeriod();

                sqLiteConnection1.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = sqLiteConnection1;
                
                cmd.CommandText = "update invoice_header set invoice_locked = 1 where invoice_locked = 0";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "update invoice_items set current_flag = '0' where current_flag = 1";
                cmd.ExecuteNonQuery();
                sqLiteConnection1.Close();
            }

            logProgress("Weekly backup");
            BackupSimple.doBackup(2);  // The 2 for Weekly

            logProgress("Finished.");
        }


        private void doWeeklyUpdate() // End of Week Process
        {
            //-- Truncate All Summary Records
            try
            {
                sqLiteConnection1.Open();
                sqLiteCommand1.ExecuteNonQuery(); //drop the debtors summary table                
                sqLiteConnection1.Close();
            }
            catch
            { ; }

            Vectra.DataSet2TableAdapters.customerTableAdapter cda = new customerTableAdapter();


            //-- Iteate all customer Transactions
            DataView dv = new DataView(dataSet2.customer_trans);            
            DataView debtorView = new DataView(dataSet2.debtors_summary);
           
            DataRowView debtorsSummary; // = debtorView.AddNew();
            dv.Sort = "t_cust_id";
            int custId = 0;
            Decimal currentAmt = 0;
            Decimal days7 = 0;
            Decimal days14 = 0;
            Decimal days21 = 0;
            DateTime lastPayment = DateTime.MinValue;
            DateTime today = processDateTime.Value;
            Decimal amount;
            Decimal owing;
            Decimal openBal;

            foreach (DataRowView dr in dv)
            {
                if (custId.ToString() != dr["t_cust_id"].ToString())
                {
                    if (custId > 0)
                    {
                        // Add a new row
                        openBal = (Decimal)cda.GetCustomerOpenBal(custId)* -1;
                        owing = Decimal.Add(days7, currentAmt);
                        owing = Decimal.Add(owing, days14);
                        owing = Decimal.Add(owing, days21);
                        owing = Decimal.Add(owing, openBal);
                        
                        debtorsSummary = debtorView.AddNew();
                        debtorsSummary["cust_id"] = custId;
                        debtorsSummary["curAmt"] = currentAmt;
                        debtorsSummary["days7"] = days7;
                        debtorsSummary["days14"] = days14;
                        debtorsSummary["days21"] = days21;
                        debtorsSummary["Owing"] = owing;
                        debtorsSummary["date_last_payment"] = lastPayment.ToString();
                        debtorsSummary["open_bal"] = openBal * -1;
                        debtorsSummary.EndEdit();                      
                    }
                    custId = int.Parse(dr["t_cust_id"].ToString());
                    currentAmt = 0;
                    days7 = 0;
                    days14 = 0;
                    days21 = 0;
                    lastPayment = DateTime.MinValue;
                }
                DateTime dt = (DateTime)new DateTimeConverter().ConvertFromString(dr["t_date"].ToString());
                
                // Payments to subtracted, other type as is.
                /*
                if (dr["t_type"].ToString() == "Payment")
                {
                    amount = Decimal.Multiply(Decimal.Parse(dr["t_amount"].ToString()), -1);
                    if (dt > lastPayment)
                        lastPayment = dt;
                }
                else
                    amount = Decimal.Parse(dr["t_amount"].ToString());
                */
                amount = Decimal.Parse(dr["t_unpaid"].ToString()); //owing is sum of unpaid amounts
                if (dt >= today.AddDays(-7))
                    currentAmt = Decimal.Add(currentAmt,amount);
                else if (dt < today.AddDays(-7) && dt >= today.AddDays(-14))
                    days7 = Decimal.Add(days7,  amount);
                else if (dt < today.AddDays(-14) && dt >= today.AddDays(-21))
                    days14 = Decimal.Add(days14, amount);
                else
                    days21 = Decimal.Add(days21, amount);                
            }
            //Decimal owing;
            if (custId > 0)
            {
                openBal = (Decimal)cda.GetCustomerOpenBal(custId) * -1;
            }
            else
            {
                openBal = 0;
            }
            owing = Decimal.Add(days7, currentAmt);
            owing = Decimal.Add(owing, days14);
            owing = Decimal.Add(owing, days21);
            owing = Decimal.Add(owing, openBal);

            // Add new row
            debtorsSummary = debtorView.AddNew();
            debtorsSummary["cust_id"] = custId;
            debtorsSummary["curAmt"] = currentAmt;
            debtorsSummary["days7"] = days7;
            debtorsSummary["days14"] = days14;
            debtorsSummary["days21"] = days21;
            debtorsSummary["date_last_payment"] = lastPayment.ToString();
            debtorsSummary["Owing"] = owing;
            debtorsSummary["open_bal"] = openBal * -1;
            debtorsSummary.EndEdit();

            this.debtors_summaryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }


        private void resetAccountingPeriod()
        {
            SQLiteCommand sqLiteCommand1 = new SQLiteCommand();
            sqLiteCommand1.CommandText = @"update configuration 
                    set acnt_period = (select t_week_id from acnt_period where t_date = date('now','localtime'))";
            sqLiteCommand1.CommandType = CommandType.Text;
            sqLiteCommand1.Connection = sqLiteConnection1;
            sqLiteConnection1.Open();
            sqLiteCommand1.ExecuteNonQuery();
            sqLiteConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer.exe", ReportFolder.reportFolderName);
        }
    }
}
