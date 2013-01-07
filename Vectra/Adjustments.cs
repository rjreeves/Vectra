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
    public partial class Adjustments : Form
    {
        public Adjustments(object item)
        {
            if ((item is DataRowView) &&
                   (((DataRowView)item).Row is DataSet2.customerRow))
            {
                InitializeComponent();
                this.customerBindingSource.DataSource = item;
            }
            else throw new ArgumentException("Incorrect type");
        }

        private void customer_transBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customer_transBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }

        private void Adjustments_Load(object sender, EventArgs e)
        {
            string m_type = "Adjustment";
            this.customerTableAdapter.Fill(this.dataSet2.customer);           
            this.customer_transTableAdapter.Fill(this.dataSet2.customer_trans);
            customer_transBindingSource.Filter = string.Format("t_cust_id = {0} AND t_type = '{1}'", this.cust_idTextBox.Text, m_type);

        }

        private void customer_transDataGridView_DoubleClick(object sender, EventArgs e)
        {
            object item = (DataRowView)this.customer_transBindingSource.Current;
            using (Form f = new AdjustmentEdit(item, customerBindingSource.Current))
            {
                f.ShowDialog();
            }
            this.customer_transTableAdapter.Fill(this.dataSet2.customer_trans);

        }
    }
}



