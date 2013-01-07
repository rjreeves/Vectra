namespace Vectra
{
    partial class CustomerInterface
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
            System.Windows.Forms.Label open_balLabel;
            System.Windows.Forms.Label curAmtLabel;
            System.Windows.Forms.Label days7Label;
            System.Windows.Forms.Label days14Label;
            System.Windows.Forms.Label days21Label;
            System.Windows.Forms.Label date_last_paymentLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInterface));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTrans = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcustidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_unpaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_src_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_src_dckt_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trefidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_transBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Vectra.DataSet2();
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalDue = new System.Windows.Forms.TextBox();
            this.t_amountTextBox = new System.Windows.Forms.TextBox();
            this.curAmtTextBox = new System.Windows.Forms.TextBox();
            this.debtors_summaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.days7TextBox = new System.Windows.Forms.TextBox();
            this.days14TextBox = new System.Windows.Forms.TextBox();
            this.days21TextBox = new System.Windows.Forms.TextBox();
            this.date_last_paymentTextBox = new System.Windows.Forms.TextBox();
            this.open_balTextBox = new System.Windows.Forms.TextBox();
            this.iNVOICE_HEADERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.custidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameaddress1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameaddress4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.open_bal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.searchValue = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnInvoicing = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReceipt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdjustment = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.iNVOICE_RECIEPTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Vectra.DataSet2TableAdapters.customerTableAdapter();
            this.tableAdapterManager = new Vectra.DataSet2TableAdapters.TableAdapterManager();
            this.customer_transTableAdapter = new Vectra.DataSet2TableAdapters.customer_transTableAdapter();
            this.debtors_summaryTableAdapter = new Vectra.DataSet2TableAdapters.debtors_summaryTableAdapter();
            this.iNVOICE_HEADERTableAdapter = new Vectra.DataSet2TableAdapters.INVOICE_HEADERTableAdapter();
            this.iNVOICE_RECIEPTSTableAdapter = new Vectra.DataSet2TableAdapters.INVOICE_RECIEPTSTableAdapter();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            open_balLabel = new System.Windows.Forms.Label();
            curAmtLabel = new System.Windows.Forms.Label();
            days7Label = new System.Windows.Forms.Label();
            days14Label = new System.Windows.Forms.Label();
            days21Label = new System.Windows.Forms.Label();
            date_last_paymentLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabTrans.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_transBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.tabSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtors_summaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_HEADERBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_RECIEPTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // open_balLabel
            // 
            open_balLabel.AutoSize = true;
            open_balLabel.Location = new System.Drawing.Point(16, 175);
            open_balLabel.Name = "open_balLabel";
            open_balLabel.Size = new System.Drawing.Size(116, 13);
            open_balLabel.TabIndex = 0;
            open_balLabel.Text = "Unallocated Payments:";
            // 
            // curAmtLabel
            // 
            curAmtLabel.AutoSize = true;
            curAmtLabel.Location = new System.Drawing.Point(67, 47);
            curAmtLabel.Name = "curAmtLabel";
            curAmtLabel.Size = new System.Drawing.Size(65, 13);
            curAmtLabel.TabIndex = 4;
            curAmtLabel.Text = "Current Amt:";
            // 
            // days7Label
            // 
            days7Label.AutoSize = true;
            days7Label.Location = new System.Drawing.Point(89, 79);
            days7Label.Name = "days7Label";
            days7Label.Size = new System.Drawing.Size(43, 13);
            days7Label.TabIndex = 6;
            days7Label.Text = "7 Days:";
            // 
            // days14Label
            // 
            days14Label.AutoSize = true;
            days14Label.Location = new System.Drawing.Point(83, 111);
            days14Label.Name = "days14Label";
            days14Label.Size = new System.Drawing.Size(49, 13);
            days14Label.TabIndex = 8;
            days14Label.Text = "14 Days:";
            // 
            // days21Label
            // 
            days21Label.AutoSize = true;
            days21Label.Location = new System.Drawing.Point(83, 143);
            days21Label.Name = "days21Label";
            days21Label.Size = new System.Drawing.Size(49, 13);
            days21Label.TabIndex = 10;
            days21Label.Text = "21 Days:";
            // 
            // date_last_paymentLabel
            // 
            date_last_paymentLabel.AutoSize = true;
            date_last_paymentLabel.Location = new System.Drawing.Point(58, 207);
            date_last_paymentLabel.Name = "date_last_paymentLabel";
            date_last_paymentLabel.Size = new System.Drawing.Size(74, 13);
            date_last_paymentLabel.TabIndex = 12;
            date_last_paymentLabel.Text = "Last Payment:";
            date_last_paymentLabel.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTrans);
            this.tabControl1.Controls.Add(this.tabSummary);
            this.tabControl1.Location = new System.Drawing.Point(0, 255);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(853, 273);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabTrans
            // 
            this.tabTrans.Controls.Add(this.splitContainer1);
            this.tabTrans.Location = new System.Drawing.Point(4, 22);
            this.tabTrans.Name = "tabTrans";
            this.tabTrans.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrans.Size = new System.Drawing.Size(845, 247);
            this.tabTrans.TabIndex = 0;
            this.tabTrans.Text = "Transactions";
            this.tabTrans.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Size = new System.Drawing.Size(839, 241);
            this.splitContainer1.SplitterDistance = 29;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tidDataGridViewTextBoxColumn,
            this.tcustidDataGridViewTextBoxColumn,
            this.ttypeDataGridViewTextBoxColumn,
            this.tdateDataGridViewTextBoxColumn,
            this.tamountDataGridViewTextBoxColumn,
            this.t_unpaid,
            this.t_src_id,
            this.t_src_dckt_id,
            this.trefidDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.customer_transBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(839, 208);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.TabStop = false;
            this.dataGridView2.DoubleClick += new System.EventHandler(this.dataGridView2_DoubleClick);
            // 
            // tidDataGridViewTextBoxColumn
            // 
            this.tidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tidDataGridViewTextBoxColumn.DataPropertyName = "t_id";
            this.tidDataGridViewTextBoxColumn.HeaderText = "Trans Id";
            this.tidDataGridViewTextBoxColumn.Name = "tidDataGridViewTextBoxColumn";
            this.tidDataGridViewTextBoxColumn.ReadOnly = true;
            this.tidDataGridViewTextBoxColumn.Width = 66;
            // 
            // tcustidDataGridViewTextBoxColumn
            // 
            this.tcustidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tcustidDataGridViewTextBoxColumn.DataPropertyName = "t_cust_id";
            this.tcustidDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.tcustidDataGridViewTextBoxColumn.Name = "tcustidDataGridViewTextBoxColumn";
            this.tcustidDataGridViewTextBoxColumn.ReadOnly = true;
            this.tcustidDataGridViewTextBoxColumn.Width = 76;
            // 
            // ttypeDataGridViewTextBoxColumn
            // 
            this.ttypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ttypeDataGridViewTextBoxColumn.DataPropertyName = "t_type";
            this.ttypeDataGridViewTextBoxColumn.HeaderText = "Transaction Type";
            this.ttypeDataGridViewTextBoxColumn.Name = "ttypeDataGridViewTextBoxColumn";
            this.ttypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.ttypeDataGridViewTextBoxColumn.Width = 106;
            // 
            // tdateDataGridViewTextBoxColumn
            // 
            this.tdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tdateDataGridViewTextBoxColumn.DataPropertyName = "t_date";
            this.tdateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.tdateDataGridViewTextBoxColumn.Name = "tdateDataGridViewTextBoxColumn";
            this.tdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.tdateDataGridViewTextBoxColumn.Width = 55;
            // 
            // tamountDataGridViewTextBoxColumn
            // 
            this.tamountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tamountDataGridViewTextBoxColumn.DataPropertyName = "t_amount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0.0";
            this.tamountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.tamountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.tamountDataGridViewTextBoxColumn.Name = "tamountDataGridViewTextBoxColumn";
            this.tamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.tamountDataGridViewTextBoxColumn.Width = 68;
            // 
            // t_unpaid
            // 
            this.t_unpaid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.t_unpaid.DataPropertyName = "t_unpaid";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.t_unpaid.DefaultCellStyle = dataGridViewCellStyle2;
            this.t_unpaid.HeaderText = "Unpaid";
            this.t_unpaid.Name = "t_unpaid";
            this.t_unpaid.ReadOnly = true;
            this.t_unpaid.Width = 66;
            // 
            // t_src_id
            // 
            this.t_src_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.t_src_id.DataPropertyName = "t_src_id";
            this.t_src_id.HeaderText = "Invoice Id";
            this.t_src_id.Name = "t_src_id";
            this.t_src_id.ReadOnly = true;
            this.t_src_id.Width = 73;
            // 
            // t_src_dckt_id
            // 
            this.t_src_dckt_id.DataPropertyName = "t_src_dckt_id";
            this.t_src_dckt_id.HeaderText = "Docket No.";
            this.t_src_dckt_id.Name = "t_src_dckt_id";
            this.t_src_dckt_id.ReadOnly = true;
            // 
            // trefidDataGridViewTextBoxColumn
            // 
            this.trefidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trefidDataGridViewTextBoxColumn.DataPropertyName = "t_ref_id";
            this.trefidDataGridViewTextBoxColumn.HeaderText = "Payment/Adj Id";
            this.trefidDataGridViewTextBoxColumn.Name = "trefidDataGridViewTextBoxColumn";
            this.trefidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customer_transBindingSource
            // 
            this.customer_transBindingSource.DataMember = "customer_trans_customer";
            this.customer_transBindingSource.DataSource = this.customerBindingSource;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabSummary
            // 
            this.tabSummary.Controls.Add(this.label1);
            this.tabSummary.Controls.Add(this.TotalDue);
            this.tabSummary.Controls.Add(this.t_amountTextBox);
            this.tabSummary.Controls.Add(curAmtLabel);
            this.tabSummary.Controls.Add(this.curAmtTextBox);
            this.tabSummary.Controls.Add(days7Label);
            this.tabSummary.Controls.Add(this.days7TextBox);
            this.tabSummary.Controls.Add(days14Label);
            this.tabSummary.Controls.Add(this.days14TextBox);
            this.tabSummary.Controls.Add(days21Label);
            this.tabSummary.Controls.Add(this.days21TextBox);
            this.tabSummary.Controls.Add(date_last_paymentLabel);
            this.tabSummary.Controls.Add(this.date_last_paymentTextBox);
            this.tabSummary.Controls.Add(open_balLabel);
            this.tabSummary.Controls.Add(this.open_balTextBox);
            this.tabSummary.Location = new System.Drawing.Point(4, 22);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSummary.Size = new System.Drawing.Size(845, 247);
            this.tabSummary.TabIndex = 1;
            this.tabSummary.Text = "Summary";
            this.tabSummary.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Due:";
            // 
            // TotalDue
            // 
            this.TotalDue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalDue.Location = new System.Drawing.Point(138, 15);
            this.TotalDue.Name = "TotalDue";
            this.TotalDue.ReadOnly = true;
            this.TotalDue.Size = new System.Drawing.Size(100, 20);
            this.TotalDue.TabIndex = 16;
            this.TotalDue.TabStop = false;
            this.TotalDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // t_amountTextBox
            // 
            this.t_amountTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.t_amountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_transBindingSource, "t_amount", true));
            this.t_amountTextBox.Location = new System.Drawing.Point(138, 207);
            this.t_amountTextBox.Name = "t_amountTextBox";
            this.t_amountTextBox.ReadOnly = true;
            this.t_amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.t_amountTextBox.TabIndex = 15;
            this.t_amountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t_amountTextBox.Visible = false;
            // 
            // curAmtTextBox
            // 
            this.curAmtTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.curAmtTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.curAmtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtors_summaryBindingSource, "curAmt", true));
            this.curAmtTextBox.Location = new System.Drawing.Point(138, 47);
            this.curAmtTextBox.Name = "curAmtTextBox";
            this.curAmtTextBox.ReadOnly = true;
            this.curAmtTextBox.Size = new System.Drawing.Size(100, 20);
            this.curAmtTextBox.TabIndex = 5;
            this.curAmtTextBox.TabStop = false;
            this.curAmtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // debtors_summaryBindingSource
            // 
            this.debtors_summaryBindingSource.DataMember = "debtors_summary";
            this.debtors_summaryBindingSource.DataSource = this.dataSet2;
            // 
            // days7TextBox
            // 
            this.days7TextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.days7TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.days7TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtors_summaryBindingSource, "days7", true));
            this.days7TextBox.Location = new System.Drawing.Point(138, 79);
            this.days7TextBox.Name = "days7TextBox";
            this.days7TextBox.ReadOnly = true;
            this.days7TextBox.Size = new System.Drawing.Size(100, 20);
            this.days7TextBox.TabIndex = 7;
            this.days7TextBox.TabStop = false;
            this.days7TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // days14TextBox
            // 
            this.days14TextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.days14TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.days14TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtors_summaryBindingSource, "days14", true));
            this.days14TextBox.Location = new System.Drawing.Point(138, 111);
            this.days14TextBox.Name = "days14TextBox";
            this.days14TextBox.ReadOnly = true;
            this.days14TextBox.Size = new System.Drawing.Size(100, 20);
            this.days14TextBox.TabIndex = 9;
            this.days14TextBox.TabStop = false;
            this.days14TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // days21TextBox
            // 
            this.days21TextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.days21TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.days21TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtors_summaryBindingSource, "days21", true));
            this.days21TextBox.Location = new System.Drawing.Point(138, 143);
            this.days21TextBox.Name = "days21TextBox";
            this.days21TextBox.ReadOnly = true;
            this.days21TextBox.Size = new System.Drawing.Size(100, 20);
            this.days21TextBox.TabIndex = 11;
            this.days21TextBox.TabStop = false;
            this.days21TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // date_last_paymentTextBox
            // 
            this.date_last_paymentTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.date_last_paymentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.date_last_paymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtors_summaryBindingSource, "date_last_payment", true));
            this.date_last_paymentTextBox.Location = new System.Drawing.Point(244, 207);
            this.date_last_paymentTextBox.Name = "date_last_paymentTextBox";
            this.date_last_paymentTextBox.ReadOnly = true;
            this.date_last_paymentTextBox.Size = new System.Drawing.Size(100, 20);
            this.date_last_paymentTextBox.TabIndex = 13;
            this.date_last_paymentTextBox.Visible = false;
            // 
            // open_balTextBox
            // 
            this.open_balTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.open_balTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.open_balTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "open_bal", true));
            this.open_balTextBox.Location = new System.Drawing.Point(138, 175);
            this.open_balTextBox.Name = "open_balTextBox";
            this.open_balTextBox.ReadOnly = true;
            this.open_balTextBox.Size = new System.Drawing.Size(100, 20);
            this.open_balTextBox.TabIndex = 1;
            this.open_balTextBox.TabStop = false;
            this.open_balTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // iNVOICE_HEADERBindingSource
            // 
            this.iNVOICE_HEADERBindingSource.DataMember = "INVOICE_HEADER";
            this.iNVOICE_HEADERBindingSource.DataSource = this.dataSet2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customerDataGridView);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 200);
            this.panel1.TabIndex = 1;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custidDataGridViewTextBoxColumn,
            this.nameaddress1DataGridViewTextBoxColumn,
            this.nameaddress4DataGridViewTextBoxColumn,
            this.pcodeDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.open_bal,
            this.contactnameDataGridViewTextBoxColumn});
            this.customerDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.customerDataGridView.DataSource = this.customerBindingSource;
            this.customerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerDataGridView.Location = new System.Drawing.Point(0, 0);
            this.customerDataGridView.MultiSelect = false;
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RowHeadersVisible = false;
            this.customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGridView.Size = new System.Drawing.Size(849, 200);
            this.customerDataGridView.TabIndex = 0;
            this.customerDataGridView.Sorted += new System.EventHandler(this.customerDataGridView_Sorted);
            this.customerDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellContentClick);
            this.customerDataGridView.Click += new System.EventHandler(this.customerDataGridView_Click);
            // 
            // custidDataGridViewTextBoxColumn
            // 
            this.custidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.custidDataGridViewTextBoxColumn.DataPropertyName = "cust_id";
            this.custidDataGridViewTextBoxColumn.HeaderText = "Customer Id";
            this.custidDataGridViewTextBoxColumn.Name = "custidDataGridViewTextBoxColumn";
            this.custidDataGridViewTextBoxColumn.ReadOnly = true;
            this.custidDataGridViewTextBoxColumn.Width = 81;
            // 
            // nameaddress1DataGridViewTextBoxColumn
            // 
            this.nameaddress1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameaddress1DataGridViewTextBoxColumn.DataPropertyName = "name_address_1";
            this.nameaddress1DataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameaddress1DataGridViewTextBoxColumn.Name = "nameaddress1DataGridViewTextBoxColumn";
            this.nameaddress1DataGridViewTextBoxColumn.ReadOnly = true;
            this.nameaddress1DataGridViewTextBoxColumn.Width = 60;
            // 
            // nameaddress4DataGridViewTextBoxColumn
            // 
            this.nameaddress4DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameaddress4DataGridViewTextBoxColumn.DataPropertyName = "name_address_4";
            this.nameaddress4DataGridViewTextBoxColumn.HeaderText = "Address (4)";
            this.nameaddress4DataGridViewTextBoxColumn.Name = "nameaddress4DataGridViewTextBoxColumn";
            this.nameaddress4DataGridViewTextBoxColumn.ReadOnly = true;
            this.nameaddress4DataGridViewTextBoxColumn.Width = 79;
            // 
            // pcodeDataGridViewTextBoxColumn
            // 
            this.pcodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pcodeDataGridViewTextBoxColumn.DataPropertyName = "pcode";
            this.pcodeDataGridViewTextBoxColumn.HeaderText = "Postcode";
            this.pcodeDataGridViewTextBoxColumn.Name = "pcodeDataGridViewTextBoxColumn";
            this.pcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.pcodeDataGridViewTextBoxColumn.Width = 77;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 63;
            // 
            // open_bal
            // 
            this.open_bal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.open_bal.DataPropertyName = "open_bal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.open_bal.DefaultCellStyle = dataGridViewCellStyle3;
            this.open_bal.HeaderText = "Unallocated Bal";
            this.open_bal.Name = "open_bal";
            this.open_bal.ReadOnly = true;
            this.open_bal.Width = 98;
            // 
            // contactnameDataGridViewTextBoxColumn
            // 
            this.contactnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contactnameDataGridViewTextBoxColumn.DataPropertyName = "contact_name";
            this.contactnameDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactnameDataGridViewTextBoxColumn.Name = "contactnameDataGridViewTextBoxColumn";
            this.contactnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 48);
            this.contextMenuStrip1.Text = "Edit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchValue,
            this.toolStripSeparator5,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.btnInvoicing,
            this.toolStripSeparator3,
            this.btnReceipt,
            this.toolStripSeparator4,
            this.btnAdjustment,
            this.toolStripSeparator1,
            this.btnDelete,
            this.toolStripSeparator6,
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(873, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.TabStop = true;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // searchValue
            // 
            this.searchValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchValue.Name = "searchValue";
            this.searchValue.Size = new System.Drawing.Size(150, 25);
            this.searchValue.TextChanged += new System.EventHandler(this.searchValue_TextChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(81, 22);
            this.toolStripButton2.Text = "New Customer";
            this.toolStripButton2.Click += new System.EventHandler(this.AddNewCustomer);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnInvoicing
            // 
            this.btnInvoicing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInvoicing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInvoicing.Name = "btnInvoicing";
            this.btnInvoicing.Size = new System.Drawing.Size(77, 22);
            this.btnInvoicing.Text = "Invoicing (F5)";
            this.btnInvoicing.Click += new System.EventHandler(this.btnInvoicing_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnReceipt
            // 
            this.btnReceipt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnReceipt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(70, 22);
            this.btnReceipt.Text = "Receipt (F6)";
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAdjustment
            // 
            this.btnAdjustment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAdjustment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdjustment.Name = "btnAdjustment";
            this.btnAdjustment.Size = new System.Drawing.Size(94, 22);
            this.btnAdjustment.Text = "Adjustments (F7)";
            this.btnAdjustment.Click += new System.EventHandler(this.btnAdjustment_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 22);
            this.btnDelete.Text = "Delete Customer";
            this.btnDelete.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // iNVOICE_RECIEPTSBindingSource
            // 
            this.iNVOICE_RECIEPTSBindingSource.DataMember = "INVOICE_RECIEPTS";
            this.iNVOICE_RECIEPTSBindingSource.DataSource = this.dataSet2;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.configurationTableAdapter = null;
            this.tableAdapterManager.customer_transTableAdapter = this.customer_transTableAdapter;
            this.tableAdapterManager.customerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.debtors_summaryTableAdapter = this.debtors_summaryTableAdapter;
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
            // customer_transTableAdapter
            // 
            this.customer_transTableAdapter.ClearBeforeFill = true;
            // 
            // debtors_summaryTableAdapter
            // 
            this.debtors_summaryTableAdapter.ClearBeforeFill = true;
            // 
            // iNVOICE_HEADERTableAdapter
            // 
            this.iNVOICE_HEADERTableAdapter.ClearBeforeFill = true;
            // 
            // iNVOICE_RECIEPTSTableAdapter
            // 
            this.iNVOICE_RECIEPTSTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(91, 22);
            this.toolStripButton1.Text = "Current Invoices";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // CustomerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 548);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "CustomerInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.CustomerInterface_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerInterface_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabTrans.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_transBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.tabSummary.ResumeLayout(false);
            this.tabSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtors_summaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_HEADERBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_RECIEPTSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTrans;
        private System.Windows.Forms.Panel panel1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Vectra.DataSet2TableAdapters.customerTableAdapter customerTableAdapter;
        private Vectra.DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private Vectra.DataSet2TableAdapters.customer_transTableAdapter customer_transTableAdapter;
        private System.Windows.Forms.BindingSource customer_transBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton btnInvoicing;
        private System.Windows.Forms.ToolStripButton btnReceipt;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox searchValue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private Vectra.DataSet2TableAdapters.INVOICE_HEADERTableAdapter iNVOICE_HEADERTableAdapter;
        private System.Windows.Forms.BindingSource iNVOICE_HEADERBindingSource;
        private Vectra.DataSet2TableAdapters.INVOICE_RECIEPTSTableAdapter iNVOICE_RECIEPTSTableAdapter;
        private System.Windows.Forms.BindingSource iNVOICE_RECIEPTSBindingSource;
        private System.Windows.Forms.ToolStripButton btnAdjustment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private Vectra.DataSet2TableAdapters.debtors_summaryTableAdapter debtors_summaryTableAdapter;
        private System.Windows.Forms.BindingSource debtors_summaryBindingSource;
        private System.Windows.Forms.TextBox t_amountTextBox;
        private System.Windows.Forms.TextBox curAmtTextBox;
        private System.Windows.Forms.TextBox days7TextBox;
        private System.Windows.Forms.TextBox days14TextBox;
        private System.Windows.Forms.TextBox days21TextBox;
        private System.Windows.Forms.TextBox date_last_paymentTextBox;
        private System.Windows.Forms.TextBox open_balTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalDue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.DataGridViewTextBoxColumn tidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcustidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_unpaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_src_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_src_dckt_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn trefidDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripLabel btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.DataGridViewTextBoxColumn custidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameaddress1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameaddress4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn open_bal;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}