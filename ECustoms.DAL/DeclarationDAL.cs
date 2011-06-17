using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ECustoms.Utilities;

namespace ECustoms.DAL
{
    public class DeclarationDAL
    {
        #region Private variables
        private string _connectionString;
        private DbConnection _dbConnection;
        #endregion

        public DeclarationDAL(string connectionString)
        {
            _connectionString = connectionString;
            _dbConnection = new DbConnection(_connectionString);
        }


        /// <summary>
        /// Delete Decleration by ID
        /// </summary>
        /// <param name="declerationID">DeclerationID</param>
        /// <returns>Number of rows are effected</returns>
        public int DeleteByID(int declerationID)
        {
            var result = -1;
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];

                parameters[0] = new SqlParameter("@DeclerationID", declerationID);

                result = _dbConnection.ExecuteNonQuery(ConstantInfo.SP_DELETEDECLERATION, parameters);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

       

       
    }
}
