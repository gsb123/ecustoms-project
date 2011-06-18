using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ECustoms.Utilities.Enums;

namespace ECustoms.DAL
{
    /// <summary>
    /// This data access for all report
    /// make DataView for report
    /// do not use Entity framework*
    /// </summary>
    public class ReportDAL
    {


        #region Private variables
        private string _connectionString;
        private DbConnection _dbConnection;
        #endregion // end private

        public ReportDAL(string connectionString)
        {
            _connectionString = connectionString;
            _dbConnection = new DbConnection(_connectionString);
        }

        /// <summary>
        /// Get Report Table
        /// </summary>

        public DataTable GetReportTable(ReportType reportType, DateTime dateFromExport, DateTime dateToExport, DateTime dateFromImport, DateTime dateToImport)
        {
            try
            {
                var parameters = new SqlParameter[5];
                parameters[0] = new SqlParameter("@ReportType", (int)reportType);
                parameters[1] = new SqlParameter("@DateFromExport", dateFromExport);
                parameters[2] = new SqlParameter("@DateToExport", dateToExport);
                parameters[3] = new SqlParameter("@DateFromImport", dateFromImport);
                parameters[4] = new SqlParameter("@DateToImport", dateToImport);
                var dataTable = _dbConnection.ExecuteSelectQuery("st_GetReportTable", parameters);

                return dataTable;

            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
