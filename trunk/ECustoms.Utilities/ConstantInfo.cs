using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECustoms.Utilities
{
    public class ConstantInfo
    {
        #region Store procedure Name
        public const string SP_GETUSER = "sp_GetUser";
        public const string SP_INSERTDECLARATION = "sp_InsertDeclaration";
        public const string SP_INSERTVEHICLE = "sp_InsertVehicle";
        public const string SP_GETVEHICLENOTIMPORTEXPORT = "sp_getVehicleNotImportExport";
        public const string SP_SEARCHVEHICLE = "sp_searchVehicle";
        public const string SP_SELECTDECLERATION = "sp_selectDecleration";
        public const string SP_DELETEDECLERATION = "sp_deleteDecleration";
        public const string SP_UPDATEDECLARATION = "sp_updateDeclaration";
        public const string SP_SELECTDECLERATIONBYID = "sp_selectDeclerationByID";
        public const string SP_SELECTVEHICLEBYDECLARATIONID = "sp_selectVehicleByDeclarationID";
        public const string SP_SELECTVEHICLEBYID = "sp_SelectVehicleByID";
        public const string SP_UPDATEVEHICLE = "sp_updateVehicle";
        public const string SP_DELETEVEHICLEBYID = "sp_deleteVehicleByID";
        public const string SP_SELECTALLUSER = "sp_SelectAllUser";
        public const string SP_INSERTUSER = "sp_insertUser";
        public const string SP_COUNTUSERBYUSERNAME = "sp_countUserByUserName";
        public const string SP_SELECTALLPERMISSION = "sp_selectAllPermission";
        public const string SP_SELECTUSERBYID = "sp_SelectUserByID";
        public const string SP_UPDATEUSER = "sp_updateUser";
        public const string SP_DELETEUSER = "sp_deleteUser";
        
        #endregion

        #region Table User
        public const string TBL_USER_USERID = "UserID";
        public const string TBL_USER_NAME = "Name";
        public const string TBL_USER_SEX = "Sex";
        public const string TBL_USER_BIRTHDAY = "Birthday";
        public const string TBL_USER_ADDRESS = "Address";
        public const string TBL_USER_EMAIL = "Email";
        public const string TBL_USER_PHONE_NUMBER = "PhoneNumber";
        public const string TBL_USER_USERNAME = "UserName";
        public const string TBL_USER_PASSWORD = "Password";
        public const string TBL_USER_PERMISSION = "Permission";        
        public const string TBL_USER_IS_ACTIVE = "IsActive";
        #endregion

        #region Table Permission 
        public const string TBL_PERMISSION_PERMISSION_ID = "PermissionID";
        public const string TBL_PERMISSION_PERMISSION = "Permission";
        #endregion

        #region Table Vehicle
        public const string TBL_VEHICLE_VEHICLE_ID = "VehicleID";
        public const string TBL_VEHICLE_PLATE_NUMBER = "PlateNumber";
        public const string TBL_VEHICLE_NUMBER_OF_CONTAINER = "NumberOfContainer";
        public const string TBL_VEHICLE_DRIVER_NAME = "DriverName";
        public const string TBL_VEHICLE_IMPORT_DATE = "ImportDate";
        public const string TBL_VEHICLE_IS_IMPORT = "IsImport";
        public const string TBL_VEHICLE_EXPORT_DATE = "ExportDate";
        public const string TBL_VEHICLE_IS_EXPORT = "IsExport";
        public const string TBL_VEHICLE_NOTE = "Note";
        public const string TBL_VEHICLE_STATUS = "Status";
        public const string TBL_VEHICLE_IS_COMPLETED = "IsCompleted";
        public const string TBL_VEHICLE_IS_GOODS_IMPORTED = "IsGoodsImported";
        public const string TBL_VEHICLE_EXPORT_HOUR = "ExportHour";
        public const string TBL_VEHICLE_IMPORT_HOUR = "ImportHour";
        public const string TBL_VEHICLE_IMPORT_STATUS = "ImportStatus";
        public const string TBL_VEHICLE_IMPORTED_LOCAL_TIME = "ImportedLocalTime";
        #endregion

        #region Table Declaration
        public const string TBL_DECLARATION_DECLARATION_ID = "DeclarationID";
        public const string TBL_DECLARATION_NUMBER = "Number";
        public const string TBL_DECLARATION_PRODUCT_NAME = "ProductName";
        public const string TBL_DECLARATION_COMPANY_NAME = "CompanyName";
        public const string TBL_DECLARATION_PRODUCT_AMOUNT = "ProductAmount";
        public const string TBL_DECLARATION_UNIT = "Unit";
        public const string TBL_DECLARATION_CREATED_BY_ID = "CreatedByID";
        public const string TBL_DECLARATION_MODIFIED_BY_ID = "ModifiedByID";
        public const string TBL_DECLARATION_MODIFIED_DATE = "ModifiedDate";
        public const string TBL_DECLARATION_CREATED_DATE = "CreatedDate";
        public const string TBL_DECLARATION_HAS_DECLARATION = "HasDeclaration";
        public const string TBL_DECLARATION_TYPE = "Type";
        #endregion

        #region Message
        public const string MESSAGE_LOGIN_FAIL = "Tên truy cập hoặc mật khẩu không đúng.";
        public const string MESSAGE_WELCOME = "Xin chào {0}";
        public const string MESSAGE_USERNAME_EXISTING = "Tên truy cập đã tồn tại.";        
        public const string MESSAGE_BLANK_USERNAME = "Tên truy cập không được trống.";
        public const string MESSAGE_BLANK_PASSWORD = "Mật khẩu không được trống.";
        public const string MESSAGE_COMPARE_PASSWORD = "Mật khẩu và nhập lại nhập khẩu phải giống nhau.";
        public const string MESSAGE_BLANK_EMAIL = "Bạn cần nhập Email.";
        public const string MESSAGE_WRONG_EMAIL = "Địa chỉ Email không dúng.";
        public const string MESSAGE_BLANK_DRIVER = "Tên lái xe không được trống.";
        public const string MESSAGE_INSERT_SUCESSFULLY = "Tạo mới xong.";
        public const string MESSAGE_UPDATE_SUCESSFULLY = "Cập nhật xong.";
        public const string MESSAGE_ADD_MORE = "Bạn có muốn thêm tiếp?";
        public const string MESSAGE_ADD_DONE = "Thêm xong.";
        public const string MESSAGE_BLANK_DECLARATION_NUMBER = "Số tờ khai không được trống.";
        public const string MESSAGE_TITLE = " :: Chi cục Hải quan Tân Thanh - Đội giám sát";
        public const string MESSAGE_INCORRECT_PASS = "Mật khẩu cũ chưa đúng!";

        #endregion

        #region System

        public const string HashString = "dfkjdk234fda23fdfssf";

        #endregion
    }
}
