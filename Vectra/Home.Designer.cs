namespace Vectra
{
    partial class Home
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
            System.Windows.Forms.Label bus_namesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.configurationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.configurationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Vectra.DataSet2();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.configurationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bus_namesTextBox = new System.Windows.Forms.TextBox();
            this.cntReceipts = new System.Windows.Forms.Label();
            this.cntSales = new System.Windows.Forms.Label();
            this.zgc1 = new ZedGraph.ZedGraphControl();
            this.configurationTableAdapter = new Vectra.DataSet2TableAdapters.configurationTableAdapter();
            this.tableAdapterManager = new Vectra.DataSet2TableAdapters.TableAdapterManager();
            this.label4 = new System.Windows.Forms.Label();
            this.cntCustomers = new System.Windows.Forms.Label();
            this.cntInvoiceStats = new System.Windows.Forms.Label();
            this.cntUnpaidCust = new System.Windows.Forms.Label();
            this.cntUnpaidAmount = new System.Windows.Forms.Label();
            this.cntAcntPeriod = new System.Windows.Forms.Label();
            this.cntToday = new System.Windows.Forms.Label();
            this.sqLiteConnection1 = new Devart.Data.SQLite.SQLiteConnection();
            this.cntPeriodValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cntPeriodEnd = new System.Windows.Forms.Label();
            bus_namesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingNavigator)).BeginInit();
            this.configurationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // bus_namesLabel
            // 
            bus_namesLabel.AutoSize = true;
            bus_namesLabel.Location = new System.Drawing.Point(12, 14);
            bus_namesLabel.Name = "bus_namesLabel";
            bus_namesLabel.Size = new System.Drawing.Size(83, 13);
            bus_namesLabel.TabIndex = 4;
            bus_namesLabel.Text = "Business Name:";
            // 
            // configurationBindingNavigator
            // 
            this.configurationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.configurationBindingNavigator.BindingSource = this.configurationBindingSource;
            this.configurationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.configurationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.configurationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.configurationBindingNavigatorSaveItem});
            this.configurationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.configurationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.configurationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.configurationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.configurationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.configurationBindingNavigator.Name = "configurationBindingNavigator";
            this.configurationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.configurationBindingNavigator.Size = new System.Drawing.Size(890, 25);
            this.configurationBindingNavigator.TabIndex = 3;
            this.configurationBindingNavigator.Text = "bindingNavigator1";
            this.configurationBindingNavigator.Visible = false;
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
            // configurationBindingSource
            // 
            this.configurationBindingSource.DataMember = "configuration";
            this.configurationBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // configurationBindingNavigatorSaveItem
            // 
            this.configurationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.configurationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("configurationBindingNavigatorSaveItem.Image")));
            this.configurationBindingNavigatorSaveItem.Name = "configurationBindingNavigatorSaveItem";
            this.configurationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.configurationBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // bus_namesTextBox
            // 
            this.bus_namesTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.bus_namesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bus_namesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationBindingSource, "bus_names", true));
            this.bus_namesTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bus_namesTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bus_namesTextBox.Location = new System.Drawing.Point(15, 30);
            this.bus_namesTextBox.Name = "bus_namesTextBox";
            this.bus_namesTextBox.ReadOnly = true;
            this.bus_namesTextBox.Size = new System.Drawing.Size(300, 20);
            this.bus_namesTextBox.TabIndex = 5;
            this.bus_namesTextBox.TabStop = false;
            this.bus_namesTextBox.Text = "BUSINESS NAME";
            // 
            // cntReceipts
            // 
            this.cntReceipts.AutoSize = true;
            this.cntReceipts.Location = new System.Drawing.Point(12, 218);
            this.cntReceipts.Name = "cntReceipts";
            this.cntReceipts.Size = new System.Drawing.Size(103, 13);
            this.cntReceipts.TabIndex = 8;
            this.cntReceipts.Text = "Receipts (this week)";
            // 
            // cntSales
            // 
            this.cntSales.AutoSize = true;
            this.cntSales.Location = new System.Drawing.Point(12, 237);
            this.cntSales.Name = "cntSales";
            this.cntSales.Size = new System.Drawing.Size(94, 13);
            this.cntSales.TabIndex = 9;
            this.cntSales.Text = "Sales (This Week)";
            // 
            // zgc1
            // 
            this.zgc1.Location = new System.Drawing.Point(364, 14);
            this.zgc1.Name = "zgc1";
            this.zgc1.ScrollGrace = 0;
            this.zgc1.ScrollMaxX = 0;
            this.zgc1.ScrollMaxY = 0;
            this.zgc1.ScrollMaxY2 = 0;
            this.zgc1.ScrollMinX = 0;
            this.zgc1.ScrollMinY = 0;
            this.zgc1.ScrollMinY2 = 0;
            this.zgc1.Size = new System.Drawing.Size(460, 355);
            this.zgc1.TabIndex = 10;
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
            this.tableAdapterManager.PaymentAdjustRptTableAdapter = null;
            this.tableAdapterManager.product_typeTableAdapter = null;
            this.tableAdapterManager.ProductSalesReportTableAdapter = null;
            this.tableAdapterManager.ProductSalesSummaryTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.SalesSummary1TableAdapter = null;
            this.tableAdapterManager.sqlite_sequenceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Vectra.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Customers";
            // 
            // cntCustomers
            // 
            this.cntCustomers.AutoSize = true;
            this.cntCustomers.Location = new System.Drawing.Point(74, 142);
            this.cntCustomers.Name = "cntCustomers";
            this.cntCustomers.Size = new System.Drawing.Size(13, 13);
            this.cntCustomers.TabIndex = 12;
            this.cntCustomers.Text = "0";
            // 
            // cntInvoiceStats
            // 
            this.cntInvoiceStats.AutoSize = true;
            this.cntInvoiceStats.Location = new System.Drawing.Point(102, 195);
            this.cntInvoiceStats.Name = "cntInvoiceStats";
            this.cntInvoiceStats.Size = new System.Drawing.Size(0, 13);
            this.cntInvoiceStats.TabIndex = 13;
            // 
            // cntUnpaidCust
            // 
            this.cntUnpaidCust.AutoSize = true;
            this.cntUnpaidCust.Location = new System.Drawing.Point(12, 166);
            this.cntUnpaidCust.Name = "cntUnpaidCust";
            this.cntUnpaidCust.Size = new System.Drawing.Size(62, 13);
            this.cntUnpaidCust.TabIndex = 14;
            this.cntUnpaidCust.Text = "UnpaidCust";
            // 
            // cntUnpaidAmount
            // 
            this.cntUnpaidAmount.AutoSize = true;
            this.cntUnpaidAmount.Location = new System.Drawing.Point(12, 185);
            this.cntUnpaidAmount.Name = "cntUnpaidAmount";
            this.cntUnpaidAmount.Size = new System.Drawing.Size(42, 13);
            this.cntUnpaidAmount.TabIndex = 15;
            this.cntUnpaidAmount.Text = "Owings";
            // 
            // cntAcntPeriod
            // 
            this.cntAcntPeriod.AutoSize = true;
            this.cntAcntPeriod.Location = new System.Drawing.Point(15, 68);
            this.cntAcntPeriod.Name = "cntAcntPeriod";
            this.cntAcntPeriod.Size = new System.Drawing.Size(117, 13);
            this.cntAcntPeriod.TabIndex = 16;
            this.cntAcntPeriod.Text = "Accounting Period No: ";
            // 
            // cntToday
            // 
            this.cntToday.AutoSize = true;
            this.cntToday.Location = new System.Drawing.Point(12, 120);
            this.cntToday.Name = "cntToday";
            this.cntToday.Size = new System.Drawing.Size(43, 13);
            this.cntToday.TabIndex = 17;
            this.cntToday.Text = "Today: ";
            // 
            // sqLiteConnection1
            // 
            this.sqLiteConnection1.ConnectionString = "Data Source=\"C:\\Documents and Settings\\All Users\\Application Data\\Vectra\\Data\\PRO" +
                "D.db3\";";
            this.sqLiteConnection1.Name = "sqLiteConnection1";
            this.sqLiteConnection1.Owner = this;
            // 
            // cntPeriodValue
            // 
            this.cntPeriodValue.AutoSize = true;
            this.cntPeriodValue.Location = new System.Drawing.Point(129, 68);
            this.cntPeriodValue.Name = "cntPeriodValue";
            this.cntPeriodValue.Size = new System.Drawing.Size(30, 13);
            this.cntPeriodValue.TabIndex = 18;
            this.cntPeriodValue.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Accounting Period End Date:";
            // 
            // cntPeriodEnd
            // 
            this.cntPeriodEnd.AutoSize = true;
            this.cntPeriodEnd.Location = new System.Drawing.Point(158, 93);
            this.cntPeriodEnd.Name = "cntPeriodEnd";
            this.cntPeriodEnd.Size = new System.Drawing.Size(30, 13);
            this.cntPeriodEnd.TabIndex = 21;
            this.cntPeriodEnd.Text = "Date";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 394);
            this.Controls.Add(this.cntPeriodEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cntPeriodValue);
            this.Controls.Add(this.cntToday);
            this.Controls.Add(this.cntAcntPeriod);
            this.Controls.Add(this.cntUnpaidAmount);
            this.Controls.Add(this.cntUnpaidCust);
            this.Controls.Add(this.cntInvoiceStats);
            this.Controls.Add(this.cntCustomers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zgc1);
            this.Controls.Add(this.cntSales);
            this.Controls.Add(this.cntReceipts);
            this.Controls.Add(bus_namesLabel);
            this.Controls.Add(this.bus_namesTextBox);
            this.Controls.Add(this.configurationBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingNavigator)).EndInit();
            this.configurationBindingNavigator.ResumeLayout(false);
            this.configurationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource configurationBindingSource;
        private Vectra.DataSet2TableAdapters.configurationTableAdapter configurationTableAdapter;
        private Vectra.DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator configurationBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton configurationBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox bus_namesTextBox;
        private System.Windows.Forms.Label cntReceipts;
        private System.Windows.Forms.Label cntSales;
        private ZedGraph.ZedGraphControl zgc1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cntCustomers;       
        private System.Windows.Forms.Label cntInvoiceStats;
        private System.Windows.Forms.Label cntUnpaidCust;
        private System.Windows.Forms.Label cntUnpaidAmount;
        private System.Windows.Forms.Label cntAcntPeriod;
        private System.Windows.Forms.Label cntToday;
        private Devart.Data.SQLite.SQLiteConnection sqLiteConnection1;
        private System.Windows.Forms.Label cntPeriodValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cntPeriodEnd;
    }
}