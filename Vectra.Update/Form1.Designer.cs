namespace Vectra.Update
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sqLiteConnection1 = new Devart.Data.SQLite.SQLiteConnection();
            this.sqLiteCommand1 = new Devart.Data.SQLite.SQLiteCommand();
            this.sqLiteCommand2 = new Devart.Data.SQLite.SQLiteCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.sqLiteCommand1.CommandText = "DROP TABLE debtors_summary;";
            this.sqLiteCommand1.Connection = this.sqLiteConnection1;
            this.sqLiteCommand1.Name = "sqLiteCommand1";
            this.sqLiteCommand1.Owner = this;
            // 
            // sqLiteCommand2
            // 
            this.sqLiteCommand2.CommandText = "CREATE TABLE \"debtors_summary\" (\n\"cust_id\"  INTEGER NOT NULL,\n\"curAmt\"  REAL,\n\"da" +
                "ys7\"  REAL,\n\"days14\"  REAL,\n\"days21\"  REAL,\n\"date_last_payment\"  TEXT,\n\"Owing\"  " +
                "REAL\n);\n";
            this.sqLiteCommand2.Connection = this.sqLiteConnection1;
            this.sqLiteCommand2.Name = "sqLiteCommand2";
            this.sqLiteCommand2.Owner = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 107);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Vectra Table Update";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Devart.Data.SQLite.SQLiteConnection sqLiteConnection1;
        private Devart.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private Devart.Data.SQLite.SQLiteCommand sqLiteCommand2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

