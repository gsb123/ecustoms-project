using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ECustoms.DAL;
using ECustoms.Utilities;
using System.Configuration;

namespace ECustoms.BOL
{
    public class VehicleFactory
    {        
        private readonly string _dbConnectionString;
        private readonly VehicleDAL _vehicleDAL;
        
        public VehicleFactory()
        {
            _dbConnectionString = Utilities.Common.Decrypt(System.Configuration.ConfigurationSettings.AppSettings["connectionString"], true);
            _vehicleDAL = new VehicleDAL(_dbConnectionString);
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
        public List<ViewAllVehicle> SearchVehicle(bool isCompleted, string plateNumber, bool isExport, bool isImport, bool isNotImport, DateTime importFrom, DateTime importTo, DateTime exportFrom, DateTime exportTo)
        {
            var db = new dbEcustomEntities(Utilities.Common.Decrypt(ConfigurationManager.ConnectionStrings["dbEcustomEntities"].ConnectionString, true));
            if(string.IsNullOrEmpty(plateNumber)) { // compare with platnumber
                if (isCompleted)
                {  // Da hoan thanh
                    if (isExport)
                    {  // Da xuat                        
                        if (isImport)
                        { // da nhap theo thoi gian
                            // Lay nhung ban ghi da hoan thanh theo export va import
                            importFrom = new DateTime(importFrom.Year, importFrom.Month, importFrom.Day, 0, 0, 0);
                            importTo = new DateTime(importTo.Year, importTo.Month, importTo.Day, 23, 59, 59);
                            exportFrom = new DateTime(exportFrom.Year, exportFrom.Month, exportFrom.Day, 0, 0, 0);
                            exportTo = new DateTime(exportTo.Year, exportTo.Month, exportTo.Day, 23, 59, 59);
                            return db.ViewAllVehicles.Where(g => (g.IsExport == true && g.ExportDate >= exportFrom && g.ExportDate <= exportTo) && (g.IsImport == true && g.ImportDate >= importFrom && g.ImportDate <= importTo)).ToList();
                        }
                        else
                        { // Khong quan tam toi thoi gian nhap
                            // Chi lay nhung ban ghi da xuat va isImprot = true
                            exportFrom = new DateTime(exportFrom.Year, exportFrom.Month, exportFrom.Day, 0, 0, 0);
                            exportTo = new DateTime(exportTo.Year, exportTo.Month, exportTo.Day, 23, 59, 59);
                            return db.ViewAllVehicles.Where(g => (g.IsExport == true) && (g.IsImport == true) && (g.ExportDate >= exportFrom) && (g.ExportDate <= exportTo)).ToList();
                        }
                    }
                    else
                    {  // da xuat = uncheck
                        // Lay tat ca ban ghi ma da hoan tat, khong quan tam toi thoi gian
                        return db.ViewAllVehicles.Where(g => (g.IsExport == true) && (g.IsImport == true)).ToList();
                    }
                }
                else
                {  // compted = uncheck
                    if (isExport)
                    {  // Da xuat
                        if (isNotImport)// chua nhap canh
                        {
                            // chi lay nhung ban ghi da xuat, ma chua nhap
                            exportFrom = new DateTime(exportFrom.Year, exportFrom.Month, exportFrom.Day, 0, 0, 0);
                            exportTo = new DateTime(exportTo.Year, exportTo.Month, exportTo.Day, 23, 59, 59);
                            return db.ViewAllVehicles.Where(g => (g.IsExport == true) && (g.IsImport == false) && (g.ExportDate >= exportFrom) && (g.ExportDate <= exportTo)).ToList();
                        }
                        else
                        { // chi lay ban ghi da xuat canh, khong quan tam da nhap  hay chua
                            // chi lay nhung ban ghi da xuat, ma chua nhap
                            exportFrom = new DateTime(exportFrom.Year, exportFrom.Month, exportFrom.Day, 0, 0, 0);
                            exportTo = new DateTime(exportTo.Year, exportTo.Month, exportTo.Day, 23, 59, 59);
                            return db.ViewAllVehicles.Where(g => (g.IsExport == true) && (g.ExportDate >= exportFrom) && (g.ExportDate <= exportTo)).ToList();
                        }
                    }
                    else
                    {
                        // lay tat ban ghi chua xuat, chua nhap
                        return db.ViewAllVehicles.Where(g => (g.IsExport == null || g.IsExport == false) && (g.IsImport == null || g.IsImport == false)).ToList();
                    }
                }
            } else {
                if (isCompleted)
                {  // Da hoan thanh
                    if (isExport)
                    {  // Da xuat                        
                        if (isImport)
                        { // da nhap theo thoi gian
                            // Lay nhung ban ghi da hoan thanh theo export va import
                            importFrom = new DateTime(importFrom.Year, importFrom.Month, importFrom.Day, 0, 0, 0);
                            importTo = new DateTime(importTo.Year, importTo.Month, importTo.Day, 23, 59, 59);
                            exportFrom = new DateTime(exportFrom.Year, exportFrom.Month, exportFrom.Day, 0, 0, 0);
                            exportTo = new DateTime(exportTo.Year, exportTo.Month, exportTo.Day, 23, 59, 59);
                            return db.ViewAllVehicles.Where(g => (g.IsExport == true && g.ExportDate >= exportFrom && g.ExportDate <= exportTo) && (g.IsImport == true && g.ImportDate >= importFrom && g.ImportDate <= importTo) && g.PlateNumber.Contains(plateNumber)).ToList();
                        }
                        else
                        { // Khong quan tam toi thoi gian nhap
                            // Chi lay nhung ban ghi da xuat va isImprot = true
                            exportFrom = new DateTime(exportFrom.Year, exportFrom.Month, exportFrom.Day, 0, 0, 0);
                            exportTo = new DateTime(exportTo.Year, exportTo.Month, exportTo.Day, 23, 59, 59);
                            return db.ViewAllVehicles.Where(g => (g.IsExport == true) && (g.IsImport == true) && (g.ExportDate >= exportFrom) && (g.ExportDate <= exportTo) && g.PlateNumber.Contains(plateNumber)).ToList();
                        }
                    }
                    else
                    {  // da xuat = uncheck
                        // Lay tat ca ban ghi ma da hoan tat, khong quan tam toi thoi gian
                        return db.ViewAllVehicles.Where(g => (g.IsExport == true) && (g.IsImport == true)).ToList();
                    }
                }
                else
                {  // compted = uncheck
                    if (isExport)
                    {  // Da xuat
                        if (isNotImport)// chua nhap canh
                        {
                            // chi lay nhung ban ghi da xuat, ma chua nhap
                            exportFrom = new DateTime(exportFrom.Year, exportFrom.Month, exportFrom.Day, 0, 0, 0);
                            exportTo = new DateTime(exportTo.Year, exportTo.Month, exportTo.Day, 23, 59, 59);
                            return db.ViewAllVehicles.Where(g => (g.IsExport == true) && (g.IsImport == false) && (g.ExportDate >= exportFrom) && (g.ExportDate <= exportTo) && g.PlateNumber.Contains(plateNumber)).ToList();
                        }
                        else
                        { // chi lay ban ghi da xuat canh, khong quan tam da nhap  hay chua
                            // chi lay nhung ban ghi da xuat, ma chua nhap
                            exportFrom = new DateTime(exportFrom.Year, exportFrom.Month, exportFrom.Day, 0, 0, 0);
                            exportTo = new DateTime(exportTo.Year, exportTo.Month, exportTo.Day, 23, 59, 59);
                            return db.ViewAllVehicles.Where(g => (g.IsExport == true) && (g.ExportDate >= exportFrom) && (g.ExportDate <= exportTo) && g.PlateNumber.Contains(plateNumber)).ToList();
                        }
                    }
                    else
                    {
                        // lay tat ban ghi chua xuat, chua nhap
                        return db.ViewAllVehicles.Where(g => (g.IsExport == null || g.IsExport == false) && (g.IsImport == null || g.IsImport == false) && g.PlateNumber.Contains(plateNumber)).ToList();
                    }
                }    
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

        /// <summary>
        /// Select Vehicle by VehicleID
        /// </summary>
        /// <param name="vehicleID"></param>
        /// <returns></returns>
        public VehicleInfo SelectByID(int vehicleID)
        {
            var vehicleInfo = _vehicleDAL.SelectByID(vehicleID);
            if (vehicleInfo.ExportDate != null)
                vehicleInfo.ExportHour = vehicleInfo.ExportDate.Value.ToString("hh:mm");
            if (vehicleInfo.ImportDate != null)
                vehicleInfo.ImportHour = vehicleInfo.ImportDate.Value.ToString("hh:mm");
            return vehicleInfo;
        }

        public static tblVehicle GetByID(int vehicleID) {
            var db = new dbEcustomEntities(Utilities.Common.Decrypt(ConfigurationManager.ConnectionStrings["dbEcustomEntities"].ConnectionString, true));
            return db.tblVehicles.Where(g => g.VehicleID == vehicleID).FirstOrDefault();
        }

        /// <summary>
        /// Update vehicle
        /// </summary>
        /// <param name="vehicleInfo">vehicleInfo object</param>
        /// <returns>Number of rows are effected</returns>
        public int Update(VehicleInfo vehicleInfo)
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

        /// <summary>
        /// Update Vehicle
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        public static int UpdateVehicle(tblVehicle vehicle ) {
            var db = new dbEcustomEntities(Utilities.Common.Decrypt(ConfigurationManager.ConnectionStrings["dbEcustomEntities"].ConnectionString, true));
            // Get orgin vehicle
            var vehicleOrgin = db.tblVehicles.Where(g => g.VehicleID == vehicle.VehicleID).FirstOrDefault();
            db.Attach(vehicleOrgin);
            db.ApplyPropertyChanges("tblVehicles", vehicle);
            return db.SaveChanges();
        }

        /// <summary>
        /// Delete vehicle by ID
        /// </summary>
        /// <param name="vehicleID">Vehicle ID</param>
        /// <returns>Number of rows are effected</returns>
        public static int DeleteByID(int vehicleID)
        {
            var db = new dbEcustomEntities(Utilities.Common.Decrypt(ConfigurationManager.ConnectionStrings["dbEcustomEntities"].ConnectionString, true));
            var vehicle = db.tblVehicles.Where(g => g.VehicleID == vehicleID).FirstOrDefault();
            db.DeleteObject(vehicle);
            return db.SaveChanges();
        }
        
        /// <summary>
        /// Insert vehicel
        /// </summary>
        /// <param name="vehicleInfo">VehicleInfo object</param>
        /// <returns>Number of rows are effectd</returns>
        public int Insert(VehicleInfo vehicleInfo)
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

        /// <summary>
        ///  Get all Exported vehicle
        /// </summary>
        /// <returns></returns>
        public static List<tblVehicle> GetExported() {
            var db = new dbEcustomEntities(Utilities.Common.Decrypt(ConfigurationManager.ConnectionStrings["dbEcustomEntities"].ConnectionString, true));
            return db.tblVehicles.Where(g => g.IsExport == true).ToList();
        }        
    }
}
