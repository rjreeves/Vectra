using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Devart.Data.SQLite;

namespace Vectra
{
    public partial class AccountingPeriod : Form
    {
        public AccountingPeriod()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnForce_Click(object sender, EventArgs e)
        {
            SQLiteCommand sqLiteCommand1 = new SQLiteCommand();
            sqLiteCommand1.CommandText = @"update configuration 
                    set acnt_period = (select t_week_id from acnt_period where t_date = date('now','localtime'))";
            sqLiteCommand1.CommandType = CommandType.Text;
            sqLiteCommand1.Connection = sqLiteConnection1;
            sqLiteConnection1.Open();
            sqLiteCommand1.ExecuteNonQuery();
            getAcntPeriod();
        }

        private void AccountingPeriod_Load(object sender, EventArgs e)
        {
            getAcntPeriod();

        }

        private void getAcntPeriod()
        {
            SQLiteCommand sqLiteCommand1 = new SQLiteCommand();
            sqLiteCommand1.CommandText = @"Select acnt_period, StatementDate from configuration";
            sqLiteCommand1.CommandType = CommandType.Text;
            sqLiteCommand1.Connection = sqLiteConnection1;
            sqLiteConnection1.Open();
            SQLiteDataReader dr = sqLiteCommand1.ExecuteReader();
            dr.Read();
            this.textBox1.Text = dr.GetInt32(0).ToString();
            this.textBox4.Text = getFridaysDate(dr.GetInt32(0)).ToString("dd-MMM-yyyy");
            sqLiteConnection1.Close();

            sqLiteCommand1.CommandText = @"select t_week_id from acnt_period where t_date = date('now','localtime')";
            sqLiteCommand1.CommandType = CommandType.Text;
            sqLiteCommand1.Connection = sqLiteConnection1;
            sqLiteConnection1.Open();
            SQLiteDataReader dr1 = sqLiteCommand1.ExecuteReader();
            dr1.Read();
            this.textBox6.Text = dr1.GetInt32(0).ToString();
            this.textBox5.Text = getFridaysDate(dr1.GetInt32(0)).ToString("dd-MMM-yyyy");
            sqLiteConnection1.Close();

            string cmd = @"select strftime('%d-%m-%Y',t_timestamp) as '{0}', 
                                            t_week_id as '{1}' ,count(*) as '{2}'
                                            from invoice_header h, customer_trans t, configuration c
                                            where invoice_number = t_src_id and t_week_id > (acnt_period - 3)
                                            group by  Date(t_timestamp), t_week_id";
            string sqlcmd = String.Format(cmd, "Entry Date","Accounting Period", "Invoices");
            SQLiteDataAdapter da = new SQLiteDataAdapter(sqlcmd.ToString(), sqLiteConnection1);

            DataTable dt = new DataTable();           
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Width = dataGridView1.Columns[0].Width + dataGridView1.Columns[1].Width + dataGridView1.Columns[2].Width + 5;
            dataGridView1.ReadOnly = true;

        }

        private DateTime getFridaysDate(Int32 weekNo)
        {
            SQLiteCommand sqLiteCommand1 = new SQLiteCommand();
            sqLiteCommand1.CommandText = String.Format(@"select t_date from acnt_period a 
                                           where a.t_week_id = '{0}'
                                           and t_Day_of_week = 6;",weekNo);
            sqLiteCommand1.CommandType = CommandType.Text;
            sqLiteCommand1.Connection = sqLiteConnection1;
            sqLiteConnection1.Open();
            return DateTime.Parse(sqLiteCommand1.ExecuteScalar().ToString());
        }


    }
}
