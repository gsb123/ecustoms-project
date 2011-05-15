using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECustoms.Utilities;
using System.Data;
using System.Data.SqlClient;

namespace ECustoms.DAL
{
    public class UserDAL
    {
       
        #region private variable
        private string _connectionString;
        private DbConnection _dbConnection;
        #endregion
        public UserDAL(string connectionString)
        {
            _connectionString = connectionString;
            _dbConnection = new DbConnection(_connectionString);
        }

        /// <summary>
        /// Get UserInfo
        /// </summary>
        /// <returns></returns>
        public UserInfo GetUser(UserInfo userInfo)
        {
            var result = new UserInfo();
            try
            {
                var dataTable = _dbConnection.ExecuteSelectQuery(ConstantInfo.SP_GETUSER,
                                                                       new SqlParameter("@UserName", userInfo.UserName),
                                                                       new SqlParameter("@Password", userInfo.Password));
                if (dataTable.Rows.Count > 0)
                {
                    result.CreateFrom(dataTable.Rows[0]);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                //Log here
                throw;
            }
            return result;
        }

        /// <summary>
        /// Select all user
        /// </summary>
        /// <returns></returns>
        public List<UserInfo> SelectAll()
        {
            var result = new List<UserInfo>();
            UserInfo userInfo;
            try
            {
                var dataTable = _dbConnection.ExecuteSelectQuery(ConstantInfo.SP_SELECTALLUSER);
                foreach (DataRow dr in dataTable.Rows)
                {
                    userInfo = new UserInfo();
                    userInfo.CreateFrom(dr);
                    userInfo.UserName = Common.Decrypt(userInfo.UserName, true);

                    result.Add(userInfo);
                }
                return result;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        /// <summary>
        /// Insert User
        /// </summary>
        /// <param name="userInfo">UserInfo object</param>
        /// <returns>Number of rows are effected</returns>
        public int Insert(UserInfo userInfo)
        {
            var result = -1;
            try
            {
                var parameters = new SqlParameter[8];
                parameters[0] = new SqlParameter("@Name", userInfo.Name);                                
                parameters[1] = new SqlParameter("@Address", userInfo.Address );
                parameters[2] = new SqlParameter("@Email", userInfo.Email);
                parameters[3] = new SqlParameter("@PhoneNumber", userInfo.PhoneNumber);
                parameters[4] = new SqlParameter("@UserName", userInfo.UserName);
                parameters[5] = new SqlParameter("@Password", userInfo.Password);
                parameters[6] = new SqlParameter("@PermissionID", userInfo.PermissionID);
                parameters[7] = new SqlParameter("@IsActive", userInfo.IsActive);                
                result = Convert.ToInt32(_dbConnection.ExecuteNonQuery(ConstantInfo.SP_INSERTUSER, parameters));
                return result;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        /// <summary>
        /// Count User by UserName
        /// </summary>
        /// <param name="username">UserName</param>
        /// <returns>Number of roows are found</returns>
        public int CountByUserName(string username)
        {
            try
            {
                var parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@UserName", username);
                return Convert.ToInt32(_dbConnection.ExecuteScalar(ConstantInfo.SP_COUNTUSERBYUSERNAME, parameters));
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Select user by ID
        /// </summary>
        /// <param name="userID">UserID</param>
        /// <returns>UserInfo object</returns>
        public UserInfo SelectByID(int userID)
        {
            var userInfo = new UserInfo();
            try
            {
                var parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@UserID", userID);

                var dataTable = _dbConnection.ExecuteSelectQuery(ConstantInfo.SP_SELECTUSERBYID, parameters);
                if (dataTable.Rows.Count == 1)
                {
                    userInfo.CreateFrom(dataTable.Rows[0]);
                }
                return userInfo;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="userInfo">userInfo object</param>
        /// <returns>Number of rows are effected</returns>
        public int Update(UserInfo userInfo)
        {
            try
            {
                var parameters = new SqlParameter[9];
                parameters[0] = new SqlParameter("@Name", userInfo.Name);
                parameters[1] = new SqlParameter("@Address", userInfo.Address);
                parameters[2] = new SqlParameter("@Email", userInfo.Email);
                parameters[3] = new SqlParameter("@PhoneNumber", userInfo.PhoneNumber);
                parameters[4] = new SqlParameter("@UserName", userInfo.UserName);
                parameters[5] = new SqlParameter("@Password", userInfo.Password);
                parameters[6] = new SqlParameter("@PermissionID", userInfo.PermissionID);
                parameters[7] = new SqlParameter("@IsActive", userInfo.IsActive);
                parameters[8] = new SqlParameter("@UserID", userInfo.UserID);
                return _dbConnection.ExecuteNonQuery(ConstantInfo.SP_UPDATEUSER, parameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Delete User by ID
        /// </summary>
        /// <param name="UserID">User ID</param>
        /// <returns>Number of rows are effected</returns>
        public int DeleteByID(int UserID)
        {
            try
            {
                var parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@UserID", UserID);
                return _dbConnection.ExecuteNonQuery(ConstantInfo.SP_DELETEUSER, parameters);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
