using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ECustoms.DAL;
using ECustoms.Utilities;

namespace ECustoms.BOL
{
    public class VehicleBOL
    {        
        private readonly string _dbConnectionString;
        private readonly VehicleDAL _vehicleDAL;

        public VehicleBOL()
        {
            _dbConnectionString = System.Configuration.ConfigurationSettings.AppSettings["connectionString"];
            _vehicleDAL = new VehicleDAL(_dbConnectionString);
        }

        /// <summary>
        /// Get list Vehicle whihc not import or export
        /// </summary>
        /// <returns>List vehicle objects</returns>
        public List<VehicleInfo> SelectVehicleNotImportExport()
        {
            try
            {
                return _vehicleDAL.SelectVehicleNotImportExport();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool CheckVehicle(string plateNumber)
        {
            return _vehicleDAL.CheckVehicle(plateNumber);
        }

        /// <summary>
        /// Search Vehicle
        /// </summary>
        /// <param name="isExport">IsExport</param>
        /// <param name="isImport">IsImport</param>
        /// <param name="isNotImport">IsNotImport</param>
        /// <param name="importFrom">Import from date</param>
        /// <param name="importTo">Import to date</param>
        /// <param name="exportFrom">Export from date</param>
        /// <param name="exportTo">Export to date</param>
        /// <param name="isCompleted"></param>
        /// <returns>List vehicleInfo object</returns>
        public DataTable SearchVehicle(bool isCompleted, string plateNumber, bool isExport, bool isImport, bool isNotImport, DateTime importFrom, DateTime importTo, DateTime exportFrom, DateTime exportTo)
        {
            try
            {
                DataTable dataTable;
                // SearchType 1 - Not Export and not Imported
                if (!isExport)
                {


                    dataTable = _vehicleDAL.SearchVehicle(isCompleted, plateNumber, importFrom, importTo, exportFrom, exportTo, 1);
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        if (!string.IsNullOrEmpty(dataRow["ImportDate"].ToString()) && Convert.ToDateTime(dataRow["ImportDate"].ToString()).Year.Equals(1900))
                        {
                            dataRow["ImportDate"] = new DateTime(1900, 1, 1);
                        }

                        if (!string.IsNullOrEmpty(dataRow["ExportDate"].ToString()) && Convert.ToDateTime(dataRow["ExportDate"].ToString()).Year.Equals(1900))
                        {
                            dataRow["ExportDate"] = new DateTime(1900, 1, 1);
                        }

                    }

                    return dataTable;
                }

                // Searctype 2 - Exported and Not Import or Imported
                if (!isImport && !isNotImport)
                {
                    importFrom = new DateTime(importFrom.Year, importFrom.Month, importFrom.Day, 0, 0, 0);
                    importTo = new DateTime(importTo.Year, importTo.Month, importTo.Day, 23, 59, 59);
                    exportFrom = new DateTime(exportFrom.Year, exportFrom.Month, exportFrom.Day, 0, 0, 0);
                    exportTo = new DateTime(exportTo.Year, exportTo.Month, exportTo.Day, 23, 59, 59);
                    dataTable = _vehicleDAL.SearchVehicle(isCompleted, plateNumber, importFrom, importTo, exportFrom, exportTo, 2);
                    return dataTable;
                }

                // Searctype 3- Exported and Imported ( Completed)
                if (isImport && !isNotImport)
                {
                    importFrom = new DateTime(importFrom.Year, importFrom.Month, importFrom.Day, 0, 0, 0);
                    importTo = new DateTime(importTo.Year, importTo.Month, importTo.Day, 23, 59, 59);
                    exportFrom = new DateTime(exportFrom.Year, exportFrom.Month, exportFrom.Day, 0, 0, 0);
                    exportTo = new DateTime(exportTo.Year, exportTo.Month, exportTo.Day, 23, 59, 59);

                    dataTable = _vehicleDAL.SearchVehicle(isCompleted, plateNumber, importFrom, importTo, exportFrom, exportTo, 3);
                    return dataTable;
                }
                importFrom = new DateTime(importFrom.Year, importFrom.Month, importFrom.Day, 0, 0, 0);
                exportFrom = new DateTime(exportFrom.Year, exportFrom.Month, exportFrom.Day, 23, 59, 59);
                dataTable = _vehicleDAL.SearchVehicle(isCompleted, plateNumber, importFrom, importTo, exportFrom, exportTo, 4);
                // Searctype 4- Exported and and Not Imported
                return dataTable;

            }
            catch (Exception)
            {
                throw;
            }
        }


        public List<VehicleInfo> GetExportingVehicles(int mode, int declarationID, string search)
        {
            return _vehicleDAL.GetExportingVehicles(mode, declarationID, search);
        }

        /// <summary>
        /// Get Vehicle by DeclarationID
        /// </summary>
        /// <param name="declarationID">DeclarationID</param>
        /// <returns>List VehicleInfo objects</returns>
        public List<VehicleInfo> SelectByDeclarationID(int declarationID)
        {
            try
            {
                var vehicleInfos = _vehicleDAL.SelectByDeclarationID(declarationID);
                foreach (var vehicleInfo in vehicleInfos)
                {
                    if (vehicleInfo.ImportDate != null)
                    {
                        vehicleInfo.ImportHour = vehicleInfo.ImportDate.Value.ToString("hh:mm");
                    }

                    if (vehicleInfo.ImportDate == null || vehicleInfo.ImportDate.Value.Year.Equals(1900))
                    {
                        vehicleInfo.ImportDate = null;
                        vehicleInfo.ImportHour = "";
                    }
                    if (vehicleInfo.ExportDate != null)
                        vehicleInfo.ExportHour = vehicleInfo.ExportDate.Value.ToString("hh:mm");

                    if (vehicleInfo.ExportDate == null || vehicleInfo.ExportDate.Value.Year.Equals(1900))
                    {
                        vehicleInfo.ExportDate = null;
                        vehicleInfo.ExportHour = "";
                    }
                }
                return vehicleInfos;
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
            try
            {
                var vehicleInfo = _vehicleDAL.SelectByID(vehicleID);
                if (vehicleInfo.ExportDate != null)
                    vehicleInfo.ExportHour = vehicleInfo.ExportDate.Value.ToString("hh:mm");
                if (vehicleInfo.ImportDate != null)
                    vehicleInfo.ImportHour = vehicleInfo.ImportDate.Value.ToString("hh:mm");
                return vehicleInfo;
            }
            catch (Exception)
            {
                throw;
            }
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

                // get hour and miniutes
                if (!string.IsNullOrEmpty(vehicleInfo.ImportHour) && vehicleInfo.ImportDate != null && vehicleInfo.IsImport)
                {
                    var importHour = Convert.ToInt32(vehicleInfo.ImportHour.Split(':')[0]);
                    var importMinitues = Convert.ToInt32(vehicleInfo.ImportHour.Split(':')[1]);
                    // add import our
                    vehicleInfo.ImportDate = vehicleInfo.ImportDate.Value.AddHours(importHour - vehicleInfo.ImportDate.Value.Hour);
                    // Add imort minutes
                    vehicleInfo.ImportDate = vehicleInfo.ImportDate.Value.AddMinutes(importMinitues - vehicleInfo.ImportDate.Value.Minute);
                }

                if (!string.IsNullOrEmpty(vehicleInfo.ExportHour) && vehicleInfo.ExportDate != null && vehicleInfo.IsExport)
                {
                    var exporttHour = Convert.ToInt32(vehicleInfo.ExportHour.Split(':')[0]);
                    var exporMinitues = Convert.ToInt32(vehicleInfo.ExportHour.Split(':')[1]);
                    // Add export minitues
                    vehicleInfo.ExportDate = vehicleInfo.ExportDate.Value.AddMinutes(exporMinitues - vehicleInfo.ExportDate.Value.Minute);
                    // Add export hour
                    vehicleInfo.ExportDate = vehicleInfo.ExportDate.Value.AddHours(exporttHour - vehicleInfo.ExportDate.Value.Hour);
                }


                if (vehicleInfo.ImportDate == null || !vehicleInfo.IsImport)
                {
                    vehicleInfo.ImportDate = new DateTime(1900, 1, 1);
                }

                if (vehicleInfo.ExportDate == null || !vehicleInfo.IsExport)
                {
                    vehicleInfo.ExportDate = new DateTime(1900, 1, 1);
                }

                if (!vehicleInfo.IsGoodsImported)
                {
                    vehicleInfo.ImportedLocalTime = new DateTime(1900, 1, 1);
                }

                return _vehicleDAL.Update(vehicleInfo);
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
        public static int DeleteByID(int vehicleID)
        {
            try
            {
                var db = new dbEcustomEntities();
                var vehicle = db.tblVehicles.Where(g => g.VehicleID == vehicleID).FirstOrDefault();
                db.DeleteObject(vehicle);
                return db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public int UpdateExportConfirm(int vehicleID, int userId)
        {

            return _vehicleDAL.UpdateExportConfirm(vehicleID, userId);

        }

        public int UpdateImportConfirm(int vehicleID, int userId)
        {
            return _vehicleDAL.UpdateImportConfirm(vehicleID, userId);

        }
        public int UpdateLocalConfirm(int vehicleID, int userId)
        {

            return _vehicleDAL.UpdateLocalConfirm(vehicleID, userId);

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

                // get hour and miniutes
                if (!string.IsNullOrEmpty(vehicleInfo.ImportHour) && vehicleInfo.ImportDate != null)
                {
                    var importHour = Convert.ToInt32(vehicleInfo.ImportHour.Split(':')[0]);
                    var importMinitues = Convert.ToInt32(vehicleInfo.ImportHour.Split(':')[1]);
                    // add import our
                    vehicleInfo.ImportDate = vehicleInfo.ImportDate.Value.AddHours(importHour - vehicleInfo.ImportDate.Value.Hour);
                    // Add imort minutes
                    vehicleInfo.ImportDate = vehicleInfo.ImportDate.Value.AddMinutes(importMinitues - vehicleInfo.ImportDate.Value.Minute);
                }

                if (!string.IsNullOrEmpty(vehicleInfo.ExportHour) && vehicleInfo.ExportDate != null)
                {
                    var exporttHour = Convert.ToInt32(vehicleInfo.ExportHour.Split(':')[0]);
                    var exporMinitues = Convert.ToInt32(vehicleInfo.ExportHour.Split(':')[1]);
                    // Add export minitues
                    vehicleInfo.ExportDate = vehicleInfo.ExportDate.Value.AddMinutes(exporMinitues - vehicleInfo.ExportDate.Value.Minute);
                    // Add export hour
                    vehicleInfo.ExportDate = vehicleInfo.ExportDate.Value.AddHours(exporttHour - vehicleInfo.ExportDate.Value.Hour);
                }

                if (vehicleInfo.ImportDate == null)
                {
                    vehicleInfo.ImportDate = new DateTime(1900, 1, 1);
                }
                if (vehicleInfo.ExportDate == null)
                {
                    vehicleInfo.ExportDate = new DateTime(1900, 1, 1);
                }

                if (_vehicleDAL.IsExistVehicleInDeclaration(vehicleInfo.PlateNumber, vehicleInfo.DeclarationID))
                    throw new Exception("Biển số phương tiện đã tồn tại trong tời khai này");

                return _vehicleDAL.Insert(vehicleInfo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
