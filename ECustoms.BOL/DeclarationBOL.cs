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
        public void AddDeclaration(DeclarationInfo declarationInfo, List<VehicleInfo> vehicleInfos)
        {
            try
            {
                var declarationID = _declarationDAL.Insert(declarationInfo);
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
                            vehicleInfos[i].ImportDate = new DateTime(1900, 1,1); // Set default value
                        }

                        if (!string.IsNullOrEmpty(vehicleInfos[i].ExportHour) && vehicleInfos[i].ExportDate != null && vehicleInfos[i].IsExport)
                        {
                            var exporttHour = Convert.ToInt32(vehicleInfos[i].ExportHour.Split(':')[0]);
                            var exporMinitues  = Convert.ToInt32(vehicleInfos[i].ExportHour.Split(':')[1]);
                            // Add export minitues
                            vehicleInfos[i].ExportDate = vehicleInfos[i].ExportDate.Value.AddMinutes(exporMinitues - vehicleInfos[i].ExportDate.Value.Minute);
                            // Add export hour
                            vehicleInfos[i].ExportDate = vehicleInfos[i].ExportDate.Value.AddHours(exporttHour - vehicleInfos[i].ExportDate.Value.Hour);
                        }
                        else
                        {
                             vehicleInfos[i].ExportDate = new DateTime(1900,1,1); // Set default value
                        }
                        _vehicleDAL.Insert(vehicleInfos[i]);
                    }
                }
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
        public List<DeclarationInfo> GetDecleration()
        {
            try
            {
                return _declarationDAL.Select();
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
        /// Update Decleration table
        /// </summary>
        /// <param name="declerationInfo">Decleration updated information</param>
        /// <returns>Number of rows are effected</returns>
        public int UpdateDecleration(DeclarationInfo declerationInfo)
        {
            var result = -1;
            try
            {
                result = _declarationDAL.UpdateByID(declerationInfo);
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
            try
            {
                return _declarationDAL.SelectByID(declarationID);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
