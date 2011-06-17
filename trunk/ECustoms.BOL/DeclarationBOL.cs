using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECustoms.DAL;
using ECustoms.Utilities;

namespace ECustoms.BOL
{
    public class DeclarationBOL
    {
        private readonly string _dbConnectionString;
        private readonly DeclarationDAL _declarationDAL;
        private readonly VehicleDAL _vehicleDAL;

        public DeclarationBOL()
        {
            _dbConnectionString = System.Configuration.ConfigurationSettings.AppSettings["connectionString"];
            _declarationDAL = new DeclarationDAL(_dbConnectionString);
            _vehicleDAL = new VehicleDAL(_dbConnectionString);
        }

        /// <summary>
        /// Insert to Declaration and list vehicle
        /// </summary>
        /// <param name="declarationInfo"></param>
        /// <param name="vehicleInfos"></param>
        public int AddDeclaration(tblDeclaration declarationInfo, List<VehicleInfo> vehicleInfos, int userID)
        {
            var result = -1;
            try
            {
                var db = new dbEcustomEntities();
                declarationInfo.tblUser = db.tblUsers.Where(g => g.UserID.Equals(userID)).FirstOrDefault();
                // Set Created date and Last modified date
                declarationInfo.CreatedDate = DateTime.Now;
                declarationInfo.ModifiedDate = DateTime.Now;
                db.AddTotblDeclarations(declarationInfo);
                db.SaveChanges();
                // Return if insert fail
                if(declarationInfo.DeclarationID <= 0) return - 1;
                var declarationID = declarationInfo.DeclarationID;
                // Add vehicle
                if (declarationID > 0 && vehicleInfos.Count > 0)
                {
                    for (int i = 0; i < vehicleInfos.Count; i++)
                    {
                        // Update DeclarationID
                        vehicleInfos[i].DeclarationID = declarationID;
                        // get hour and miniutes
                        if (!string.IsNullOrEmpty(vehicleInfos[i].ImportHour) && vehicleInfos[i].ImportDate != null && vehicleInfos[i].IsImport) // if it is imported
                        {
                            var importHour = Convert.ToInt32(vehicleInfos[i].ImportHour.Split(':')[0]);
                            var importMinitues = Convert.ToInt32(vehicleInfos[i].ImportHour.Split(':')[1]);
                            // add import our
                            vehicleInfos[i].ImportDate = vehicleInfos[i].ImportDate.Value.AddHours(importHour - vehicleInfos[i].ImportDate.Value.Hour);
                            // Add imort minutes
                            vehicleInfos[i].ImportDate = vehicleInfos[i].ImportDate.Value.AddMinutes(importMinitues - vehicleInfos[i].ImportDate.Value.Minute);
                        }
                        else
                        {
                            vehicleInfos[i].ImportDate = new DateTime(1900, 1, 1); // Set default value
                        }

                        if (!string.IsNullOrEmpty(vehicleInfos[i].ExportHour) && vehicleInfos[i].ExportDate != null && vehicleInfos[i].IsExport)
                        {
                            var exporttHour = Convert.ToInt32(vehicleInfos[i].ExportHour.Split(':')[0]);
                            var exporMinitues = Convert.ToInt32(vehicleInfos[i].ExportHour.Split(':')[1]);
                            // Add export minitues
                            vehicleInfos[i].ExportDate = vehicleInfos[i].ExportDate.Value.AddMinutes(exporMinitues - vehicleInfos[i].ExportDate.Value.Minute);
                            // Add export hour
                            vehicleInfos[i].ExportDate = vehicleInfos[i].ExportDate.Value.AddHours(exporttHour - vehicleInfos[i].ExportDate.Value.Hour);
                        }
                        else
                        {
                            vehicleInfos[i].ExportDate = new DateTime(1900, 1, 1); // Set default value
                        }
                        if (!vehicleInfos[i].PlateNumber.Equals(""))
                            _vehicleDAL.Insert(vehicleInfos[i]);
                    }
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
            try
            {
                return _declarationDAL.DeleteByID(declerationID);
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
        public static tblDeclaration SelectByID(int declarationID)
        {
            try
            {
                var db = new dbEcustomEntities();
                return db.tblDeclarations.Where(g => g.DeclarationID == declarationID).FirstOrDefault();                
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// update declaration
        /// </summary>
        /// <param name="declaration"></param>
        /// <param name="modifiedByID"></param>
        /// <returns></returns>
        public static int Update(tblDeclaration declaration) {
            var db = new dbEcustomEntities();
            var objDeclaration = db.tblDeclarations.Where(g => g.DeclarationID.Equals(declaration.DeclarationID)).FirstOrDefault();
            // Set to the new object
            // Export
            objDeclaration.Number = declaration.Number;
            objDeclaration.ExportType = declaration.ExportType;
            objDeclaration.CompanyName = declaration.CompanyName;
            objDeclaration.CompanyCode = declaration.CompanyCode;
            objDeclaration.RegisterDate = declaration.RegisterDate;
            objDeclaration.ProductAmount = declaration.ProductAmount;
            objDeclaration.Unit = declaration.Unit;
            objDeclaration.ProductName = declaration.ProductName;            
            
            // Import
            objDeclaration.ImportNumber = declaration.ImportNumber;
            objDeclaration.ImportType = declaration.ImportType;
            objDeclaration.ImportCompanyName = declaration.ImportCompanyName;
            objDeclaration.ImportCompanyCode = declaration.ImportCompanyCode;
            objDeclaration.ImportRegisterDate = declaration.ImportRegisterDate;
            objDeclaration.ImportProductAmount = declaration.ImportProductAmount;
            objDeclaration.ImportUnit = declaration.ImportUnit;
            objDeclaration.ImportProductName = declaration.ImportProductName;            
            objDeclaration.ModifiedByID = declaration.ModifiedByID;
            objDeclaration.ModifiedDate = DateTime.Now;

            objDeclaration.HasDeclaration = declaration.HasDeclaration;
            objDeclaration.ImportHasDeclaration = declaration.ImportHasDeclaration;
            objDeclaration.ModifiedByID = declaration.ModifiedByID;
           
            return db.SaveChanges();            
        }

        public static List<ViewAllDeclaration> SelectAllFromView() {
            var db = new dbEcustomEntities();
            return db.ViewAllDeclarations.ToList();
        }
    }
}
