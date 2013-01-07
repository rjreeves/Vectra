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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }



        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }

        private void Products1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dataSet1.products);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show("Delete current row?", "Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.productsBindingSource.RemoveCurrent();
            }
        }

        private void Products_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }

    }
}
