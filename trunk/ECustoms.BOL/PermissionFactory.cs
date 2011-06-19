using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECustoms.DAL;
using ECustoms.Utilities;

namespace ECustoms.BOL
{
    public class PermissionFactory
    {
        private readonly string _dbConnectionString;
        private readonly PermissionDAL _permissionDAL;

        public PermissionFactory()
        {
            _dbConnectionString = Utilities.Common.Decrypt(System.Configuration.ConfigurationSettings.AppSettings["connectionString"], true);
            _permissionDAL = new PermissionDAL(_dbConnectionString);
        }

        /// <summary>
        /// Select all Permission
        /// </summary>
        /// <returns>List permissionInfo objects</returns>
        public List<PermissionInfo> GetAllPermission()
        {           
           return _permissionDAL.SelectAll();            
        }
    }
}
