namespace Vectra
{
    partial class Receipts
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
            System.Windows.Forms.Label t_typeLabel;
            System.Windows.Forms.Label t_cust_idLabel;
            System.Windows.Forms.Label t_ref_idLabel;
            System.Windows.Forms.Label t_dateLabel;
            System.Windows.Forms.Label t_noteLabel;
            System.Windows.Forms.Label t_timestampLabel;
            System.Windows.Forms.Label t_amountLabel;
            System.Windows.Forms.Label t_src_idLabel;
            System.Windows.Forms.Label name_address_1Label;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.t_idTextBox = new System.Windows.Forms.TextBox();
            this.customer_transBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Vectra.DataSet2();
            this.t_typeTextBox = new System.Windows.Forms.TextBox();
            this.t_cust_idTextBox = new System.Windows.Forms.TextBox();
            this.t_ref_idTextBox = new System.Windows.Forms.TextBox();
            this.t_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.t_noteTextBox = new System.Windows.Forms.TextBox();
            this.t_timestampDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.t_amountTextBox = new System.Windows.Forms.TextBox();
            this.t_src_idTextBox = new System.Windows.Forms.TextBox();
            this.name_address_1TextBox = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cust_idTextBox = new System.Windows.Forms.TextBox();
            this.iNVOICE_HEADERDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unpaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recent_payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNVOICE_HEADERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNVOICE_RECIEPTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnApply = new System.Windows.Forms.Button();
            this.customer_transTableAdapter = new Vectra.DataSet2TableAdapters.customer_transTableAdapter();
            this.tableAdapterManager = new Vectra.DataSet2TableAdapters.TableAdapterManager();
            this.customerTableAdapter = new Vectra.DataSet2TableAdapters.customerTableAdapter();
            this.iNVOICE_HEADERTableAdapter = new Vectra.DataSet2TableAdapters.INVOICE_HEADERTableAdapter();
            this.iNVOICE_RECIEPTSTableAdapter = new Vectra.DataSet2TableAdapters.INVOICE_RECIEPTSTableAdapter();
            this.sqLiteConnection1 = new Devart.Data.SQLite.SQLiteConnection();
            this.ApplyReciepts = new System.Windows.Forms.Button();
            this.UnAllocatedAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubTotal = new System.Windows.Forms.Button();
            t_idLabel = new System.Windows.Forms.Label();
            t_typeLabel = new System.Windows.Forms.Label();
            t_cust_idLabel = new System.Windows.Forms.Label();
            t_ref_idLabel = new System.Windows.Forms.Label();
            t_dateLabel = new System.Windows.Forms.Label();
            t_noteLabel = new System.Windows.Forms.Label();
            t_timestampLabel = new System.Windows.Forms.Label();
            t_amountLabel = new System.Windows.Forms.Label();
            t_src_idLabel = new System.Windows.Forms.Label();
            name_address_1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customer_transBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_HEADERDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_HEADERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_RECIEPTSBindingSource)).BeginInit();
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
            // t_typeLabel
            // 
            t_typeLabel.AutoSize = true;
            t_typeLabel.Location = new System.Drawing.Point(11, 328);
            t_typeLabel.Name = "t_typeLabel";
            t_typeLabel.Size = new System.Drawing.Size(93, 13);
            t_typeLabel.TabIndex = 4;
            t_typeLabel.Text = "Transaction Type:";
            // 
            // t_cust_idLabel
            // 
            t_cust_idLabel.AutoSize = true;
            t_cust_idLabel.Location = new System.Drawing.Point(50, 354);
            t_cust_idLabel.Name = "t_cust_idLabel";
            t_cust_idLabel.Size = new System.Drawing.Size(54, 13);
            t_cust_idLabel.TabIndex = 6;
            t_cust_idLabel.Text = "Customer:";
            // 
            // t_ref_idLabel
            // 
            t_ref_idLabel.AutoSize = true;
            t_ref_idLabel.Location = new System.Drawing.Point(44, 380);
            t_ref_idLabel.Name = "t_ref_idLabel";
            t_ref_idLabel.Size = new System.Drawing.Size(60, 13);
            t_ref_idLabel.TabIndex = 8;
            t_ref_idLabel.Text = "Reference:";
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
            // t_noteLabel
            // 
            t_noteLabel.AutoSize = true;
            t_noteLabel.Location = new System.Drawing.Point(328, 328);
            t_noteLabel.Name = "t_noteLabel";
            t_noteLabel.Size = new System.Drawing.Size(33, 13);
            t_noteLabel.TabIndex = 12;
            t_noteLabel.Text = "Note:";
            // 
            // t_timestampLabel
            // 
            t_timestampLabel.AutoSize = true;
            t_timestampLabel.Location = new System.Drawing.Point(364, 310);
            t_timestampLabel.Name = "t_timestampLabel";
            t_timestampLabel.Size = new System.Drawing.Size(27, 13);
            t_timestampLabel.TabIndex = 14;
            t_timestampLabel.Text = "Dud";
            t_timestampLabel.Visible = false;
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
            // t_src_idLabel
            // 
            t_src_idLabel.AutoSize = true;
            t_src_idLabel.Location = new System.Drawing.Point(212, 496);
            t_src_idLabel.Name = "t_src_idLabel";
            t_src_idLabel.Size = new System.Drawing.Size(41, 13);
            t_src_idLabel.TabIndex = 18;
            t_src_idLabel.Text = "t src id:";
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
            this.t_idTextBox.Leave += new System.EventHandler(this.t_idTextBox_Leave);
            // 
            // customer_transBindingSource
            // 
            this.customer_transBindingSource.DataMember = "customer_trans";
            this.customer_transBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_typeTextBox
            // 
            this.t_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_transBindingSource, "t_type", true));
            this.t_typeTextBox.Location = new System.Drawing.Point(110, 324);
            this.t_typeTextBox.Name = "t_typeTextBox";
            this.t_typeTextBox.Size = new System.Drawing.Size(200, 20);
            this.t_typeTextBox.TabIndex = 5;
            // 
            // t_cust_idTextBox
            // 
            this.t_cust_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_transBindingSource, "t_cust_id", true));
            this.t_cust_idTextBox.Location = new System.Drawing.Point(110, 351);
            this.t_cust_idTextBox.Name = "t_cust_idTextBox";
            this.t_cust_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.t_cust_idTextBox.TabIndex = 6;
            // 
            // t_ref_idTextBox
            // 
            this.t_ref_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_transBindingSource, "t_ref_id", true));
            this.t_ref_idTextBox.Location = new System.Drawing.Point(110, 377);
            this.t_ref_idTextBox.Name = "t_ref_idTextBox";
            this.t_ref_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.t_ref_idTextBox.TabIndex = 7;
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
            // t_noteTextBox
            // 
            this.t_noteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_transBindingSource, "t_note", true));
            this.t_noteTextBox.Location = new System.Drawing.Point(397, 324);
            this.t_noteTextBox.Multiline = true;
            this.t_noteTextBox.Name = "t_noteTextBox";
            this.t_noteTextBox.Size = new System.Drawing.Size(200, 73);
            this.t_noteTextBox.TabIndex = 8;
            this.t_noteTextBox.Leave += new System.EventHandler(this.t_noteTextBox_Leave);
            // 
            // t_timestampDateTimePicker
            // 
            this.t_timestampDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_transBindingSource, "t_timestamp", true));
            this.t_timestampDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customer_transBindingSource, "t_timestamp", true));
            this.t_timestampDateTimePicker.Enabled = false;
            this.t_timestampDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.t_timestampDateTimePicker.Location = new System.Drawing.Point(397, 305);
            this.t_timestampDateTimePicker.Name = "t_timestampDateTimePicker";
            this.t_timestampDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.t_timestampDateTimePicker.TabIndex = 15;
            this.t_timestampDateTimePicker.Visible = false;
            // 
            // t_amountTextBox
            // 
            this.t_amountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t_amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_transBindingSource, "t_amount", true));
            this.t_amountTextBox.Location = new System.Drawing.Point(525, 45);
            this.t_amountTextBox.Name = "t_amountTextBox";
            this.t_amountTextBox.Size = new System.Drawing.Size(139, 13);
            this.t_amountTextBox.TabIndex = 2;
            this.t_amountTextBox.Leave += new System.EventHandler(this.t_amountTextBox_Leave);
            // 
            // t_src_idTextBox
            // 
            this.t_src_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_transBindingSource, "t_src_id", true));
            this.t_src_idTextBox.Location = new System.Drawing.Point(281, 493);
            this.t_src_idTextBox.Name = "t_src_idTextBox";
            this.t_src_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.t_src_idTextBox.TabIndex = 19;
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
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.dataSet2;
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
            // iNVOICE_HEADERDataGridView
            // 
            this.iNVOICE_HEADERDataGridView.AutoGenerateColumns = false;
            this.iNVOICE_HEADERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iNVOICE_HEADERDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.unpaid,
            this.recent_payment});
            this.iNVOICE_HEADERDataGridView.DataSource = this.iNVOICE_HEADERBindingSource;
            this.iNVOICE_HEADERDataGridView.Location = new System.Drawing.Point(9, 79);
            this.iNVOICE_HEADERDataGridView.Name = "iNVOICE_HEADERDataGridView";
            this.iNVOICE_HEADERDataGridView.RowHeadersVisible = false;
            this.iNVOICE_HEADERDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.iNVOICE_HEADERDataGridView.Size = new System.Drawing.Size(906, 220);
            this.iNVOICE_HEADERDataGridView.TabIndex = 4;
            this.iNVOICE_HEADERDataGridView.TabStop = false;
            this.iNVOICE_HEADERDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.iNVOICE_HEADERDataGridView_CellClick);
            this.iNVOICE_HEADERDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.iNVOICE_HEADERDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "invoice_number";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "Invoice Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "invoice_date";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Invoice Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cust_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Customer";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "docket_number";
            this.dataGridViewTextBoxColumn4.HeaderText = "Docket Number";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "notes";
            this.dataGridViewTextBoxColumn5.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "text_fully_paid";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fully Paid";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "invoice_amount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn7.HeaderText = "Invoice Amount";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // unpaid
            // 
            this.unpaid.DataPropertyName = "invoice_unpaid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.unpaid.DefaultCellStyle = dataGridViewCellStyle4;
            this.unpaid.HeaderText = "Invoice Unpaid";
            this.unpaid.Name = "unpaid";
            this.unpaid.ReadOnly = true;
            // 
            // recent_payment
            // 
            this.recent_payment.DataPropertyName = "recent_payment";
            this.recent_payment.HeaderText = "Allocation";
            this.recent_payment.Name = "recent_payment";
            // 
            // iNVOICE_HEADERBindingSource
            // 
            this.iNVOICE_HEADERBindingSource.DataMember = "INVOICE_HEADER";
            this.iNVOICE_HEADERBindingSource.DataSource = this.dataSet2;
            // 
            // iNVOICE_RECIEPTSBindingSource
            // 
            this.iNVOICE_RECIEPTSBindingSource.DataMember = "INVOICE_RECIEPTS";
            this.iNVOICE_RECIEPTSBindingSource.DataSource = this.dataSet2;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(687, 40);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Auto Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
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
            this.tableAdapterManager.SalesSummary1TableAdapter = null;
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
            // sqLiteConnection1
            // 
            this.sqLiteConnection1.ConnectionString = "Data Source=\"C:\\Documents and Settings\\All Users\\Application Data\\Vectra\\Data\\PRO" +
    "D.db3\";";
            this.sqLiteConnection1.Name = "sqLiteConnection1";
            this.sqLiteConnection1.Owner = this;
            // 
            // ApplyReciepts
            // 
            this.ApplyReciepts.Location = new System.Drawing.Point(840, 41);
            this.ApplyReciepts.Name = "ApplyReciepts";
            this.ApplyReciepts.Size = new System.Drawing.Size(75, 23);
            this.ApplyReciepts.TabIndex = 24;
            this.ApplyReciepts.Text = "Apply";
            this.ApplyReciepts.UseVisualStyleBackColor = true;
            this.ApplyReciepts.Click += new System.EventHandler(this.button1_Click);
            // 
            // UnAllocatedAmount
            // 
            this.UnAllocatedAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnAllocatedAmount.ForeColor = System.Drawing.Color.Red;
            this.UnAllocatedAmount.Location = new System.Drawing.Point(815, 357);
            this.UnAllocatedAmount.Name = "UnAllocatedAmount";
            this.UnAllocatedAmount.Size = new System.Drawing.Size(100, 13);
            this.UnAllocatedAmount.TabIndex = 25;
            this.UnAllocatedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(692, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Remaining Unallocated: ";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(815, 380);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 23);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset Allocation";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSubTotal
            // 
            this.btnSubTotal.Location = new System.Drawing.Point(840, 318);
            this.btnSubTotal.Name = "btnSubTotal";
            this.btnSubTotal.Size = new System.Drawing.Size(75, 23);
            this.btnSubTotal.TabIndex = 28;
            this.btnSubTotal.Text = "Sub Total";
            this.btnSubTotal.UseVisualStyleBackColor = true;
            this.btnSubTotal.Click += new System.EventHandler(this.btnSubTotal_Click);
            // 
            // Receipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(920, 424);
            this.Controls.Add(this.btnSubTotal);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnAllocatedAmount);
            this.Controls.Add(this.ApplyReciepts);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.iNVOICE_HEADERDataGridView);
            this.Controls.Add(this.cust_idTextBox);
            this.Controls.Add(name_address_1Label);
            this.Controls.Add(this.name_address_1TextBox);
            this.Controls.Add(t_idLabel);
            this.Controls.Add(this.t_idTextBox);
            this.Controls.Add(t_typeLabel);
            this.Controls.Add(this.t_typeTextBox);
            this.Controls.Add(t_cust_idLabel);
            this.Controls.Add(this.t_cust_idTextBox);
            this.Controls.Add(t_ref_idLabel);
            this.Controls.Add(this.t_ref_idTextBox);
            this.Controls.Add(t_dateLabel);
            this.Controls.Add(this.t_dateDateTimePicker);
            this.Controls.Add(t_noteLabel);
            this.Controls.Add(this.t_noteTextBox);
            this.Controls.Add(t_timestampLabel);
            this.Controls.Add(this.t_timestampDateTimePicker);
            this.Controls.Add(t_amountLabel);
            this.Controls.Add(this.t_amountTextBox);
            this.Controls.Add(t_src_idLabel);
            this.Controls.Add(this.t_src_idTextBox);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Receipts";
            this.Text = "Receipts";
            this.Load += new System.EventHandler(this.Receipts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customer_transBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_HEADERDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_HEADERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_RECIEPTSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource customer_transBindingSource;
        private Vectra.DataSet2TableAdapters.customer_transTableAdapter customer_transTableAdapter;
        private Vectra.DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox t_idTextBox;
        private System.Windows.Forms.TextBox t_typeTextBox;
        private System.Windows.Forms.TextBox t_cust_idTextBox;
        private System.Windows.Forms.TextBox t_ref_idTextBox;
        private System.Windows.Forms.DateTimePicker t_dateDateTimePicker;
        private System.Windows.Forms.TextBox t_noteTextBox;
        private System.Windows.Forms.DateTimePicker t_timestampDateTimePicker;
        private System.Windows.Forms.TextBox t_amountTextBox;
        private System.Windows.Forms.TextBox t_src_idTextBox;
        private Vectra.DataSet2TableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.TextBox name_address_1TextBox;
        private System.Windows.Forms.TextBox cust_idTextBox;
        private Vectra.DataSet2TableAdapters.INVOICE_HEADERTableAdapter iNVOICE_HEADERTableAdapter;
        private System.Windows.Forms.BindingSource iNVOICE_HEADERBindingSource;
        private System.Windows.Forms.DataGridView iNVOICE_HEADERDataGridView;
        private Vectra.DataSet2TableAdapters.INVOICE_RECIEPTSTableAdapter iNVOICE_RECIEPTSTableAdapter;
        private System.Windows.Forms.BindingSource iNVOICE_RECIEPTSBindingSource;
        private System.Windows.Forms.Button btnApply;
        private Devart.Data.SQLite.SQLiteConnection sqLiteConnection1;
        private System.Windows.Forms.Button ApplyReciepts;
        private System.Windows.Forms.TextBox UnAllocatedAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn unpaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn recent_payment;
    }
}