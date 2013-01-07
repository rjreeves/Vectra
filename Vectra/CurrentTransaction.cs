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
    public partial class CurrentTransaction : Form
    {
        public CurrentTransaction()
        {
            InitializeComponent();
        }
    
        private void CurrentTransaction_Load(object sender, EventArgs e)
        {
            try
            {
                this.iNVOICE_HEADERTableAdapter.FillByRecent(this.dataSet2.INVOICE_HEADER);
            }
            catch(Exception ex) { ; }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
