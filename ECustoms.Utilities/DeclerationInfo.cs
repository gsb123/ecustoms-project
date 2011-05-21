using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ECustoms.Utilities
{
    public class DeclarationInfo
    {
        #region public properties
        public int DeclarationID { get; set; }
        public int Number { get; set; }

        private string _importType = "";
        private string _exportType = "";

        public string ImportType
        {
            get { return _importType; }
            set { _importType = value; }
        }

        public string ExportType
        {
            get { return _exportType; }
            set { _exportType = value; }
        }

        private string _productName = "";
        public string ProductName 
        {
            get { return _productName; }
            set { _productName = value; }
        }

        private string _companyName = "";
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        private string _productAmount = "";
        public string ProductAmount
        {
            get { return _productAmount; }
            set { _productAmount = value; }
        }

        private string _unit = "";
        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }
        public int CreatedByID { get; set; }
        public int ModifiedByID { get; set; }
        public DateTime ModifiedDate { get; set; }

        private string _createdBy = "";
        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }
        public DateTime CreatedDate { get; set; }
        public bool HasDeclaration { get; set; }

        public int ImportNumber { get; set; }

        private string _importProductName = "";
        public string ImportProductName
        {
            get { return _importProductName; }
            set { _importProductName = value; }
        }

        private string _importCompanyName = "";
        public string ImportCompanyName
        {
            get { return _importCompanyName; }
            set { _importCompanyName = value; }
        }

        private string _importProductAmount = "";
        public string ImportProductAmount
        {
            get { return _importProductAmount; }
            set { _importProductAmount = value; }
        }

        private string _importUnit = "";
        public string ImportUnit
        {
            get { return _importUnit; }
            set { _importUnit = value; }
        }
        public bool ImportHasDeclaration { get; set; }
        #endregion

        #region Methods
        public void CreateFrom(DataRow dr)
        {
            if (dr.Table.Columns.Contains(ConstantInfo.TBL_DECLARATION_DECLARATION_ID) && !dr.IsNull(ConstantInfo.TBL_DECLARATION_DECLARATION_ID))
            {
                this.DeclarationID = Convert.ToInt32(dr[ConstantInfo.TBL_DECLARATION_DECLARATION_ID]);
            }
            if (dr.Table.Columns.Contains(ConstantInfo.TBL_DECLARATION_NUMBER) && !dr.IsNull(ConstantInfo.TBL_DECLARATION_NUMBER))
            {
                this.Number = Convert.ToInt32(dr[ConstantInfo.TBL_DECLARATION_NUMBER]);
            }

            if (dr.Table.Columns.Contains(ConstantInfo.TBL_DECLARATION_PRODUCT_NAME) && !dr.IsNull(ConstantInfo.TBL_DECLARATION_PRODUCT_NAME))
            {
                this.ProductName = dr[ConstantInfo.TBL_DECLARATION_PRODUCT_NAME].ToString();
            }

            if (dr.Table.Columns.Contains(ConstantInfo.TBL_DECLARATION_COMPANY_NAME) && !dr.IsNull(ConstantInfo.TBL_DECLARATION_COMPANY_NAME))
            {
                this.CompanyName = dr[ConstantInfo.TBL_DECLARATION_COMPANY_NAME].ToString();
            }
            if (dr.Table.Columns.Contains(ConstantInfo.TBL_DECLARATION_PRODUCT_AMOUNT) && !dr.IsNull(ConstantInfo.TBL_DECLARATION_PRODUCT_AMOUNT))
            {
                this.ProductAmount = dr[ConstantInfo.TBL_DECLARATION_PRODUCT_AMOUNT].ToString();
            }
            if (dr.Table.Columns.Contains(ConstantInfo.TBL_DECLARATION_UNIT) && !dr.IsNull(ConstantInfo.TBL_DECLARATION_UNIT))
            {
                this.Unit = dr[ConstantInfo.TBL_DECLARATION_UNIT].ToString();
            }

            if (dr.Table.Columns.Contains(ConstantInfo.TBL_DECLARATION_CREATED_BY_ID) && !dr.IsNull(ConstantInfo.TBL_DECLARATION_CREATED_BY_ID))
            {
                this.CreatedByID = Convert.ToInt32(dr[ConstantInfo.TBL_DECLARATION_CREATED_BY_ID]);
            }

            if (dr.Table.Columns.Contains(ConstantInfo.TBL_DECLARATION_MODIFIED_BY_ID) && !dr.IsNull(ConstantInfo.TBL_DECLARATION_MODIFIED_BY_ID))
            {
                this.ModifiedByID = Convert.ToInt32(dr[ConstantInfo.TBL_DECLARATION_CREATED_BY_ID]);
            }
            if (dr.Table.Columns.Contains(ConstantInfo.TBL_DECLARATION_MODIFIED_DATE) && !dr.IsNull(ConstantInfo.TBL_DECLARATION_MODIFIED_DATE))
            {
                this.ModifiedDate = Convert.ToDateTime(dr[ConstantInfo.TBL_DECLARATION_MODIFIED_DATE]);
            }

            if (dr.Table.Columns.Contains(ConstantInfo.TBL_USER_NAME) && !dr.IsNull(ConstantInfo.TBL_USER_NAME))
            {
                this.CreatedBy = dr[ConstantInfo.TBL_USER_NAME].ToString();
            }

            if (dr.Table.Columns.Contains(ConstantInfo.TBL_DECLARATION_CREATED_DATE) && !dr.IsNull(ConstantInfo.TBL_DECLARATION_CREATED_DATE))
            {
                this.CreatedDate = Convert.ToDateTime(dr[ConstantInfo.TBL_DECLARATION_CREATED_DATE]);
            }


            if (dr.Table.Columns.Contains(ConstantInfo.TBL_DECLARATION_HAS_DECLARATION) && !dr.IsNull(ConstantInfo.TBL_DECLARATION_HAS_DECLARATION))
            {
                this.HasDeclaration = Convert.ToBoolean(dr[ConstantInfo.TBL_DECLARATION_HAS_DECLARATION]);
            }
            // import
            if (dr.Table.Columns.Contains("ImportNumber") && !dr.IsNull("ImportNumber"))
            {
                this.ImportNumber = Convert.ToInt32(dr["ImportNumber"]);
            }

            if (dr.Table.Columns.Contains("ImportProductName") && !dr.IsNull("ImportProductName"))
            {
                this.ImportProductName = dr["ImportProductName"].ToString();
            }

            if (dr.Table.Columns.Contains("ImportCompanyName") && !dr.IsNull("ImportCompanyName"))
            {
                this.ImportCompanyName = dr["ImportCompanyName"].ToString();
            }
            if (dr.Table.Columns.Contains("ImportProductAmount") && !dr.IsNull("ImportProductAmount"))
            {
                this.ImportProductAmount = dr["ImportProductAmount"].ToString();
            }
            if (dr.Table.Columns.Contains("ImportUnit") && !dr.IsNull("ImportUnit"))
            {
                this.ImportUnit = dr["ImportUnit"].ToString();
            }

            if (dr.Table.Columns.Contains("ImportHasDeclaration") && !dr.IsNull("ImportHasDeclaration"))
            {
                this.ImportHasDeclaration = Convert.ToBoolean(dr["ImportHasDeclaration"]);
            }

            if (dr.Table.Columns.Contains("ImportType") && !dr.IsNull("ImportType"))
            {
                this.ImportType = dr["ImportType"].ToString();
            }

            if (dr.Table.Columns.Contains("ExportType") && !dr.IsNull("ExportType"))
            {
                this.ExportType = dr["ExportType"].ToString();
            }

        }
        #endregion
    }
}
