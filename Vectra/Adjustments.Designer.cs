namespace Vectra
{
    partial class Adjustments
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
            System.Windows.Forms.Label cust_idLabel;
            this.dataSet2 = new Vectra.DataSet2();
            this.customer_transBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_transTableAdapter = new Vectra.DataSet2TableAdapters.customer_transTableAdapter();
            this.tableAdapterManager = new Vectra.DataSet2TableAdapters.TableAdapterManager();
            this.customer_transDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Vectra.DataSet2TableAdapters.customerTableAdapter();
            this.cust_idTextBox = new System.Windows.Forms.TextBox();
            this.name_address_1TextBox = new System.Windows.Forms.TextBox();
            cust_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_transBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_transDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customer_transBindingSource
            // 
            this.customer_transBindingSource.DataMember = "customer_trans";
            this.customer_transBindingSource.DataSource = this.dataSet2;
            // 
            // customer_transTableAdapter
            // 
            this.customer_transTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.configurationTableAdapter = null;
            this.tableAdapterManager.customer_transTableAdapter = this.customer_transTableAdapter;
            this.tableAdapterManager.customerTableAdapter = this.customerTableAdapter;
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
            // customer_transDataGridView
            // 
            this.customer_transDataGridView.AutoGenerateColumns = false;
            this.customer_transDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_transDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.customer_transDataGridView.DataSource = this.customer_transBindingSource;
            this.customer_transDataGridView.Location = new System.Drawing.Point(0, 31);
            this.customer_transDataGridView.Name = "customer_transDataGridView";
            this.customer_transDataGridView.Size = new System.Drawing.Size(956, 286);
            this.customer_transDataGridView.TabIndex = 1;
            this.customer_transDataGridView.DoubleClick += new System.EventHandler(this.customer_transDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "t_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "t_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "t_type";
            this.dataGridViewTextBoxColumn2.HeaderText = "t_type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "t_cust_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "t_cust_id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "t_src_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "t_src_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "t_ref_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "t_ref_id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "t_date";
            this.dataGridViewTextBoxColumn6.HeaderText = "t_date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "t_amount";
            this.dataGridViewTextBoxColumn9.HeaderText = "t_amount";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "t_unpaid";
            this.dataGridViewTextBoxColumn10.HeaderText = "t_unpaid";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.dataSet2;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // cust_idLabel
            // 
            cust_idLabel.AutoSize = true;
            cust_idLabel.Location = new System.Drawing.Point(16, 5);
            cust_idLabel.Name = "cust_idLabel";
            cust_idLabel.Size = new System.Drawing.Size(51, 13);
            cust_idLabel.TabIndex = 1;
            cust_idLabel.Text = "Customer";
            // 
            // cust_idTextBox
            // 
            this.cust_idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cust_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "cust_id", true));
            this.cust_idTextBox.Location = new System.Drawing.Point(73, 5);
            this.cust_idTextBox.Name = "cust_idTextBox";
            this.cust_idTextBox.Size = new System.Drawing.Size(100, 13);
            this.cust_idTextBox.TabIndex = 2;
            // 
            // name_address_1TextBox
            // 
            this.name_address_1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_address_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "name_address_1", true));
            this.name_address_1TextBox.Location = new System.Drawing.Point(179, 5);
            this.name_address_1TextBox.Name = "name_address_1TextBox";
            this.name_address_1TextBox.Size = new System.Drawing.Size(515, 13);
            this.name_address_1TextBox.TabIndex = 4;
            // 
            // Adjustments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 337);
            this.Controls.Add(this.name_address_1TextBox);
            this.Controls.Add(cust_idLabel);
            this.Controls.Add(this.cust_idTextBox);
            this.Controls.Add(this.customer_transDataGridView);
            this.Name = "Adjustments";
            this.Text = "Adjustments";
            this.Load += new System.EventHandler(this.Adjustments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_transBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_transDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource customer_transBindingSource;
        private Vectra.DataSet2TableAdapters.customer_transTableAdapter customer_transTableAdapter;
        private Vectra.DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView customer_transDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private Vectra.DataSet2TableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.TextBox cust_idTextBox;
        private System.Windows.Forms.TextBox name_address_1TextBox;
    }
}