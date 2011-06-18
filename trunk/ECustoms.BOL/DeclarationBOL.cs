﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECustoms.DAL;
using ECustoms.Utilities;
using System.Data.Objects.DataClasses;

namespace ECustoms.BOL
{
    public class DeclarationBOL
    {
        private readonly string _dbConnectionString;        
        private readonly VehicleDAL _vehicleDAL;

        public DeclarationBOL()
        {
            _dbConnectionString = System.Configuration.ConfigurationSettings.AppSettings["connectionString"];            
            _vehicleDAL = new VehicleDAL(_dbConnectionString);
        }

        /// <summary>
        /// Insert to Declaration and list vehicle
        /// </summary>
        /// <param name="declarationInfo"></param>
        /// <param name="vehicleInfos"></param>
        public int AddDeclaration(tblDeclaration declarationInfo, List<tblVehicle> vehicleInfos, int userID)
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
                foreach (var vehicle in vehicleInfos)
                {
                    vehicle.tblDeclaration = declarationInfo;
                    db.AddTotblVehicles(vehicle);
                    db.SaveChanges();
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
        public static int DeleteByID(int declerationID)
        {
            var db = new dbEcustomEntities();
            var declaration = db.tblDeclarations.Where(g => g.DeclarationID == declerationID).FirstOrDefault();
            db.DeleteObject(declaration);
            return db.SaveChanges();
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
            declaration.ModifiedDate = DateTime.Now;
            // Get orgin object
            var objOrginDeclaration = db.tblDeclarations.Where(g => g.DeclarationID.Equals(declaration.DeclarationID)).FirstOrDefault();
            db.Attach(objOrginDeclaration);
            db.ApplyPropertyChanges("tblDeclarations", declaration);
            return db.SaveChanges();            
        }

        public static List<ViewAllDeclaration> SelectAllFromView() {
            var db = new dbEcustomEntities();
            return db.ViewAllDeclarations.ToList();
        }
    }
}
