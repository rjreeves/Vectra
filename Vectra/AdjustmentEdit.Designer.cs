namespace Vectra
{
    partial class AdjustmentEdit
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
            System.Windows.Forms.Label t_src_idLabel;
            System.Windows.Forms.Label t_ref_idLabel;
            System.Windows.Forms.Label t_noteLabel;
            System.Windows.Forms.Label t_amountLabel;
            System.Windows.Forms.Label cust_idLabel;
            System.Windows.Forms.Label t_dateLabel1;
            System.Windows.Forms.Label open_balLabel;
            this.t_idTextBox = new System.Windows.Forms.TextBox();
            this.customer_transBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Vectra.DataSet2();
            this.t_noteTextBox = new System.Windows.Forms.TextBox();
            this.t_amountTextBox = new System.Windows.Forms.TextBox();
            this.cust_idTextBox = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.name_address_1TextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.paymentCB = new System.Windows.Forms.ComboBox();
            this.sqLiteConnection1 = new Devart.Data.SQLite.SQLiteConnection();
            this.invoice_header_unpaidComboBox = new System.Windows.Forms.ComboBox();
            this.t_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customer_transTableAdapter = new Vectra.DataSet2TableAdapters.customer_transTableAdapter();
            this.tableAdapterManager = new Vectra.DataSet2TableAdapters.TableAdapterManager();
            this.customerTableAdapter = new Vectra.DataSet2TableAdapters.customerTableAdapter();
            this.iNVOICE_HEADERTableAdapter = new Vectra.DataSet2TableAdapters.INVOICE_HEADERTableAdapter();
            this.iNVOICE_HEADERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoice_header_unpaidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoice_header_unpaidTableAdapter = new Vectra.DataSet2TableAdapters.invoice_header_unpaidTableAdapter();
            this.open_balTextBox = new System.Windows.Forms.TextBox();
            this.cbPrintAdj = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            t_idLabel = new System.Windows.Forms.Label();
            t_src_idLabel = new System.Windows.Forms.Label();
            t_ref_idLabel = new System.Windows.Forms.Label();
            t_noteLabel = new System.Windows.Forms.Label();
            t_amountLabel = new System.Windows.Forms.Label();
            cust_idLabel = new System.Windows.Forms.Label();
            t_dateLabel1 = new System.Windows.Forms.Label();
            open_balLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customer_transBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_HEADERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_header_unpaidBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // t_idLabel
            // 
            t_idLabel.AutoSize = true;
            t_idLabel.Location = new System.Drawing.Point(16, 46);
            t_idLabel.Name = "t_idLabel";
            t_idLabel.Size = new System.Drawing.Size(42, 13);
            t_idLabel.TabIndex = 1;
            t_idLabel.Text = "Adj. ID:";
            // 
            // t_src_idLabel
            // 
            t_src_idLabel.AutoSize = true;
            t_src_idLabel.Location = new System.Drawing.Point(13, 77);
            t_src_idLabel.Name = "t_src_idLabel";
            t_src_idLabel.Size = new System.Drawing.Size(45, 13);
            t_src_idLabel.TabIndex = 7;
            t_src_idLabel.Text = "Invoice:";
            // 
            // t_ref_idLabel
            // 
            t_ref_idLabel.AutoSize = true;
            t_ref_idLabel.Location = new System.Drawing.Point(7, 108);
            t_ref_idLabel.Name = "t_ref_idLabel";
            t_ref_idLabel.Size = new System.Drawing.Size(51, 13);
            t_ref_idLabel.TabIndex = 9;
            t_ref_idLabel.Text = "Payment:";
            // 
            // t_noteLabel
            // 
            t_noteLabel.AutoSize = true;
            t_noteLabel.Location = new System.Drawing.Point(286, 81);
            t_noteLabel.Name = "t_noteLabel";
            t_noteLabel.Size = new System.Drawing.Size(35, 13);
            t_noteLabel.TabIndex = 13;
            t_noteLabel.Text = "Notes";
            // 
            // t_amountLabel
            // 
            t_amountLabel.AutoSize = true;
            t_amountLabel.Location = new System.Drawing.Point(12, 170);
            t_amountLabel.Name = "t_amountLabel";
            t_amountLabel.Size = new System.Drawing.Size(46, 13);
            t_amountLabel.TabIndex = 17;
            t_amountLabel.Text = "Amount:";
            // 
            // cust_idLabel
            // 
            cust_idLabel.AutoSize = true;
            cust_idLabel.Location = new System.Drawing.Point(0, 9);
            cust_idLabel.Name = "cust_idLabel";
            cust_idLabel.Size = new System.Drawing.Size(51, 13);
            cust_idLabel.TabIndex = 20;
            cust_idLabel.Text = "Customer";
            // 
            // t_dateLabel1
            // 
            t_dateLabel1.AutoSize = true;
            t_dateLabel1.Location = new System.Drawing.Point(4, 139);
            t_dateLabel1.Name = "t_dateLabel1";
            t_dateLabel1.Size = new System.Drawing.Size(54, 13);
            t_dateLabel1.TabIndex = 28;
            t_dateLabel1.Text = "Adj. Date:";
            // 
            // open_balLabel
            // 
            open_balLabel.AutoSize = true;
            open_balLabel.Location = new System.Drawing.Point(335, 42);
            open_balLabel.Name = "open_balLabel";
            open_balLabel.Size = new System.Drawing.Size(106, 13);
            open_balLabel.TabIndex = 29;
            open_balLabel.Text = "Unallocated Balance";
            // 
            // t_idTextBox
            // 
            this.t_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_transBindingSource, "t_id", true));
            this.t_idTextBox.Location = new System.Drawing.Point(69, 42);
            this.t_idTextBox.Name = "t_idTextBox";
            this.t_idTextBox.ReadOnly = true;
            this.t_idTextBox.Size = new System.Drawing.Size(49, 20);
            this.t_idTextBox.TabIndex = 2;
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
            // t_noteTextBox
            // 
            this.t_noteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_transBindingSource, "t_note", true));
            this.t_noteTextBox.Location = new System.Drawing.Point(329, 81);
            this.t_noteTextBox.Multiline = true;
            this.t_noteTextBox.Name = "t_noteTextBox";
            this.t_noteTextBox.Size = new System.Drawing.Size(286, 224);
            this.t_noteTextBox.TabIndex = 14;
            // 
            // t_amountTextBox
            // 
            this.t_amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_transBindingSource, "t_amount", true));
            this.t_amountTextBox.Location = new System.Drawing.Point(69, 164);
            this.t_amountTextBox.Name = "t_amountTextBox";
            this.t_amountTextBox.Size = new System.Drawing.Size(200, 20);
            this.t_amountTextBox.TabIndex = 18;
            this.t_amountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cust_idTextBox
            // 
            this.cust_idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cust_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "cust_id", true));
            this.cust_idTextBox.Location = new System.Drawing.Point(57, 9);
            this.cust_idTextBox.Name = "cust_idTextBox";
            this.cust_idTextBox.Size = new System.Drawing.Size(100, 13);
            this.cust_idTextBox.TabIndex = 21;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.dataSet2;
            // 
            // name_address_1TextBox
            // 
            this.name_address_1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_address_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "name_address_1", true));
            this.name_address_1TextBox.Location = new System.Drawing.Point(163, 9);
            this.name_address_1TextBox.Name = "name_address_1TextBox";
            this.name_address_1TextBox.Size = new System.Drawing.Size(452, 13);
            this.name_address_1TextBox.TabIndex = 23;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(69, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDiscard.Location = new System.Drawing.Point(194, 282);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(75, 23);
            this.btnDiscard.TabIndex = 25;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_transBindingSource, "t_type", true));
            this.comboBox1.DisplayMember = "t_type";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "General Adj.",
            "Unallocated Adj."});
            this.comboBox1.Location = new System.Drawing.Point(124, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.ValueMember = "t_type";
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // paymentCB
            // 
            this.paymentCB.FormattingEnabled = true;
            this.paymentCB.Location = new System.Drawing.Point(69, 103);
            this.paymentCB.Name = "paymentCB";
            this.paymentCB.Size = new System.Drawing.Size(200, 21);
            this.paymentCB.TabIndex = 28;
            this.paymentCB.SelectionChangeCommitted += new System.EventHandler(this.paymentCB_SelectionChangeCommitted);
            this.paymentCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            this.paymentCB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // sqLiteConnection1
            // 
            this.sqLiteConnection1.ConnectionString = myConfig.connstr;
                
            this.sqLiteConnection1.Name = "sqLiteConnection1";
            this.sqLiteConnection1.Owner = this;
            // 
            // invoice_header_unpaidComboBox
            // 
            this.invoice_header_unpaidComboBox.CausesValidation = false;
            this.invoice_header_unpaidComboBox.FormattingEnabled = true;
            this.invoice_header_unpaidComboBox.Location = new System.Drawing.Point(69, 72);
            this.invoice_header_unpaidComboBox.MaxDropDownItems = 99;
            this.invoice_header_unpaidComboBox.Name = "invoice_header_unpaidComboBox";
            this.invoice_header_unpaidComboBox.Size = new System.Drawing.Size(200, 21);
            this.invoice_header_unpaidComboBox.TabIndex = 28;
            this.invoice_header_unpaidComboBox.SelectionChangeCommitted += new System.EventHandler(this.invoice_header_unpaidComboBox_SelectionChangeCommitted);
            this.invoice_header_unpaidComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            this.invoice_header_unpaidComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // t_dateDateTimePicker
            // 
            this.t_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.t_dateDateTimePicker.Location = new System.Drawing.Point(69, 135);
            this.t_dateDateTimePicker.Name = "t_dateDateTimePicker";
            this.t_dateDateTimePicker.Size = new System.Drawing.Size(84, 20);
            this.t_dateDateTimePicker.TabIndex = 29;
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
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // iNVOICE_HEADERTableAdapter
            // 
            this.iNVOICE_HEADERTableAdapter.ClearBeforeFill = true;
            // 
            // iNVOICE_HEADERBindingSource
            // 
            this.iNVOICE_HEADERBindingSource.DataMember = "INVOICE_HEADER";
            this.iNVOICE_HEADERBindingSource.DataSource = this.dataSet2;
            // 
            // invoice_header_unpaidBindingSource
            // 
            this.invoice_header_unpaidBindingSource.AllowNew = false;
            this.invoice_header_unpaidBindingSource.DataMember = "invoice_header_unpaid";
            this.invoice_header_unpaidBindingSource.DataSource = this.dataSet2;
            // 
            // invoice_header_unpaidTableAdapter
            // 
            this.invoice_header_unpaidTableAdapter.ClearBeforeFill = true;
            // 
            // open_balTextBox
            // 
            this.open_balTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.open_balTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.open_balTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "open_bal", true));
            this.open_balTextBox.Location = new System.Drawing.Point(449, 42);
            this.open_balTextBox.Name = "open_balTextBox";
            this.open_balTextBox.ReadOnly = true;
            this.open_balTextBox.Size = new System.Drawing.Size(100, 13);
            this.open_balTextBox.TabIndex = 30;
            // 
            // cbPrintAdj
            // 
            this.cbPrintAdj.AutoSize = true;
            this.cbPrintAdj.Checked = true;
            this.cbPrintAdj.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPrintAdj.Location = new System.Drawing.Point(167, 138);
            this.cbPrintAdj.Name = "cbPrintAdj";
            this.cbPrintAdj.Size = new System.Drawing.Size(102, 17);
            this.cbPrintAdj.TabIndex = 31;
            this.cbPrintAdj.Text = "Print Adjustment";
            this.cbPrintAdj.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Note: Minus Amount for CR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Positive to Increase Invoice Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Positive to Increase Payment Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Positive to  Decrease Unall.Bal";
            // 
            // AdjustmentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 316);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPrintAdj);
            this.Controls.Add(open_balLabel);
            this.Controls.Add(this.open_balTextBox);
            this.Controls.Add(t_dateLabel1);
            this.Controls.Add(this.t_dateDateTimePicker);
            this.Controls.Add(this.invoice_header_unpaidComboBox);
            this.Controls.Add(this.paymentCB);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.name_address_1TextBox);
            this.Controls.Add(cust_idLabel);
            this.Controls.Add(this.cust_idTextBox);
            this.Controls.Add(t_idLabel);
            this.Controls.Add(this.t_idTextBox);
            this.Controls.Add(t_src_idLabel);
            this.Controls.Add(t_ref_idLabel);
            this.Controls.Add(t_noteLabel);
            this.Controls.Add(this.t_noteTextBox);
            this.Controls.Add(t_amountLabel);
            this.Controls.Add(this.t_amountTextBox);
            this.Name = "AdjustmentEdit";
            this.Text = "Adjustment";
            this.Load += new System.EventHandler(this.AdjustmentEdt_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdjustmentEdit_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.customer_transBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_HEADERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_header_unpaidBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource customer_transBindingSource;
        private Vectra.DataSet2TableAdapters.customer_transTableAdapter customer_transTableAdapter;
        private Vectra.DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox t_idTextBox;
        private System.Windows.Forms.TextBox t_noteTextBox;
        private System.Windows.Forms.TextBox t_amountTextBox;
        private Vectra.DataSet2TableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.TextBox cust_idTextBox;
        private System.Windows.Forms.TextBox name_address_1TextBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox paymentCB;
        private Devart.Data.SQLite.SQLiteConnection sqLiteConnection1;
        private Vectra.DataSet2TableAdapters.INVOICE_HEADERTableAdapter iNVOICE_HEADERTableAdapter;
        private System.Windows.Forms.BindingSource iNVOICE_HEADERBindingSource;
        private System.Windows.Forms.BindingSource invoice_header_unpaidBindingSource;
        private Vectra.DataSet2TableAdapters.invoice_header_unpaidTableAdapter invoice_header_unpaidTableAdapter;
        private System.Windows.Forms.ComboBox invoice_header_unpaidComboBox;
        private System.Windows.Forms.DateTimePicker t_dateDateTimePicker;
        private System.Windows.Forms.TextBox open_balTextBox;
        private System.Windows.Forms.CheckBox cbPrintAdj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}