using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Vectra
{
    public partial class CustomerInterface : Form
    {
        public string currentSelectedCustId;
        DataView dirv;
        public CustomerInterface()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            this.customerTableAdapter.Fill(this.dataSet2.customer);
            this.debtors_summaryTableAdapter.Fill(this.dataSet2.debtors_summary);            
            this.iNVOICE_RECIEPTSTableAdapter.Fill(this.dataSet2.INVOICE_RECIEPTS);
            this.iNVOICE_HEADERTableAdapter.Fill(this.dataSet2.INVOICE_HEADER);
            this.customer_transTableAdapter.Fill(this.dataSet2.customer_trans);           
        }

        private void CustomerInterface_Load(object sender, EventArgs e)
        {
            LoadData();
            this.customerTableAdapter.Fill(this.dataSet2.customer);
            
            customerDataGridView_Click(sender, e);
            this.toolStrip2.Focus();
            searchValue.Focus();            

            dirv = new DataView(dataSet2.INVOICE_HEADER);
            DataRowView drc = (DataRowView)this.customerBindingSource.Current;
            dirv.RowFilter = string.Format("CUST_ID = {0}", drc.Row["cust_id"].ToString());
            // Sort the customer transactions by transaction ID desc
            dataGridView2.Sort(dataGridView2.Columns[0], ListSortDirection.Descending);
        }

        void EditCustomer(DataRowView item)
        {            
            using (CustomerEdit dlg = new CustomerEdit(item))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    this.customerBindingSource.ResetCurrentItem();
                    this.customerTableAdapter.Update(this.dataSet2.customer);
                }
            }
        }

        private void AddNewCustomer(object sender, EventArgs e) //Menu - New Customer
        {              
            this.EditCustomer((DataRowView)this.customerBindingSource.AddNew());
        }
        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            this.EditCustomer((DataRowView)this.customerBindingSource.Current);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.EditCustomer((DataRowView)this.customerBindingSource.Current);
            LoadData();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e) // Delete Customer on toolbar
        {
            deleteToolStripMenuItem_Click(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) //pop up menu
        {
            DialogResult result = MessageBox.Show("Delete Current Customer?", Application.ProductName,
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.customerBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.dataSet2);
            }

        }
        private void CustomerInterface_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5) btnInvoicing_Click(sender, e);
            if (e.KeyCode == Keys.F6) btnReceipt_Click(sender, e);
            if (e.KeyCode == Keys.F7) btnAdjustment_Click(sender, e);
        }

        private void btnInvoicing_Click(object sender, EventArgs e)
        {
            object item = (DataRowView)this.customerBindingSource.Current;
            using (Form f = new InvoiceNew(item))
            {
                f.ShowDialog();
            }
            this.customer_transTableAdapter.Fill(this.dataSet2.customer_trans);
            this.iNVOICE_HEADERTableAdapter.Fill(this.dataSet2.INVOICE_HEADER);
            this.toolStrip2.Focus();
            searchValue.Focus();
            searchValue.SelectAll();
            this.Refresh();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            int currentRowIndex = customerDataGridView.SelectedRows[0].Index;
            object item = (DataRowView)this.customerBindingSource.Current;
            using (Form f = new Receipts(item))            
            {
                f.ShowDialog();
                //this.customerBindingSource.ResetCurrentItem();               
            }            
            this.customer_transTableAdapter.Fill(this.dataSet2.customer_trans);
            this.iNVOICE_HEADERTableAdapter.Fill(this.dataSet2.INVOICE_HEADER);            
            this.toolStrip2.Focus();
            searchValue.Focus();
            searchValue.SelectAll();
            this.Refresh();
        }


        private void btnAdjustment_Click(object sender, EventArgs e)
        {   
            object item = (DataRowView)this.customer_transBindingSource.AddNew();

            // Sort the customer transactions by transaction ID desc
            dataGridView2.Sort(dataGridView2.Columns[0], ListSortDirection.Descending);
            
            using (Form f = new AdjustmentEdit(item, customerBindingSource.Current))
            {
               if (f.ShowDialog() == DialogResult.OK)
                {
                    this.customer_transBindingSource.EndEdit();
                    this.customerBindingSource.ResetCurrentItem();
                    //this.customer_transBindingSource.ResetCurrentItem();
                    this.customer_transTableAdapter.Update(this.dataSet2.customer_trans);
                }
            }
            this.customer_transTableAdapter.Fill(this.dataSet2.customer_trans);
            this.iNVOICE_HEADERTableAdapter.Fill(this.dataSet2.INVOICE_HEADER); 
            // Sort the customer transactions by transaction ID desc
            dataGridView2.Sort(dataGridView2.Columns[0], ListSortDirection.Descending);
            this.toolStrip2.Focus();
            searchValue.Focus();
            searchValue.SelectAll();
         }


        private void customerDataGridView_Click(object sender, EventArgs e)
        {   
            DataRowView drc = (DataRowView)this.customerBindingSource.Current;
            currentSelectedCustId = drc["cust_id"].ToString();            
            dirv = new DataView(dataSet2.INVOICE_HEADER);
            dirv.RowFilter = string.Format("CUST_ID = {0}", drc.Row["cust_id"].ToString());           
           
            this.debtors_summaryBindingSource.Filter = string.Format("cust_id = {0}", drc.Row["cust_id"].ToString());
            DataRowView drs = (DataRowView)this.debtors_summaryBindingSource.Current;
            Decimal x = 0;
            this.TotalDue.Text = "0";

            // Sort the customer transactions by transaction ID desc
            dataGridView2.Sort(dataGridView2.Columns[0], ListSortDirection.Descending);
           
            
            try
            {
               x = Convert.ToDecimal(drs.Row["curAmt"].ToString())
                 + Convert.ToDecimal(drs.Row["days7"].ToString())
                 + Convert.ToDecimal(drs.Row["days14"].ToString())
                 + Convert.ToDecimal(drs.Row["days21"].ToString());
               this.TotalDue.Text = string.Format("{0,2:C}",x);
            }
            catch{ ; }
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            DataRowView drc = (DataRowView)this.customer_transBindingSource.Current;
            
            if (drc.Row["t_type"].ToString() == "Invoice")
            {
                object item = (DataRowView)this.customerBindingSource.Current;
                object invoice = (DataRowView)this.customer_transBindingSource.Current;
                using (Form f = new InvoiceEdit(item, invoice))
                {
                    f.ShowDialog();
                }
                this.customer_transTableAdapter.Fill(this.dataSet2.customer_trans);
                this.iNVOICE_HEADERTableAdapter.Fill(this.dataSet2.INVOICE_HEADER);            
            }
            else
            if (drc.Row["t_type"].ToString() == "Payment")
            {
                object item = (DataRowView)this.customerBindingSource.Current;
                object receipt = (DataRowView)this.customer_transBindingSource.Current;
                using (Form f = new ReceiptEdit(item, receipt))
                {
                    f.ShowDialog();                                       
                }
                this.customer_transTableAdapter.Fill(this.dataSet2.customer_trans);
                this.iNVOICE_HEADERTableAdapter.Fill(this.dataSet2.INVOICE_HEADER);
                this.customerBindingSource.ResetCurrentItem();
                
            }                     
            this.toolStrip2.Focus();
            searchValue.Focus();
            searchValue.SelectAll();
            this.Refresh();
        }


        private bool IsTextNumeric(string strTextEntry)
        {
            Regex objNotWholePattern = new Regex("[^0-9]");
            return !objNotWholePattern.IsMatch(strTextEntry)
                 && (strTextEntry != "");
        }

        private void searchValue_TextChanged(object sender, EventArgs e)
        {
            if (searchValue.Text.Length > 0)
            {
                if (IsTextNumeric(searchValue.ToString()))
                {
                    this.customerBindingSource.Filter = String.Format(@"cust_id = {0}", searchValue.Text);
                }
                else
                {
                    this.customerBindingSource.Filter = String.Format(@"name_address_1 like '{0}%'", searchValue.Text);
                }
            }
            else
            {
                    this.customerBindingSource.RemoveFilter();
            }

        }

        private void open_balTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerDataGridView_Sorted(object sender, EventArgs e)
        {
            int index = this.customerBindingSource.Find("cust_id", currentSelectedCustId.ToString());
            this.customerBindingSource.Position = index;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form f = new CurrentTransaction();
            f.ShowDialog();
        }


    }
}
