using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ECustoms.Utilities
{
    public class UserInfo
    {
        public int UserID { get; set; }
        public string Name { get; set; }                
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Permission { get; set; }
        public int PermissionID { get; set; }
        public bool IsActive { get; set; }

        #region Methods
        public void CreateFrom(DataRow dr)
        {
            if (dr.Table.Columns.Contains(ConstantInfo.TBL_USER_USERID) && !dr.IsNull(ConstantInfo.TBL_USER_USERID))
            {
                this.UserID = Convert.ToInt32(dr[ConstantInfo.TBL_USER_USERID]);
            }
            if (dr.Table.Columns.Contains(ConstantInfo.TBL_USER_NAME) && !dr.IsNull(ConstantInfo.TBL_USER_NAME))
            {
                this.Name = dr[ConstantInfo.TBL_USER_NAME].ToString();
            }

            if (dr.Table.Columns.Contains(ConstantInfo.TBL_USER_BIRTHDAY) && !dr.IsNull(ConstantInfo.TBL_USER_BIRTHDAY))
            {
                this.Birthday = Convert.ToDateTime(dr[ConstantInfo.TBL_USER_BIRTHDAY]);
            }

            if (dr.Table.Columns.Contains(ConstantInfo.TBL_USER_ADDRESS) && !dr.IsNull(ConstantInfo.TBL_USER_ADDRESS))
            {
                this.Address = dr[ConstantInfo.TBL_USER_ADDRESS].ToString();
            }
            if (dr.Table.Columns.Contains(ConstantInfo.TBL_USER_EMAIL) && !dr.IsNull(ConstantInfo.TBL_USER_EMAIL))
            {
                this.Email = dr[ConstantInfo.TBL_USER_EMAIL].ToString();
            }
            if (dr.Table.Columns.Contains(ConstantInfo.TBL_USER_PHONE_NUMBER) && !dr.IsNull(ConstantInfo.TBL_USER_PHONE_NUMBER))
            {
                this.PhoneNumber = dr[ConstantInfo.TBL_USER_PHONE_NUMBER].ToString();
            }
            if (dr.Table.Columns.Contains(ConstantInfo.TBL_USER_USERNAME) && !dr.IsNull(ConstantInfo.TBL_USER_USERNAME))
            {
                this.UserName = dr[ConstantInfo.TBL_USER_USERNAME].ToString();
            }
            if (dr.Table.Columns.Contains(ConstantInfo.TBL_USER_PASSWORD) && !dr.IsNull(ConstantInfo.TBL_USER_PASSWORD))
            {
                this.Password = dr[ConstantInfo.TBL_USER_PASSWORD].ToString();
            }

            if (dr.Table.Columns.Contains(ConstantInfo.TBL_PERMISSION_PERMISSION) && !dr.IsNull(ConstantInfo.TBL_PERMISSION_PERMISSION))
            {
                this.Permission = dr[ConstantInfo.TBL_PERMISSION_PERMISSION].ToString();
            }

            if (dr.Table.Columns.Contains(ConstantInfo.TBL_PERMISSION_PERMISSION_ID) && !dr.IsNull(ConstantInfo.TBL_PERMISSION_PERMISSION_ID))
            {
                this.PermissionID = Convert.ToInt32(dr[ConstantInfo.TBL_PERMISSION_PERMISSION_ID]);
            }
            if (dr.Table.Columns.Contains(ConstantInfo.TBL_USER_IS_ACTIVE) &&  !dr.IsNull(ConstantInfo.TBL_USER_IS_ACTIVE))
            {
                this.IsActive = Convert.ToBoolean(dr[ConstantInfo.TBL_USER_IS_ACTIVE]);
            }
        }
        #endregion
    }
}
