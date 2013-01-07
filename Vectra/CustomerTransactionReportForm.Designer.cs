namespace Vectra
{
    partial class CustomerTransactionReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataSet2 = new Vectra.DataSet2();
            this.tableAdapterManager = new Vectra.DataSet2TableAdapters.TableAdapterManager();
            this.configurationTableAdapter1 = new Vectra.DataSet2TableAdapters.configurationTableAdapter();
            this.customer_transTableAdapter1 = new Vectra.DataSet2TableAdapters.customer_transTableAdapter();
            this.customerTableAdapter1 = new Vectra.DataSet2TableAdapters.customerTableAdapter();
            this.CustomerTransactionReport1 = new Vectra.CustomerTransactionReport();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.configurationTableAdapter = this.configurationTableAdapter1;
            this.tableAdapterManager.customer_transTableAdapter = this.customer_transTableAdapter1;
            this.tableAdapterManager.customerTableAdapter = this.customerTableAdapter1;
            this.tableAdapterManager.debtors_summaryTableAdapter = null;
            this.tableAdapterManager.debtorsTableAdapter = null;
            this.tableAdapterManager.gl_categoryTableAdapter = null;
            this.tableAdapterManager.gl_txnsTableAdapter = null;
            this.tableAdapterManager.glTableAdapter = null;
            this.tableAdapterManager.INVOICE_HEADERTableAdapter = null;
            this.tableAdapterManager.invoice_itemsTableAdapter = null;
            this.tableAdapterManager.INVOICE_RECIEPTSTableAdapter = null;
            this.tableAdapterManager.payment_typeTableAdapter = null;
            this.tableAdapterManager.product_typeTableAdapter = null;
            this.tableAdapterManager.ProductSalesSummaryTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.sqlite_sequenceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Vectra.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // configurationTableAdapter1
            // 
            this.configurationTableAdapter1.ClearBeforeFill = true;
            // 
            // customer_transTableAdapter1
            // 
            this.customer_transTableAdapter1.ClearBeforeFill = true;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // CustomerTransactionReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 52);
            this.Name = "CustomerTransactionReportForm";
            this.Text = "Customer Transactions";
            this.Load += new System.EventHandler(this.CustomerTransactionReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet2 dataSet2;
        private Vectra.DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private Vectra.DataSet2TableAdapters.configurationTableAdapter configurationTableAdapter1;
        private Vectra.DataSet2TableAdapters.customer_transTableAdapter customer_transTableAdapter1;
        private Vectra.DataSet2TableAdapters.customerTableAdapter customerTableAdapter1;
        private CustomerTransactionReport CustomerTransactionReport1;
    }
}