﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ECustoms.BOL;
using ECustoms.Utilities;
using Microsoft.Office.Interop.Excel;
using Point = System.Drawing.Point;
using System.Data;
using ECustoms.DAL;
using log4net;

namespace ECustoms
{
    public partial class frmVehicleSearch : Form
    {
        private static log4net.ILog logger = LogManager.GetLogger("Ecustoms.frmVehicleSearch");
        private VehicleFactory _vehicleBOL;
        private UserInfo _userInfo;
        private System.Data.DataTable _dtResult;
        public frmVehicleSearch()
        {
            InitializeComponent();
        }

        public frmVehicleSearch(UserInfo userInfo)
        {
            InitializeComponent();
            _userInfo = userInfo;
            InitialPermission();

        }
        private void InitialPermission()
        {
            //throw new NotImplementedException();

            if (_userInfo.Type == UserType.Admin)
            {

            }
            else if (_userInfo.Type == UserType.Confirm)
            {

            }
            else if (_userInfo.Type == UserType.Input)
            {
                btnXacNhanXuatCanh.Visible = false;
                btnXacNhanNhapCanhCoHang.Visible = false;
                btnXacNhanXuatCanhKhongCoHang.Visible = false;
                btnLocalConfirm.Visible = false;
            }
        }
        private void frmVehicleSearch_Load(object sender, EventArgs e)
        {
            this.Text = "Tìm kiếm" + ConstantInfo.MESSAGE_TITLE;
            // Show form to the center
            this.Location = new Point((this.ParentForm.Width - this.Width) / 2, (this.ParentForm.Height - this.Height) / 2);
            _vehicleBOL = new VehicleFactory();
            //Init data
            BindData();
            txtPlateNumber.Focus();
        }

        private void BindData()
        {
            try
            {
                grdVehicle.AutoGenerateColumns = false;
                List<ViewAllVehicle> result;
                result = _vehicleBOL.SearchVehicle(cbIsCompleted.Checked, txtPlateNumber.Text, cbIsExport.Checked, cbIsImport.Checked, cbIsNotImport.Checked, dtpImportFrom.Value, dtpImportTo.Value,
                                                        dtpExportFrom.Value, dtpExportTo.Value);

                grdVehicle.DataSource = result;
                /*
                 * 
                     1-[Xe không xuất cảnh]=Xe không chở hàng đã xuất cảnh = xe có số tờ khai xuất khẩu
                    bằng 0 đã được xác nhận xuất cảnh.
                    ( [DeclationNumber]=0&& [ComfirmExport=1] 

                    2-[Xe không nhập cảnh]=xe không chở hàng đã nhập cảnh=
                    xe được xác nhận xe nhập cảnh không có hàng.
                    ( [HasGood]=0 && [ComfirmImport=1] 

                    3-xe có hàng xuất cảnh = xe chở hàng đã xuất cảnh= xe có số tờ khai xuất khẩu khác
                    0 đã được xác nhận xuất cảnh.
                    [DeclationNumber<>0]&& [ComfirmExport = 1]

                    4-xe có hàng nhập cảnh = xe chở hàng đã nhập cảnh=xe được xác nhận xe nhập cảnh
                    có hàng.
                    [XeChoHangDaNhapKhau]  = ( [HasGood]=1 && [ComfirmImport=1] 

                    5-Tổng số xe đã vào nội địa = xe chở hàng dược xác nhận xe nhập cảnh có
                    hàng+được xác nhận hàng đã vào nội địa.
                    [XeDaVaoNoiDia] = [LocalImport=1]&&[HasGood=1]&&[ConfirmImport=1]

                    =>xe chở hàng nhập khẩu còn tồn tại cửa khẩu = xe chở hàng đã nhập khẩu- xe đã
                    vào nội địa;
                    [XeNhapKhauTonTaiCuaKhau] = [XeChoHangDaNhapKhau] – [XeDaoVaoNoiDia]
                     xe chở hàng xuất khẩu còn tồn tại cửa khẩu
                     = [xe đã đăng ký có số tờ khai khác 0] – [xe đã đăng ký có số tờ khai khác 0 đã được xác nhận xuất cảnh] = [xe còn tồn trên màn hình tìm kiếm khi bấm vào tìm kiếm.]
                    [XeXuaKhauTonTaiCuaKhau] = [Xe([DeclationNumber<>0]&&[ConfirmExport=0])] - Xe([DeclationNumber<>0]&&[ConfirmExport=1])]

                 * */

                int xeKhongChoHangDaXC = 0;
                int xeKhongChoHangDaNC = 0;
                int xeCoHangDaXC = 0;
                int xeNhapHangDaNC = 0;
                int xeVaoNoiDia = 0;


                foreach (var v in result)
                {
                    // Do something here

                    // Xe khong cho hang da xuat canh
                    if (v.IsExport != null &&  v.IsExport.Value && v.Number == 0)
                        xeKhongChoHangDaXC++;
                    if (v.IsImport != null && v.IsImport.Value && v.HasGoodsImported != null &&  !v.HasGoodsImported.Value)
                        xeKhongChoHangDaNC++;
                    if (v.IsExport != null && v.IsExport.Value && v.DeclarationNumberExport != 0)
                        xeCoHangDaXC++;
                    if (v.IsImport !=null &&  v.IsImport.Value && v.HasGoodsImported !=null && v.HasGoodsImported.Value)
                        xeNhapHangDaNC++;
                    if (v.IsGoodsImported !=null &&  v.IsGoodsImported.Value)
                        xeVaoNoiDia++;

                }

                lblKhongXC.Text = xeKhongChoHangDaXC.ToString();
                lblKhongNC.Text = xeKhongChoHangDaNC.ToString();
                lblCohangNC.Text = xeNhapHangDaNC.ToString();
                lblCoHangXC.Text = xeCoHangDaXC.ToString();
                lblVaonoidia.Text = xeVaoNoiDia.ToString();
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
                if (GlobalInfo.IsDebug) MessageBox.Show(ex.ToString());
            }
        }

        private void cbIsExport_CheckedChanged(object sender, EventArgs e)
        {
            // Export
            if (cbIsExport.Checked)
            {
                EnableExport(true);
            }
            else
            {
                EnableExport(false);
                EnabledImport(false);
                cbIsImport.Checked = false;
                cbIsNotImport.Checked = false;
            }
        }

        private void cbIsImport_CheckedChanged(object sender, EventArgs e)
        {
            // Import
            if (!cbIsExport.Checked && cbIsImport.Checked)
            {
                MessageBox.Show("Bạn phải nhập thời gian xuất cảnh cảnh.");
                cbIsImport.Checked = false;
                return;
            }

            if (cbIsImport.Checked && cbIsExport.Checked) // completed
            {
                EnabledImport(true);
                cbIsNotImport.Checked = false;
                cbIsNotImport.Enabled = false;
                cbIsCompleted.Checked = true;

            }
            else if(!cbIsCompleted.Checked)
            {
                EnabledImport(false);
                cbIsNotImport.Enabled = true;                
            }
        }

        /// <summary>
        /// Enable or disable Import information
        /// </summary>
        /// <param name="value">True is enable</param>
        private void EnabledImport(bool value)
        {
            lblImportFrom.Enabled = value;
            lblImportTo.Enabled = value;
            dtpImportFrom.Enabled = value;
            dtpImportTo.Enabled = value;
        }

        /// <summary>
        /// Enable or disable Export information
        /// </summary>
        /// <param name="value">True if enabled</param>
        private void EnableExport(bool value)
        {
            lblExportFrom.Enabled = value;
            lblExportTo.Enabled = value;
            dtpExportFrom.Enabled = value;
            dtpExportTo.Enabled = value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                BindData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void cbIsNotImport_CheckedChanged(object sender, EventArgs e)
        {           
            // Import
            if (!cbIsExport.Checked && cbIsNotImport.Checked)
            {
                MessageBox.Show("Bạn phải nhập thời gian xuất cảnh.");
                cbIsNotImport.Checked = false;
                return;
            }

            if (cbIsImport.Checked && cbIsNotImport.Checked)
            {
                EnabledImport(true);
                cbIsImport.Checked = false;
                cbIsImport.Enabled = false;

            }
            else if (!cbIsImport.Checked)
            {
                EnabledImport(false);
                cbIsImport.Enabled = true;
            }
        }

        private void grdVehicle_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && grdVehicle.SelectedRows.Count == 1) // Only select one row
                {
                    var vehicle = new frmVehicle(3, Convert.ToInt32(grdVehicle.Rows[e.RowIndex].Cells["VehicleID"].Value), _userInfo);
                    vehicle.MdiParent = this.ParentForm;
                    vehicle.Show();
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

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                var excel = new ApplicationClass();
                excel.Application.Workbooks.Add(true);

                var columnIndex = 0;
                for (var i = 0; i < grdVehicle.Columns.Count; i++)
                {
                    if (!grdVehicle.Columns[i].Visible) continue;
                    columnIndex++;
                    excel.Cells[1, columnIndex] = grdVehicle.Columns[i].HeaderText;
                    ((Range)excel.Cells[1, columnIndex]).Font.Bold = true;
                }

                int rowIndex = 0;

                foreach (DataGridViewRow dataRow in grdVehicle.Rows)
                {
                    rowIndex++;
                    excel.Cells[rowIndex + 1, 1] = dataRow.Cells["Number"].Value != null ? dataRow.Cells["Number"].Value.ToString() : "";
                    excel.Cells[rowIndex + 1, 2] = dataRow.Cells["ExportType"].Value != null ? dataRow.Cells["ExportType"].Value.ToString() : "";
                    excel.Cells[rowIndex + 1, 3] = dataRow.Cells["RegisterDate"].Value != null ? dataRow.Cells["RegisterDate"].Value.ToString() : "";
                    excel.Cells[rowIndex + 1, 4] = dataRow.Cells["PlateNumber"].Value != null ? dataRow.Cells["PlateNumber"].Value.ToString() : "";
                    excel.Cells[rowIndex + 1, 5] = dataRow.Cells["DriverName"].Value != null ? dataRow.Cells["DriverName"].Value.ToString() : "";
                    excel.Cells[rowIndex + 1, 6] = dataRow.Cells["Status"].Value != null ? dataRow.Cells["Status"].Value.ToString() : "";
                    excel.Cells[rowIndex + 1, 7] = dataRow.Cells["Note"].Value != null ? dataRow.Cells["Note"].Value.ToString() : "";
                    excel.Cells[rowIndex + 1, 8] = dataRow.Cells["CompanyName"].Value != null ? dataRow.Cells["ProductName"].Value.ToString() : "";
                    excel.Cells[rowIndex + 1, 9] = dataRow.Cells["ProductName"].Value != null ? dataRow.Cells["ProductName"].Value.ToString() : "";
                    excel.Cells[rowIndex + 1, 10] = dataRow.Cells["ProductAmount"].Value != null ? dataRow.Cells["ProductAmount"].Value.ToString() : "";
                    excel.Cells[rowIndex + 1, 11] = dataRow.Cells["Unit"].Value != null ? dataRow.Cells["Unit"].Value.ToString() : "";
                    excel.Cells[rowIndex + 1, 12] = dataRow.Cells["ExportDate"].Value != null ? dataRow.Cells["ExportDate"].Value.ToString() : "";
                    excel.Cells[rowIndex + 1, 13] = dataRow.Cells["ImportNumber"].Value != null ? dataRow.Cells["ImportNumber"].Value.ToString() : "";
                    excel.Cells[rowIndex + 1, 14] = dataRow.Cells["ImportType"].Value != null ? dataRow.Cells["ImportType"].Value.ToString() : "";
                    excel.Cells[rowIndex + 1, 15] = dataRow.Cells["ImportCompanyName"].Value != null ? dataRow.Cells["ImportCompanyName"].Value.ToString() : "";
                    excel.Cells[rowIndex + 1, 16] = dataRow.Cells["ImportProductName"].Value != null ? dataRow.Cells["ImportProductName"].Value.ToString() : "";
                    excel.Cells[rowIndex + 1, 17] = dataRow.Cells["ImportProductAmount"].Value  != null ? dataRow.Cells["ImportProductAmount"].Value.ToString() : "";
                    excel.Cells[rowIndex + 1, 18] = dataRow.Cells["ImportDate"].Value != null ? dataRow.Cells["ImportDate"].Value.ToString() : "";
                    excel.Cells[rowIndex + 1, 19] = dataRow.Cells["ImportStatus"].Value != null ? dataRow.Cells["ImportStatus"].Value.ToString() : "";
                    excel.Cells[rowIndex + 1, 20] = dataRow.Cells["ImportedLocalTime"].Value != null ? dataRow.Cells["ImportedLocalTime"].Value.ToString() : "";
                    excel.Cells[rowIndex + 1, 21] = dataRow.Cells["ConfirmExportByName"].Value != null ? dataRow.Cells["ConfirmExportByName"].Value.ToString() : "";
                    excel.Cells[rowIndex + 1, 22] = dataRow.Cells["ConfirmImportByName"].Value != null ? dataRow.Cells["ConfirmImportByName"].Value.ToString() : "";
                    excel.Cells[rowIndex + 1, 23] = dataRow.Cells["ConfirmLocalImportByName"].Value != null ? dataRow.Cells["ConfirmLocalImportByName"].Value.ToString() : "";

                    excel.Visible = true;
                    var worksheet = (Worksheet)excel.ActiveSheet;
                    worksheet.Activate();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
                if (GlobalInfo.IsDebug) MessageBox.Show(ex.ToString());
            }
        }

        private void btnUpdateVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdVehicle.SelectedRows.Count == 1)
                {
                    var vehicle = new frmVehicle(3, Convert.ToInt32(grdVehicle.SelectedRows[0].Cells["VehicleID"].Value), _userInfo);
                    vehicle.MdiParent = this.ParentForm;
                    vehicle.Show();
                }
                else
                {
                    MessageBox.Show("Bạn cần chọn 1 phương tiện cần cập nhật.");
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
                if (GlobalInfo.IsDebug) MessageBox.Show(ex.ToString());
            }
        }

        private void txtPlateNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // Enter key
            {
                BindData();
                if (grdVehicle.Rows.Count > 0) // Set focus
                {
                    btnXacNhanXuatCanh.Focus();
                }
            }
        }

        private void btnXacNhanXuatCanh_Click(object sender, EventArgs e)
        {
            try
            {
                var message = new StringBuilder();
                message.Append("Thời gian xuất cảnh: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));

                var vehicleInfo = VehicleFactory.GetByID(int.Parse(grdVehicle.SelectedRows[0].Cells["VehicleID"].Value.ToString()));

                if (MessageBox.Show(message.ToString(), "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    vehicleInfo.ExportDate = DateTime.Now;

                    if (vehicleInfo.ConfirmExportBy != null && vehicleInfo.ConfirmExportBy != 0 && vehicleInfo.ConfirmExportBy != _userInfo.UserID)
                        throw new Exception("Phương tiện đã được xác nhận bởi một người dùng khác!");

                    vehicleInfo.ConfirmExportBy = _userInfo.UserID;
                    vehicleInfo.IsExport = true;
                    VehicleFactory.UpdateVehicle(vehicleInfo);
                }
                // Bind to grid
                BindData();
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
                if (GlobalInfo.IsDebug) MessageBox.Show(ex.ToString());
            }
        }

        private void btnXacNhanNhapCanhCoHang_Click(object sender, EventArgs e)
        {
            try
            {
                var message = new StringBuilder();
                message.Append("Thời gian nhập cảnh: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));

                var vehicle = VehicleFactory.GetByID(int.Parse(grdVehicle.SelectedRows[0].Cells["VehicleID"].Value.ToString()));
                //var vehicle = VehicleFactory.GetByID(int.Parse(grdVehicle.SelectedRows[0].Cells["VehicleID"].Value.ToString()));

                if (MessageBox.Show(message.ToString(), "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    vehicle.ImportDate = DateTime.Now;
                    //vehicle.ImportHour = DateTime.Now.ToString("HH:mm");
                    vehicle.IsImport = true;
                    vehicle.HasGoodsImported = true;
                    vehicle.ImportStatus = "Nhập cảnh có hàng";
                    if (vehicle.ConfirmImportBy != null && vehicle.ConfirmImportBy != 0 && vehicle.ConfirmImportBy != _userInfo.UserID)
                        throw new Exception("Phương tiện đã được xác nhận bởi một người dùng khác!");

                    vehicle.ConfirmImportBy = _userInfo.UserID;
                    VehicleFactory.UpdateVehicle(vehicle);
                }
                // Bind data to gridview
                BindData();
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
                if (GlobalInfo.IsDebug) MessageBox.Show(ex.ToString());
            }
        }

        private void btnXacNhanXuatCanhKhongCoHang_Click(object sender, EventArgs e)
        {
            try
            {
                var message = new StringBuilder();
                message.Append("Thời gian nhập cảnh: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));

                var vehicle = VehicleFactory.GetByID(int.Parse(grdVehicle.SelectedRows[0].Cells["VehicleID"].Value.ToString()));

                if (MessageBox.Show(message.ToString(), "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    vehicle.ImportDate = DateTime.Now;                    
                    vehicle.IsImport = true;
                    vehicle.HasGoodsImported = false;
                    if (vehicle.ConfirmImportBy != null && vehicle.ConfirmImportBy != 0 && vehicle.ConfirmImportBy != _userInfo.UserID)
                        throw new Exception("Phương tiện đã được xác nhận bởi một người dùng khác!");

                    vehicle.ConfirmImportBy = _userInfo.UserID;
                    vehicle.ImportStatus = "Nhập cảnh không có hàng";
                    VehicleFactory.UpdateVehicle(vehicle);
                }
                // Bind data
                BindData();
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
                if (GlobalInfo.IsDebug) MessageBox.Show(ex.ToString());
            }
        }

        private void btnLocalConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var vehicleInfo = VehicleFactory.GetByID(int.Parse(grdVehicle.SelectedRows[0].Cells["VehicleID"].Value.ToString()));
                vehicleInfo.ImportDate = DateTime.Now;                
                vehicleInfo.IsGoodsImported = true;
                vehicleInfo.ImportedLocalTime = DateTime.Now;
                // is completed when user is confirm is local 
                vehicleInfo.IsCompleted = true;

                if (vehicleInfo.ConfirmLocalImportBy != null && vehicleInfo.ConfirmLocalImportBy != 0 && vehicleInfo.ConfirmLocalImportBy != _userInfo.UserID)
                    throw new Exception("Phương tiện đã được xác nhận bởi một người dùng khác!");

                vehicleInfo.ConfirmLocalImportBy = _userInfo.UserID;

                VehicleFactory.UpdateVehicle(vehicleInfo);
                // Bind data to gridview
                BindData();
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
                if (GlobalInfo.IsDebug) MessageBox.Show(ex.ToString());
            }
        }

        private void cbIsCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsCompleted.Checked) {
                cbIsNotImport.Checked = false;
                cbIsNotImport.Enabled = false;
            } else {                
                cbIsNotImport.Enabled = true;
            }
        }

    }
}
