using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ECustoms.DAL;
using ECustoms.Utilities.Enums;

namespace ECustoms.BOL
{
    /// <summary>
    /// Get datatable for reporting.
    /// </summary>
    public class ReportBOL
    {
        private readonly string _dbConnectionString;
        private readonly ReportDAL _reportDAL;

        public ReportBOL()
        {
            _dbConnectionString = System.Configuration.ConfigurationSettings.AppSettings["connectionString"];
            _reportDAL = new ReportDAL(_dbConnectionString);
        }

        public DataTable GetReportTable(ReportType reportType, DateTime dateFrom, DateTime dateTo)
        {


            DataTable dt = new DataTable("People");
            for (int i = 0; i < 14; i++)
            {
                dt.Columns.Add("Column " + i, typeof(string));
            }
            dt.Columns.Add("Date Time", typeof(DateTime));
            for (int i = 0; i < 14; i++)
            {
                dt.Rows.Add(new Object[] { "Roosevelt", "Roosevelt", "Roosevelt", "Roosevelt", "Roosevelt", "Roosevelt", "Roosevelt", "Roosevelt", "Roosevelt", "Roosevelt", "Roosevelt", "Roosevelt", "Roosevelt", "Roosevelt", new DateTime(1998, 11, 27) });
            }

            //dt.Rows.Add(new Object[] { "Theodore", "Roosevelt", new DateTime(1858, 11, 27) });
            //dt.Rows.Add(new Object[] { "Winston ", "Churchill", new DateTime(1874, 11, 30) });
            //dt.Rows.Add(new Object[] { "Pablo", "Picasso", new DateTime(1881, 10, 25) });
            //dt.Rows.Add(new Object[] { "Charlie", "Chaplin", new DateTime(1889, 4, 16) });
            //dt.Rows.Add(new Object[] { "Steven", "Spielberg", new DateTime(1946, 12, 18) });
            //dt.Rows.Add(new Object[] { "Bart", "Simpson", new DateTime(1987, 4, 19) });
            //dt.Rows.Add(new Object[] { "Louis", "Armstrong", new DateTime(1901, 8, 4) });
            //dt.Rows.Add(new Object[] { "Igor", "Stravinski", new DateTime(1882, 6, 17) });
            //dt.Rows.Add(new Object[] { "Bill", "Gates", new DateTime(1955, 10, 28) });
            //dt.Rows.Add(new Object[] { "Albert", "Einstein", new DateTime(1879, 3, 14) });
            //dt.Rows.Add(new Object[] { "Marilyn", "Monroe", new DateTime(1927, 6, 1) });
            //dt.Rows.Add(new Object[] { "Mother", "Teresa", new DateTime(1910, 8, 27) });
            return dt;

            //return _reportDAL.GetReportTable(reportType, dateFrom, dateTo);
        }

    }
}
