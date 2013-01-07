namespace Vectra
{
    partial class EndOfWeek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndOfWeek));
            this.processDateTime = new System.Windows.Forms.DateTimePicker();
            this.acntPeriodText = new System.Windows.Forms.TextBox();
            this.lblArchivePeriod = new System.Windows.Forms.Label();
            this.bntProcess = new System.Windows.Forms.Button();
            this.lblEow = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sqLiteConnection1 = new Devart.Data.SQLite.SQLiteConnection();
            this.sqLiteCommand1 = new Devart.Data.SQLite.SQLiteCommand();
            this.customer_transBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Vectra.DataSet2();
            this.customer_transTableAdapter = new Vectra.DataSet2TableAdapters.customer_transTableAdapter();
            this.tableAdapterManager = new Vectra.DataSet2TableAdapters.TableAdapterManager();
            this.customerTableAdapter1 = new Vectra.DataSet2TableAdapters.customerTableAdapter();
            this.debtors_summaryTableAdapter = new Vectra.DataSet2TableAdapters.debtors_summaryTableAdapter();
            this.debtors_summaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseBooks = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_transBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtors_summaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // processDateTime
            // 
            this.processDateTime.Location = new System.Drawing.Point(127, 24);
            this.processDateTime.Name = "processDateTime";
            this.processDateTime.Size = new System.Drawing.Size(200, 20);
            this.processDateTime.TabIndex = 0;
            // 
            // acntPeriodText
            // 
            this.acntPeriodText.BackColor = System.Drawing.SystemColors.Control;
            this.acntPeriodText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.acntPeriodText.Location = new System.Drawing.Point(249, 66);
            this.acntPeriodText.Name = "acntPeriodText";
            this.acntPeriodText.Size = new System.Drawing.Size(52, 13);
            this.acntPeriodText.TabIndex = 1;
            this.acntPeriodText.Text = "60";
            // 
            // lblArchivePeriod
            // 
            this.lblArchivePeriod.AutoSize = true;
            this.lblArchivePeriod.Location = new System.Drawing.Point(147, 65);
            this.lblArchivePeriod.Name = "lblArchivePeriod";
            this.lblArchivePeriod.Size = new System.Drawing.Size(97, 13);
            this.lblArchivePeriod.TabIndex = 2;
            this.lblArchivePeriod.Text = "Accounting  Period";
            // 
            // bntProcess
            // 
            this.bntProcess.Location = new System.Drawing.Point(169, 142);
            this.bntProcess.Name = "bntProcess";
            this.bntProcess.Size = new System.Drawing.Size(75, 23);
            this.bntProcess.TabIndex = 3;
            this.bntProcess.Text = "Process";
            this.bntProcess.UseVisualStyleBackColor = true;
            this.bntProcess.Click += new System.EventHandler(this.bntProcess_Click);
            // 
            // lblEow
            // 
            this.lblEow.AutoSize = true;
            this.lblEow.Location = new System.Drawing.Point(50, 28);
            this.lblEow.Name = "lblEow";
            this.lblEow.Size = new System.Drawing.Size(72, 13);
            this.lblEow.TabIndex = 4;
            this.lblEow.Text = "End Of Week";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 438);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(511, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
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
            this.sqLiteCommand1.CommandText = "delete from  debtors_summary;";
            this.sqLiteCommand1.Connection = this.sqLiteConnection1;
            this.sqLiteCommand1.Name = "sqLiteCommand1";
            this.sqLiteCommand1.Owner = this;
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
            // customer_transTableAdapter
            // 
            this.customer_transTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.configurationTableAdapter = null;
            this.tableAdapterManager.customer_transTableAdapter = this.customer_transTableAdapter;
            this.tableAdapterManager.customerTableAdapter = this.customerTableAdapter1;
            this.tableAdapterManager.debtors_summaryTableAdapter = this.debtors_summaryTableAdapter;
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
            this.tableAdapterManager.sqlite_sequenceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Vectra.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // debtors_summaryTableAdapter
            // 
            this.debtors_summaryTableAdapter.ClearBeforeFill = true;
            // 
            // debtors_summaryBindingSource
            // 
            this.debtors_summaryBindingSource.DataMember = "debtors_summary";
            this.debtors_summaryBindingSource.DataSource = this.dataSet2;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(127, 192);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(181, 158);
            this.listBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Progress:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Report Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "C:\\Documents and Settings\\Administrator\\My Documents\\Vectra\\2011-Jun-03";
            // 
            // btnCloseBooks
            // 
            this.btnCloseBooks.AutoSize = true;
            this.btnCloseBooks.Location = new System.Drawing.Point(150, 105);
            this.btnCloseBooks.Name = "btnCloseBooks";
            this.btnCloseBooks.Size = new System.Drawing.Size(142, 17);
            this.btnCloseBooks.TabIndex = 10;
            this.btnCloseBooks.Text = "Close Accounting Period";
            this.btnCloseBooks.UseVisualStyleBackColor = true;
            // 
            // EndOfWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 460);
            this.Controls.Add(this.btnCloseBooks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblEow);
            this.Controls.Add(this.bntProcess);
            this.Controls.Add(this.lblArchivePeriod);
            this.Controls.Add(this.acntPeriodText);
            this.Controls.Add(this.processDateTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EndOfWeek";
            this.Text = "End Of Week";
            this.Load += new System.EventHandler(this.EndOfWeek_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_transBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtors_summaryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker processDateTime;
        private System.Windows.Forms.TextBox acntPeriodText;
        private System.Windows.Forms.Label lblArchivePeriod;
        private System.Windows.Forms.Button bntProcess;
        private System.Windows.Forms.Label lblEow;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private Devart.Data.SQLite.SQLiteConnection sqLiteConnection1;
        private Devart.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private Vectra.DataSet2TableAdapters.customer_transTableAdapter customer_transTableAdapter;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource customer_transBindingSource;
        private Vectra.DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private Vectra.DataSet2TableAdapters.debtors_summaryTableAdapter debtors_summaryTableAdapter;
        private System.Windows.Forms.BindingSource debtors_summaryBindingSource;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private Vectra.DataSet2TableAdapters.customerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox btnCloseBooks;
    }
}