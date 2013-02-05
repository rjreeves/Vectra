using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vectra.DBA.DataSet1TableAdapters;

namespace Vectra.DBA
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Vectra.DBA.DataSet1TableAdapters.customer_transTableAdapter ta = new customer_transTableAdapter();
            this.toolStripStatusLabel1.Text = ta.Connection.ConnectionString.ToString();
            this.conn.ConnectionString = ta.Connection.ConnectionString;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form f = new Invoicing())
            {
                f.ShowDialog();
            }

        }

        private void receiptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form f = new Receipts())
            {
                f.ShowDialog();
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete all transaction!", "Are you sure?",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                sqLiteCommand1.ExecuteNonQuery();
                conn.Close();

                string sql_text = @"
                DROP TABLE invoice_items;
                CREATE TABLE invoice_items (
                invoice_number  integer,
                line_number  integer,
                prod_id  text,
                qty  REAL,
                weight  real,
                rate  real,
                gst_value  real,
                amount  real,
                qty_rate  TEXT,
                current_flag  TEXT DEFAULT 1,
                PRIMARY KEY (invoice_number ASC, line_number ASC)
                );";
                sqLiteCommand2.CommandText = sql_text;
                sqLiteCommand2.Connection = conn;
                conn.Open();
                sqLiteCommand2.ExecuteNonQuery();
                conn.Close();
            }
            
        }
    }
}
