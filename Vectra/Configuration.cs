using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vectra
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
        }

        private void configurationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.configurationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.configuration' table. You can move, or remove it, as needed.
            this.configurationTableAdapter.Fill(this.dataSet2.configuration);
            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }
    }
}
