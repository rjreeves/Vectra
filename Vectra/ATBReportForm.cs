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
    public partial class ATBReportForm : Form
    {
        public ATBReportForm()
        {
            InitializeComponent();
        }

        private void ATBReportForm_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt;


            this.debtors_summaryTableAdapter1.Fill(this.dataSet21.debtors_summary);
            this.customerTableAdapter1.Fill(this.dataSet21.customer);
            ATBReport rpt = new ATBReport();
            rpt.SetDataSource(this.dataSet21);
            rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;

            cryRpt = new ReportDocument();
            cryRpt.Load(rpt.FileName.ToString());
            cryRpt.SetDataSource(dataSet21);
            cryRpt.ExportToDisk(ExportFormatType.PortableDocFormat, ReportFolder.reportFolderName + @"\AgedTrialBalance.pdf");
            
        }
    }
}
