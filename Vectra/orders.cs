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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void iNVOICE_HEADERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iNVOICE_HEADERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }

        private void orders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.dataSet2.customer);
            // TODO: This line of code loads data into the 'dataSet2.invoice_items' table. You can move, or remove it, as needed.
            this.invoice_itemsTableAdapter.Fill(this.dataSet2.invoice_items);
            // TODO: This line of code loads data into the 'dataSet2.INVOICE_HEADER' table. You can move, or remove it, as needed.
            this.iNVOICE_HEADERTableAdapter.Fill(this.dataSet2.INVOICE_HEADER);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
