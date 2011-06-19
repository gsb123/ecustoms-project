using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using ECustoms.DAL;

namespace ECustoms.BOL
{
    public class RoleFactory
    {
        private readonly string _dbConnectionString;
        private dbEcustomEntities _db;
        public RoleFactory()
        {
            _dbConnectionString = Utilities.Common.Decrypt(ConfigurationManager.ConnectionStrings["dbEcustomEntities"].ConnectionString, true);
            _db = new dbEcustomEntities(_dbConnectionString);

        }

    }
}
