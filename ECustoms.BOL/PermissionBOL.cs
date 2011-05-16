﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECustoms.DAL;
using ECustoms.Utilities;

namespace ECustoms.BOL
{
    public class PermissionBOL
    {
        private readonly string _dbConnectionString;
        private readonly PermissionDAL _permissionDAL;

        public PermissionBOL()
        {
            _dbConnectionString = System.Configuration.ConfigurationSettings.AppSettings["connectionString"];
            _permissionDAL = new PermissionDAL(_dbConnectionString);
        }

        /// <summary>
        /// Select all Permission
        /// </summary>
        /// <returns>List permissionInfo objects</returns>
        public List<PermissionInfo> GetAllPermission()
        {
            try
            {
                return _permissionDAL.SelectAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}