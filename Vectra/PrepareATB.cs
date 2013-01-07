using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace Vectra
{
    static class PrepareATB
    {
        static public void prepareATB()
        {
            ReportDocument cryRpt;
            DataSet2 dataSet2 = new DataSet2();
            Vectra.DataSet2TableAdapters.debtors_summaryTableAdapter debtors_summaryTableAdapter1 = new Vectra.DataSet2TableAdapters.debtors_summaryTableAdapter();
            Vectra.DataSet2TableAdapters.customerTableAdapter customerTableAdapter1 = new Vectra.DataSet2TableAdapters.customerTableAdapter();
            debtors_summaryTableAdapter1.Fill(dataSet2.debtors_summary);
            customerTableAdapter1.Fill(dataSet2.customer);
            ATBReport rpt = new ATBReport();
            rpt.SetDataSource(dataSet2);
            rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;

            cryRpt = new ReportDocument();
            cryRpt.Load(rpt.FileName.ToString());

            try
            {
                ExportOptions CrExportOptions;
                DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions CrFormatTypeOptions = new PdfRtfWordFormatOptions();
                CrDiskFileDestinationOptions.DiskFileName = @"C:\Documents and Settings\All Users\Desktop\AgedTrialBalance.pdf";
                CrExportOptions = cryRpt.ExportOptions;
                {
                    CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                    CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                    CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;
                    CrExportOptions.FormatOptions = CrFormatTypeOptions;
                }
                cryRpt.Export();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }       
    }
}
