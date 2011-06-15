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

        public void MakeDocument(ReportDocument reportDocument)
        {
            TextStyle.ResetStyles();

            TextStyle.Normal.Size = 10;
            TextStyle.Heading1.Size = 16;
            TextStyle.Heading1.Bold = false;
            TextStyle.TableHeader.BackgroundBrush = Brushes.Blue;
            TextStyle.TableHeader.Brush = Brushes.LightGoldenrodYellow;
            TextStyle.TableHeader.MarginNear = 0.1f;
            TextStyle.TableHeader.MarginFar = 0.1f;
            TextStyle.TableHeader.MarginTop = 0.05f;
            TextStyle.TableHeader.MarginBottom = 0.05f;
            TextStyle.TableRow.MarginNear = 0.1f;
            TextStyle.TableRow.MarginFar = 0.1f;
            TextStyle.TableRow.MarginTop = 0.05f;

            ReportBuilder builder = new ReportBuilder(reportDocument);
            builder.StartLinearLayout(Direction.Vertical);

            Pen innerPen = new Pen(Color.Green, 0.02f);

            //DataView dv = SampleReportMaker1.GetDataView();
            DataView dv = null;
            builder.AddPageHeader(String.Empty, "This is test 11 - Tables with lines", "page %p");

            builder.AddText("Table with lines using default lines\n");
            // Following line sets up the pen used for lins for tables
            builder.DefaultTablePen = reportDocument.ThinPen;
            builder.AddTable(dv, true);
            builder.CurrentSection.HorizontalAlignment = HorizontalAlignment.Center;
            builder.AddColumn("FirstName", "First Name", 1.8f, true, true);
            builder.AddColumn("LastName", "Last Name", 1.8f, true, true);
            builder.AddColumn("Birthdate", "Birthdate", 1.8f, true, true);
            builder.FinishLinearLayout();

        }

        #endregion
    }
}
