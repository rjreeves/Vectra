namespace Vectra
{
    partial class CustomerEdit
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
            System.Windows.Forms.Label name_address_1Label;
            System.Windows.Forms.Label name_address_2Label;
            System.Windows.Forms.Label name_address_3Label;
            System.Windows.Forms.Label name_address_4Label;
            System.Windows.Forms.Label pcodeLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label contact_nameLabel;
            System.Windows.Forms.Label abnLabel;
            System.Windows.Forms.Label credit_ratingLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label dunningLabel;
            System.Windows.Forms.Label avg_paymentLabel;
            System.Windows.Forms.Label open_balLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerEdit));
            this.cust_idTextBox = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Vectra.DataSet2();
            this.name_address_1TextBox = new System.Windows.Forms.TextBox();
            this.name_address_2TextBox = new System.Windows.Forms.TextBox();
            this.name_address_3TextBox = new System.Windows.Forms.TextBox();
            this.name_address_4TextBox = new System.Windows.Forms.TextBox();
            this.pcodeTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.contact_nameTextBox = new System.Windows.Forms.TextBox();
            this.abnTextBox = new System.Windows.Forms.TextBox();
            this.credit_ratingTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.dunningTextBox = new System.Windows.Forms.TextBox();
            this.avg_paymentTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.open_balTextBox = new System.Windows.Forms.TextBox();
            this.btnDeleteCust = new System.Windows.Forms.Button();
            this.customerTableAdapter = new Vectra.DataSet2TableAdapters.customerTableAdapter();
            this.tableAdapterManager = new Vectra.DataSet2TableAdapters.TableAdapterManager();
            cust_idLabel = new System.Windows.Forms.Label();
            name_address_1Label = new System.Windows.Forms.Label();
            name_address_2Label = new System.Windows.Forms.Label();
            name_address_3Label = new System.Windows.Forms.Label();
            name_address_4Label = new System.Windows.Forms.Label();
            pcodeLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            contact_nameLabel = new System.Windows.Forms.Label();
            abnLabel = new System.Windows.Forms.Label();
            credit_ratingLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            dunningLabel = new System.Windows.Forms.Label();
            avg_paymentLabel = new System.Windows.Forms.Label();
            open_balLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // cust_idLabel
            // 
            cust_idLabel.AutoSize = true;
            cust_idLabel.Location = new System.Drawing.Point(26, 15);
            cust_idLabel.Name = "cust_idLabel";
            cust_idLabel.Size = new System.Drawing.Size(68, 13);
            cust_idLabel.TabIndex = 1;
            cust_idLabel.Text = "Customer ID:";
            // 
            // name_address_1Label
            // 
            name_address_1Label.AutoSize = true;
            name_address_1Label.Location = new System.Drawing.Point(9, 43);
            name_address_1Label.Name = "name_address_1Label";
            name_address_1Label.Size = new System.Drawing.Size(85, 13);
            name_address_1Label.TabIndex = 3;
            name_address_1Label.Text = "Customer Name:";
            // 
            // name_address_2Label
            // 
            name_address_2Label.AutoSize = true;
            name_address_2Label.Location = new System.Drawing.Point(46, 71);
            name_address_2Label.Name = "name_address_2Label";
            name_address_2Label.Size = new System.Drawing.Size(48, 13);
            name_address_2Label.TabIndex = 5;
            name_address_2Label.Text = "Address:";
            // 
            // name_address_3Label
            // 
            name_address_3Label.AutoSize = true;
            name_address_3Label.Location = new System.Drawing.Point(9, 93);
            name_address_3Label.Name = "name_address_3Label";
            name_address_3Label.Size = new System.Drawing.Size(0, 13);
            name_address_3Label.TabIndex = 7;
            // 
            // name_address_4Label
            // 
            name_address_4Label.AutoSize = true;
            name_address_4Label.Location = new System.Drawing.Point(57, 127);
            name_address_4Label.Name = "name_address_4Label";
            name_address_4Label.Size = new System.Drawing.Size(37, 13);
            name_address_4Label.TabIndex = 9;
            name_address_4Label.Text = "Town:";
            // 
            // pcodeLabel
            // 
            pcodeLabel.AutoSize = true;
            pcodeLabel.Location = new System.Drawing.Point(39, 155);
            pcodeLabel.Name = "pcodeLabel";
            pcodeLabel.Size = new System.Drawing.Size(55, 13);
            pcodeLabel.TabIndex = 11;
            pcodeLabel.Text = "Postcode:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(53, 183);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 13;
            phoneLabel.Text = "Phone:";
            // 
            // contact_nameLabel
            // 
            contact_nameLabel.AutoSize = true;
            contact_nameLabel.Location = new System.Drawing.Point(16, 211);
            contact_nameLabel.Name = "contact_nameLabel";
            contact_nameLabel.Size = new System.Drawing.Size(78, 13);
            contact_nameLabel.TabIndex = 15;
            contact_nameLabel.Text = "Contact Name:";
            // 
            // abnLabel
            // 
            abnLabel.AutoSize = true;
            abnLabel.Location = new System.Drawing.Point(62, 239);
            abnLabel.Name = "abnLabel";
            abnLabel.Size = new System.Drawing.Size(32, 13);
            abnLabel.TabIndex = 17;
            abnLabel.Text = "ABN:";
            // 
            // credit_ratingLabel
            // 
            credit_ratingLabel.AutoSize = true;
            credit_ratingLabel.Location = new System.Drawing.Point(210, 239);
            credit_ratingLabel.Name = "credit_ratingLabel";
            credit_ratingLabel.Size = new System.Drawing.Size(71, 13);
            credit_ratingLabel.TabIndex = 19;
            credit_ratingLabel.Text = "Credit Rating:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(56, 292);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(38, 13);
            notesLabel.TabIndex = 21;
            notesLabel.Text = "Notes:";
            // 
            // dunningLabel
            // 
            dunningLabel.AutoSize = true;
            dunningLabel.Location = new System.Drawing.Point(44, 267);
            dunningLabel.Name = "dunningLabel";
            dunningLabel.Size = new System.Drawing.Size(50, 13);
            dunningLabel.TabIndex = 23;
            dunningLabel.Text = "Dunning:";
            // 
            // avg_paymentLabel
            // 
            avg_paymentLabel.AutoSize = true;
            avg_paymentLabel.Location = new System.Drawing.Point(411, 15);
            avg_paymentLabel.Name = "avg_paymentLabel";
            avg_paymentLabel.Size = new System.Drawing.Size(94, 13);
            avg_paymentLabel.TabIndex = 25;
            avg_paymentLabel.Text = "Average Payment:";
            // 
            // open_balLabel
            // 
            open_balLabel.AutoSize = true;
            open_balLabel.Location = new System.Drawing.Point(427, 239);
            open_balLabel.Name = "open_balLabel";
            open_balLabel.Size = new System.Drawing.Size(78, 13);
            open_balLabel.TabIndex = 30;
            open_balLabel.Text = "Open Balance:";
            // 
            // cust_idTextBox
            // 
            this.cust_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "cust_id", true));
            this.cust_idTextBox.Location = new System.Drawing.Point(100, 11);
            this.cust_idTextBox.Name = "cust_idTextBox";
            this.cust_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.cust_idTextBox.TabIndex = 0;
            this.cust_idTextBox.Leave += new System.EventHandler(this.cust_idTextBox_Leave);
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
            // name_address_1TextBox
            // 
            this.name_address_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "name_address_1", true));
            this.name_address_1TextBox.Location = new System.Drawing.Point(100, 39);
            this.name_address_1TextBox.Name = "name_address_1TextBox";
            this.name_address_1TextBox.Size = new System.Drawing.Size(510, 20);
            this.name_address_1TextBox.TabIndex = 1;
            // 
            // name_address_2TextBox
            // 
            this.name_address_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "name_address_2", true));
            this.name_address_2TextBox.Location = new System.Drawing.Point(100, 67);
            this.name_address_2TextBox.Name = "name_address_2TextBox";
            this.name_address_2TextBox.Size = new System.Drawing.Size(510, 20);
            this.name_address_2TextBox.TabIndex = 2;
            // 
            // name_address_3TextBox
            // 
            this.name_address_3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "name_address_3", true));
            this.name_address_3TextBox.Location = new System.Drawing.Point(100, 95);
            this.name_address_3TextBox.Name = "name_address_3TextBox";
            this.name_address_3TextBox.Size = new System.Drawing.Size(510, 20);
            this.name_address_3TextBox.TabIndex = 3;
            // 
            // name_address_4TextBox
            // 
            this.name_address_4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "name_address_4", true));
            this.name_address_4TextBox.Location = new System.Drawing.Point(100, 123);
            this.name_address_4TextBox.Name = "name_address_4TextBox";
            this.name_address_4TextBox.Size = new System.Drawing.Size(510, 20);
            this.name_address_4TextBox.TabIndex = 4;
            // 
            // pcodeTextBox
            // 
            this.pcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "pcode", true));
            this.pcodeTextBox.Location = new System.Drawing.Point(100, 151);
            this.pcodeTextBox.Name = "pcodeTextBox";
            this.pcodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.pcodeTextBox.TabIndex = 5;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(100, 179);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(301, 20);
            this.phoneTextBox.TabIndex = 6;
            // 
            // contact_nameTextBox
            // 
            this.contact_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "contact_name", true));
            this.contact_nameTextBox.Location = new System.Drawing.Point(100, 207);
            this.contact_nameTextBox.Name = "contact_nameTextBox";
            this.contact_nameTextBox.Size = new System.Drawing.Size(510, 20);
            this.contact_nameTextBox.TabIndex = 7;
            // 
            // abnTextBox
            // 
            this.abnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "abn", true));
            this.abnTextBox.Location = new System.Drawing.Point(100, 235);
            this.abnTextBox.Name = "abnTextBox";
            this.abnTextBox.Size = new System.Drawing.Size(100, 20);
            this.abnTextBox.TabIndex = 8;
            // 
            // credit_ratingTextBox
            // 
            this.credit_ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "credit_rating", true));
            this.credit_ratingTextBox.Location = new System.Drawing.Point(281, 235);
            this.credit_ratingTextBox.Name = "credit_ratingTextBox";
            this.credit_ratingTextBox.Size = new System.Drawing.Size(100, 20);
            this.credit_ratingTextBox.TabIndex = 9;
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(99, 291);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(510, 155);
            this.notesTextBox.TabIndex = 11;
            // 
            // dunningTextBox
            // 
            this.dunningTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "dunning", true));
            this.dunningTextBox.Location = new System.Drawing.Point(99, 263);
            this.dunningTextBox.Name = "dunningTextBox";
            this.dunningTextBox.Size = new System.Drawing.Size(510, 20);
            this.dunningTextBox.TabIndex = 10;
            // 
            // avg_paymentTextBox
            // 
            this.avg_paymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "avg_payment", true));
            this.avg_paymentTextBox.Location = new System.Drawing.Point(509, 11);
            this.avg_paymentTextBox.Name = "avg_paymentTextBox";
            this.avg_paymentTextBox.Size = new System.Drawing.Size(100, 20);
            this.avg_paymentTextBox.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(100, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(200, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 22);
            this.button2.TabIndex = 13;
            this.button2.Text = "Discard";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Leave += new System.EventHandler(this.button2_Leave);
            // 
            // open_balTextBox
            // 
            this.open_balTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "open_bal", true));
            this.open_balTextBox.Location = new System.Drawing.Point(509, 235);
            this.open_balTextBox.Name = "open_balTextBox";
            this.open_balTextBox.Size = new System.Drawing.Size(100, 20);
            this.open_balTextBox.TabIndex = 31;
            // 
            // btnDeleteCust
            // 
            this.btnDeleteCust.Location = new System.Drawing.Point(509, 473);
            this.btnDeleteCust.Name = "btnDeleteCust";
            this.btnDeleteCust.Size = new System.Drawing.Size(101, 23);
            this.btnDeleteCust.TabIndex = 32;
            this.btnDeleteCust.Text = "Customer Delete";
            this.btnDeleteCust.UseVisualStyleBackColor = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.configurationTableAdapter = null;
            this.tableAdapterManager.customer_transTableAdapter = null;
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
            this.tableAdapterManager.PaymentAdjustRptTableAdapter = null;
            this.tableAdapterManager.product_typeTableAdapter = null;
            this.tableAdapterManager.ProductSalesReportTableAdapter = null;
            this.tableAdapterManager.ProductSalesSummaryTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.SalesSummary1TableAdapter = null;
            this.tableAdapterManager.sqlite_sequenceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Vectra.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // CustomerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 516);
            this.Controls.Add(this.btnDeleteCust);
            this.Controls.Add(open_balLabel);
            this.Controls.Add(this.open_balTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(cust_idLabel);
            this.Controls.Add(this.cust_idTextBox);
            this.Controls.Add(name_address_1Label);
            this.Controls.Add(this.name_address_1TextBox);
            this.Controls.Add(name_address_2Label);
            this.Controls.Add(this.name_address_2TextBox);
            this.Controls.Add(name_address_3Label);
            this.Controls.Add(this.name_address_3TextBox);
            this.Controls.Add(name_address_4Label);
            this.Controls.Add(this.name_address_4TextBox);
            this.Controls.Add(pcodeLabel);
            this.Controls.Add(this.pcodeTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(contact_nameLabel);
            this.Controls.Add(this.contact_nameTextBox);
            this.Controls.Add(abnLabel);
            this.Controls.Add(this.abnTextBox);
            this.Controls.Add(credit_ratingLabel);
            this.Controls.Add(this.credit_ratingTextBox);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(dunningLabel);
            this.Controls.Add(this.dunningTextBox);
            this.Controls.Add(avg_paymentLabel);
            this.Controls.Add(this.avg_paymentTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerEdit";
            this.Text = "Customer Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerEdit_FormClosing);
            this.Load += new System.EventHandler(this.CustomerEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Vectra.DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cust_idTextBox;
        private System.Windows.Forms.TextBox name_address_1TextBox;
        private System.Windows.Forms.TextBox name_address_2TextBox;
        private System.Windows.Forms.TextBox name_address_3TextBox;
        private System.Windows.Forms.TextBox name_address_4TextBox;
        private System.Windows.Forms.TextBox pcodeTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox contact_nameTextBox;
        private System.Windows.Forms.TextBox abnTextBox;
        private System.Windows.Forms.TextBox credit_ratingTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox dunningTextBox;
        private System.Windows.Forms.TextBox avg_paymentTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Vectra.DataSet2TableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.TextBox open_balTextBox;
        private System.Windows.Forms.Button btnDeleteCust;
    }
}