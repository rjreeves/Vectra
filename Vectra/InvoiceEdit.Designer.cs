namespace Vectra
{
    partial class InvoiceEdit
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
            System.Windows.Forms.Label invoice_numberLabel;
            System.Windows.Forms.Label invoice_dateLabel;
            System.Windows.Forms.Label cust_idLabel;
            System.Windows.Forms.Label docket_numberLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label text_fully_paidLabel;
            System.Windows.Forms.Label invoice_unpaidLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceEdit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iNVOICE_HEADERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Vectra.DataSet2();
            this.iNVOICE_HEADERBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.iNVOICE_HEADERBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.invoice_numberTextBox = new System.Windows.Forms.TextBox();
            this.docket_numberTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.text_fully_paidTextBox = new System.Windows.Forms.TextBox();
            this.name_address_1TextBox = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.name_address_2TextBox = new System.Windows.Forms.TextBox();
            this.name_address_3TextBox = new System.Windows.Forms.TextBox();
            this.name_address_4TextBox = new System.Windows.Forms.TextBox();
            this.pcodeTextBox = new System.Windows.Forms.TextBox();
            this.invoice_itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice_itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cust_idTextBox = new System.Windows.Forms.TextBox();
            this.cust_idTextBox1 = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.gstTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.sQLiteSelectCommand1 = new Devart.Data.SQLite.SQLiteCommand();
            this.sqLiteConnection1 = new Devart.Data.SQLite.SQLiteConnection();
            this.sqLiteCommand1 = new Devart.Data.SQLite.SQLiteCommand();
            this.invoice_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.invoice_unpaidTextBox = new System.Windows.Forms.TextBox();
            this.productsinvoiceitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_transBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNVOICE_HEADERTableAdapter = new Vectra.DataSet2TableAdapters.INVOICE_HEADERTableAdapter();
            this.tableAdapterManager = new Vectra.DataSet2TableAdapters.TableAdapterManager();
            this.customer_transTableAdapter = new Vectra.DataSet2TableAdapters.customer_transTableAdapter();
            this.customerTableAdapter = new Vectra.DataSet2TableAdapters.customerTableAdapter();
            this.invoice_itemsTableAdapter = new Vectra.DataSet2TableAdapters.invoice_itemsTableAdapter();
            this.product_typeTableAdapter = new Vectra.DataSet2TableAdapters.product_typeTableAdapter();
            this.productsTableAdapter = new Vectra.DataSet2TableAdapters.productsTableAdapter();
            invoice_numberLabel = new System.Windows.Forms.Label();
            invoice_dateLabel = new System.Windows.Forms.Label();
            cust_idLabel = new System.Windows.Forms.Label();
            docket_numberLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            text_fully_paidLabel = new System.Windows.Forms.Label();
            invoice_unpaidLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_HEADERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_HEADERBindingNavigator)).BeginInit();
            this.iNVOICE_HEADERBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_itemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsinvoiceitemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_transBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // invoice_numberLabel
            // 
            invoice_numberLabel.AutoSize = true;
            invoice_numberLabel.Location = new System.Drawing.Point(300, 164);
            invoice_numberLabel.Name = "invoice_numberLabel";
            invoice_numberLabel.Size = new System.Drawing.Size(82, 13);
            invoice_numberLabel.TabIndex = 1;
            invoice_numberLabel.Text = "invoice number:";
            invoice_numberLabel.Visible = false;
            // 
            // invoice_dateLabel
            // 
            invoice_dateLabel.AutoSize = true;
            invoice_dateLabel.Location = new System.Drawing.Point(441, 68);
            invoice_dateLabel.Name = "invoice_dateLabel";
            invoice_dateLabel.Size = new System.Drawing.Size(71, 13);
            invoice_dateLabel.TabIndex = 3;
            invoice_dateLabel.Text = "Invoice Date:";
            // 
            // cust_idLabel
            // 
            cust_idLabel.AutoSize = true;
            cust_idLabel.Location = new System.Drawing.Point(9, 41);
            cust_idLabel.Name = "cust_idLabel";
            cust_idLabel.Size = new System.Drawing.Size(51, 13);
            cust_idLabel.TabIndex = 5;
            cust_idLabel.Text = "Customer";
            // 
            // docket_numberLabel
            // 
            docket_numberLabel.AutoSize = true;
            docket_numberLabel.Location = new System.Drawing.Point(427, 41);
            docket_numberLabel.Name = "docket_numberLabel";
            docket_numberLabel.Size = new System.Drawing.Size(85, 13);
            docket_numberLabel.TabIndex = 7;
            docket_numberLabel.Text = "Docket Number:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(479, 94);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(33, 13);
            notesLabel.TabIndex = 9;
            notesLabel.Text = "Note:";
            // 
            // text_fully_paidLabel
            // 
            text_fully_paidLabel.AutoSize = true;
            text_fully_paidLabel.Location = new System.Drawing.Point(455, 185);
            text_fully_paidLabel.Name = "text_fully_paidLabel";
            text_fully_paidLabel.Size = new System.Drawing.Size(55, 13);
            text_fully_paidLabel.TabIndex = 11;
            text_fully_paidLabel.Text = "Fully Paid:";
            text_fully_paidLabel.Visible = false;
            // 
            // invoice_unpaidLabel
            // 
            invoice_unpaidLabel.AutoSize = true;
            invoice_unpaidLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICE_HEADERBindingSource, "invoice_unpaid", true));
            invoice_unpaidLabel.Location = new System.Drawing.Point(609, 548);
            invoice_unpaidLabel.Name = "invoice_unpaidLabel";
            invoice_unpaidLabel.Size = new System.Drawing.Size(79, 13);
            invoice_unpaidLabel.TabIndex = 38;
            invoice_unpaidLabel.Text = "invoice unpaid:";
            // 
            // iNVOICE_HEADERBindingSource
            // 
            this.iNVOICE_HEADERBindingSource.DataMember = "INVOICE_HEADER";
            this.iNVOICE_HEADERBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNVOICE_HEADERBindingNavigator
            // 
            this.iNVOICE_HEADERBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iNVOICE_HEADERBindingNavigator.BindingSource = this.iNVOICE_HEADERBindingSource;
            this.iNVOICE_HEADERBindingNavigator.CountItem = null;
            this.iNVOICE_HEADERBindingNavigator.DeleteItem = null;
            this.iNVOICE_HEADERBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.iNVOICE_HEADERBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripLabel1});
            this.iNVOICE_HEADERBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iNVOICE_HEADERBindingNavigator.MoveFirstItem = null;
            this.iNVOICE_HEADERBindingNavigator.MoveLastItem = null;
            this.iNVOICE_HEADERBindingNavigator.MoveNextItem = null;
            this.iNVOICE_HEADERBindingNavigator.MovePreviousItem = null;
            this.iNVOICE_HEADERBindingNavigator.Name = "iNVOICE_HEADERBindingNavigator";
            this.iNVOICE_HEADERBindingNavigator.PositionItem = null;
            this.iNVOICE_HEADERBindingNavigator.Size = new System.Drawing.Size(801, 25);
            this.iNVOICE_HEADERBindingNavigator.TabIndex = 0;
            this.iNVOICE_HEADERBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // iNVOICE_HEADERBindingNavigatorSaveItem
            // 
            this.iNVOICE_HEADERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iNVOICE_HEADERBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iNVOICE_HEADERBindingNavigatorSaveItem.Image")));
            this.iNVOICE_HEADERBindingNavigatorSaveItem.Name = "iNVOICE_HEADERBindingNavigatorSaveItem";
            this.iNVOICE_HEADERBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.iNVOICE_HEADERBindingNavigatorSaveItem.Text = "Save Data";
            this.iNVOICE_HEADERBindingNavigatorSaveItem.Click += new System.EventHandler(this.iNVOICE_HEADERBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(129, 22);
            this.toolStripLabel1.Text = "**     Invoice Locked    **";
            // 
            // invoice_numberTextBox
            // 
            this.invoice_numberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.invoice_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICE_HEADERBindingSource, "invoice_number", true));
            this.invoice_numberTextBox.Location = new System.Drawing.Point(388, 165);
            this.invoice_numberTextBox.Name = "invoice_numberTextBox";
            this.invoice_numberTextBox.ReadOnly = true;
            this.invoice_numberTextBox.Size = new System.Drawing.Size(100, 13);
            this.invoice_numberTextBox.TabIndex = 1;
            this.invoice_numberTextBox.Visible = false;
            // 
            // docket_numberTextBox
            // 
            this.docket_numberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.docket_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICE_HEADERBindingSource, "docket_number", true));
            this.docket_numberTextBox.Location = new System.Drawing.Point(515, 41);
            this.docket_numberTextBox.Name = "docket_numberTextBox";
            this.docket_numberTextBox.Size = new System.Drawing.Size(268, 13);
            this.docket_numberTextBox.TabIndex = 0;
            // 
            // notesTextBox
            // 
            this.notesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICE_HEADERBindingSource, "notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(515, 94);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(268, 61);
            this.notesTextBox.TabIndex = 2;
            // 
            // text_fully_paidTextBox
            // 
            this.text_fully_paidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_fully_paidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICE_HEADERBindingSource, "text_fully_paid", true));
            this.text_fully_paidTextBox.Location = new System.Drawing.Point(513, 185);
            this.text_fully_paidTextBox.Name = "text_fully_paidTextBox";
            this.text_fully_paidTextBox.Size = new System.Drawing.Size(268, 13);
            this.text_fully_paidTextBox.TabIndex = 3;
            this.text_fully_paidTextBox.Visible = false;
            // 
            // name_address_1TextBox
            // 
            this.name_address_1TextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name_address_1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_address_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "name_address_1", true));
            this.name_address_1TextBox.Location = new System.Drawing.Point(12, 65);
            this.name_address_1TextBox.Name = "name_address_1TextBox";
            this.name_address_1TextBox.ReadOnly = true;
            this.name_address_1TextBox.Size = new System.Drawing.Size(367, 13);
            this.name_address_1TextBox.TabIndex = 16;
            this.name_address_1TextBox.TabStop = false;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.dataSet2;
            // 
            // name_address_2TextBox
            // 
            this.name_address_2TextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name_address_2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_address_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "name_address_2", true));
            this.name_address_2TextBox.Location = new System.Drawing.Point(12, 91);
            this.name_address_2TextBox.Name = "name_address_2TextBox";
            this.name_address_2TextBox.ReadOnly = true;
            this.name_address_2TextBox.Size = new System.Drawing.Size(367, 13);
            this.name_address_2TextBox.TabIndex = 18;
            this.name_address_2TextBox.TabStop = false;
            // 
            // name_address_3TextBox
            // 
            this.name_address_3TextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name_address_3TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_address_3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "name_address_3", true));
            this.name_address_3TextBox.Location = new System.Drawing.Point(12, 117);
            this.name_address_3TextBox.Name = "name_address_3TextBox";
            this.name_address_3TextBox.ReadOnly = true;
            this.name_address_3TextBox.Size = new System.Drawing.Size(367, 13);
            this.name_address_3TextBox.TabIndex = 20;
            this.name_address_3TextBox.TabStop = false;
            // 
            // name_address_4TextBox
            // 
            this.name_address_4TextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name_address_4TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_address_4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "name_address_4", true));
            this.name_address_4TextBox.Location = new System.Drawing.Point(12, 143);
            this.name_address_4TextBox.Name = "name_address_4TextBox";
            this.name_address_4TextBox.ReadOnly = true;
            this.name_address_4TextBox.Size = new System.Drawing.Size(311, 13);
            this.name_address_4TextBox.TabIndex = 22;
            this.name_address_4TextBox.TabStop = false;
            // 
            // pcodeTextBox
            // 
            this.pcodeTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "pcode", true));
            this.pcodeTextBox.Location = new System.Drawing.Point(329, 143);
            this.pcodeTextBox.Name = "pcodeTextBox";
            this.pcodeTextBox.ReadOnly = true;
            this.pcodeTextBox.Size = new System.Drawing.Size(50, 13);
            this.pcodeTextBox.TabIndex = 24;
            this.pcodeTextBox.TabStop = false;
            // 
            // invoice_itemsDataGridView
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.invoice_itemsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.invoice_itemsDataGridView.AutoGenerateColumns = false;
            this.invoice_itemsDataGridView.CausesValidation = false;
            this.invoice_itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoice_itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.qty,
            this.weight,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.invoice_itemsDataGridView.DataSource = this.invoice_itemsBindingSource;
            this.invoice_itemsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.invoice_itemsDataGridView.Location = new System.Drawing.Point(11, 209);
            this.invoice_itemsDataGridView.Name = "invoice_itemsDataGridView";
            this.invoice_itemsDataGridView.RowHeadersVisible = false;
            this.invoice_itemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.invoice_itemsDataGridView.Size = new System.Drawing.Size(780, 241);
            this.invoice_itemsDataGridView.TabIndex = 3;
            this.invoice_itemsDataGridView.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.invoice_itemsDataGridView_CellParsing);
            this.invoice_itemsDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.invoice_itemsDataGridView_RowsAdded);
            this.invoice_itemsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoice_itemsDataGridView_CellClick);
            this.invoice_itemsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.invoice_itemsDataGridView_DataError);
            this.invoice_itemsDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.invoice_itemsDataGridView_KeyDown);
            this.invoice_itemsDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoice_itemsDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "line_number";
            this.dataGridViewTextBoxColumn2.HeaderText = "Line";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prod_id";
            this.dataGridViewTextBoxColumn3.DataSource = this.productsBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "desc";
            this.dataGridViewTextBoxColumn3.HeaderText = "Product";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "prod_id";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.dataSet2;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            // 
            // weight
            // 
            this.weight.DataPropertyName = "weight";
            this.weight.HeaderText = "Weight";
            this.weight.Name = "weight";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "rate";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn6.HeaderText = "Rate";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "gst_value";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn7.HeaderText = "GST";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "amount";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn8.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // invoice_itemsBindingSource
            // 
            this.invoice_itemsBindingSource.AllowNew = true;
            this.invoice_itemsBindingSource.DataMember = "invHeader_invItems";
            this.invoice_itemsBindingSource.DataSource = this.iNVOICE_HEADERBindingSource;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "GST";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(649, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Total";
            // 
            // cust_idTextBox
            // 
            this.cust_idTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cust_idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cust_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "cust_id", true));
            this.cust_idTextBox.Location = new System.Drawing.Point(279, 41);
            this.cust_idTextBox.Name = "cust_idTextBox";
            this.cust_idTextBox.ReadOnly = true;
            this.cust_idTextBox.Size = new System.Drawing.Size(100, 13);
            this.cust_idTextBox.TabIndex = 31;
            this.cust_idTextBox.TabStop = false;
            // 
            // cust_idTextBox1
            // 
            this.cust_idTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cust_idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICE_HEADERBindingSource, "cust_id", true));
            this.cust_idTextBox1.Location = new System.Drawing.Point(694, 584);
            this.cust_idTextBox1.Name = "cust_idTextBox1";
            this.cust_idTextBox1.Size = new System.Drawing.Size(100, 13);
            this.cust_idTextBox1.TabIndex = 32;
            this.cust_idTextBox1.TabStop = false;
            // 
            // btnTotal
            // 
            this.btnTotal.Enabled = false;
            this.btnTotal.Location = new System.Drawing.Point(581, 466);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(41, 23);
            this.btnTotal.TabIndex = 4;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Visible = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // gstTextBox
            // 
            this.gstTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gstTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gstTextBox.Location = new System.Drawing.Point(691, 466);
            this.gstTextBox.Name = "gstTextBox";
            this.gstTextBox.ReadOnly = true;
            this.gstTextBox.Size = new System.Drawing.Size(100, 13);
            this.gstTextBox.TabIndex = 35;
            this.gstTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalTextBox
            // 
            this.totalTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICE_HEADERBindingSource, "invoice_amount", true));
            this.totalTextBox.Location = new System.Drawing.Point(691, 490);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 13);
            this.totalTextBox.TabIndex = 36;
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sQLiteSelectCommand1
            // 
            this.sQLiteSelectCommand1.CommandText = "Select t.desc,p.desc from products p, product_type t\norder by p.desc";
            this.sQLiteSelectCommand1.Name = "sQLiteSelectCommand1";
            this.sQLiteSelectCommand1.Owner = this;
            // 
            // sqLiteConnection1
            // 
            this.sqLiteConnection1.ConnectionString = "Data Source=\"C:\\Documents and Settings\\All Users\\Application Data\\Vectra\\Data\\PRO" +
                "D.db3\";";
            this.sqLiteConnection1.Name = "sqLiteConnection1";
            this.sqLiteConnection1.Owner = this;
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = "insert into customer_trans (t_cust_id) values (123)\n";
            this.sqLiteCommand1.Connection = this.sqLiteConnection1;
            this.sqLiteCommand1.Name = "sqLiteCommand1";
            this.sqLiteCommand1.Owner = this;
            // 
            // invoice_dateDateTimePicker
            // 
            this.invoice_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.iNVOICE_HEADERBindingSource, "invoice_date", true));
            this.invoice_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICE_HEADERBindingSource, "invoice_date", true));
            this.invoice_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.invoice_dateDateTimePicker.Location = new System.Drawing.Point(515, 64);
            this.invoice_dateDateTimePicker.Name = "invoice_dateDateTimePicker";
            this.invoice_dateDateTimePicker.Size = new System.Drawing.Size(268, 20);
            this.invoice_dateDateTimePicker.TabIndex = 1;
            // 
            // invoice_unpaidTextBox
            // 
            this.invoice_unpaidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICE_HEADERBindingSource, "invoice_unpaid", true));
            this.invoice_unpaidTextBox.Location = new System.Drawing.Point(694, 545);
            this.invoice_unpaidTextBox.Name = "invoice_unpaidTextBox";
            this.invoice_unpaidTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoice_unpaidTextBox.TabIndex = 39;
            // 
            // productsinvoiceitemsBindingSource
            // 
            this.productsinvoiceitemsBindingSource.DataMember = "products_invoice_items";
            this.productsinvoiceitemsBindingSource.DataSource = this.productsBindingSource;
            // 
            // customer_transBindingSource
            // 
            this.customer_transBindingSource.DataMember = "customer_trans";
            this.customer_transBindingSource.DataSource = this.dataSet2;
            // 
            // iNVOICE_HEADERTableAdapter
            // 
            this.iNVOICE_HEADERTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.invoice_itemsTableAdapter = this.invoice_itemsTableAdapter;
            this.tableAdapterManager.INVOICE_RECIEPTSTableAdapter = null;
            this.tableAdapterManager.payment_typeTableAdapter = null;
            this.tableAdapterManager.PaymentAdjustRptTableAdapter = null;
            this.tableAdapterManager.product_typeTableAdapter = this.product_typeTableAdapter;
            this.tableAdapterManager.ProductSalesReportTableAdapter = null;
            this.tableAdapterManager.ProductSalesSummaryTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.sqlite_sequenceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Vectra.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customer_transTableAdapter
            // 
            this.customer_transTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // invoice_itemsTableAdapter
            // 
            this.invoice_itemsTableAdapter.ClearBeforeFill = true;
            // 
            // product_typeTableAdapter
            // 
            this.product_typeTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // InvoiceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(801, 510);
            this.Controls.Add(invoice_unpaidLabel);
            this.Controls.Add(this.invoice_unpaidTextBox);
            this.Controls.Add(this.invoice_dateDateTimePicker);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.gstTextBox);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.cust_idTextBox1);
            this.Controls.Add(this.cust_idTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.invoice_itemsDataGridView);
            this.Controls.Add(this.pcodeTextBox);
            this.Controls.Add(this.name_address_4TextBox);
            this.Controls.Add(this.name_address_3TextBox);
            this.Controls.Add(this.name_address_2TextBox);
            this.Controls.Add(this.name_address_1TextBox);
            this.Controls.Add(invoice_numberLabel);
            this.Controls.Add(this.invoice_numberTextBox);
            this.Controls.Add(invoice_dateLabel);
            this.Controls.Add(cust_idLabel);
            this.Controls.Add(docket_numberLabel);
            this.Controls.Add(this.docket_numberTextBox);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(text_fully_paidLabel);
            this.Controls.Add(this.text_fully_paidTextBox);
            this.Controls.Add(this.iNVOICE_HEADERBindingNavigator);
            this.Name = "InvoiceEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Invoice";
            this.Load += new System.EventHandler(this.InvoiceEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_HEADERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_HEADERBindingNavigator)).EndInit();
            this.iNVOICE_HEADERBindingNavigator.ResumeLayout(false);
            this.iNVOICE_HEADERBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_itemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsinvoiceitemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_transBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource iNVOICE_HEADERBindingSource;
        private Vectra.DataSet2TableAdapters.INVOICE_HEADERTableAdapter iNVOICE_HEADERTableAdapter;
        private Vectra.DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iNVOICE_HEADERBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton iNVOICE_HEADERBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox invoice_numberTextBox;
        private System.Windows.Forms.TextBox docket_numberTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox text_fully_paidTextBox;
        private Vectra.DataSet2TableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.TextBox name_address_1TextBox;
        private System.Windows.Forms.TextBox name_address_2TextBox;
        private System.Windows.Forms.TextBox name_address_3TextBox;
        private System.Windows.Forms.TextBox name_address_4TextBox;
        private System.Windows.Forms.TextBox pcodeTextBox;
        private Vectra.DataSet2TableAdapters.invoice_itemsTableAdapter invoice_itemsTableAdapter;
        private System.Windows.Forms.BindingSource invoice_itemsBindingSource;
        private System.Windows.Forms.DataGridView invoice_itemsDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox cust_idTextBox;
        private System.Windows.Forms.TextBox cust_idTextBox1;
        private Vectra.DataSet2TableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.TextBox gstTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private Devart.Data.SQLite.SQLiteCommand sQLiteSelectCommand1;
        private System.Windows.Forms.BindingSource productsinvoiceitemsBindingSource;
        private Vectra.DataSet2TableAdapters.product_typeTableAdapter product_typeTableAdapter;
        private Vectra.DataSet2TableAdapters.customer_transTableAdapter customer_transTableAdapter;
        private System.Windows.Forms.BindingSource customer_transBindingSource;
        private Devart.Data.SQLite.SQLiteConnection sqLiteConnection1;
        private Devart.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.DateTimePicker invoice_dateDateTimePicker;
        private System.Windows.Forms.TextBox invoice_unpaidTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}