namespace Vectra.DBA
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.conn = new Devart.Data.SQLite.SQLiteConnection();
            this.sqLiteCommand1 = new Devart.Data.SQLite.SQLiteCommand();
            this.sqLiteCommand2 = new Devart.Data.SQLite.SQLiteCommand();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aRToolStripMenuItem
            // 
            this.aRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billingToolStripMenuItem,
            this.receiptsToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem1});
            this.aRToolStripMenuItem.Name = "aRToolStripMenuItem";
            this.aRToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.aRToolStripMenuItem.Text = "A-R";
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.billingToolStripMenuItem.Text = "Billing";
            this.billingToolStripMenuItem.Click += new System.EventHandler(this.billingToolStripMenuItem_Click);
            // 
            // receiptsToolStripMenuItem
            // 
            this.receiptsToolStripMenuItem.Name = "receiptsToolStripMenuItem";
            this.receiptsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.receiptsToolStripMenuItem.Text = "Receipts";
            this.receiptsToolStripMenuItem.Click += new System.EventHandler(this.receiptsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem1.Text = "Clear Transactions";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // conn
            // 
            this.conn.ConnectionString = "Data Source=\"C:\\Documents and Settings\\All Users\\Application Data\\Vectra\\Data\\PRO" +
                "D.db3\";";
            this.conn.Name = "conn";
            this.conn.Owner = this;
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = "delete from debtors_summary;\ndelete from customer_trans;\ndelete from invoice_head" +
                "er;\ndelete from invoice_items;\ndelete from invoice_reciepts;\nupdate customer set" +
                " open_bal = 0;\n\n\n";
            this.sqLiteCommand1.Connection = this.conn;
            this.sqLiteCommand1.Name = "sqLiteCommand1";
            this.sqLiteCommand1.Owner = this;
            // 
            // sqLiteCommand2
            // 
            this.sqLiteCommand2.Name = "sqLiteCommand2";
            this.sqLiteCommand2.Owner = this;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 33);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Vectra.DBA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private Devart.Data.SQLite.SQLiteConnection conn;
        private Devart.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private Devart.Data.SQLite.SQLiteCommand sqLiteCommand2;
    }
}

