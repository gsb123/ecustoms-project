using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECustoms.DAL;
using ECustoms.Utilities;

namespace ECustoms.BOL
{
    public class UserBOL
    {
        private readonly string _dbConnectionString;

        private readonly UserDAL _userDAL;

        public UserBOL()
        {
            // Get connectionString from the config file
            _dbConnectionString = System.Configuration.ConfigurationSettings.AppSettings["connectionString"];
            _userDAL = new UserDAL(_dbConnectionString);
        }

        /// <summary>
        /// Get UserInformation
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public UserInfo GetUser(UserInfo userInfo)
        {
            try
            {
                // Encode the password & username
                userInfo.Password = Common.Encode(userInfo.Password);
                userInfo.UserName =userInfo.UserName;
                return _userDAL.GetUser(userInfo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Select all user
        /// </summary>
        /// <returns></returns>
        public List<UserInfo> SelectAll()
        {
            try
            {
                return _userDAL.SelectAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Insert User
        /// </summary>
        /// <param name="userInfo">UserInfo object</param>
        /// <returns>Number of rows are effected</returns>
        public int Insert(UserInfo userInfo)
        {
            try
            {


                // Encode password & username
                userInfo.Password = Common.Encode(userInfo.Password);
                userInfo.UserName = userInfo.UserName;

                return _userDAL.Insert(userInfo);
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// Check if the username is exising or not
        /// </summary>
        /// <param name="username">UserName</param>
        /// <returns>Number of roows are found</returns>
        public bool IsUserExisting(string username)
        {
            try
            {
                var result = false;
                var count = _userDAL.CountByUserName(username);
                if (count > 0)
                {
                    result = true;
                }
                if (count == 0) result = false;

                return result;
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
            try
            {
                return _userDAL.SelectByID(userID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static tblUser GetByID(int userID) {
            var db = new dbEcustomEntities();
            return db.tblUsers.Where(g => g.UserID.Equals(userID)).FirstOrDefault();
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
                // Encode password & username
                userInfo.Password = Common.Encode(userInfo.Password);
                userInfo.UserName = userInfo.UserName;
                return _userDAL.Update(userInfo);
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
                return _userDAL.DeleteByID(UserID);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
