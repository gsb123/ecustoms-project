﻿using System;
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
            _dbConnectionString = Utilities.Common.Decrypt(System.Configuration.ConfigurationSettings.AppSettings["connectionString"], true);
            _reportDAL = new ReportDAL(_dbConnectionString);
        }

        public DataTable GetReportTable(ReportType reportType, DateTime dateFromExport, DateTime dateToExport, DateTime dateFromImport, DateTime dateToImport)
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

            DateTime fromExport = new DateTime(dateFromExport.Year, dateFromExport.Month, dateFromExport.Day, 0, 0, 0);
            DateTime toExport = new DateTime(dateToExport.Year, dateToExport.Month, dateToExport.Day, 23, 59, 59);

            DateTime fromImport = new DateTime(dateFromImport.Year, dateFromImport.Month, dateFromImport.Day, 0, 0, 0);
            DateTime toImport = new DateTime(dateToImport.Year, dateToImport.Month, dateToImport.Day, 23, 59, 59);

            return _reportDAL.GetReportTable(reportType, fromExport, toExport, fromImport,fromImport);
        }

    }
}
