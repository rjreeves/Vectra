namespace Vectra
{
    partial class Configuration
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
            System.Windows.Forms.Label bus_addr1Label;
            System.Windows.Forms.Label bus_addr2Label;
            System.Windows.Forms.Label bus_post_codeLabel;
            System.Windows.Forms.Label bus_phoneLabel;
            System.Windows.Forms.Label gl_salesLabel;
            System.Windows.Forms.Label gl_sales_gstLabel;
            System.Windows.Forms.Label gl_bankLabel;
            System.Windows.Forms.Label gl_adjLabel;
            System.Windows.Forms.Label gl_discLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuration));
            this.configurationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.configurationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Vectra.DataSet2();
            this.configurationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bus_namesTextBox = new System.Windows.Forms.TextBox();
            this.bus_addr1TextBox = new System.Windows.Forms.TextBox();
            this.bus_addr2TextBox = new System.Windows.Forms.TextBox();
            this.bus_post_codeTextBox = new System.Windows.Forms.TextBox();
            this.bus_phoneTextBox = new System.Windows.Forms.TextBox();
            this.gl_salesTextBox = new System.Windows.Forms.TextBox();
            this.gl_sales_gstTextBox = new System.Windows.Forms.TextBox();
            this.gl_bankTextBox = new System.Windows.Forms.TextBox();
            this.gl_adjTextBox = new System.Windows.Forms.TextBox();
            this.gl_discTextBox = new System.Windows.Forms.TextBox();
            this.configurationTableAdapter = new Vectra.DataSet2TableAdapters.configurationTableAdapter();
            this.tableAdapterManager = new Vectra.DataSet2TableAdapters.TableAdapterManager();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            bus_namesLabel = new System.Windows.Forms.Label();
            bus_addr1Label = new System.Windows.Forms.Label();
            bus_addr2Label = new System.Windows.Forms.Label();
            bus_post_codeLabel = new System.Windows.Forms.Label();
            bus_phoneLabel = new System.Windows.Forms.Label();
            gl_salesLabel = new System.Windows.Forms.Label();
            gl_sales_gstLabel = new System.Windows.Forms.Label();
            gl_bankLabel = new System.Windows.Forms.Label();
            gl_adjLabel = new System.Windows.Forms.Label();
            gl_discLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingNavigator)).BeginInit();
            this.configurationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // bus_namesLabel
            // 
            bus_namesLabel.AutoSize = true;
            bus_namesLabel.Location = new System.Drawing.Point(12, 36);
            bus_namesLabel.Name = "bus_namesLabel";
            bus_namesLabel.Size = new System.Drawing.Size(61, 13);
            bus_namesLabel.TabIndex = 1;
            bus_namesLabel.Text = "bus names:";
            // 
            // bus_addr1Label
            // 
            bus_addr1Label.AutoSize = true;
            bus_addr1Label.Location = new System.Drawing.Point(12, 62);
            bus_addr1Label.Name = "bus_addr1Label";
            bus_addr1Label.Size = new System.Drawing.Size(57, 13);
            bus_addr1Label.TabIndex = 3;
            bus_addr1Label.Text = "bus addr1:";
            // 
            // bus_addr2Label
            // 
            bus_addr2Label.AutoSize = true;
            bus_addr2Label.Location = new System.Drawing.Point(12, 88);
            bus_addr2Label.Name = "bus_addr2Label";
            bus_addr2Label.Size = new System.Drawing.Size(57, 13);
            bus_addr2Label.TabIndex = 5;
            bus_addr2Label.Text = "bus addr2:";
            // 
            // bus_post_codeLabel
            // 
            bus_post_codeLabel.AutoSize = true;
            bus_post_codeLabel.Location = new System.Drawing.Point(12, 114);
            bus_post_codeLabel.Name = "bus_post_codeLabel";
            bus_post_codeLabel.Size = new System.Drawing.Size(77, 13);
            bus_post_codeLabel.TabIndex = 7;
            bus_post_codeLabel.Text = "bus post code:";
            // 
            // bus_phoneLabel
            // 
            bus_phoneLabel.AutoSize = true;
            bus_phoneLabel.Location = new System.Drawing.Point(12, 140);
            bus_phoneLabel.Name = "bus_phoneLabel";
            bus_phoneLabel.Size = new System.Drawing.Size(60, 13);
            bus_phoneLabel.TabIndex = 9;
            bus_phoneLabel.Text = "bus phone:";
            // 
            // gl_salesLabel
            // 
            gl_salesLabel.AutoSize = true;
            gl_salesLabel.Location = new System.Drawing.Point(12, 166);
            gl_salesLabel.Name = "gl_salesLabel";
            gl_salesLabel.Size = new System.Drawing.Size(45, 13);
            gl_salesLabel.TabIndex = 11;
            gl_salesLabel.Text = "gl sales:";
            // 
            // gl_sales_gstLabel
            // 
            gl_sales_gstLabel.AutoSize = true;
            gl_sales_gstLabel.Location = new System.Drawing.Point(12, 192);
            gl_sales_gstLabel.Name = "gl_sales_gstLabel";
            gl_sales_gstLabel.Size = new System.Drawing.Size(62, 13);
            gl_sales_gstLabel.TabIndex = 13;
            gl_sales_gstLabel.Text = "gl sales gst:";
            // 
            // gl_bankLabel
            // 
            gl_bankLabel.AutoSize = true;
            gl_bankLabel.Location = new System.Drawing.Point(12, 218);
            gl_bankLabel.Name = "gl_bankLabel";
            gl_bankLabel.Size = new System.Drawing.Size(45, 13);
            gl_bankLabel.TabIndex = 15;
            gl_bankLabel.Text = "gl bank:";
            // 
            // gl_adjLabel
            // 
            gl_adjLabel.AutoSize = true;
            gl_adjLabel.Location = new System.Drawing.Point(12, 244);
            gl_adjLabel.Name = "gl_adjLabel";
            gl_adjLabel.Size = new System.Drawing.Size(35, 13);
            gl_adjLabel.TabIndex = 17;
            gl_adjLabel.Text = "gl adj:";
            // 
            // gl_discLabel
            // 
            gl_discLabel.AutoSize = true;
            gl_discLabel.Location = new System.Drawing.Point(12, 270);
            gl_discLabel.Name = "gl_discLabel";
            gl_discLabel.Size = new System.Drawing.Size(40, 13);
            gl_discLabel.TabIndex = 19;
            gl_discLabel.Text = "gl disc:";
            // 
            // configurationBindingNavigator
            // 
            this.configurationBindingNavigator.AddNewItem = null;
            this.configurationBindingNavigator.BindingSource = this.configurationBindingSource;
            this.configurationBindingNavigator.CountItem = null;
            this.configurationBindingNavigator.DeleteItem = null;
            this.configurationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationBindingNavigatorSaveItem});
            this.configurationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.configurationBindingNavigator.MoveFirstItem = null;
            this.configurationBindingNavigator.MoveLastItem = null;
            this.configurationBindingNavigator.MoveNextItem = null;
            this.configurationBindingNavigator.MovePreviousItem = null;
            this.configurationBindingNavigator.Name = "configurationBindingNavigator";
            this.configurationBindingNavigator.PositionItem = null;
            this.configurationBindingNavigator.Size = new System.Drawing.Size(597, 25);
            this.configurationBindingNavigator.TabIndex = 0;
            this.configurationBindingNavigator.Text = "bindingNavigator1";
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
            // configurationBindingNavigatorSaveItem
            // 
            this.configurationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("configurationBindingNavigatorSaveItem.Image")));
            this.configurationBindingNavigatorSaveItem.Name = "configurationBindingNavigatorSaveItem";
            this.configurationBindingNavigatorSaveItem.Size = new System.Drawing.Size(77, 22);
            this.configurationBindingNavigatorSaveItem.Text = "Save Data";
            this.configurationBindingNavigatorSaveItem.Click += new System.EventHandler(this.configurationBindingNavigatorSaveItem_Click);
            // 
            // bus_namesTextBox
            // 
            this.bus_namesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationBindingSource, "bus_names", true));
            this.bus_namesTextBox.Location = new System.Drawing.Point(95, 33);
            this.bus_namesTextBox.Name = "bus_namesTextBox";
            this.bus_namesTextBox.Size = new System.Drawing.Size(347, 20);
            this.bus_namesTextBox.TabIndex = 2;
            // 
            // bus_addr1TextBox
            // 
            this.bus_addr1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationBindingSource, "bus_addr1", true));
            this.bus_addr1TextBox.Location = new System.Drawing.Point(95, 59);
            this.bus_addr1TextBox.Name = "bus_addr1TextBox";
            this.bus_addr1TextBox.Size = new System.Drawing.Size(347, 20);
            this.bus_addr1TextBox.TabIndex = 4;
            // 
            // bus_addr2TextBox
            // 
            this.bus_addr2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationBindingSource, "bus_addr2", true));
            this.bus_addr2TextBox.Location = new System.Drawing.Point(95, 85);
            this.bus_addr2TextBox.Name = "bus_addr2TextBox";
            this.bus_addr2TextBox.Size = new System.Drawing.Size(347, 20);
            this.bus_addr2TextBox.TabIndex = 6;
            // 
            // bus_post_codeTextBox
            // 
            this.bus_post_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationBindingSource, "bus_post_code", true));
            this.bus_post_codeTextBox.Location = new System.Drawing.Point(95, 111);
            this.bus_post_codeTextBox.Name = "bus_post_codeTextBox";
            this.bus_post_codeTextBox.Size = new System.Drawing.Size(347, 20);
            this.bus_post_codeTextBox.TabIndex = 8;
            // 
            // bus_phoneTextBox
            // 
            this.bus_phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationBindingSource, "bus_phone", true));
            this.bus_phoneTextBox.Location = new System.Drawing.Point(95, 137);
            this.bus_phoneTextBox.Name = "bus_phoneTextBox";
            this.bus_phoneTextBox.Size = new System.Drawing.Size(347, 20);
            this.bus_phoneTextBox.TabIndex = 10;
            // 
            // gl_salesTextBox
            // 
            this.gl_salesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationBindingSource, "gl_sales", true));
            this.gl_salesTextBox.Location = new System.Drawing.Point(95, 163);
            this.gl_salesTextBox.Name = "gl_salesTextBox";
            this.gl_salesTextBox.Size = new System.Drawing.Size(100, 20);
            this.gl_salesTextBox.TabIndex = 12;
            // 
            // gl_sales_gstTextBox
            // 
            this.gl_sales_gstTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationBindingSource, "gl_sales_gst", true));
            this.gl_sales_gstTextBox.Location = new System.Drawing.Point(95, 189);
            this.gl_sales_gstTextBox.Name = "gl_sales_gstTextBox";
            this.gl_sales_gstTextBox.Size = new System.Drawing.Size(100, 20);
            this.gl_sales_gstTextBox.TabIndex = 14;
            // 
            // gl_bankTextBox
            // 
            this.gl_bankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationBindingSource, "gl_bank", true));
            this.gl_bankTextBox.Location = new System.Drawing.Point(95, 215);
            this.gl_bankTextBox.Name = "gl_bankTextBox";
            this.gl_bankTextBox.Size = new System.Drawing.Size(100, 20);
            this.gl_bankTextBox.TabIndex = 16;
            // 
            // gl_adjTextBox
            // 
            this.gl_adjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationBindingSource, "gl_adj", true));
            this.gl_adjTextBox.Location = new System.Drawing.Point(95, 241);
            this.gl_adjTextBox.Name = "gl_adjTextBox";
            this.gl_adjTextBox.Size = new System.Drawing.Size(100, 20);
            this.gl_adjTextBox.TabIndex = 18;
            // 
            // gl_discTextBox
            // 
            this.gl_discTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationBindingSource, "gl_disc", true));
            this.gl_discTextBox.Location = new System.Drawing.Point(95, 267);
            this.gl_discTextBox.Name = "gl_discTextBox";
            this.gl_discTextBox.Size = new System.Drawing.Size(100, 20);
            this.gl_discTextBox.TabIndex = 20;
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
            this.tableAdapterManager.product_typeTableAdapter = null;
            this.tableAdapterManager.ProductSalesSummaryTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.sqlite_sequenceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Vectra.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 456);
            this.Controls.Add(bus_namesLabel);
            this.Controls.Add(this.bus_namesTextBox);
            this.Controls.Add(bus_addr1Label);
            this.Controls.Add(this.bus_addr1TextBox);
            this.Controls.Add(bus_addr2Label);
            this.Controls.Add(this.bus_addr2TextBox);
            this.Controls.Add(bus_post_codeLabel);
            this.Controls.Add(this.bus_post_codeTextBox);
            this.Controls.Add(bus_phoneLabel);
            this.Controls.Add(this.bus_phoneTextBox);
            this.Controls.Add(gl_salesLabel);
            this.Controls.Add(this.gl_salesTextBox);
            this.Controls.Add(gl_sales_gstLabel);
            this.Controls.Add(this.gl_sales_gstTextBox);
            this.Controls.Add(gl_bankLabel);
            this.Controls.Add(this.gl_bankTextBox);
            this.Controls.Add(gl_adjLabel);
            this.Controls.Add(this.gl_adjTextBox);
            this.Controls.Add(gl_discLabel);
            this.Controls.Add(this.gl_discTextBox);
            this.Controls.Add(this.configurationBindingNavigator);
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.Configuration_Load);
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
        private System.Windows.Forms.ToolStripButton configurationBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox bus_namesTextBox;
        private System.Windows.Forms.TextBox bus_addr1TextBox;
        private System.Windows.Forms.TextBox bus_addr2TextBox;
        private System.Windows.Forms.TextBox bus_post_codeTextBox;
        private System.Windows.Forms.TextBox bus_phoneTextBox;
        private System.Windows.Forms.TextBox gl_salesTextBox;
        private System.Windows.Forms.TextBox gl_sales_gstTextBox;
        private System.Windows.Forms.TextBox gl_bankTextBox;
        private System.Windows.Forms.TextBox gl_adjTextBox;
        private System.Windows.Forms.TextBox gl_discTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}