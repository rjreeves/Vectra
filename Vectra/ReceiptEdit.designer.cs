namespace Vectra
{
    partial class ReceiptEdit
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
            System.Windows.Forms.Label t_idLabel;
            System.Windows.Forms.Label t_dateLabel;
            System.Windows.Forms.Label t_amountLabel;
            System.Windows.Forms.Label name_address_1Label;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.t_idTextBox = new System.Windows.Forms.TextBox();
            this.t_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.t_amountTextBox = new System.Windows.Forms.TextBox();
            this.name_address_1TextBox = new System.Windows.Forms.TextBox();
            this.cust_idTextBox = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.sqLiteConnection1 = new Devart.Data.SQLite.SQLiteConnection();
            this.iNVOICE_RECIEPTSDataGridView = new System.Windows.Forms.DataGridView();
            this.iNVOICE_RECIEPTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Vectra.DataSet2();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_transBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNVOICE_HEADERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_transTableAdapter = new Vectra.DataSet2TableAdapters.customer_transTableAdapter();
            this.tableAdapterManager = new Vectra.DataSet2TableAdapters.TableAdapterManager();
            this.customerTableAdapter = new Vectra.DataSet2TableAdapters.customerTableAdapter();
            this.iNVOICE_HEADERTableAdapter = new Vectra.DataSet2TableAdapters.INVOICE_HEADERTableAdapter();
            this.iNVOICE_RECIEPTSTableAdapter = new Vectra.DataSet2TableAdapters.INVOICE_RECIEPTSTableAdapter();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice_key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            t_idLabel = new System.Windows.Forms.Label();
            t_dateLabel = new System.Windows.Forms.Label();
            t_amountLabel = new System.Windows.Forms.Label();
            name_address_1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_RECIEPTSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_RECIEPTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_transBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_HEADERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // t_idLabel
            // 
            t_idLabel.AutoSize = true;
            t_idLabel.Location = new System.Drawing.Point(12, 45);
            t_idLabel.Name = "t_idLabel";
            t_idLabel.Size = new System.Drawing.Size(80, 13);
            t_idLabel.TabIndex = 2;
            t_idLabel.Text = "Transaction ID:";
            // 
            // t_dateLabel
            // 
            t_dateLabel.AutoSize = true;
            t_dateLabel.Location = new System.Drawing.Point(233, 45);
            t_dateLabel.Name = "t_dateLabel";
            t_dateLabel.Size = new System.Drawing.Size(73, 13);
            t_dateLabel.TabIndex = 10;
            t_dateLabel.Text = "Receipt Date:";
            // 
            // t_amountLabel
            // 
            t_amountLabel.AutoSize = true;
            t_amountLabel.Location = new System.Drawing.Point(473, 45);
            t_amountLabel.Name = "t_amountLabel";
            t_amountLabel.Size = new System.Drawing.Size(46, 13);
            t_amountLabel.TabIndex = 16;
            t_amountLabel.Text = "Amount:";
            // 
            // name_address_1Label
            // 
            name_address_1Label.AutoSize = true;
            name_address_1Label.Location = new System.Drawing.Point(41, 12);
            name_address_1Label.Name = "name_address_1Label";
            name_address_1Label.Size = new System.Drawing.Size(51, 13);
            name_address_1Label.TabIndex = 20;
            name_address_1Label.Text = "Customer";
            // 
            // t_idTextBox
            // 
            this.t_idTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.t_idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_transBindingSource, "t_id", true));
            this.t_idTextBox.Location = new System.Drawing.Point(98, 45);
            this.t_idTextBox.Name = "t_idTextBox";
            this.t_idTextBox.ReadOnly = true;
            this.t_idTextBox.Size = new System.Drawing.Size(112, 13);
            this.t_idTextBox.TabIndex = 0;
            this.t_idTextBox.TabStop = false;
            // 
            // t_dateDateTimePicker
            // 
            this.t_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customer_transBindingSource, "t_date", true));
            this.t_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_transBindingSource, "t_date", true));
            this.t_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.t_dateDateTimePicker.Location = new System.Drawing.Point(312, 41);
            this.t_dateDateTimePicker.Name = "t_dateDateTimePicker";
            this.t_dateDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.t_dateDateTimePicker.TabIndex = 1;
            // 
            // t_amountTextBox
            // 
            this.t_amountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t_amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_transBindingSource, "t_amount", true));
            this.t_amountTextBox.Location = new System.Drawing.Point(525, 45);
            this.t_amountTextBox.Name = "t_amountTextBox";
            this.t_amountTextBox.Size = new System.Drawing.Size(139, 13);
            this.t_amountTextBox.TabIndex = 2;
            // 
            // name_address_1TextBox
            // 
            this.name_address_1TextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name_address_1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_address_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "name_address_1", true));
            this.name_address_1TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.name_address_1TextBox.Location = new System.Drawing.Point(236, 12);
            this.name_address_1TextBox.Name = "name_address_1TextBox";
            this.name_address_1TextBox.ReadOnly = true;
            this.name_address_1TextBox.Size = new System.Drawing.Size(526, 13);
            this.name_address_1TextBox.TabIndex = 21;
            this.name_address_1TextBox.TabStop = false;
            // 
            // cust_idTextBox
            // 
            this.cust_idTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cust_idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cust_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "cust_id", true));
            this.cust_idTextBox.Location = new System.Drawing.Point(98, 12);
            this.cust_idTextBox.Name = "cust_idTextBox";
            this.cust_idTextBox.ReadOnly = true;
            this.cust_idTextBox.Size = new System.Drawing.Size(112, 13);
            this.cust_idTextBox.TabIndex = 23;
            this.cust_idTextBox.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(550, 99);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 34);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // sqLiteConnection1
            // 
            this.sqLiteConnection1.ConnectionString = "Data Source=\"C:\\Documents and Settings\\All Users\\Application Data\\Vectra\\Data\\PRO" +
                "D.db3\";";
            this.sqLiteConnection1.Name = "sqLiteConnection1";
            this.sqLiteConnection1.Owner = this;
            // 
            // iNVOICE_RECIEPTSDataGridView
            // 
            this.iNVOICE_RECIEPTSDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            this.iNVOICE_RECIEPTSDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.iNVOICE_RECIEPTSDataGridView.AutoGenerateColumns = false;
            this.iNVOICE_RECIEPTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iNVOICE_RECIEPTSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn10,
            this.invoice_key});
            this.iNVOICE_RECIEPTSDataGridView.DataSource = this.iNVOICE_RECIEPTSBindingSource;
            this.iNVOICE_RECIEPTSDataGridView.Location = new System.Drawing.Point(15, 99);
            this.iNVOICE_RECIEPTSDataGridView.Name = "iNVOICE_RECIEPTSDataGridView";
            this.iNVOICE_RECIEPTSDataGridView.RowHeadersVisible = false;
            this.iNVOICE_RECIEPTSDataGridView.Size = new System.Drawing.Size(465, 151);
            this.iNVOICE_RECIEPTSDataGridView.TabIndex = 28;
            // 
            // iNVOICE_RECIEPTSBindingSource
            // 
            this.iNVOICE_RECIEPTSBindingSource.DataMember = "INVOICE_RECIEPTS";
            this.iNVOICE_RECIEPTSBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.dataSet2;
            // 
            // customer_transBindingSource
            // 
            this.customer_transBindingSource.DataMember = "customer_trans";
            this.customer_transBindingSource.DataSource = this.dataSet2;
            // 
            // iNVOICE_HEADERBindingSource
            // 
            this.iNVOICE_HEADERBindingSource.DataMember = "INVOICE_HEADER";
            this.iNVOICE_HEADERBindingSource.DataSource = this.dataSet2;
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
            this.tableAdapterManager.INVOICE_HEADERTableAdapter = this.iNVOICE_HEADERTableAdapter;
            this.tableAdapterManager.invoice_itemsTableAdapter = null;
            this.tableAdapterManager.INVOICE_RECIEPTSTableAdapter = this.iNVOICE_RECIEPTSTableAdapter;
            this.tableAdapterManager.payment_typeTableAdapter = null;
            this.tableAdapterManager.PaymentAdjustRptTableAdapter = null;
            this.tableAdapterManager.product_typeTableAdapter = null;
            this.tableAdapterManager.ProductSalesReportTableAdapter = null;
            this.tableAdapterManager.ProductSalesSummaryTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.sqlite_sequenceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Vectra.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // iNVOICE_HEADERTableAdapter
            // 
            this.iNVOICE_HEADERTableAdapter.ClearBeforeFill = true;
            // 
            // iNVOICE_RECIEPTSTableAdapter
            // 
            this.iNVOICE_RECIEPTSTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "recpt_number";
            this.dataGridViewTextBoxColumn9.HeaderText = "Receipt No";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "invoice_number";
            this.dataGridViewTextBoxColumn12.HeaderText = "Invoice No.";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "recpt_date";
            this.dataGridViewTextBoxColumn11.HeaderText = "Date";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn10.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // invoice_key
            // 
            this.invoice_key.DataPropertyName = "invoice_key";
            this.invoice_key.HeaderText = "invoice_key";
            this.invoice_key.Name = "invoice_key";
            this.invoice_key.Visible = false;
            // 
            // ReceiptEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(766, 263);
            this.Controls.Add(this.iNVOICE_RECIEPTSDataGridView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cust_idTextBox);
            this.Controls.Add(name_address_1Label);
            this.Controls.Add(this.name_address_1TextBox);
            this.Controls.Add(t_idLabel);
            this.Controls.Add(this.t_idTextBox);
            this.Controls.Add(t_dateLabel);
            this.Controls.Add(this.t_dateDateTimePicker);
            this.Controls.Add(t_amountLabel);
            this.Controls.Add(this.t_amountTextBox);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "ReceiptEdit";
            this.Text = "Receipts";
            this.Load += new System.EventHandler(this.Receipts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_RECIEPTSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_RECIEPTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_transBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_HEADERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource customer_transBindingSource;
        private Vectra.DataSet2TableAdapters.customer_transTableAdapter customer_transTableAdapter;
        private Vectra.DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox t_idTextBox;
        private System.Windows.Forms.DateTimePicker t_dateDateTimePicker;
        private System.Windows.Forms.TextBox t_amountTextBox;
        private Vectra.DataSet2TableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.TextBox name_address_1TextBox;
        private System.Windows.Forms.TextBox cust_idTextBox;
        private Vectra.DataSet2TableAdapters.INVOICE_HEADERTableAdapter iNVOICE_HEADERTableAdapter;
        private System.Windows.Forms.BindingSource iNVOICE_HEADERBindingSource;
        private Vectra.DataSet2TableAdapters.INVOICE_RECIEPTSTableAdapter iNVOICE_RECIEPTSTableAdapter;
        private System.Windows.Forms.BindingSource iNVOICE_RECIEPTSBindingSource;
        private System.Windows.Forms.Button btnDelete;
        private Devart.Data.SQLite.SQLiteConnection sqLiteConnection1;
        private System.Windows.Forms.DataGridView iNVOICE_RECIEPTSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice_key;
    }
}