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
    public partial class Receipts : Form
    {
        public Receipts()
        {
            InitializeComponent();
        }

        private void iNVOICE_RECIEPTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iNVOICE_RECIEPTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Receipts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.INVOICE_RECIEPTS' table. You can move, or remove it, as needed.
            this.iNVOICE_RECIEPTSTableAdapter.Fill(this.dataSet1.INVOICE_RECIEPTS);

        }
    }
}
