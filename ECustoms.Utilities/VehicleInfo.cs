using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ECustoms.Utilities
{
    public class VehicleInfo
    {
        #region public properties
        public int VehicleID { get; set; }
        public int DeclarationID { get; set; }
        public int DeclarationNumberExport { set; get; }
        public int DeclarationNumberImport { set; get; }
        private string _plateNumber = "";
        public string PlateNumber
        {
            get { return _plateNumber; }
            set { _plateNumber = value; }
        }
        public int NumberOfContainer { get; set; }

        private string _driverName = "";
        public string DriverName
        {
            get { return _driverName; }
            set { _driverName = value; }
        }

        private string _note = "";
        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }

        private string _status = "";
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private DateTime? _exportDate = new DateTime(1900, 1, 1);
        public DateTime? ExportDate
        {
            get { return _exportDate; }
            set { _exportDate = value; }
        }

        public bool IsExport { get; set; }

        private DateTime? _importDate = new DateTime(1900, 1, 1);
        public DateTime? ImportDate
        {
            get { return _importDate; }
            set
            {
                _importDate = value;
            }
        }

        public bool IsImport { get; set; }
        private string _importHour;
        public string ImportHour
        {
            get
            {
                return _importHour;
            }
            set { _importHour = value; }
        }

        private string _exportHour;
        public string ExportHour
        {
            get
            {
                return _exportHour;
            }
            set { _exportHour = value; }
        }

        public bool IsCompleted { get; set; }

        /// <summary>
        /// This propety use to set and get the count of vehicle
        /// </summary>
        public int Count { get; set; }

        public bool IsGoodsImported { get; set; }

        // Nhập cảnh có hàng
        public bool HasGoodsImported { get; set; }
        private DateTime _importedLocalTime = new DateTime(1900, 1, 1);
        public DateTime ImportedLocalTime
        {
            get { return _importedLocalTime; }
            set { _importedLocalTime = value; }
        }
        private string _importStatus = "";
        public string ImportStatus
        {
            get { return _importStatus; }
            set { _importStatus = value; }
        }


        public int ConfirmImportBy { set; get; }
        public int ConfirmExportBy { set; get; }
        public int ConfirmLocalImportBy { set; get; }

        public string ConfirmImportByName { set; get; }
        public string ConfirmExportByName { set; get; }
        public string ConfirmLocalImportByName { set; get; }
        #endregion

        #region Methods
        public void CreateFrom(DataRow dr)
        {


            if (dr.Table.Columns.Contains("DeclarationNumberExport") && !dr.IsNull("DeclarationNumberExport"))
            {
                this.DeclarationNumberExport = Convert.ToInt32(dr["DeclarationNumberExport"]);
            }
            else
                this.DeclarationNumberExport = 0;


            if (dr.Table.Columns.Contains("DeclarationNumberImport") && !dr.IsNull("DeclarationNumberImport"))
            {
                this.DeclarationNumberImport = Convert.ToInt32(dr["DeclarationNumberImport"]);
            }
            else
                this.DeclarationNumberImport = 0;


            if (dr.Table.Columns.Contains("HasGoodsImported") && !dr.IsNull("HasGoodsImported"))
            {
                this.HasGoodsImported = Convert.ToBoolean(dr["HasGoodsImported"]);
            }

            if (dr.Table.Columns.Contains("IsGoodsImported") && !dr.IsNull("IsGoodsImported"))
            {
                this.IsGoodsImported = Convert.ToBoolean(dr["IsGoodsImported"]);
            }


            try
            {

                if (dr.Table.Columns.Contains("ConfirmImportBy") && !dr.IsNull("ConfirmImportBy"))
                {
                    this.ConfirmImportBy = Convert.ToInt32(dr["ConfirmImportBy"]);
                }
                else this.ConfirmImportBy = 0;
                if (dr.Table.Columns.Contains("ConfirmExportBy") && !dr.IsNull("ConfirmExportBy"))
                {
                    this.ConfirmExportBy = Convert.ToInt32(dr["ConfirmExportBy"]);
                }
                else this.ConfirmExportBy = 0;

                if (dr.Table.Columns.Contains("ConfirmLocalImportBy") && !dr.IsNull("ConfirmLocalImportBy"))
                {
                    this.ConfirmLocalImportBy = Convert.ToInt32(dr["ConfirmLocalImportBy"]);
                }
                else this.ConfirmLocalImportBy = 0;

                /*Name*/

                if (dr.Table.Columns.Contains("ConfirmImportByName") && !dr.IsNull("ConfirmImportByName"))
                {
                    this.ConfirmImportByName = Convert.ToString(dr["ConfirmImportByName"]);
                }
                else this.ConfirmImportByName = "";
                if (dr.Table.Columns.Contains("ConfirmExportByName") && !dr.IsNull("ConfirmExportByName"))
                {
                    this.ConfirmExportByName = Convert.ToString(dr["ConfirmExportByName"]);
                }
                else this.ConfirmExportByName = "";

                if (dr.Table.Columns.Contains("ConfirmLocalImportByName") && !dr.IsNull("ConfirmLocalImportByName"))
                {
                    this.ConfirmLocalImportByName = Convert.ToString(dr["ConfirmLocalImportByName"]);
                }
                else this.ConfirmLocalImportByName = "";

            }
            catch (Exception ex)
            {
                throw;
            }

            try
            {
                if (dr.Table.Columns.Contains(ConstantInfo.TBL_VEHICLE_VEHICLE_ID) && !dr.IsNull(ConstantInfo.TBL_VEHICLE_VEHICLE_ID))
                {
                    this.VehicleID = Convert.ToInt32(dr[ConstantInfo.TBL_VEHICLE_VEHICLE_ID]);
                }

                if (dr.Table.Columns.Contains(ConstantInfo.TBL_DECLARATION_DECLARATION_ID) && !dr.IsNull(ConstantInfo.TBL_DECLARATION_DECLARATION_ID))
                {
                    this.DeclarationID = Convert.ToInt32(dr[ConstantInfo.TBL_DECLARATION_DECLARATION_ID]);
                }

                if (dr.Table.Columns.Contains(ConstantInfo.TBL_VEHICLE_PLATE_NUMBER) && !dr.IsNull(ConstantInfo.TBL_VEHICLE_PLATE_NUMBER))
                {
                    this.PlateNumber = dr[ConstantInfo.TBL_VEHICLE_PLATE_NUMBER].ToString();
                }

                if (dr.Table.Columns.Contains(ConstantInfo.TBL_VEHICLE_NUMBER_OF_CONTAINER) && !dr.IsNull(ConstantInfo.TBL_VEHICLE_NUMBER_OF_CONTAINER))
                {
                    this.NumberOfContainer = Convert.ToInt32(dr[ConstantInfo.TBL_VEHICLE_NUMBER_OF_CONTAINER]);
                }


                if (dr.Table.Columns.Contains(ConstantInfo.TBL_VEHICLE_DRIVER_NAME) && !dr.IsNull(ConstantInfo.TBL_VEHICLE_DRIVER_NAME))
                {
                    this.DriverName = dr[ConstantInfo.TBL_VEHICLE_DRIVER_NAME].ToString();
                }



                if (dr.Table.Columns.Contains(ConstantInfo.TBL_VEHICLE_IS_IMPORT) && !dr.IsNull(ConstantInfo.TBL_VEHICLE_IS_IMPORT))
                {
                    this.IsImport = Convert.ToBoolean(dr[ConstantInfo.TBL_VEHICLE_IS_IMPORT]);
                }



                if (dr.Table.Columns.Contains(ConstantInfo.TBL_VEHICLE_IS_EXPORT) && !dr.IsNull(ConstantInfo.TBL_VEHICLE_IS_EXPORT))
                {
                    this.IsExport = Convert.ToBoolean(dr[ConstantInfo.TBL_VEHICLE_IS_EXPORT]);
                }

                if (dr.Table.Columns.Contains(ConstantInfo.TBL_VEHICLE_NOTE) && !dr.IsNull(ConstantInfo.TBL_VEHICLE_NOTE))
                {
                    this.Note = dr[ConstantInfo.TBL_VEHICLE_NOTE].ToString();
                }
                if (dr.Table.Columns.Contains(ConstantInfo.TBL_VEHICLE_STATUS) && !dr.IsNull(ConstantInfo.TBL_VEHICLE_STATUS))
                {
                    this.Status = dr[ConstantInfo.TBL_VEHICLE_STATUS].ToString();
                }

                if (dr.Table.Columns.Contains(ConstantInfo.TBL_VEHICLE_IS_COMPLETED) && !dr.IsNull(ConstantInfo.TBL_VEHICLE_IS_COMPLETED))
                {
                    this.IsCompleted = Convert.ToBoolean(dr[ConstantInfo.TBL_VEHICLE_IS_COMPLETED]);
                }

                if (dr.Table.Columns.Contains(ConstantInfo.TBL_VEHICLE_IS_GOODS_IMPORTED) && !dr.IsNull(ConstantInfo.TBL_VEHICLE_IS_GOODS_IMPORTED))
                {
                    this.IsGoodsImported = Convert.ToBoolean(dr[ConstantInfo.TBL_VEHICLE_IS_GOODS_IMPORTED]);
                }

                if (dr.Table.Columns.Contains(ConstantInfo.TBL_VEHICLE_IMPORT_STATUS) && !dr.IsNull(ConstantInfo.TBL_VEHICLE_IMPORT_STATUS))
                {
                    this.ImportStatus = dr[ConstantInfo.TBL_VEHICLE_IMPORT_STATUS].ToString();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            try
            {
                if (dr.Table.Columns.Contains(ConstantInfo.TBL_VEHICLE_IMPORTED_LOCAL_TIME) && !dr.IsNull(ConstantInfo.TBL_VEHICLE_IMPORTED_LOCAL_TIME))
                {
                    this.ImportedLocalTime = Convert.ToDateTime(dr[ConstantInfo.TBL_VEHICLE_IMPORTED_LOCAL_TIME].ToString());
                }
                else this.ImportedLocalTime = DateTime.MinValue;

                if (dr.Table.Columns.Contains(ConstantInfo.TBL_VEHICLE_EXPORT_DATE) && !dr.IsNull(ConstantInfo.TBL_VEHICLE_EXPORT_DATE))
                {
                    this.ExportDate = Convert.ToDateTime(dr[ConstantInfo.TBL_VEHICLE_EXPORT_DATE]);
                }
                else this.ExportDate = DateTime.MinValue;

                if (dr.Table.Columns.Contains(ConstantInfo.TBL_VEHICLE_IMPORT_DATE) && !dr.IsNull(ConstantInfo.TBL_VEHICLE_IMPORT_DATE))
                {
                    this.ImportDate = Convert.ToDateTime(dr[ConstantInfo.TBL_VEHICLE_IMPORT_DATE]);
                }
                else this.ImportDate = DateTime.MinValue;

            }
            catch (Exception ex)
            {
                throw;

            }
        }
        #endregion
    }
}
