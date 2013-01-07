namespace Vectra
{
    partial class ATBReportForm
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
            this.customerTableAdapter1 = new Vectra.DataSet2TableAdapters.customerTableAdapter();
            this.dataSet21 = new Vectra.DataSet2();
            this.debtors_summaryTableAdapter1 = new Vectra.DataSet2TableAdapters.debtors_summaryTableAdapter();
            this.ATBReport1 = new Vectra.ATBReport();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
            this.SuspendLayout();
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet21
            // 
            this.dataSet21.DataSetName = "DataSet2";
            this.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // debtors_summaryTableAdapter1
            // 
            this.debtors_summaryTableAdapter1.ClearBeforeFill = true;
            // 
            // ATBReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 81);
            this.Name = "ATBReportForm";
            this.Text = "ATBReportForm";
            this.Load += new System.EventHandler(this.ATBReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Vectra.DataSet2TableAdapters.customerTableAdapter customerTableAdapter1;
        private DataSet2 dataSet21;
        private Vectra.DataSet2TableAdapters.debtors_summaryTableAdapter debtors_summaryTableAdapter1;
        private ATBReport ATBReport1;
    }
}