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
    public partial class Debtors : Form
    {
        public Debtors()
        {
            InitializeComponent();
        }

        private void debtorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.debtorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }

        private void Debtors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.debtors' table. You can move, or remove it, as needed.
            this.debtorsTableAdapter.Fill(this.dataSet2.debtors);

        }
    }
}
