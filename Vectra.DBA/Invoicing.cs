using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vectra.DBA
{
    public partial class Invoicing : Form
    {
        public Invoicing()
        {
            InitializeComponent();
        }

        private void iNVOICE_HEADERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iNVOICE_HEADERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Invoicing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.customer_trans' table. You can move, or remove it, as needed.
            this.customer_transTableAdapter.Fill(this.dataSet1.customer_trans);
            // TODO: This line of code loads data into the 'dataSet1.invoice_items' table. You can move, or remove it, as needed.
            this.invoice_itemsTableAdapter.Fill(this.dataSet1.invoice_items);
            // TODO: This line of code loads data into the 'dataSet1.INVOICE_HEADER' table. You can move, or remove it, as needed.
            this.iNVOICE_HEADERTableAdapter.Fill(this.dataSet1.INVOICE_HEADER);

        }
    }
}
