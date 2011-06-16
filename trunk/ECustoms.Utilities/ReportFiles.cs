using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ReportPrinting;

namespace ECustoms.Utilities
{
    public class ReportFiles : IReportMaker
    {
        #region IReportMaker Members

        private DataTable _dt;

        public void MakeDocument(ReportDocument reportDocument)
        {
            TextStyle.ResetStyles();

            TextStyle.Normal.Size = 5.5f;


            TextStyle.Heading1.Size = 16;
            TextStyle.Heading1.Bold = false;
            TextStyle.TableHeader.BackgroundBrush = Brushes.Gray;
            TextStyle.TableHeader.Brush = Brushes.White;
            //TextStyle.TableHeader.MarginNear = 0.1f;
            //TextStyle.TableHeader.MarginFar = 0.1f;
            //TextStyle.TableHeader.MarginTop = 0.05f;
            //TextStyle.TableHeader.MarginBottom = 0.05f;
            //TextStyle.TableRow.MarginNear = 0.1f;
            //TextStyle.TableRow.MarginFar = 0.1f;
            //TextStyle.TableRow.MarginTop = 0.05f;



            ReportBuilder builder = new ReportBuilder(reportDocument);
            builder.StartLinearLayout(Direction.Vertical);

            Pen innerPen = new Pen(Color.Green, 0.02f);

            //DataView dv = SampleReportMaker1.GetDataView();
            DataView dv = _dt.DefaultView;
            builder.AddPageHeader(String.Empty, "Reporting", "page %p");
            builder.PageHeader.MarginRight = 0;
            builder.PageHeader.UseFullWidth = true;
            builder.CurrentContainer.UseFullWidth = true;
            //builder.AddText("Table with lines using default lines\n");
            // Following line sets up the pen used for lins for tables
            builder.DefaultTablePen = reportDocument.ThinPen;
            builder.AddTable(dv, true);
            builder.CurrentSection.HorizontalAlignment = HorizontalAlignment.Center;


            foreach (DataColumn column in _dt.Columns)
            {
                //Console.WriteLine(column.ColumnName);

                //builder.AddColumn(column.ColumnName, column.ColumnName, 1.8f, true, true);
                builder.AddColumn(column.ColumnName, column.ColumnName, 1f, true, true);

            }

            //builder.AddTable(dv, true);
            //builder.AddAllColumns(1.0f, true, true);
            //builder.CurrentSection.MarginLeft = 0.0f;
            //builder.CurrentSection.MarginRight = 0.0f;
            //builder.CurrentSection.MaxWidth = 100f;
            //builder.CurrentSection.MarginBottom = 0.2f;


            builder.CurrentDocument.Body.UseFullWidth = true;


            builder.FinishLinearLayout();

        }

        #endregion

        public ReportFiles(DataTable dataTable)
        {
            _dt = dataTable;
        }
    }
}
