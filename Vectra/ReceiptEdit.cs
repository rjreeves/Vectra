using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Devart.Data;
using Devart.Data.SQLite;


namespace Vectra
{
    public partial class ReceiptEdit : Form
    {

        public Decimal unallocated_bal = 0;
        DataRowView drvReceipt;
        DataRowView drvCustomer;

        Vectra.DataSet2TableAdapters.configurationTableAdapter da = new Vectra.DataSet2TableAdapters.configurationTableAdapter();
        
        public ReceiptEdit(object item, object receipt)
        {
            if ((item is DataRowView) &&
     (((DataRowView)item).Row is DataSet2.customerRow))
            {
                InitializeComponent();
                this.customerBindingSource.DataSource = item;
                drvReceipt = (DataRowView)receipt;                
                drvCustomer = (DataRowView)item;
                this.customerBindingSource.DataSource = item;
                this.customer_transBindingSource.DataSource = receipt;                
            }
            else throw new ArgumentException("Incorrect type");
        }
                
        private void Receipts_Load(object sender, EventArgs e)
        {
            long currentTrans = (long)drvReceipt["t_ID"];
            this.iNVOICE_RECIEPTSTableAdapter.FillBy(this.dataSet2.INVOICE_RECIEPTS, currentTrans);                        
        }

        private void doSQL(string sqlText)
        {
            SQLiteCommand sqLiteCommand1 = new SQLiteCommand();
            sqLiteCommand1.CommandText = sqlText;

            sqLiteCommand1.CommandType = CommandType.Text;
            sqLiteCommand1.Connection = sqLiteConnection1;
            sqLiteConnection1.Open();
            sqLiteCommand1.ExecuteNonQuery();
            sqLiteConnection1.Close();

        }

        
        private void btnDelete_Click(object sender, EventArgs e)        
        {
            DataRowView t = (DataRowView)this.customer_transBindingSource.Current;

            Decimal recptAmount = Convert.ToDecimal(t["t_amount"]);

            Decimal allocatedAmount = 0;

            DataGridView dv = (DataGridView)this.iNVOICE_RECIEPTSDataGridView;
            foreach (DataGridViewRow r in dv.Rows)
            {
                allocatedAmount += Convert.ToDecimal(r.Cells[3].Value);

                doSQL(String.Format(
                    "Update invoice_header set invoice_unpaid = invoice_unpaid + {0} where invoice_number = '{1}'",
                    r.Cells[3].Value,r.Cells[4].Value));

                doSQL(String.Format(
                    "Update customer_trans set t_unpaid = t_unpaid + {0} where t_src_id = '{1}'",
                    r.Cells[3].Value, r.Cells[4].Value));              
            }

            if (recptAmount != allocatedAmount) // only add back to unallocated if there is some!
            {  
                doSQL(String.Format(
                    "update customer set open_bal = open_bal + {0} where cust_id = '{1}'",
                    Decimal.Add(recptAmount, allocatedAmount), t["t_cust_id"]));
            }

            doSQL( String.Format("Delete from customer_trans where t_id = '{0}'",t["t_id"].ToString()));
            
            doSQL( String.Format("Delete from iNVOICE_RECIEPTS where recpt_number = '{0}'", t["t_id"].ToString()));

            this.tableAdapterManager.UpdateAll(this.dataSet2);
            Close();
             
        }



    }
}
    
