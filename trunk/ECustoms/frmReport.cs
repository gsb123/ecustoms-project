using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ECustoms.BOL;
using ECustoms.Utilities;
using ECustoms.Utilities.Enums;
using ReportPrinting;

namespace ECustoms
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
            InitializeReportType();
        }


        private void InitializeReportType()
        {


            // Put some stuff in the combo box
            cbReportType.Items.Add("Phương tiện xuất cảnh xe không");
            cbReportType.Items.Add("Phương tiện nhập cảnh xe không ");
            cbReportType.Items.Add("Phương tiện chở hàng xuất khẩu");
            cbReportType.Items.Add("Phương tiện chở hàng nhập khẩu");
            cbReportType.Items.Add("Phương tiện hoàn thành thủ tục Hải quan vào nội địa");
            cbReportType.SelectedIndex = 0;


        }


        // Content item for the combo box
        private class Item
        {
            public string Name;
            public int Value;
            public Item(string name, int value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }


        /// <summary>
        /// Get DataTable to report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get data file here
            ReportBOL facade = new ReportBOL();
            //testing

            ReportType type = (ReportType)(cbReportType.SelectedIndex + 1);
            DateTime fromExport = dtpExportFrom.Value;
            DateTime toExport = dtpExportTo.Value;
            DateTime fromImport = dtpImportFrom.Value;
            DateTime toImport = dtpImportTo.Value;

            string reportName = cbReportType.SelectedItem.ToString();
            DataTable reportTable = facade.GetReportTable(type, fromExport,toExport,fromImport, toImport);
            dataGridView1.DataSource = reportTable;
            this.reportDocument1.ReportMaker = GetReportMaker(reportTable, reportName);

        }



        IReportMaker GetReportMaker(DataTable reportTable, string reportName)
        {
            IReportMaker reportFiles = new ReportFiles(reportTable, reportName);
            return reportFiles;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

        }

     

    }

}
