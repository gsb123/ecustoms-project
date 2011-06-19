using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECustoms.DAL;
using ECustoms.Utilities;
using System.Configuration;

namespace ECustoms.BOL
{
    public class UserFactory
    {
        private readonly string _dbConnectionString;

        private readonly UserDAL _userDAL;

        public UserFactory()
        {
            // Get connectionString from the config file
            _dbConnectionString = Utilities.Common.Decrypt(System.Configuration.ConfigurationSettings.AppSettings["connectionString"], true);
            _userDAL = new UserDAL(_dbConnectionString);
        }

        /// <summary>
        /// Get UserInformation
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public UserInfo GetUser(UserInfo userInfo)
        {
            // Encode the password & username
            userInfo.Password = Common.Encode(userInfo.Password);
            userInfo.UserName =userInfo.UserName;
            return _userDAL.GetUser(userInfo);
        }

        /// <summary>
        /// Select all user
        /// </summary>
        /// <returns></returns>
        public List<UserInfo> SelectAll()
        {
           return _userDAL.SelectAll();
        }

        /// <summary>
        /// Insert User
        /// </summary>
        /// <param name="userInfo">UserInfo object</param>
        /// <returns>Number of rows are effected</returns>
        public int Insert(UserInfo userInfo)
        {
            // Encode password & username
            userInfo.Password = Common.Encode(userInfo.Password);
            userInfo.UserName = userInfo.UserName;
            return _userDAL.Insert(userInfo);
        }

        /// <summary>
        /// Check if the username is exising or not
        /// </summary>
        /// <param name="username">UserName</param>
        /// <returns>Number of roows are found</returns>
        public bool IsUserExisting(string username)
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

        /// <summary>
        /// Select user by ID
        /// </summary>
        /// <param name="userID">UserID</param>
        /// <returns>UserInfo object</returns>
        public UserInfo SelectByID(int userID)
        {
           return _userDAL.SelectByID(userID);
        }

        public static tblUser GetByID(int userID) {
            var db = new dbEcustomEntities(Utilities.Common.Decrypt(ConfigurationManager.ConnectionStrings["dbEcustomEntities"].ConnectionString, true));
            return db.tblUsers.Where(g => g.UserID.Equals(userID)).FirstOrDefault();
        }

        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="userInfo">userInfo object</param>
        /// <returns>Number of rows are effected</returns>
        public int Update(UserInfo userInfo)
        {
            // Encode password & username
            userInfo.Password = Common.Encode(userInfo.Password);
            userInfo.UserName = userInfo.UserName;
            return _userDAL.Update(userInfo);
        }

        /// <summary>
        /// Delete User by ID
        /// </summary>
        /// <param name="UserID">User ID</param>
        /// <returns>Number of rows are effected</returns>
        public int DeleteByID(int UserID)
        {
            return _userDAL.DeleteByID(UserID);
        }

    }
}
