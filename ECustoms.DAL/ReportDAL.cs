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

        public DataTable GetReportTable(ReportType reportType, DateTime dateFrom, DateTime dateTo)
        {
            try
            {
                var parameters = new SqlParameter[3];
                parameters[0] = new SqlParameter("@ReportType", (int)reportType);
                parameters[1] = new SqlParameter("@DateFrom", dateFrom);
                parameters[2] = new SqlParameter("@DateTo", dateTo);
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
