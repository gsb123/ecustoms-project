using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECustoms.Utilities;
using System.Data;

namespace ECustoms.DAL
{
    public class PermissionDAL
    {
        #region private variable
        private string _connectionString;
        private DbConnection _dbConnection;
        #endregion

        public PermissionDAL(string connectionString)
        {
            _connectionString = connectionString;
            _dbConnection = new DbConnection(_connectionString);
        }

        /// <summary>
        /// Select all Permission
        /// </summary>
        /// <returns>List permissionInfo objects</returns>
        public List<PermissionInfo> SelectAll()
        {
            var result = new List<PermissionInfo>();
            PermissionInfo permissionInfo;
            try
            {
                var dataTable = _dbConnection.ExecuteSelectQuery(ConstantInfo.SP_SELECTALLPERMISSION);
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    permissionInfo = new PermissionInfo();
                    permissionInfo.CreateFrom(dataRow);
                    result.Add(permissionInfo);
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
