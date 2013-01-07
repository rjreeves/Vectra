using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;
using Devart.Data.SQLite;
using Devart.Common;

namespace Vectra
{
    public partial class Home : Form
    {
        //- used further below for populating the graph
        public string seriesSQl = @"
                        select acnt.t_week_of_year, 
                        sum(case when t_type = 'Invoice' then t_amount else 0 end) as invoice_amt,
                        sum(case when t_type = 'Payment' then t_amount else 0 end) as payment_amt
                        from customer_trans tran, acnt_period acnt
                        where t_type in ('Invoice', 'Payment')
                        and acnt.t_date = substr(tran.t_date,1,10)
                        group by acnt.t_date";

        
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.sqLiteConnection1.ConnectionString = myConfig.connstr;
            CustomerStats c = new CustomerStats(this.sqLiteConnection1.ConnectionString.ToString());
            try
            {
                this.MinimumSize = new Size(this.Width, this.Height);
                this.MaximumSize = new Size(this.Width, this.Height);
                cntPeriodValue.Text = getCurrentAcntPeriod().ToString();
                cntPeriodEnd.Text = getFridaysDate().ToString("dd-MMM-yyyy");

                cntToday.Text += getToday();              

                cntCustomers.Text = c.getCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer Stats: " + ex.Message, this.sqLiteConnection1.ConnectionString.ToString());
            }

                c.getInvoiceStats();
                cntUnpaidCust.Text = String.Format("Customers owing  {0}", c.unPaidCustomers);
                cntUnpaidAmount.Text = String.Format("Customers owings {0:C}", c.unPaidAmount);
                cntReceipts.Text = String.Format("Payments {0:C}", c.getReceipts());
                cntSales.Text = String.Format("Sales {0:C}", c.getSales());

            this.configurationTableAdapter.Fill(this.dataSet2.configuration);
                       
            //- Let do the graph
            
            GraphPane myPane1 = zgc1.GraphPane;
           
            myPane1.Title.Text = "Turnover";
           
            myPane1.XAxis.Title.Text = "Weeks";
            myPane1.YAxis.Title.Text = "Dollars";

            PointPairList list1 = new PointPairList();
            PointPairList list2 = new PointPairList();
            SQLiteCommand sqLiteCommand1 = new SQLiteCommand();                        
            string myCmd = seriesSQl;
            sqLiteCommand1.CommandText = myCmd;
            sqLiteCommand1.CommandType = CommandType.Text;
            sqLiteCommand1.Connection = sqLiteConnection1;
            sqLiteConnection1.Open();
            SQLiteDataReader sqReader = sqLiteCommand1.ExecuteReader();
            while (sqReader.Read())
            {
                double x = sqReader.GetInt16(0);
                double y = sqReader.GetDouble(1);
                double z = sqReader.GetDouble(2);
                list1.Add(x, y);
                list2.Add(x, z);
            }
            sqReader.Close();

            LineItem myCurve1 = myPane1.AddCurve("Sales", list1, Color.Purple,
                        SymbolType.Circle);

            LineItem myCurve2 = myPane1.AddCurve("Reciepts", list2, Color.Blue,
                        SymbolType.Circle);
             
            zgc1.AxisChange();

           // zgc1.Location = new Point(Frame.Right - zgc1.Width-10, 30);

            //-- Check accounting period is roughly correct!!!
            //-- If today's date is not in the current acnt_period week_id then prompt for guidance
            if ((getCurrentAcntPeriod() == "0") || (getCurrentAcntPeriod() != getExpectedAcntPeriod()))
            {
                 Form f = new AccountingPeriod();
                 f.ShowDialog();
                 cntPeriodValue.Text = getCurrentAcntPeriod();
            }            
        }

        public string getExpectedAcntPeriod()
        {
            SQLiteCommand sqLiteCommand1 = new SQLiteCommand();
            sqLiteCommand1.CommandText = @"select t_week_id from acnt_period 
                    where date('now','localtime') = t_date;";
            sqLiteCommand1.CommandType = CommandType.Text;
            sqLiteCommand1.Connection = sqLiteConnection1;
            sqLiteConnection1.Open();
            return sqLiteCommand1.ExecuteScalar().ToString();
        }
        public string getCurrentAcntPeriod()
        {
            SQLiteCommand sqLiteCommand1 = new SQLiteCommand();
            sqLiteCommand1.CommandText = @"Select acnt_period from configuration";
            sqLiteCommand1.CommandType = CommandType.Text;
            sqLiteCommand1.Connection = sqLiteConnection1;
            sqLiteConnection1.Open();
            return sqLiteCommand1.ExecuteScalar().ToString();
        }
        public string getToday()
        {
            return DateTime.Now.Date.ToString("dd-MMM-yyyy");

            /* -- I used this to verify SQLITE was reporting the correct date.
            SQLiteCommand sqLiteCommand1 = new SQLiteCommand();
            sqLiteCommand1.CommandText = @"Select strftime('%d-%m-%Y','now','localtime');";
            sqLiteCommand1.CommandType = CommandType.Text;
            sqLiteCommand1.Connection = sqLiteConnection1;
            sqLiteConnection1.Open();
            return sqLiteCommand1.ExecuteScalar().ToString();
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form f = new Test())
            {
                f.ShowDialog();
            }
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

        public void play()
        {
            try
            {
                SQLiteCommand sqLiteCommand1 = new SQLiteCommand();
                sqLiteCommand1.CommandText = "pragma table_info(invoice_items)";
                sqLiteCommand1.CommandType = CommandType.Text;
                sqLiteCommand1.Connection = sqLiteConnection1;
                sqLiteConnection1.Open();
                SQLiteDataReader sr =sqLiteCommand1.ExecuteReader();

                bool found_col = false;
                while (sr.Read())
                {
                    if (sr.GetString(1) == "current_flag1")
                    {
                        found_col = true;
                    }
                }
                sqLiteConnection1.Close();

                if (found_col == false)
                {
                    addColumn("invoice_items", "current_flag1", "text default '1'");
                }                
                
            }
            catch
            { ; }

        }


    public void addColumn(string aTable, string aColumn, string aType)
        {
            try
            {
                SQLiteCommand sqLiteCommand1 = new SQLiteCommand();
                sqLiteCommand1.CommandText = String.Format(@"Alter Table {0} ADD COLUMN {1} {2}", aTable, aColumn, aType);
                sqLiteCommand1.CommandType = CommandType.Text;
                sqLiteCommand1.Connection = sqLiteConnection1;
                sqLiteConnection1.Open();
                sqLiteCommand1.ExecuteNonQuery();
                sqLiteConnection1.Close();
            } catch
            { ; }
        }

    }




    public class CustomerStats
    {
        SQLiteConnection sqLiteConnection1;
        public int unPaidCustomers;
        public decimal unPaidAmount;
        public int salesSeries1;
        public decimal salesSeries2;
        public int recptSeries1;
        public decimal recptSeries2;


        public CustomerStats(string cs)
        {
            sqLiteConnection1 = new SQLiteConnection();
            sqLiteConnection1.ConnectionString = cs;
        }
        public string getCustomers()
        {
            SQLiteCommand sqLiteCommand1 = new SQLiteCommand();
            sqLiteCommand1.CommandText = @"Select count(*) from customer";
            sqLiteCommand1.CommandType = CommandType.Text;
            sqLiteCommand1.Connection = sqLiteConnection1;
            sqLiteConnection1.Open();
            return sqLiteCommand1.ExecuteScalar().ToString();
        }

        public void getInvoiceStats()
        {
            SQLiteCommand sqLiteCommand1 = new SQLiteCommand();
            string myCmd = @"select count(*), sum(t_unpaid) from customer_trans where (t_type = 'Invoice') and (t_unpaid > 0)";
            sqLiteCommand1.CommandText = myCmd;
            sqLiteCommand1.CommandType = CommandType.Text;
            sqLiteCommand1.Connection = sqLiteConnection1;
            sqLiteConnection1.Open();
            SQLiteDataReader sqReader = sqLiteCommand1.ExecuteReader();
            sqReader.Read();
            unPaidCustomers = sqReader.GetInt16(0);
            unPaidAmount = sqReader.GetDecimal(1);
        }

        public decimal getReceipts()
        {            
            SQLiteCommand sqLiteCommand1 = new SQLiteCommand();
            sqLiteCommand1.CommandText = "";
            sqLiteCommand1.CommandText = @"Select sum(t_amount )from customer_trans where (t_type = 'Payment')";
            sqLiteCommand1.CommandType = CommandType.Text;
            sqLiteCommand1.Connection = sqLiteConnection1;
            sqLiteConnection1.Open();
            SQLiteDataReader sqReader = sqLiteCommand1.ExecuteReader();
            sqReader.Read();
            decimal result = sqReader.GetDecimal(0);
            sqLiteConnection1.Close();
            return result;
        }

        public decimal getSales()
        {
            SQLiteCommand sqLiteCommand1 = new SQLiteCommand();
            sqLiteCommand1.CommandText = "";
            sqLiteCommand1.CommandText = @"Select sum(t_amount )from customer_trans where (t_type = 'Invoice')";
            sqLiteCommand1.CommandType = CommandType.Text;
            sqLiteCommand1.Connection = sqLiteConnection1;
            sqLiteConnection1.Open();
            SQLiteDataReader sqReader = sqLiteCommand1.ExecuteReader();
            sqReader.Read();
            return sqReader.GetDecimal(0);
        }
    }
}
