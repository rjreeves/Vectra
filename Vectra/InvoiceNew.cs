using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Devart.Data.SQLite;
using Devart.Data;

namespace Vectra
{
    
    public partial class InvoiceNew : Form
    {
        public delegate double calcDelegate(double a, double b);        

        public bool flgCredit;
        public bool flgQty;
        public bool flgWeight;
        public static int custPos;
        ToolTip tp1 = new ToolTip();
        public bool firstTime = true;
        public InvoiceNew(object item)
        {            
            if ((item is DataRowView) &&
                (((DataRowView)item).Row is DataSet2.customerRow))
            {
                InitializeComponent();
                this.customerBindingSource.DataSource = item;                
            }
            else throw new ArgumentException("Incorrect type");
        }

        public string getCurrentAcntPeriod()
        {
            Vectra.DataSet2TableAdapters.configurationTableAdapter da = new Vectra.DataSet2TableAdapters.configurationTableAdapter();
            return da.getCurrentAcntPeriod().ToString();           
        }

        private void iNVOICE_HEADERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            DataView dvn = new DataView(dataSet2.invoice_items);            
            foreach (DataRowView r in dvn)
            {
                if (r.Row["prod_id"].ToString().Length < 2)
                {                    
                    r.Row.Delete();
                }
            }

            doTotal();

            // Set the row to be unlocked. 0 - Unlocked. 1 = Locked
             
            ((DataRowView)iNVOICE_HEADERBindingSource.Current).Row["invoice_locked"] = "0";
            this.invoice_unpaidTextBox.Text = this.totalTextBox.Text;

            ((DataRowView)iNVOICE_HEADERBindingSource.Current).Row["invoice_date"] = 
                Convert.ToDateTime(((DataRowView)iNVOICE_HEADERBindingSource.Current).Row["invoice_date"]).ToString("dd/MM/yyyy");

            ((DataRowView)iNVOICE_HEADERBindingSource.Current).Row["sort_date"] =
                Convert.ToDateTime(((DataRowView)iNVOICE_HEADERBindingSource.Current).Row["invoice_date"]).ToString("yyyyMMdd");
            this.Validate();
            this.iNVOICE_HEADERBindingSource.EndEdit();        

            DataRowView dv = (DataRowView)this.iNVOICE_HEADERBindingSource.Current;
            DataRowView drvct = (DataRowView)this.customer_transBindingSource.AddNew();
            drvct["t_type"] = "Invoice";
            drvct["t_cust_id"] = dv.Row["cust_id"];
            drvct["t_src_id"] = dv.Row["invoice_number"];            
            drvct["t_date"] = dv.Row["invoice_date"];            
            drvct["t_amount"] = dv.Row["invoice_amount"];
            drvct["t_unpaid"] = dv.Row["invoice_amount"];
            drvct["t_timestamp"] = DateTime.Now.ToLongTimeString();
            drvct["t_week_id"] = getCurrentAcntPeriod();
            drvct["t_src_dckt_id"] = dv.Row["docket_number"];
            drvct.EndEdit();

            foreach (DataRowView r in dvn)
            {
                if (r.Row["prod_id"].ToString().Length < 2)
                {
                    r.Row.Delete();
                }
            }

            this.tableAdapterManager.UpdateAll(this.dataSet2);

            Close(); //close the form
           
        }

        private void InvoiceNew_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.customer_trans' table. You can move, or remove it, as needed.
            this.customer_transTableAdapter.Fill(this.dataSet2.customer_trans);

            // TODO: This line of code loads data into the 'dataSet2.product_type' table. You can move, or remove it, as needed.
            this.product_typeTableAdapter.Fill(this.dataSet2.product_type);
            // TODO: This line of code loads data into the 'dataSet1.xProds' table. You can move, or remove it, as needed.
           
            this.cust_idTextBox1.Text = this.cust_idTextBox.Text;

            // TODO: This line of code loads data into the 'dataSet2.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dataSet2.products);           
            // TODO: This line of code loads data into the 'dataSet2.invoice_items' table. You can move, or remove it, as needed.
            this.invoice_itemsTableAdapter.Fill(this.dataSet2.invoice_items);
            // TODO: This line of code loads data into the 'dataSet2.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.dataSet2.customer);
            // TODO: This line of code loads data into the 'dataSet2.INVOICE_HEADER' table. You can move, or remove it, as needed.
            this.iNVOICE_HEADERTableAdapter.Fill(this.dataSet2.INVOICE_HEADER);

            this.iNVOICE_HEADERBindingSource.AddNew();
            this.cust_idTextBox1.Text = this.cust_idTextBox.Text;
            
            this.invoice_itemsBindingSource.AddNew();

            this.invoice_dateDateTimePicker.Text =  DateTime.Now.ToShortDateString();

            tp1.AutoPopDelay = 5000;
            tp1.InitialDelay = 1000;
            tp1.ReshowDelay = 500;
            tp1.ShowAlways = true;
            //tp1.SetToolTip(this.btnCustLookup, "Customer Lookup");

            //invoice_itemsDataGridView.RowValidating += invoice_itemsDataGridView_RowValidating;
            
        }
        


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print","Vectra Invoice",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }


        private void doTotal()
        {
            DataView dvn = new DataView(dataSet2.invoice_items);
            Decimal gst = 0;
            Decimal total = 0;
            Decimal subTotal = 0;
            foreach (DataGridViewRow Row in this.invoice_itemsDataGridView.Rows)
            {
                try
                {                    
                    gst = gst + decimal.Parse(Row.Cells[5].Value.ToString());
                    total = total + decimal.Parse(Row.Cells[6].Value.ToString());                    
                }
                catch
                {
                }
                subTotal = Decimal.Subtract(total, gst);
                //this.SubTotalTextBox.Text = String.Format("{0:C}", subTotal);
                this.totalTextBox.Text = String.Format("{0:C}", total);
                this.gstTextBox.Text = String.Format("{0:C}", gst);
                Refresh();

            }           


        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            doTotal();
        }

  
        private void invoice_itemsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.ColumnIndex == 0)
            {
                flgQty = false;  // These flags for ensuring one of the cols has a rate value
                flgWeight = false;                
                int myLineNum;
                myLineNum = e.RowIndex;
                if (this.invoice_itemsDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString() == "")
                {
                    if (myLineNum != 0)
                    {
                        myLineNum = int.Parse(this.invoice_itemsDataGridView[e.ColumnIndex, myLineNum - 1].Value.ToString()) + 1;
                    }
                    else
                    {
                        myLineNum = 1;
                    }
                    this.invoice_itemsDataGridView[e.ColumnIndex, e.RowIndex].Value = myLineNum;
                }
                              
            }
            if (e.ColumnIndex == 2)
            {
                invoice_itemsDataGridView.RowValidating += invoice_itemsDataGridView_RowValidating;
            }
            if (e.ColumnIndex == 4) 
            {
                SendKeys.Send("{TAB}");
                SendKeys.Send("{TAB}");
                SendKeys.Send("{TAB}");
                SendKeys.Send("{TAB}");
                btnTotal_Click(sender, e);
            }

            
        }

        //-- Row validation not active. Future consideration
        private void invoice_itemsDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
                if ((flgQty == false) && (flgWeight == false))
                {
                    MessageBox.Show("Rate value is required. Try again...",
                        "Rate value missing",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    e.Cancel = true;
                    invoice_itemsDataGridView.CurrentCell = invoice_itemsDataGridView[2, e.RowIndex];
                }
                invoice_itemsDataGridView.RowValidating -= invoice_itemsDataGridView_RowValidating;
                
        }

        private Boolean IsLidOk(DataGridViewCell cell)
        {
            if (cell.Value.ToString().Length == 0)
            {
                cell.ErrorText = "Click Here to auto line number";
                return false;
            }
            return true;
        }

        private Boolean IsPidOk(DataGridViewCell cell)
        {
            if (cell.Selected.ToString().Length == 0)
            {
                cell.ErrorText = "Click here to select";
                return false;
            }
            return true;
        }
        private Boolean IsRateOk(DataGridViewCell cell)
        {
            if (cell.Selected.ToString().Length == 0)
            {
                cell.ErrorText = "Enter a value";
                return false;
            }
            return true;
        }
        private Boolean IsAmtOk(DataGridViewCell cell)
        {
            if (cell.Selected.ToString().Length == 0)
            {
                cell.ErrorText = "Enter a value";
                return false;
            }
            return true;
        }

        //Important:- This function refreshes the customer details when using the navigaion bar
        private void cust_idTextBox1_TextChanged(object sender, EventArgs e)
        {
            int index = customerBindingSource.Find("cust_id", this.cust_idTextBox1.Text);
            customerBindingSource.Position = index;
        }

        //Important-- Ignore unnecessary data errors due to odd navigation behaviour
        private void invoice_itemsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {            
            invoice_itemsDataGridView.CancelEdit();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {            
            Close();
        }

//++
        static double[] Parse(string math)
        {            
            string pattern = @"^\s*(?<a>(\-)*\d+\.?\d*|\.\d+)\s*(?<operator>(\+|\-|\*|\/))\s*(?<b>\d+\.?\d*|\.\d+)\s*$";
            if (Regex.IsMatch(math, pattern, RegexOptions.IgnorePatternWhitespace))
            {
                Match match = Regex.Match(math, pattern, RegexOptions.IgnorePatternWhitespace);
                calcDelegate del = GetDelegate(match.Groups["operator"].Value);
                double[] reply = { 0, 0, 0 };
                reply[0] = double.Parse(match.Groups["a"].Value);                
                reply[1] = double.Parse(match.Groups["b"].Value);
                reply[2] = del(double.Parse(match.Groups["a"].Value), double.Parse(match.Groups["b"].Value));
                return reply;
            }
            else
                throw new Exception("parameter does not seem valid");
        }
        static calcDelegate GetDelegate(string op)
        {
            switch (op)
            {
                case "+":
                    return new calcDelegate(Add);
                case "-":
                    return new calcDelegate(Subtract);
                case "*":
                    return new calcDelegate(Multiply);
                case "/":
                    return new calcDelegate(Divide);
                default:
                    throw new Exception("Invalid operator");
            }
        }

        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Subtract(double a, double b)
        {
            return a - b;
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Divide(double a, double b)
        {
            if (b != 0)
                return (a / b);
            throw new DivideByZeroException();
        }


        private void invoice_itemsDataGridView_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {            
            if ((e.ColumnIndex == 2) || (e.ColumnIndex == 3))
            {
                //MessageBox.Show("Parsing"+e.Value.ToString());
                double[] reply = { 0, 0, 0 };
                try
                {
                    reply = Parse(e.Value.ToString());
                    e.Value = reply[0];
                    this.invoice_itemsDataGridView[4, e.RowIndex].Value = reply[1];
                    DataRowView drv;
                    drv = (DataRowView)this.productsBindingSource.Current;
                    Decimal gstRate = (Decimal.Parse(drv.Row["gst"].ToString()) / 100);
                    Decimal gstValue = 0;
                    Decimal amount = Decimal.Parse(reply[2].ToString());
                    if( drv.Row["desc"].ToString().ToLower().Contains("credit"))
                    {
                        amount = Decimal.Subtract(0, amount);
                    }

                    gstValue = Decimal.Multiply(amount, gstRate);
                    amount = amount + gstValue;

                    this.invoice_itemsDataGridView[5, e.RowIndex].Value = gstValue;
                    this.invoice_itemsDataGridView[6, e.RowIndex].Value = amount;

                    this.invoice_itemsDataGridView.Refresh();

                    e.ParsingApplied = true;
                }
                catch { ; }

                if (e.ColumnIndex == 2)
                {
                    if (reply[1] == 0)
                    {
                        flgQty = false;
                    }
                    else
                    {
                        flgQty = true;
                    }
                }
                if (e.ColumnIndex == 3)
                {
                    if (reply[1] == 0)
                    {
                        flgWeight = false;
                    }
                    else
                    {
                        flgWeight = true;
                    }
                }
            }
        }

        private void invoice_itemsDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            // Delete an invoice line item
            if (e.KeyCode.ToString() == Keys.Delete.ToString())
            {
                DataGridView dg = (DataGridView)sender;
                DialogResult result = MessageBox.Show(String.Format("Delete Current Invoice Line {0}?",dg[0,dg.CurrentRow.Index].Value.ToString()), Application.ProductName,
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataRowView drv;
                    drv = (DataRowView)this.invoice_itemsBindingSource.Current;
                    drv.Delete();
                    doTotal();
                    this.Refresh();
                }
            }
        }

        //-- Avoid weird TAB and ARROW keys behaviour
        private void docket_numberTextBox_Leave(object sender, EventArgs e)
        {
            this.invoice_dateDateTimePicker.Focus();
        }

        //-- Avoid weird TAB and ARROW keys behaviour
        private void btnTotal_Leave(object sender, EventArgs e)
        {
            this.docket_numberTextBox.Focus();
        }
 
    }
}
