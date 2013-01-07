using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace Vectra
{
    public partial class StatementReportForm : Form
    {
        public StatementReportForm()
        {
            InitializeComponent();
        }
     

        private void StatementReportForm_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt;

            this.customer_transTableAdapter1.FillBy1(this.dataSet2.customer_trans);
            this.customerTableAdapter1.Fill(this.dataSet2.customer);
            this.configurationTableAdapter1.Fill(this.dataSet2.configuration);
            this.debtors_summaryTableAdapter1.Fill(this.dataSet2.debtors_summary);

            StatementsReport rpt = new StatementsReport();
            rpt.SetDataSource(this.dataSet2);

            cryRpt = new ReportDocument();
            cryRpt.Load(rpt.FileName.ToString());
            cryRpt.SetDataSource(dataSet2);
            cryRpt.ExportToDisk(ExportFormatType.PortableDocFormat, ReportFolder.reportFolderName + @"\Statements.pdf");

        }

    }
}
