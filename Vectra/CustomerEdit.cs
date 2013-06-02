                                                           using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vectra
{
    public partial class CustomerEdit : Form
    {        
        public CustomerEdit(object item)
        {
            if ((item is DataRowView) &&
                (((DataRowView)item).Row is DataSet2.customerRow))
            {
                InitializeComponent();
                this.customerBindingSource.DataSource = item;
            }
            else throw new ArgumentException("Incorrect type");
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);       
        }

        private void CustomerEdit_Load(object sender, EventArgs e)
        {
            ; 
        }

        private void CustomerEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Canceledit if cancel button is pressed or form is closed from
            // either the system menu or close box
            if ((e.CloseReason == CloseReason.UserClosing) ||
               (this.DialogResult == DialogResult.Cancel))
            {
                this.customerBindingSource.CancelEdit();
            }
            else
            {
                this.Validate();
                this.customerBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet2);                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);         
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            cust_idTextBox.Focus();
        }

        private void cust_idTextBox_Leave(object sender, EventArgs e)
        {
            name_address_1TextBox.Focus();
        }    
    }
}
