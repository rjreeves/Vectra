using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Devart.Data;
using Devart.Data.SQLite;

namespace Vectra
{
    public partial class AdjustmentEdit : Form
    {
        DataRowView drt;
        string CurrentAcntPeriod;
        public AdjustmentEdit(object item, object customer)
        {
            if ((item is DataRowView) &&
                  (((DataRowView)item).Row is DataSet2.customer_transRow)
                   && ((customer is DataRowView) &&
                (((DataRowView)customer).Row is DataSet2.customerRow)))
            {
                InitializeComponent();
                this.customerBindingSource.DataSource = customer;
                this.customer_transBindingSource.DataSource = item;
                drt = (DataRowView)customer_transBindingSource.Current;

            }
            else throw new ArgumentException("Incorrect type");

        }

        private void AdjustmentEdt_Load(object sender, EventArgs e)
        {
           
            this.invoice_header_unpaidTableAdapter.Fill(this.dataSet2.invoice_header_unpaid);           
            this.iNVOICE_HEADERTableAdapter.Fill(this.dataSet2.INVOICE_HEADER);           
            this.customerTableAdapter.Fill(this.dataSet2.customer);           
            this.customer_transTableAdapter.Fill(this.dataSet2.customer_trans);

            // Invoice header binding source 
            invoice_header_unpaidBindingSource.Filter = String.Format("cust_id = '{0}'", ((DataRowView)customerBindingSource.DataSource).Row["cust_id"]);

            // Load the drop down list for Invoices with custom invoice list
            sqLiteConnection1.Open();
            string cmd = String.Format("select 0 invoice_number, 'Customer Level' invoice_text from customer where cust_id = '{0}'  union select invoice_number, invoice_number || ' - ' ||ifnull(docket_number,0) || ' - ' || ifnull(date(invoice_date),' ') || ' - ' || invoice_unpaid as invoice_text from invoice_header where cust_id = '{0}' and invoice_unpaid != 0 order by 1", ((DataRowView)customerBindingSource.DataSource).Row["cust_id"]);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd, sqLiteConnection1);                  
            DataSet ds = new DataSet();
            da.Fill(ds, "inv");            
            invoice_header_unpaidComboBox.DataSource = ds.Tables["inv"];
            invoice_header_unpaidComboBox.DisplayMember = ds.Tables["inv"].Columns[1].ToString();
            invoice_header_unpaidComboBox.ValueMember = ds.Tables["inv"].Columns[0].ToString();            
            sqLiteConnection1.Close();

            // Load the drop down list for Payments with custom payments list 
            sqLiteConnection1.Open();
            string cmd1 = String.Format("select 0 recpt_number, 'Customer Level' payment_text from customer where cust_id = '{0}'  union select recpt_number, recpt_number || ' - ' || ifnull(date(recpt_date), ' ') || ' - ' || amount as payment_text from INVOICE_RECIEPTS where cust_id = '{0}' and amount != 0 order by 1", ((DataRowView)customerBindingSource.DataSource).Row["cust_id"]);
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(cmd1, sqLiteConnection1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "pay");            
            paymentCB.DataSource = ds1.Tables["pay"];
            paymentCB.DisplayMember = ds1.Tables["pay"].Columns[1].ToString();
            paymentCB.ValueMember = ds1.Tables["pay"].Columns[0].ToString();
            sqLiteConnection1.Close();
            comboBox1.Text = comboBox1.Items[0].ToString();

            // Get the Current Accounting Period
            Vectra.DataSet2TableAdapters.configurationTableAdapter configDA = new Vectra.DataSet2TableAdapters.configurationTableAdapter();
            CurrentAcntPeriod =  configDA.getCurrentAcntPeriod().ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.Equals(t_amountTextBox.Text.ToString(), "") && !string.Equals(t_amountTextBox.Text.ToString(), "0"))
            {
                if (invoice_header_unpaidComboBox.SelectedValue.ToString() != "0")
                    drt.Row["t_src_id"] = invoice_header_unpaidComboBox.SelectedValue;
                if (paymentCB.SelectedValue.ToString() != "0" && string.Equals(this.comboBox1.SelectedItem.ToString(), "General Adj."))
                    drt.Row["t_ref_id"] = paymentCB.SelectedValue;
                drt.Row["t_date"] = t_dateDateTimePicker.Value.ToShortDateString();
                drt.Row["t_timestamp"] = DateTime.Now.ToShortTimeString();
                drt.Row["t_week_id"] = CurrentAcntPeriod;
                drt.Row["t_amount"] = (double)drt.Row["t_amount"];
                // Print Checked field
                if (cbPrintAdj.Checked)
                    drt.Row["t_no_print"] = "Y";
                else
                    drt.Row["t_no_print"] = "N";

                this.sqLiteConnection1.Open();

                //Add Unalloated amount to customer Open bal amount
                //    ==========
                if (string.Equals(this.comboBox1.SelectedItem.ToString(), "Unallocated Adj."))
                {
                    DataRowView drv = (DataRowView)customerBindingSource.Current;
                    drv.BeginEdit();
                    Decimal x = Convert.ToDecimal(drt.Row["t_amount"]) * -1 ;
                    Decimal y = Convert.ToDecimal(drv.Row["open_bal"]);
                    Decimal z = 0;

                    // DO NOT KEEP the Cust_Trans as it is required.
                    customer_transBindingSource.CancelEdit();

                    if (invoice_header_unpaidComboBox.SelectedValue.ToString() != "0")
                    {   //AdjustFormScrollbars a Specific Inovice
                        z = Decimal.Subtract(y, x);
                        // Update the invoice transaction record unpaid amount
                        // with by value of x                     
                        
                        string cmd = string.Format(@"update customer_trans set t_unpaid = t_unpaid - {0}, t_week_id = '{3}' where t_type = 'Invoice' and t_cust_id = {1} and t_src_id = {2}",
                            x.ToString(), ((DataRowView)customerBindingSource.DataSource).Row["cust_id"].ToString(), invoice_header_unpaidComboBox.SelectedValue.ToString(), CurrentAcntPeriod.ToString());
                        SQLiteCommand sqlCmd = new SQLiteCommand(cmd, sqLiteConnection1);
                        sqlCmd.ExecuteNonQuery();
                                                
                        sqlCmd.CommandText = string.Format("update invoice_header set invoice_unpaid = invoice_unpaid - {0}, invoice_locked = 1 where invoice_number = {1}",
                             x.ToString(), invoice_header_unpaidComboBox.SelectedValue.ToString());
                        sqlCmd.ExecuteNonQuery();
                       

                        sqlCmd.CommandText = string.Format("update customer set open_bal = {0} where cust_id = {1}",
                             z.ToString(), ((DataRowView)customerBindingSource.DataSource).Row["cust_id"].ToString());
                        sqlCmd.ExecuteNonQuery();
                    }
                    else
                    {  
                        z = Decimal.Add(x, y);
                        string cmd = string.Format("update customer set open_bal = {0} where cust_id = {1}",
                             z.ToString(), ((DataRowView)customerBindingSource.DataSource).Row["cust_id"].ToString());

                        SQLiteCommand sqlCmd = new SQLiteCommand(cmd, sqLiteConnection1);

                        sqlCmd.ExecuteNonQuery();
                    }
                    drv.Row["open_bal"] = z.ToString();
                }
                else  //General Adj
                {     //===========
                    SQLiteCommand sqlCmd = new SQLiteCommand("", sqLiteConnection1);
                    DataRowView drv = (DataRowView)customerBindingSource.Current;
                        
                    Decimal x = Convert.ToDecimal(drt.Row["t_amount"]) * -1;                   
                    Decimal y = Convert.ToDecimal(drv.Row["open_bal"]);
                        
                    if (paymentCB.SelectedValue.ToString().Equals("0") &&
                        invoice_header_unpaidComboBox.SelectedValue.ToString().Equals("0"))
                    {  // Adj to OpenBal
                        string cmd = string.Format("update customer set open_bal = {0} where cust_id = {1}",
                             Decimal.Add(x,y).ToString(), ((DataRowView)customerBindingSource.DataSource).Row["cust_id"].ToString());
                        sqlCmd.CommandText = cmd;
                        sqlCmd.ExecuteNonQuery();
                        drv.Row["open_bal"] = Decimal.Add(x, y).ToString();
                    }
                    else if (paymentCB.SelectedValue.ToString().Equals("0"))
                    {   // Adj and Update specific invoice
                        string cmd = string.Format(@"update customer_trans set t_unpaid = t_unpaid - {0}, t_week_id = '{3}' where t_type = 'Invoice' and t_cust_id = {1} and t_src_id = {2}",
                            x.ToString(), ((DataRowView)customerBindingSource.DataSource).Row["cust_id"].ToString(), invoice_header_unpaidComboBox.SelectedValue.ToString(), CurrentAcntPeriod.ToString());

                        sqlCmd.CommandText = cmd;
                        sqlCmd.ExecuteNonQuery();

                        sqlCmd.CommandText = string.Format("update invoice_header set invoice_unpaid = invoice_unpaid - {0}, invoice_locked = 1 where invoice_number = {1}",
                             x.ToString(), invoice_header_unpaidComboBox.SelectedValue.ToString());
                        sqlCmd.ExecuteNonQuery();
                    }
                    else
                    {  // Adj and Update specific payment 
                        sqlCmd.CommandText = string.Format("update customer set open_bal = {0} where cust_id = {1}",
                             Decimal.Add(y,x).ToString(), ((DataRowView)customerBindingSource.DataSource).Row["cust_id"].ToString());
                        sqlCmd.ExecuteNonQuery();                       
                        drv.Row["open_bal"] = Decimal.Add(y, x).ToString();
                    }

                }

                this.sqLiteConnection1.Close();
                this.Validate();
                this.customerBindingSource.EndEdit();
                this.customer_transBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet2);
            }
            else
            {
                this.customer_transBindingSource.CancelEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet2);
            }
        }

        private void AdjustmentEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((e.CloseReason == CloseReason.UserClosing) ||
                    (this.DialogResult == DialogResult.Cancel))
            {
                this.customer_transBindingSource.CancelEdit();
            }
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {           
            if (string.Equals(this.comboBox1.SelectedItem.ToString(),"Unallocated Adj."))
            {               
                paymentCB.Enabled = false;
            }
        }

        
        // Protective code to ensure only one invoice or payment can be selected
        private void invoice_header_unpaidComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (paymentCB.SelectedValue.ToString() != "0" && 
                invoice_header_unpaidComboBox.SelectedValue.ToString() != "0")
            {
                MessageBox.Show("Single Selection Of Payment Or Receipt Only");
                paymentCB.SelectedItem = paymentCB.Items[0];
            }
        }

        // Protective code to ensure only one invoice or payment can be selected
        private void paymentCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (paymentCB.SelectedValue.ToString() != "0" &&
                invoice_header_unpaidComboBox.SelectedValue.ToString() != "0")
            {
                MessageBox.Show("Single Selection Of Payment Or Receipt Only");
                paymentCB.SelectedItem = paymentCB.Items[0];
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

    }
}
