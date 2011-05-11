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
        /// Insert new Declaration
        /// </summary>
        /// <param name="declarationInfo">DeclarationInfo object</param>
        /// <returns>new id</returns>
        public int Insert(DeclarationInfo declarationInfo)
        {

            var result = -1;
            try
            {                
                var parameters = new SqlParameter[16];

                parameters[0] = new SqlParameter("@Number", declarationInfo.Number);
                parameters[1] = new SqlParameter("@ProductName", declarationInfo.ProductName);
                parameters[2] = new SqlParameter("@CompanyName", declarationInfo.CompanyName);
                parameters[3] = new SqlParameter("@ProductAmount", declarationInfo.ProductAmount);
                parameters[4] = new SqlParameter("@Unit", declarationInfo.Unit);
                parameters[5] = new SqlParameter("@CreatedByID", declarationInfo.CreatedByID);
                parameters[6] = new SqlParameter("@ModifiedByID", declarationInfo.ModifiedByID);
                parameters[7] = new SqlParameter("@ModifiedDate", declarationInfo.ModifiedDate);
                parameters[8] = new SqlParameter("@CreatedDate", DateTime.Now);
                parameters[9] = new SqlParameter("@HasDeclaration", Convert.ToInt32(declarationInfo.HasDeclaration));
                parameters[10] = new SqlParameter("@ImportNumber", declarationInfo.ImportNumber);
                parameters[11] = new SqlParameter("@ImportProductName", declarationInfo.ImportProductName);
                parameters[12] = new SqlParameter("@ImportCompanyName", declarationInfo.ImportCompanyName);
                parameters[13] = new SqlParameter("@ImportProductAmount", declarationInfo.ImportProductAmount);
                parameters[14] = new SqlParameter("@ImportUnit", declarationInfo.ImportUnit);
                parameters[15] = new SqlParameter("@ImportHasDeclaration", Convert.ToInt32(declarationInfo.ImportHasDeclaration));
                

                result = Convert.ToInt32( _dbConnection.ExecuteScalar(ConstantInfo.SP_INSERTDECLARATION, parameters));                
                return result;
            }
            catch (Exception)
            {
                    
                throw;
            }
        }

        /// <summary>
        /// Get DeclerationInfo
        /// </summary>
        /// <returns></returns>
        public List<DeclarationInfo> Select()
        {
            var result = new List<DeclarationInfo>();
            DeclarationInfo declerationInfo;
            try
            {
                var dataTable = _dbConnection.ExecuteSelectQuery(ConstantInfo.SP_SELECTDECLERATION);
                foreach (DataRow dr in dataTable.Rows)
                {
                    declerationInfo = new DeclarationInfo();
                    declerationInfo.CreateFrom(dr);
                    result.Add(declerationInfo);
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
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

        /// <summary>
        /// Update Decleration by ID
        /// </summary>
        /// <param name="declerationID">DeclerationID</param>
        /// <returns>Number of rows are effected</returns>
        public int UpdateByID(DeclarationInfo declerationInfo)
        {
            var result = -1;
            try
            {
                var parameters = new SqlParameter[15];
                parameters[0] = new SqlParameter("@DeclerationID", declerationInfo.DeclarationID);
                parameters[1] = new SqlParameter("@Number", declerationInfo.Number);
                parameters[2] = new SqlParameter("@ProductName", declerationInfo.ProductName);
                parameters[3] = new SqlParameter("@CompanyName", declerationInfo.CompanyName);
                parameters[4] = new SqlParameter("@ProductAmount", declerationInfo.ProductAmount);
                parameters[5] = new SqlParameter("@Unit", declerationInfo.Unit);                
                parameters[6] = new SqlParameter("@ModifiedByID", declerationInfo.ModifiedByID);
                parameters[7] = new SqlParameter("@ModifiedDate", declerationInfo.ModifiedDate);
                parameters[8] = new SqlParameter("@HasDeclaration", Convert.ToInt32(declerationInfo.HasDeclaration));

                parameters[9] = new SqlParameter("@ImportNumber", declerationInfo.ImportNumber);
                parameters[10] = new SqlParameter("@ImportProductName", declerationInfo.ImportProductName);
                parameters[11] = new SqlParameter("@ImportCompanyName", declerationInfo.ImportCompanyName);
                parameters[12] = new SqlParameter("@ImportProductAmount", declerationInfo.ImportProductAmount);
                parameters[13] = new SqlParameter("@ImportUnit", declerationInfo.ImportUnit);
                parameters[14] = new SqlParameter("@ImportHasDeclaration", Convert.ToInt32(declerationInfo.ImportHasDeclaration));                

                result = Convert.ToInt32(_dbConnection.ExecuteScalar(ConstantInfo.SP_UPDATEDECLARATION, parameters));
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Get Declaration by ID
        /// </summary>
        /// <param name="declarationID">DeclarationID</param>
        /// <returns>DeclarationInfo object</returns>
        public DeclarationInfo SelectByID(int declarationID)
        {
            var declerationInfo = new DeclarationInfo();
            try
            {
                var parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@DeclarationID", declarationID);

                var dataTable = _dbConnection.ExecuteSelectQuery(ConstantInfo.SP_SELECTDECLERATIONBYID, parameters);
                if (dataTable.Rows.Count == 1)
                {
                    declerationInfo.CreateFrom(dataTable.Rows[0]);   
                }
                return declerationInfo;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
