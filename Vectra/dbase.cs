using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Devart.Data.SQLite;
using System.Configuration;


namespace Vectra
{
    public partial class dbase : Form
    {
        public string sql_cmd;
        public string sql_conn;



        public dbase()
        {
            InitializeComponent();
        }

        private void dbase_Load(object sender, EventArgs e)
        {
            this.table_metaTableAdapter.Fill(this.dataSet3.table_meta);
            this.table_namesTableAdapter.Fill(this.dataSet3.table_names);            
            this.configurationTableAdapter.Fill(this.dataSet3.configuration);


        }

        private void configurationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.configurationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected_table = table_namesComboBox.Text;
            table_metaBindingSource.Position = table_metaBindingSource.Find("Name", selected_table);
            DataRowView drv = (DataRowView)table_metaBindingSource.Current;

            this.textBox1.Text = drv[1].ToString();
        }

    }
}
