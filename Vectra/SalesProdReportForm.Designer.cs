namespace Vectra
{
    partial class SalesProdReportForm
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
            this.components = new System.ComponentModel.Container();
            this.dataSet2 = new Vectra.DataSet2();
            this.configurationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configurationTableAdapter = new Vectra.DataSet2TableAdapters.configurationTableAdapter();
            this.tableAdapterManager = new Vectra.DataSet2TableAdapters.TableAdapterManager();
            this.productSalesReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productSalesReportTableAdapter = new Vectra.DataSet2TableAdapters.ProductSalesReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSalesReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // configurationBindingSource
            // 
            this.configurationBindingSource.DataMember = "configuration";
            this.configurationBindingSource.DataSource = this.dataSet2;
            // 
            // configurationTableAdapter
            // 
            this.configurationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.configurationTableAdapter = this.configurationTableAdapter;
            this.tableAdapterManager.customer_transTableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = null;
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
            this.tableAdapterManager.ProductSalesReportTableAdapter = this.productSalesReportTableAdapter;
            this.tableAdapterManager.ProductSalesSummaryTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.sqlite_sequenceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Vectra.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productSalesReportBindingSource
            // 
            this.productSalesReportBindingSource.DataMember = "ProductSalesReport";
            this.productSalesReportBindingSource.DataSource = this.dataSet2;
            // 
            // productSalesReportTableAdapter
            // 
            this.productSalesReportTableAdapter.ClearBeforeFill = true;
            // 
            // SalesProdReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 203);
            this.Name = "SalesProdReportForm";
            this.Text = "SalesProdReportForm";
            this.Load += new System.EventHandler(this.SalesProdReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSalesReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource configurationBindingSource;
        private Vectra.DataSet2TableAdapters.configurationTableAdapter configurationTableAdapter;
        private Vectra.DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private Vectra.DataSet2TableAdapters.ProductSalesReportTableAdapter productSalesReportTableAdapter;
        private System.Windows.Forms.BindingSource productSalesReportBindingSource;
    }
}