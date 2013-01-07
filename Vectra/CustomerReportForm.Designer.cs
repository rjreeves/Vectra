namespace Vectra
{
    partial class CustomerReportForm
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
            System.Windows.Forms.Label bus_namesLabel;
            this.dataSet2 = new Vectra.DataSet2();
            this.customerTableAdapter1 = new Vectra.DataSet2TableAdapters.customerTableAdapter();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CustomerReport1 = new Vectra.CustomerReport();
            this.configurationTableAdapter1 = new Vectra.DataSet2TableAdapters.configurationTableAdapter();
            this.tableAdapterManager = new Vectra.DataSet2TableAdapters.TableAdapterManager();
            bus_namesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CustomerReport1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(915, 516);
            this.crystalReportViewer1.TabIndex = 2;
            // 
            // configurationTableAdapter1
            // 
            this.configurationTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.configurationTableAdapter = this.configurationTableAdapter1;
            this.tableAdapterManager.customer_transTableAdapter = null;
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
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.sqlite_sequenceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Vectra.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bus_namesLabel
            // 
            bus_namesLabel.AutoSize = true;
            bus_namesLabel.Location = new System.Drawing.Point(363, 475);
            bus_namesLabel.Name = "bus_namesLabel";
            bus_namesLabel.Size = new System.Drawing.Size(61, 13);
            bus_namesLabel.TabIndex = 3;
            bus_namesLabel.Text = "bus names:";
            // 
            // CustomerReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 516);
            this.Controls.Add(bus_namesLabel);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "CustomerReportForm";
            this.Text = "CustomerReportForm";
            this.Load += new System.EventHandler(this.CustomerReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CustomerReport CustomerReport1;
        private DataSet2 dataSet2;
        private Vectra.DataSet2TableAdapters.customerTableAdapter customerTableAdapter1;
        private Vectra.DataSet2TableAdapters.configurationTableAdapter configurationTableAdapter1;
        private Vectra.DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
    }
}