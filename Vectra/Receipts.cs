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
    public partial class Receipts : Form
    {

        string UpdateCustTranswithNewUnpaid = @"update customer_trans 
                    set t_unpaid = (select invoice_unpaid from invoice_header 
								where customer_trans.t_cust_id = invoice_header.cust_id 
								and customer_trans.t_src_id = invoice_header.invoice_number
								and customer_trans.t_type = 'Invoice'
								and invoice_header.recent_payment <> 0
								)
                    where
	                    exists(
		                    select * 
		                    from invoice_header
		                    where invoice_header.cust_id = customer_trans.t_cust_id 
		                    and  customer_trans.t_src_id = invoice_header.invoice_number
		                    and customer_trans.t_type = 'Invoice'
		                    and invoice_header.recent_payment <> 0
		                    )";


        

        public Decimal unallocated_bal = 0;
        
        public bool errorFlag = false;

        Vectra.DataSet2TableAdapters.configurationTableAdapter da = new Vectra.DataSet2TableAdapters.configurationTableAdapter();
        
        public Receipts(object item)
        {
            if ((item is DataRowView) &&
     (((DataRowView)item).Row is DataSet2.customerRow))
            {
                InitializeComponent();
                this.customerBindingSource.DataSource = item;
            }
            else throw new ArgumentException("Incorrect type");
        }


        private void Receipts_Load(object sender, EventArgs e)
        {
            this.iNVOICE_RECIEPTSBindingSource.Filter = string.Format("cust_id = {0}", this.cust_idTextBox.Text);
            this.iNVOICE_RECIEPTSTableAdapter.Fill(this.dataSet2.INVOICE_RECIEPTS);

            this.iNVOICE_HEADERTableAdapter.FillBy2(this.dataSet2.INVOICE_HEADER, Convert.ToInt64(this.cust_idTextBox.Text));            
            this.customer_transTableAdapter.Fill(this.dataSet2.customer_trans);
            this.customer_transBindingSource.AddNew();
            t_cust_idTextBox.Text = cust_idTextBox.Text;
            t_typeTextBox.Text = "Payment";
            t_dateDateTimePicker.Text = DateTime.Now.ToShortDateString();
            t_timestampDateTimePicker.Text = DateTime.Now.ToShortDateString();
            t_amountTextBox.Text = "0";

            this.sqLiteConnection1.ConnectionString = da.Connection.ConnectionString;
                        
        }

        private void doSQL(string sqlText)
        {
            SQLiteCommand sqLiteCommand1 = new SQLiteCommand();
            sqLiteCommand1.CommandText = sqlText;

            sqLiteCommand1.CommandType = CommandType.Text;
            sqLiteCommand1.Connection = sqLiteConnection1;
            sqLiteConnection1.Open();
            sqLiteCommand1.ExecuteNonQuery();
            sqLiteConnection1.Close();

        }
        

        private void btnApply_Click(object sender, EventArgs e)
        {   
            Decimal payAmt = Convert.ToDecimal(t_amountTextBox.Text);
            if (payAmt <= 0)
            {   
                BetterDialog.ShowDialog("Reciept error", "Amount must be greater than ZERO", "Try again",null, "OK",Properties.Resources.books.ToBitmap());
                return;
            }
            Decimal x;
            
            DataView dv = new DataView(dataSet2.INVOICE_HEADER);
            dv.RowFilter = string.Format("CUST_ID = {0} AND invoice_unpaid <> 0", this.cust_idTextBox.Text);
            dv.Sort = ("sort_date ASC");

            sqLiteConnection1.Open();

            if (dv.Count == 0)     // No invoices to attach payment to.
            {
                DataRowView r = (DataRowView)this.customer_transBindingSource.Current;
                r["t_week_id"] = da.getCurrentAcntPeriod();
                r["t_timestamp"] = DateTime.Now.ToShortDateString();
                //r["t_amount"] = (Double)r["t_amount"] * -1;  // Store Payment in Cust_Trans as -ve.
                this.customer_transBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet2);
            }
            else
            {
                foreach (DataRowView drv in dv)
                {
                    if (payAmt > 0)
                    {
                        x = Convert.ToDecimal(drv["invoice_unpaid"].ToString());
                        if (x > 0)
                        {
                            Decimal amt;
                            if (x <= payAmt)
                            {
                                drv["invoice_unpaid"] = 0;
                                drv["invoice_locked"] = "1";
                                payAmt = Decimal.Subtract(payAmt, x);
                                amt = x;
                            }
                            else
                            {
                                x = Decimal.Subtract(x, payAmt);
                                amt = payAmt;
                                drv["invoice_unpaid"] = x;
                                drv["invoice_locked"] = "1";
                                payAmt = 0;
                            }
                            DataRowView newRow = (DataRowView)iNVOICE_RECIEPTSBindingSource.AddNew();
                            newRow.Row["cust_id"] = this.cust_idTextBox.Text;
                            newRow.Row["recpt_number"] = t_idTextBox.Text;
                            newRow.Row["invoice_key"] = drv.Row["invoice_number"];
                            if (drv.Row["docket_number"].ToString().Length == 0)
                            {
                                newRow.Row["invoice_number"] = drv.Row["invoice_number"];
                            }
                            else
                            {
                                newRow.Row["invoice_number"] = drv.Row["docket_number"];
                            }
                            newRow.Row["recpt_date"] = t_dateDateTimePicker.Value.ToShortDateString();
                            newRow.Row["amount"] = amt;
                            newRow.EndEdit();

                            DataRowView r = (DataRowView)this.customer_transBindingSource.Current;
                            r["t_week_id"] = da.getCurrentAcntPeriod();
                            if (drv.Row["docket_number"].ToString().Length == 0)
                            {
                                t_ref_idTextBox.Text = drv.Row["invoice_number"].ToString();
                            }
                            else
                            {
                                t_ref_idTextBox.Text = drv.Row["docket_number"].ToString();
                            }
                            r["t_timestamp"] = DateTime.Now.ToShortDateString();
                            //r["t_amount"] = (Double)r["t_amount"] * -1;  // Store Payment in Cust_Trans as -ve.
                            this.customer_transBindingSource.EndEdit();

                            this.tableAdapterManager.UpdateAll(this.dataSet2);

                            string cmd = string.Format(@"update customer_trans 
                            set t_unpaid =  {0}, t_week_id = {3} where t_type = 'Invoice' and t_cust_id = {1} and t_src_id = {2}",
                                drv["invoice_unpaid"], this.cust_idTextBox.Text, drv.Row["invoice_number"], da.getCurrentAcntPeriod());

                            SQLiteCommand sqlCmd = new SQLiteCommand(cmd, sqLiteConnection1);
                            sqlCmd.ExecuteNonQuery();                          

                        }
                    }
                }
            }
           

            if (payAmt > 0)
            {
                // Allocate additional payment to general bucket
                string cmd = string.Format("update customer set open_bal = open_bal + {0} where cust_id = {1}",
                             payAmt.ToString(), cust_idTextBox.Text.ToString());

                SQLiteCommand sqlCmd = new SQLiteCommand(cmd, sqLiteConnection1);

                sqlCmd.ExecuteNonQuery();

            }

            this.sqLiteConnection1.Close();
            this.customerTableAdapter.Fill(dataSet2.customer);            
            this.tableAdapterManager.UpdateAll(this.dataSet2);
            doSQL(@"Update INVOICE_HEADER set recent_payment = 0 where recent_payment > 0");

            Close();
        }

        private void t_idTextBox_Leave(object sender, EventArgs e)
        {
            t_dateDateTimePicker.Focus();
        }

        private void t_noteTextBox_Leave(object sender, EventArgs e)
        {
            t_idTextBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Decimal paymntAllocations = 0;

            this.iNVOICE_HEADERBindingSource.EndEdit();
            this.iNVOICE_HEADERTableAdapter.Update(dataSet2.INVOICE_HEADER);

            btnSubTotal_Click(sender, e);
            if (errorFlag == true) // zero amount or payments within acceptable range!
            {
                return;
            }
            else
            // no individual payment > unpaid invoice amt.
            {
                //-- Customer Trans
                DataRowView r = (DataRowView)this.customer_transBindingSource.Current;
                r["t_week_id"] = da.getCurrentAcntPeriod();
                r["t_timestamp"] = DateTime.Now.ToShortDateString();
                //r["t_amount"] = (Double)r["t_amount"] * -1;  // Store Payment in Cust_Trans as -ve.
                this.customer_transBindingSource.EndEdit();
                this.customer_transTableAdapter.Update(dataSet2.customer_trans);

                //-- InvoiceEdit Header(s)
                DataGridView dv = (DataGridView)this.iNVOICE_HEADERDataGridView;
                if (dv.RowCount > 0)
                {
                    foreach (DataGridViewRow rw in dv.Rows)
                    {
                        if (rw.Cells[8].Value != null)                       
                        {
                            DataRowView drv = (DataRowView)iNVOICE_HEADERBindingSource.Current;

                            // InvoiceRecpts 
                            Decimal pymt = 0;
                            try
                            {
                                pymt = Decimal.Parse(rw.Cells[8].Value.ToString());
                            }
                            catch
                            {
                                ;                             
                            }
                            if (pymt == 0) { continue; }
                            paymntAllocations = Decimal.Add(paymntAllocations, pymt);
                            string dck = rw.Cells[3].Value.ToString();
                            if (dck.Length == 0)
                            {
                                dck = rw.Cells[0].Value.ToString();
                            }
                            string cmd = @"Insert into INVOICE_RECIEPTS (cust_id,recpt_number,recpt_date, amount, invoice_key, invoice_number)
                                       values ('{0}','{1}','{2}','{3}','{4}','{5}')";

                            doSQL(String.Format(cmd, this.cust_idTextBox.Text, t_idTextBox.Text, t_dateDateTimePicker.Value.ToShortDateString(),
                                    pymt, Decimal.Parse(rw.Cells[0].Value.ToString()), dck));

                            // Invoice Header
                            cmd = @"Update INVOICE_HEADER set invoice_unpaid = invoice_unpaid - recent_payment where invoice_number = {0}";
                            doSQL(String.Format(cmd, Decimal.Parse(rw.Cells[0].Value.ToString())));
                            //------------ drv["invoice_locked"] = "1";

                            Decimal x = Convert.ToDecimal(drv["invoice_unpaid"]);
                            Decimal newUnpaidAmount = Decimal.Subtract(x, pymt);

                            //--update customer tran with updated unpaid amount
                            //cmd = string.Format(@"update customer_trans set t_unpaid = (select invoice_unpaid from invoice_header) , t_week_id = {2} where t_type = 'Invoice' and t_cust_id = {0} and t_src_id = {1}",
                            //   this.cust_idTextBox.Text, drv["invoice_number"],
                            //  da.getCurrentAcntPeriod());
                            doSQL(UpdateCustTranswithNewUnpaid);

                            cmd = String.Format(@"Update INVOICE_HEADER set recent_payment = 0 where recent_payment > 0 AND invoice_number = {0}",
                                Decimal.Parse(rw.Cells[0].Value.ToString()));                            
                            doSQL(cmd);
                            
                        }
                    }
                }
                
            }
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            unallocated_bal = Decimal.Parse(t_amountTextBox.Text);
            UnAllocatedAmount.Text = String.Format("{0:C}", unallocated_bal);
            for (int idx = 0; idx < iNVOICE_HEADERBindingSource.Count; idx++)
                {
                    iNVOICE_HEADERDataGridView[8, idx].Value = null;
                }
        }

        private void btnSubTotal_Click(object sender, EventArgs e)
        {
            try
            {
                errorFlag = false;
                unallocated_bal = Decimal.Parse(t_amountTextBox.Text);
                if (unallocated_bal == 0)
                {
                    BetterDialog.ShowDialog("Reciept error", "Amount must be greater than ZERO", "Try again", null, "OK", Properties.Resources.books.ToBitmap());
                    errorFlag = true;

                }
                else
                {
                    for (int idx = 0; idx < iNVOICE_HEADERBindingSource.Count; idx++)
                    {
                        if (iNVOICE_HEADERDataGridView[8, idx].Equals(""))                          
                        {
                            iNVOICE_HEADERDataGridView[8, idx].Value = 0;
                        }
                        else //if (iNVOICE_HEADERDataGridView[8, idx].Value != null)
                        {
                            Decimal pymt = Decimal.Parse(iNVOICE_HEADERDataGridView[8, idx].Value.ToString());
                            iNVOICE_HEADERDataGridView[8, idx].Value = pymt.ToString();
                            Decimal unpaid = Decimal.Parse(iNVOICE_HEADERDataGridView[7, idx].Value.ToString());
                            if (pymt > unpaid)
                            {
                                MessageBox.Show(String.Format("Allocation={0}, Unpaid={1}. Try again...", pymt, unpaid),
                                    "Allocated money to large");
                                errorFlag = true;
                            }
                            unallocated_bal = Decimal.Subtract(unallocated_bal, pymt);
                            UnAllocatedAmount.Text = String.Format("{0:C}", unallocated_bal);
                            if (unallocated_bal < 0)
                            { UnAllocatedAmount.ForeColor = Color.Red; }
                            else
                            { UnAllocatedAmount.ForeColor = Color.Black; }

                            UnAllocatedAmount.Refresh();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Msg: {0}", ex.Message));
            }
        }

        private void iNVOICE_HEADERDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                try
                {
                    int myIndex = iNVOICE_HEADERDataGridView.Columns["recent_payment"].Index;
                    if (e.ColumnIndex == myIndex)
                        if (e.Value.ToString() == "0")
                        {
                            e.Value = "";
                            e.FormattingApplied = true;
                        }
                }
                catch
                {
                    e.FormattingApplied = false;
                }
            }
        }

        private void iNVOICE_HEADERDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = new DataGridViewRow();
            dr = iNVOICE_HEADERDataGridView.Rows[e.RowIndex];
            dr.Cells["recent_payment"].Value = dr.Cells["Unpaid"].Value;
            iNVOICE_HEADERDataGridView.BeginEdit(true);
        }


    }
}
    
