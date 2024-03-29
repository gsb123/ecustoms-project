﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using ECustoms.BOL;
using ECustoms.Utilities;
using Microsoft.Office.Interop.Excel;
using Point = System.Drawing.Point;
using log4net;
using ECustoms.DAL;
using System.Configuration;

namespace ECustoms
{
    public partial class frmDecleration : Form
    {
        private readonly ILog logger = LogManager.GetLogger("Ecustoms.frmDecleration");

        private DeclarationFactory _declarationBOL;
        private UserInfo _userInfo;
        private Form _parrent;
        private System.Timers.Timer aTimer;
        private List<ViewAllDeclaration> _listDeclarationinfo;
        public frmDecleration()
        {
            InitializeComponent();
        }

        public frmDecleration(UserInfo userInfo, Form parrent)
        {
            InitializeComponent();
            _userInfo = userInfo;
            _parrent = parrent;
        }


        private void frmDecleration_Load(object sender, EventArgs e)
        {
            try
            {
                this.FormClosed += new FormClosedEventHandler(frmDecleration_FormClosed);
                this.Text = "Danh sách tờ khai" + ConstantInfo.MESSAGE_TITLE;
                // Show form to the center
                this.Location = new Point((this.ParentForm.Width - this.Width) / 2, (this.ParentForm.Height - this.Height) / 2);
                _declarationBOL = new DeclarationFactory();

                this._listDeclarationinfo = DeclarationFactory.SelectAllFromView();
                BindData();
                txtDeclaraceNumber.Focus();
                InitialPermission();

                //Start a timer

                // The secret here :)
                this.aTimer = new System.Timers.Timer();
                this.aTimer.Elapsed += new ElapsedEventHandler(OnTimerMonitor);
                this.aTimer.Interval = Convert.ToInt32(System.Configuration.ConfigurationSettings.AppSettings["TimeDelay"]) * 1000;
                this.aTimer.Enabled = true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
                if (GlobalInfo.IsDebug) MessageBox.Show(ex.ToString());
            }
        }

        void frmDecleration_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.aTimer.Enabled = false;
        }

        private void OnTimerMonitor(object sender, System.Timers.ElapsedEventArgs e)
        {
            MonitorContacIdCallback monitorContacIdCallback = new MonitorContacIdCallback(BindData);
            this.Invoke(monitorContacIdCallback);
        }

        private delegate void MonitorContacIdCallback();

        /// <summary>
        /// Personal check
        /// </summary>
        private void InitialPermission()
        {
            //throw new NotImplementedException();

            if (_userInfo.Type == UserType.Admin)
            {

            }
            else if (_userInfo.Type == UserType.Confirm)
            {
                btnDelete.Enabled = false;
            }
            else if (_userInfo.Type == UserType.Input)
            {
                //TODO:
            }
        }

        /// <summary>
        /// Bind data by search codition
        /// This methold will be called after refresh time ( from web.config)
        /// </summary>
        public void BindData()
        {
            try
            {
                // Get declaration from database
                _listDeclarationinfo = DeclarationFactory.SelectAllFromView();
                var declarationNumber = txtDeclaraceNumber.Text.Trim();
                var companyName = txtCompanyName.Text.Trim();
                List<ViewAllDeclaration> result = null;


                if (string.IsNullOrEmpty(txtDeclaraceNumber.Text) && string.IsNullOrEmpty(txtCompanyName.Text))
                {
                    result = _listDeclarationinfo;
                }
                else if (string.IsNullOrEmpty(txtCompanyName.Text))
                { //has nunber, not has copany name
                    result = _listDeclarationinfo.Where(d => d.Number.ToString().Contains(declarationNumber) || d.ImportNumber.ToString().Contains(declarationNumber)).ToList();
                }
                else if (string.IsNullOrEmpty(txtDeclaraceNumber.Text))
                { // has company name, has not number
                    result = _listDeclarationinfo.Where(d => (d.CompanyName != null) && (d.CompanyName.Contains(companyName) || d.ImportCompanyName.Contains(companyName))).ToList();
                }
                grvDecleration.AutoGenerateColumns = false;
                grvDecleration.DataSource = result;

                if (result != null && result.Count > 0)
                {
                    SetVehicleInfo(grvDecleration.Rows[0]);
                }
                else
                {  // No result
                    lblHeader.Text = "";
                    listViewVehicle.Clear();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
                if (GlobalInfo.IsDebug) MessageBox.Show(ex.ToString());
            }            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (grvDecleration.SelectedRows.Count > 0)
                {
                    var dr = MessageBox.Show("Bạn có chắc là muốn xóa?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        for (int i = 0; i < grvDecleration.SelectedRows.Count; i++)
                        {
                            var declerationID = Convert.ToInt32(grvDecleration.SelectedRows[i].Cells[0].Value);
                            DeclarationFactory.DeleteByID(declerationID);
                        }
                        MessageBox.Show("Xóa xong");
                        BindData();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn cần chọn tờ khai.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
                if (GlobalInfo.IsDebug) MessageBox.Show(ex.ToString());
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (grvDecleration.SelectedRows.Count != 0)
                {
                    frmExport frmExport = new frmExport(_userInfo, 1, Convert.ToInt32(grvDecleration.SelectedRows[0].Cells[0].Value));
                    frmExport.MdiParent = _parrent;
                    frmExport.Show();
                }
                else
                {
                    MessageBox.Show("Bạn cần chọn 1 tờ khai cần cập nhật.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
                if (GlobalInfo.IsDebug) MessageBox.Show(ex.ToString());              
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmExport = new frmExport(_userInfo, 0, this);
            frmExport.MdiParent = _parrent;
            frmExport.Show();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                var excel = new ApplicationClass();
                excel.Application.Workbooks.Add(true);

                var columnIndex = 0;
                for (var i = 0; i < grvDecleration.Columns.Count; i++)
                {
                    if (!grvDecleration.Columns[i].Visible) continue;
                    columnIndex++;
                    excel.Cells[1, columnIndex] = grvDecleration.Columns[i].HeaderText;
                    ((Range)excel.Cells[1, columnIndex]).Font.Bold = true;
                }
                int rowIndex = 0;                
                foreach (var declarationInfo in _listDeclarationinfo)
                {
                    rowIndex++;
                    excel.Cells[rowIndex + 1, 1] = declarationInfo.Number != null  ? declarationInfo.Number : 0 ;
                    excel.Cells[rowIndex + 1, 2] = declarationInfo.CompanyCode != null ? declarationInfo.CompanyCode : "" ;
                    excel.Cells[rowIndex + 1, 3] = declarationInfo.ExportType != null ? declarationInfo.ExportType : "";
                    excel.Cells[rowIndex + 1, 4] = declarationInfo.RegisterDate != null ? declarationInfo.RegisterDate.Value.ToString("dd/MM/yyyy hh:mm") : "";
                    excel.Cells[rowIndex + 1, 5] = declarationInfo.ImportNumber != null ? declarationInfo.ImportNumber : 0;
                    excel.Cells[rowIndex + 1, 6] = declarationInfo.ImportCompanyCode != null ? declarationInfo.ImportCompanyCode : "";
                    excel.Cells[rowIndex + 1, 7] = declarationInfo.ImportType != null ? declarationInfo.ImportType: "";
                    excel.Cells[rowIndex + 1, 8] = declarationInfo.ImportRegisterDate != null ? declarationInfo.ImportRegisterDate.Value.ToString("dd/MM/yyyy hh:mm") : "";
                    excel.Cells[rowIndex + 1, 9] = declarationInfo.ProductName != null ? declarationInfo.ProductName : "";
                    excel.Cells[rowIndex + 1, 10] = declarationInfo.ImportProductName != null ? declarationInfo.ImportProductName : "";
                    excel.Cells[rowIndex + 1, 11] = declarationInfo.CompanyName != null ? declarationInfo.CompanyName : "";
                    excel.Cells[rowIndex + 1, 12] = declarationInfo.ImportCompanyName != null ? declarationInfo.ImportCompanyName : "";
                    excel.Cells[rowIndex + 1, 13] = declarationInfo.ProductAmount != null ? declarationInfo.ProductAmount : "";
                    excel.Cells[rowIndex + 1, 14] = declarationInfo.ImportProductAmount != null ? declarationInfo.ImportProductAmount : "";
                    excel.Cells[rowIndex + 1, 15] = declarationInfo.Unit != null ?declarationInfo.Unit : "";
                    excel.Cells[rowIndex + 1, 16] = declarationInfo.ImportUnit != null ? declarationInfo.ImportUnit : "";
                    excel.Cells[rowIndex + 1, 17] = declarationInfo.ModifiedDate != null ? declarationInfo.ModifiedDate.Value.ToString("dd/MM/yyyy hh:mm") : "";
                    excel.Cells[rowIndex + 1, 18] = declarationInfo.ModifiedBy != null ? declarationInfo.ModifiedBy : "";
                    excel.Cells[rowIndex + 1, 19] = declarationInfo.CreatedBy != null ? declarationInfo.CreatedBy : "";
                    excel.Cells[rowIndex + 1, 20] = declarationInfo.CreatedDate != null ? declarationInfo.CreatedDate.Value.ToString("dd/MM/yyyy hh:mm")  : "";
                }
                excel.Visible = true;
                var worksheet = (Worksheet)excel.ActiveSheet;
                worksheet.Activate();

            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
                if (GlobalInfo.IsDebug) MessageBox.Show(ex.ToString());
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void grvDecleration_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


            BindData();
        }

        private void BindSearch() 
        {
            try
            {
                var declarationNumber = txtDeclaraceNumber.Text.Trim();
                var companyName = txtCompanyName.Text.Trim();
                List<tblDeclaration> result = null;
                var db = new dbEcustomEntities(Utilities.Common.Decrypt(ConfigurationManager.ConnectionStrings["dbEcustomEntities"].ConnectionString, true));

                List<tblDeclaration> listDeclaration = db.tblDeclarations.ToList();
                result = listDeclaration.Where(d => (d.Number.ToString().Equals(declarationNumber) || d.ImportNumber.ToString().Equals(declarationNumber)) && (d.CompanyName.Contains(companyName) || d.ImportCompanyName.Contains(companyName))).ToList();
                grvDecleration.DataSource = result;
            }
            catch (Exception ex)
            {
                if (GlobalInfo.IsDebug) MessageBox.Show(ex.ToString());
                logger.Error(ex.ToString());
            }
            
        }

        private void grvDecleration_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grvDecleration_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grvDecleration_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {               
                logger.Info("grvDecleration_CellMouseClick");
                SetVehicleInfo(grvDecleration.Rows[e.RowIndex]);
                
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
                if (GlobalInfo.IsDebug) MessageBox.Show(ex.ToString());
            }            
        }

        /// <summary>
        /// Set Vehicel
        /// </summary>
        /// <param name="row"></param>
        private void SetVehicleInfo(DataGridViewRow row) {
            try
            {
                // Clear result
                listViewVehicle.Clear();
                lblHeader.Visible = true;

                var exportNumber = row.Cells["Number"].Value;
                var importNumber = row.Cells["ImportNumber"].Value;
                lblHeader.Text = "Thông tin về phương tiện chở hàng cho tờ khai xuất " + exportNumber + "; Tờ khai nhập " + importNumber + ":";
                // Get List vehicle 
                var declaractionID = Convert.ToInt32(row.Cells["DeclarationID"].Value);
                var vehicleBOL = new VehicleFactory();
                var listVehicle = vehicleBOL.SelectByDeclarationID(declaractionID);
                StringBuilder vehicleInfo;
                // return if does not any vehicle
                if (listVehicle.Count <= 0) return;
                for (int i = 0; i < listVehicle.Count; i++)
                {
                    var currentVehicle = listVehicle[i];
                    vehicleInfo = new StringBuilder();
                    vehicleInfo.Append("Xe " + currentVehicle.PlateNumber + "; ");
                    // Exported information
                    if (currentVehicle.IsExport) // Exported
                        vehicleInfo.Append("Đã xuất cảnh ngày " + currentVehicle.ExportDate.Value.ToString("dd/MM/yyyy HH:mm"));
                    else // not exported
                        vehicleInfo.Append(" Chưa XC;");
                    // Import Information
                    if (currentVehicle.IsImport) // Imported
                        vehicleInfo.Append(" Đã NC ngày " + currentVehicle.ImportDate.Value.ToString("dd/MM/yyyy HH:MM"));
                    else // not imported
                        vehicleInfo.Append(" Chưa NC;");
                    // hasGoodsImport
                    if (currentVehicle.HasGoodsImported)
                        vehicleInfo.Append(" Có chở hàng NK;");
                    else
                        vehicleInfo.Append(" Không chở hàng NK;");
                    // Go to local
                    if (currentVehicle.IsGoodsImported)
                        vehicleInfo.Append(" Đã vào nội địa");
                    else
                        vehicleInfo.Append(" Chưa vào nội địa");

                    // Add data to listView
                    listViewVehicle.Items.Add(vehicleInfo.ToString());
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
                if (GlobalInfo.IsDebug) MessageBox.Show(ex.ToString());
            }
        }

        private void grvDecleration_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && grvDecleration.SelectedRows.Count == 1) // Only select one row
                {
                    frmExport frmExport = new frmExport(_userInfo, 1, Convert.ToInt32(grvDecleration.SelectedRows[0].Cells[0].Value));
                    frmExport.MdiParent = _parrent;
                    frmExport.Show();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
                if (GlobalInfo.IsDebug) MessageBox.Show(ex.ToString());
            }
        }
    }
}
