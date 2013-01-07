namespace Vectra.DBA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipts));
            this.iNVOICE_RECIEPTSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.iNVOICE_RECIEPTSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iNVOICE_RECIEPTSDataGridView = new System.Windows.Forms.DataGridView();
            this.iNVOICE_RECIEPTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Vectra.DBA.DataSet1();
            this.iNVOICE_RECIEPTSTableAdapter = new Vectra.DBA.DataSet1TableAdapters.INVOICE_RECIEPTSTableAdapter();
            this.tableAdapterManager = new Vectra.DBA.DataSet1TableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recpt_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_RECIEPTSBindingNavigator)).BeginInit();
            this.iNVOICE_RECIEPTSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_RECIEPTSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_RECIEPTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // iNVOICE_RECIEPTSBindingNavigator
            // 
            this.iNVOICE_RECIEPTSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iNVOICE_RECIEPTSBindingNavigator.BindingSource = this.iNVOICE_RECIEPTSBindingSource;
            this.iNVOICE_RECIEPTSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iNVOICE_RECIEPTSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iNVOICE_RECIEPTSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.iNVOICE_RECIEPTSBindingNavigatorSaveItem});
            this.iNVOICE_RECIEPTSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iNVOICE_RECIEPTSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iNVOICE_RECIEPTSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iNVOICE_RECIEPTSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iNVOICE_RECIEPTSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iNVOICE_RECIEPTSBindingNavigator.Name = "iNVOICE_RECIEPTSBindingNavigator";
            this.iNVOICE_RECIEPTSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iNVOICE_RECIEPTSBindingNavigator.Size = new System.Drawing.Size(467, 25);
            this.iNVOICE_RECIEPTSBindingNavigator.TabIndex = 0;
            this.iNVOICE_RECIEPTSBindingNavigator.Text = "bindingNavigator1";
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
            // iNVOICE_RECIEPTSBindingNavigatorSaveItem
            // 
            this.iNVOICE_RECIEPTSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iNVOICE_RECIEPTSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iNVOICE_RECIEPTSBindingNavigatorSaveItem.Image")));
            this.iNVOICE_RECIEPTSBindingNavigatorSaveItem.Name = "iNVOICE_RECIEPTSBindingNavigatorSaveItem";
            this.iNVOICE_RECIEPTSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.iNVOICE_RECIEPTSBindingNavigatorSaveItem.Text = "Save Data";
            this.iNVOICE_RECIEPTSBindingNavigatorSaveItem.Click += new System.EventHandler(this.iNVOICE_RECIEPTSBindingNavigatorSaveItem_Click);
            // 
            // iNVOICE_RECIEPTSDataGridView
            // 
            this.iNVOICE_RECIEPTSDataGridView.AutoGenerateColumns = false;
            this.iNVOICE_RECIEPTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iNVOICE_RECIEPTSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.recpt_date,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.iNVOICE_RECIEPTSDataGridView.DataSource = this.iNVOICE_RECIEPTSBindingSource;
            this.iNVOICE_RECIEPTSDataGridView.Location = new System.Drawing.Point(0, 28);
            this.iNVOICE_RECIEPTSDataGridView.Name = "iNVOICE_RECIEPTSDataGridView";
            this.iNVOICE_RECIEPTSDataGridView.Size = new System.Drawing.Size(464, 385);
            this.iNVOICE_RECIEPTSDataGridView.TabIndex = 1;
            // 
            // iNVOICE_RECIEPTSBindingSource
            // 
            this.iNVOICE_RECIEPTSBindingSource.DataMember = "INVOICE_RECIEPTS";
            this.iNVOICE_RECIEPTSBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNVOICE_RECIEPTSTableAdapter
            // 
            this.iNVOICE_RECIEPTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customer_transTableAdapter = null;
            this.tableAdapterManager.INVOICE_HEADERTableAdapter = null;
            this.tableAdapterManager.invoice_itemsTableAdapter = null;
            this.tableAdapterManager.INVOICE_RECIEPTSTableAdapter = this.iNVOICE_RECIEPTSTableAdapter;
            this.tableAdapterManager.UpdateOrder = Vectra.DBA.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "recpt_number";
            this.dataGridViewTextBoxColumn1.HeaderText = "recpt_number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // recpt_date
            // 
            this.recpt_date.DataPropertyName = "recpt_date";
            this.recpt_date.HeaderText = "recpt_date";
            this.recpt_date.Name = "recpt_date";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "invoice_number";
            this.dataGridViewTextBoxColumn2.HeaderText = "invoice_number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Receipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 415);
            this.Controls.Add(this.iNVOICE_RECIEPTSDataGridView);
            this.Controls.Add(this.iNVOICE_RECIEPTSBindingNavigator);
            this.Name = "Receipts";
            this.Text = "Receipts";
            this.Load += new System.EventHandler(this.Receipts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_RECIEPTSBindingNavigator)).EndInit();
            this.iNVOICE_RECIEPTSBindingNavigator.ResumeLayout(false);
            this.iNVOICE_RECIEPTSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_RECIEPTSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_RECIEPTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource iNVOICE_RECIEPTSBindingSource;
        private Vectra.DBA.DataSet1TableAdapters.INVOICE_RECIEPTSTableAdapter iNVOICE_RECIEPTSTableAdapter;
        private Vectra.DBA.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iNVOICE_RECIEPTSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton iNVOICE_RECIEPTSBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView iNVOICE_RECIEPTSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn recpt_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}