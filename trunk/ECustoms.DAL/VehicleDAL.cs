using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ECustoms.Utilities;
using System.Data;

namespace ECustoms.DAL
{
    public class VehicleDAL
    {
        #region Private variables
        private string _connectionString;
        private DbConnection _dbConnection;
        #endregion

        public VehicleDAL(string connectionString)
        {
            _connectionString = connectionString;
            _dbConnection = new DbConnection(_connectionString);
        }

        /// <summary>
        /// Insert vehicel
        /// </summary>
        /// <param name="vehicleInfo">VehicleInfo object</param>
        /// <returns>Number of rows are effectd</returns>
        public int Insert(VehicleInfo vehicleInfo)
        {
            try
            {
                var parameters = new SqlParameter[15];
                parameters[0] = new SqlParameter("@DeclarationID", vehicleInfo.DeclarationID);
                parameters[1] = new SqlParameter("@PlateNumber", vehicleInfo.PlateNumber);
                parameters[2] = new SqlParameter("@NumberOfContainer", vehicleInfo.NumberOfContainer);
                parameters[3] = new SqlParameter("@DriverName", vehicleInfo.DriverName);
                parameters[4] = new SqlParameter("@ExportDate", vehicleInfo.ExportDate);
                parameters[5] = new SqlParameter("@Note", vehicleInfo.Note);
                parameters[6] = new SqlParameter("@Status", vehicleInfo.Status);
                parameters[7] = new SqlParameter("@IsExport", Convert.ToInt32(vehicleInfo.IsExport));
                parameters[8] = new SqlParameter("@IsCompleted", Convert.ToInt32(vehicleInfo.IsCompleted));
                parameters[9] = new SqlParameter("@ImportDate", vehicleInfo.ImportDate);
                parameters[10] = new SqlParameter("@IsImport", Convert.ToInt32(vehicleInfo.IsImport));
                parameters[11] = new SqlParameter("@IsGoodsImported", Convert.ToInt32(vehicleInfo.IsGoodsImported));

                // Phuong add
                parameters[12] = new SqlParameter("@ConfirmImportBy", Convert.ToInt32(vehicleInfo.ConfirmImportBy));
                parameters[13] = new SqlParameter("@ConfirmExportBy", Convert.ToInt32(vehicleInfo.ConfirmExportBy));
                parameters[14] = new SqlParameter("@ConfirmLocalImportBy", Convert.ToInt32(vehicleInfo.ConfirmLocalImportBy));



                return _dbConnection.ExecuteNonQuery(ConstantInfo.SP_INSERTVEHICLE, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get list Vehicle whihc not import or export
        /// </summary>
        /// <returns>List vehicle objects</returns>
        public List<VehicleInfo> SelectVehicleNotImportExport()
        {
            var result = new List<VehicleInfo>();
            VehicleInfo vehicleInfo;
            try
            {
                var dataTable = _dbConnection.ExecuteSelectQuery(ConstantInfo.SP_GETVEHICLENOTIMPORTEXPORT);
                foreach (DataRow dr in dataTable.Rows)
                {
                    vehicleInfo = new VehicleInfo();
                    vehicleInfo.CreateFrom(dr);
                    result.Add(vehicleInfo);
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public List<VehicleInfo> GetExportingVehicles(int mode, int declarationID, string search)
        {
            var result = new List<VehicleInfo>();
            VehicleInfo vehicleInfo;
            try
            {

                var sqlCommand =
                    "SELECT  TOP(1) * FROM    tblVehicle AS a WHERE a.PlateNumber='" + search + "' AND a.IsExport = 1 AND a.IsImport = 0 AND a.PlateNumber NOT IN ( SELECT   a.PlateNumber FROM     dbo.tblVehicle AS a WHERE    a.DeclarationID = " + declarationID + " ) ORDER BY a.ExportDate DESC";
                //var sqlCommand = "SELECT * FROM tblVehicle WHERE IsExport=1 AND IsImport=0 AND PlateNumber = '" + search + "' AND NOT DeclarationID =" + declarationID;
                //var sqlCommand = string.Empty;
                //if (search.Equals(""))
                //{
                //    if (mode == 1)
                //        sqlCommand = "SELECT * FROM tblVehicle WHERE IsExport=1 AND IsImport=0 AND NOT DeclarationID =" + declarationID;
                //    else if (mode == 2)
                //        sqlCommand = "SELECT * FROM tblVehicle WHERE IsExport=1 AND IsImport=1 AND ImportStatus ='Nhập cảnh có hàng' AND NOT DeclarationID =" + declarationID;
                //    else if (mode == 3) //Vehicle is exported
                //        sqlCommand = "SELECT * FROM tblVehicle WHERE IsExport=1 AND NOT DeclarationID =" + declarationID;
                //}
                //else
                //{
                //    if (mode == 1)
                //        sqlCommand = "SELECT * FROM tblVehicle WHERE IsExport=1 AND IsImport=0 AND PlateNumber like '%" + search + "%' AND NOT DeclarationID =" + declarationID;
                //    else if (mode == 2)
                //        sqlCommand = "SELECT * FROM tblVehicle WHERE IsExport=1 AND IsImport=1 AND ImportStatus ='Nhập cảnh có hàng' AND PlateNumber like '%" + search + "%' AND NOT DeclarationID =" + declarationID;
                //    else if (mode == 3) //Vehicle is exported
                //        sqlCommand = "SELECT * FROM tblVehicle WHERE IsExport=1 AND PlateNumber like '%" + search + "%' AND NOT DeclarationID =" + declarationID;
                //}
                var dataTable = _dbConnection.ExecuteSelectCommandText(sqlCommand);
                foreach (DataRow dr in dataTable.Rows)
                {
                    vehicleInfo = new VehicleInfo();
                    vehicleInfo.CreateFrom(dr);
                    result.Add(vehicleInfo);
                }
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Search Vehicle
        /// </summary>
        /// <param name="importFrom">Import from date</param>
        /// <param name="importTo">Import to date</param>
        /// <param name="exportFrom">Export from date</param>
        /// <param name="exportTo">Export to date</param>
        /// <param name="searchType">
        /// 0- Not import and export
        /// </param>
        /// <returns>List vehicleInfo object</returns>
        public DataTable SearchVehicle(string plateNumber, DateTime importFrom, DateTime importTo, DateTime exportFrom, DateTime exportTo, int searchType)
        {
            var result = new List<VehicleInfo>();
            VehicleInfo vehicleInfo;
            try
            {
                var parameters = new SqlParameter[6];
                // parameters[0] = new SqlParameter("@IsCompleted", isCompleted);
                parameters[0] = new SqlParameter("@PlateNumber", plateNumber);
                parameters[1] = new SqlParameter("@ImportFrom", importFrom);
                parameters[2] = new SqlParameter("@ImportTo", importTo);
                parameters[3] = new SqlParameter("@ExportFrom", exportFrom);
                parameters[4] = new SqlParameter("@ExportTo", exportTo);
                parameters[5] = new SqlParameter("@SearchType", searchType);

                var dataTable = _dbConnection.ExecuteSelectQuery(ConstantInfo.SP_SEARCHVEHICLE, parameters);
                //foreach (DataRow dr in dataTable.Rows)
                //{
                //    vehicleInfo = new VehicleInfo();
                //    vehicleInfo.CreateFrom(dr);
                //    result.Add(vehicleInfo);
                //}
                return dataTable;

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Get Vehicle by DeclarationID
        /// </summary>
        /// <param name="declarationID">DeclarationID</param>
        /// <returns>List VehicleInfo objects</returns>
        public List<VehicleInfo> SelectByDeclarationID(int declarationID)
        {
            var result = new List<VehicleInfo>();
            VehicleInfo vehicleInfo;
            try
            {
                var parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@DeclarationID", declarationID);
                var dataTable = _dbConnection.ExecuteSelectQuery(ConstantInfo.SP_SELECTVEHICLEBYDECLARATIONID, parameters);
                foreach (DataRow dr in dataTable.Rows)
                {
                    vehicleInfo = new VehicleInfo();
                    vehicleInfo.CreateFrom(dr);
                    result.Add(vehicleInfo);
                }
                return result;

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Select Vehicle by VehicleID
        /// </summary>
        /// <param name="vehicleID"></param>
        /// <returns></returns>
        public VehicleInfo SelectByID(int vehicleID)
        {
            var vehicleInfo = new VehicleInfo();
            try
            {
                var parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@VehicleID", vehicleID);

                var dataTable = _dbConnection.ExecuteSelectQuery(ConstantInfo.SP_SELECTVEHICLEBYID, parameters);

                if (dataTable.Rows.Count == 1)
                {
                    vehicleInfo.CreateFrom(dataTable.Rows[0]);
                }
                return vehicleInfo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool IsExistVehicleInDeclaration(string plateNumber, int declarationID)
        {
            var parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@PlateNumber", plateNumber);
            parameters[1] = new SqlParameter("@DeclarationID", declarationID);

            var dataTable = _dbConnection.ExecuteSelectQuery("st_IsExistVehicleInDeclaration", parameters);
            if (dataTable.Rows.Count == 1)
                return true;

            return false;

        }


        /// <summary>
        /// Update vehicle
        /// </summary>
        /// <param name="vehicleInfo">vehicleInfo object</param>
        /// <returns>Number of rows are effected</returns>
        public int Update(VehicleInfo vehicleInfo)
        {
            try
            {
                var parameters = new SqlParameter[19];
                parameters[0] = new SqlParameter("@VehicleID", vehicleInfo.VehicleID);
                parameters[1] = new SqlParameter("@PlateNumber", vehicleInfo.PlateNumber);
                parameters[2] = new SqlParameter("@NumberOfContainer", vehicleInfo.NumberOfContainer);
                parameters[3] = new SqlParameter("@DriverName", vehicleInfo.DriverName);
                parameters[4] = new SqlParameter("@ImportDate", vehicleInfo.ImportDate);
                parameters[5] = new SqlParameter("@ExportDate", vehicleInfo.ExportDate);
                parameters[6] = new SqlParameter("@Status", vehicleInfo.Status);
                parameters[7] = new SqlParameter("@Note", vehicleInfo.Note);
                parameters[8] = new SqlParameter("@IsExport", Convert.ToInt32(vehicleInfo.IsExport));
                parameters[9] = new SqlParameter("@IsImport", Convert.ToInt32(vehicleInfo.IsImport));
                parameters[10] = new SqlParameter("@IsCompleted", Convert.ToInt32(vehicleInfo.IsCompleted));
                parameters[11] = new SqlParameter("@ImportedLocalTime", Convert.ToDateTime(vehicleInfo.ImportedLocalTime));
                parameters[12] = new SqlParameter("@ImportStatus", vehicleInfo.ImportStatus);
                parameters[13] = new SqlParameter("@HasGoodsImported", Convert.ToInt32(vehicleInfo.HasGoodsImported));
                parameters[14] = new SqlParameter("@IsGoodsImported", Convert.ToInt32(vehicleInfo.IsGoodsImported));
                parameters[15] = new SqlParameter("@DeclarationID", Convert.ToInt32(vehicleInfo.DeclarationID));
                // Phuong add
                parameters[16] = new SqlParameter("@ConfirmImportBy", Convert.ToInt32(vehicleInfo.ConfirmImportBy));
                parameters[17] = new SqlParameter("@ConfirmExportBy", Convert.ToInt32(vehicleInfo.ConfirmExportBy));
                parameters[18] = new SqlParameter("@ConfirmLocalImportBy", Convert.ToInt32(vehicleInfo.ConfirmLocalImportBy));

                return _dbConnection.ExecuteNonQuery(ConstantInfo.SP_UPDATEVEHICLE, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Delete vehicle by ID
        /// </summary>
        /// <param name="vehicleID">Vehicle ID</param>
        /// <returns>Number of rows are effected</returns>
        public int DeleteByID(int vehicleID)
        {
            var parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@VehicleID", vehicleID);
            return _dbConnection.ExecuteNonQuery(ConstantInfo.SP_DELETEVEHICLEBYID, parameters);

        }



        public int UpdateLocalConfirm(int vehicleID, int userId)
        {


            var parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@VehicleID", vehicleID);
            parameters[1] = new SqlParameter("@UserId", userId);
            return _dbConnection.ExecuteNonQuery("sp_UpdateLocalConfirm", parameters);

        }

        public int UpdateImportConfirm(int vehicleID, int userId)
        {


            var parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@VehicleID", vehicleID);
            parameters[1] = new SqlParameter("@UserId", userId);
            return _dbConnection.ExecuteNonQuery("sp_UpdateImportConfirm", parameters);

        }
        public int UpdateExportConfirm(int vehicleID, int userId)
        {

            var parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@VehicleID", vehicleID);
            parameters[1] = new SqlParameter("@UserId", userId);
            return _dbConnection.ExecuteNonQuery("sp_UpdateExportConfirm", parameters);

        }
    }
}
