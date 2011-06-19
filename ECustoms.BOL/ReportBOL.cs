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

            //DataTable dt = new DataTable("People");
            //for (int i = 0; i < 14; i++)
            //{
            //    dt.Columns.Add("Column " + i, typeof(string));
            //}
            //dt.Columns.Add("Date Time", typeof(DateTime));
            //for (int i = 0; i < 14; i++)
            //{
            //    dt.Rows.Add(new Object[] { "Roosevelt\nWinston", "Roosevelt\n Winston", "Roosevelt Winston", "Roosevelt Winston", "Roosevelt", "Roosevelt", "Roosevelt",  new DateTime(1998, 11, 27).ToString(), "Roosevelt", "Roosevelt", "Roosevelt", "Roosevelt", new DateTime(1998, 11, 27).ToString(), "Roosevelt", new DateTime(1998, 11, 27) });
            //}

            DateTime from = new DateTime(dateFrom.Year, dateFrom.Month, dateFrom.Day, 0, 0, 0);
            DateTime to = new DateTime(dateTo.Year, dateTo.Month, dateTo.Day, 23, 59, 59);


            return _reportDAL.GetReportTable(reportType, from, to);
        }

    }
}
