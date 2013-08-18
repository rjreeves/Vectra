﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Devart.Data;
using Devart.Data.SQLite;
using Vectra.DataSet2TableAdapters;



namespace Vectra
{
    public partial class Receipts : Form
    {
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
            this.iNVOICE_HEADERTableAdapter.FillBy2(this.dataSet2.INVOICE_HEADER, Convert.ToInt64(this.cust_idTextBox.Text));

            //this.iNVOICE_RECIEPTSBindingSource.Filter = string.Format("cust_id = {0}", this.cust_idTextBox.Text);
            //this.iNVOICE_RECIEPTSTableAdapter.Fill(this.dataSet2.INVOICE_RECIEPTS);                       
            //this.customer_transTableAdapter.Fill(this.dataSet2.customer_trans);

            this.iNVOICE_HEADERDataGridView.AllowUserToAddRows = false;
        }



        private void btnApply_Click(object sender, EventArgs e)  //AUTO APPLY
        {   
            Decimal payAmt = Convert.ToDecimal(t_amountTextBox.Text);
            if (payAmt <= 0)
            {   
                BetterDialog.ShowDialog("Reciept error", "Amount must be greater than ZERO", "Try again",null, "OK",Properties.Resources.books.ToBitmap());
                return;
            }

            t_cust_idTextBox.Text = cust_idTextBox.Text;
            t_typeTextBox.Text = "Payment";
            t_dateDateTimePicker.Text = DateTime.Now.ToShortDateString();           
            t_amountTextBox.Text = "0";

            DataView dv = this.dataSet2.INVOICE_HEADER;

            string dd = "18/8/2013";

            
            Int16 maxId = Convert.ToInt16(customer_transTableAdapter.GetMaxID());

            

            customer_transTableAdapter.Insert(maxId + 1, "Payment", Convert.ToInt16(this.cust_idTextBox.Text), 1, 1, dd, "", DateTime.Now, Convert.ToDouble(payAmt), 0, "", 1, 1, "dckt");
            
            
            
           
            /*
            Decimal x;
            
            DataView dv = new DataView(dataSet2.INVOICE_HEADER);
            dv.RowFilter = string.Format("CUST_ID = {0} AND invoice_unpaid <> 0", this.cust_idTextBox.Text);
            dv.Sort = ("sort_date ASC");
            */
            //this.tableAdapterManager.UpdateAll(this.dataSet2);
            //Close();
        }

        private void t_idTextBox_Leave(object sender, EventArgs e)
        {
            t_dateDateTimePicker.Focus();
        }

        private void t_noteTextBox_Leave(object sender, EventArgs e)
        {
            t_idTextBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)   // Simple APPLY
        {
            /*
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
             */
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            unallocated_bal = Decimal.Parse(t_amountTextBox.Text);
            UnAllocatedAmount.Text = String.Format("{0:C}", unallocated_bal);
            for (int idx = 0; idx < iNVOICE_HEADERBindingSource.Count; idx++)
                {
                    iNVOICE_HEADERDataGridView[8, idx].Value = 0;
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
                            Decimal pymt;
                            try
                            {
                                pymt = Decimal.Parse(iNVOICE_HEADERDataGridView[8, idx].Value.ToString());
                            }
                            catch (Exception ex)
                            {
                                pymt = 0;
                            }
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
            if (unallocated_bal > 0) { errorFlag = true;  }
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
            if (e.RowIndex != -1)
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr = iNVOICE_HEADERDataGridView.Rows[e.RowIndex];

                try
                {
                    //Ensure the hint value is the lesser of the unallocated amount and the unpaid invoce amount.                   
                    if (Decimal.Compare(unallocated_bal, Convert.ToDecimal(dr.Cells["Unpaid"].Value)) == 1)
                    {
                        dr.Cells["recent_payment"].Value = dr.Cells["Unpaid"].Value;
                    }
                    else
                    {
                        dr.Cells["recent_payment"].Value = unallocated_bal;
                    }

                    iNVOICE_HEADERDataGridView.BeginEdit(true);
                    btnSubTotal_Click(sender, e);
                }
                catch
                {
                    ;
                }
            }
        }

        private void t_amountTextBox_Leave(object sender, EventArgs e)
        {
            btnSubTotal_Click(sender, e);
        }


    }
}
    
