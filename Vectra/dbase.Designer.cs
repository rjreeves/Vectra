namespace Vectra
{
    partial class dbase
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
            this.dataSet3 = new Vectra.DataSet3();
            this.configurationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configurationTableAdapter = new Vectra.DataSet3TableAdapters.configurationTableAdapter();
            this.tableAdapterManager = new Vectra.DataSet3TableAdapters.TableAdapterManager();
            this.table_namesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_namesTableAdapter = new Vectra.DataSet3TableAdapters.table_namesTableAdapter();
            this.table_namesComboBox = new System.Windows.Forms.ComboBox();
            this.bus_namesTextBox = new System.Windows.Forms.TextBox();
            this.table_metaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_metaTableAdapter = new Vectra.DataSet3TableAdapters.table_metaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_namesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_metaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // configurationBindingSource
            // 
            this.configurationBindingSource.DataMember = "configuration";
            this.configurationBindingSource.DataSource = this.dataSet3;
            // 
            // configurationTableAdapter
            // 
            this.configurationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.configurationTableAdapter = this.configurationTableAdapter;
            this.tableAdapterManager.UpdateOrder = Vectra.DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table_namesBindingSource
            // 
            this.table_namesBindingSource.DataMember = "table_names";
            this.table_namesBindingSource.DataSource = this.dataSet3;
            // 
            // table_namesTableAdapter
            // 
            this.table_namesTableAdapter.ClearBeforeFill = true;
            // 
            // table_namesComboBox
            // 
            this.table_namesComboBox.DataSource = this.table_namesBindingSource;
            this.table_namesComboBox.DisplayMember = "name";
            this.table_namesComboBox.FormattingEnabled = true;
            this.table_namesComboBox.Location = new System.Drawing.Point(5, 40);
            this.table_namesComboBox.Name = "table_namesComboBox";
            this.table_namesComboBox.Size = new System.Drawing.Size(300, 21);
            this.table_namesComboBox.TabIndex = 2;
            this.table_namesComboBox.Text = ". ";
            this.table_namesComboBox.ValueMember = "name";
            // 
            // bus_namesTextBox
            // 
            this.bus_namesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bus_namesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationBindingSource, "bus_names", true));
            this.bus_namesTextBox.Location = new System.Drawing.Point(5, 12);
            this.bus_namesTextBox.Name = "bus_namesTextBox";
            this.bus_namesTextBox.Size = new System.Drawing.Size(307, 13);
            this.bus_namesTextBox.TabIndex = 3;
            // 
            // table_metaBindingSource
            // 
            this.table_metaBindingSource.DataMember = "table_meta";
            this.table_metaBindingSource.DataSource = this.dataSet3;
            // 
            // table_metaTableAdapter
            // 
            this.table_metaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Get It";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 128);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(520, 581);
            this.textBox1.TabIndex = 5;
            // 
            // dbase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 721);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bus_namesTextBox);
            this.Controls.Add(this.table_namesComboBox);
            this.Name = "dbase";
            this.Text = "dbase";
            this.Load += new System.EventHandler(this.dbase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_namesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_metaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource configurationBindingSource;
        private Vectra.DataSet3TableAdapters.configurationTableAdapter configurationTableAdapter;
        private Vectra.DataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource table_namesBindingSource;
        private Vectra.DataSet3TableAdapters.table_namesTableAdapter table_namesTableAdapter;
        private System.Windows.Forms.ComboBox table_namesComboBox;
        private System.Windows.Forms.TextBox bus_namesTextBox;
        private System.Windows.Forms.BindingSource table_metaBindingSource;
        private Vectra.DataSet3TableAdapters.table_metaTableAdapter table_metaTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}