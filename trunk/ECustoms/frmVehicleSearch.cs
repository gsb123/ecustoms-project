using System;
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

namespace ECustoms
{
    public partial class frmVehicleSearch : Form
    {
        private VehicleBOL _vehicleBOL;
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
            _vehicleBOL = new VehicleBOL();
            //Init data
            BindData();
            txtPlateNumber.Focus();
        }

        private void BindData()
        {
            grdVehicle.AutoGenerateColumns = false;
            System.Data.DataTable dataTable;
            _dtResult = _vehicleBOL.SearchVehicle(cbIsCompleted.Checked, txtPlateNumber.Text, cbIsExport.Checked, cbIsImport.Checked, cbIsNotImport.Checked, dtpImportFrom.Value, dtpImportTo.Value,
                                                     dtpExportFrom.Value, dtpExportTo.Value);

            grdVehicle.DataSource = _dtResult;

            try
            {


                for (int i = 0; i < grdVehicle.Rows.Count; i++)
                {
                    if (grdVehicle.Rows[i].Cells["ImportedLocalTime"].Value != null && grdVehicle.Rows[i].Cells["ImportedLocalTime"].Value.ToString() != "" && Convert.ToDateTime(grdVehicle.Rows[i].Cells["ImportedLocalTime"].Value).Year.Equals(1900))
                    {
                        grdVehicle.Rows[i].Cells["ImportedLocalTime"].Value = "";
                    }
                }

                int xeKhongXC = 0, xeKhongNC = 0, xeCohangNC = 0, xeCohangXC = 0, xeVaoNoiDia = 0;

                for (int i = 0; i < _dtResult.Rows.Count; i++)
                {
                    if (!_dtResult.Rows[i].IsNull("IsExport") && _dtResult.Rows[i]["IsExport"] != null && !Convert.ToBoolean(_dtResult.Rows[i]["IsExport"].ToString()))
                    {
                        xeKhongXC = xeKhongXC + 1;
                    }

                    if (!_dtResult.Rows[i].IsNull("IsImport") && _dtResult.Rows[i]["IsImport"] != null && !Convert.ToBoolean(_dtResult.Rows[i]["IsImport"].ToString()))
                    {
                        xeKhongNC = xeKhongNC + 1;
                    }


                    if (!_dtResult.Rows[i].IsNull("IsImport") && _dtResult.Rows[i]["IsImport"] != null && Convert.ToBoolean(_dtResult.Rows[i]["IsImport"].ToString()) && !_dtResult.Rows[i].IsNull("HasGoodsImported") && _dtResult.Rows[i]["HasGoodsImported"] != null && Convert.ToBoolean(_dtResult.Rows[i]["HasGoodsImported"].ToString()))
                    {
                        xeCohangNC = xeCohangNC + 1;
                    }

                    if (!_dtResult.Rows[i].IsNull("IsExport") && _dtResult.Rows[i]["IsExport"] != null && Convert.ToBoolean(_dtResult.Rows[i]["IsExport"].ToString()) && !_dtResult.Rows[i].IsNull("HasGoodsImported") && _dtResult.Rows[i]["HasGoodsImported"] != null && Convert.ToBoolean(_dtResult.Rows[i]["HasGoodsImported"].ToString()))
                    {
                        xeCohangXC = xeCohangXC + 1;
                    }


                    if (!_dtResult.Rows[i].IsNull("IsGoodsImported") && _dtResult.Rows[i]["IsGoodsImported"] != null && Convert.ToBoolean(_dtResult.Rows[i]["IsGoodsImported"].ToString()))
                    {
                        xeVaoNoiDia = xeVaoNoiDia + 1;
                    }

                }

                lblKhongXC.Text = xeKhongXC.ToString();
                lblKhongNC.Text = xeKhongNC.ToString();
                lblCohangNC.Text = xeCohangNC.ToString();
                lblKhonghangNC.Text = xeCohangXC.ToString();
                lblVaonoidia.Text = xeVaoNoiDia.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
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
                MessageBox.Show("Bạn phải nhập thời gian nhập cảnh.");
                cbIsImport.Checked = false;
                return;
            }

            if (cbIsImport.Checked && cbIsExport.Checked)
            {
                EnabledImport(true);
                cbIsNotImport.Checked = false;
                cbIsNotImport.Enabled = false;

            }
            else
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
                //MessageBox.Show(exception.ToString());
            }
        }

        private void cbIsNotImport_CheckedChanged(object sender, EventArgs e)
        {
            // Import
            if (!cbIsExport.Checked && cbIsNotImport.Checked)
            {
                MessageBox.Show("Bạn phải nhập thời gian nhập cảnh.");
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
            catch (Exception exception)
            {
                //MessageBox.Show(exception.ToString());
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
                foreach (DataRow dataRow in _dtResult.Rows)
                {
                    rowIndex++;
                    excel.Cells[rowIndex + 1, 1] = dataRow[ConstantInfo.TBL_DECLARATION_NUMBER].ToString();
                    excel.Cells[rowIndex + 1, 2] = dataRow[ConstantInfo.TBL_VEHICLE_PLATE_NUMBER].ToString();
                    excel.Cells[rowIndex + 1, 3] = dataRow[ConstantInfo.TBL_VEHICLE_DRIVER_NAME].ToString();
                    excel.Cells[rowIndex + 1, 4] = dataRow[ConstantInfo.TBL_VEHICLE_STATUS].ToString();
                    excel.Cells[rowIndex + 1, 5] = dataRow[ConstantInfo.TBL_VEHICLE_NOTE].ToString();
                    excel.Cells[rowIndex + 1, 6] = dataRow[ConstantInfo.TBL_DECLARATION_COMPANY_NAME].ToString();
                    excel.Cells[rowIndex + 1, 7] = dataRow[ConstantInfo.TBL_DECLARATION_PRODUCT_NAME].ToString();
                    excel.Cells[rowIndex + 1, 8] = dataRow[ConstantInfo.TBL_DECLARATION_PRODUCT_AMOUNT].ToString();
                    excel.Cells[rowIndex + 1, 9] = dataRow[ConstantInfo.TBL_DECLARATION_UNIT].ToString();
                    excel.Cells[rowIndex + 1, 10] = dataRow[ConstantInfo.TBL_VEHICLE_EXPORT_DATE].ToString();
                    excel.Cells[rowIndex + 1, 11] = dataRow["ImportNumber"].ToString();
                    excel.Cells[rowIndex + 1, 12] = dataRow["ImportCompanyName"].ToString();
                    excel.Cells[rowIndex + 1, 13] = dataRow["ImportProductName"].ToString();
                    excel.Cells[rowIndex + 1, 14] = dataRow["ImportProductAmount"].ToString();
                    excel.Cells[rowIndex + 1, 15] = dataRow[ConstantInfo.TBL_VEHICLE_IMPORT_DATE].ToString();
                    excel.Cells[rowIndex + 1, 16] = dataRow[ConstantInfo.TBL_VEHICLE_IMPORT_STATUS].ToString();

                    try
                    {
                        if (dataRow[ConstantInfo.TBL_VEHICLE_IMPORTED_LOCAL_TIME] != null && Convert.ToDateTime(dataRow[ConstantInfo.TBL_VEHICLE_IMPORTED_LOCAL_TIME]).Year > 1900)
                        {
                            excel.Cells[rowIndex + 1, 17] = dataRow[ConstantInfo.TBL_VEHICLE_IMPORTED_LOCAL_TIME].ToString();
                        }
                        else
                        {
                            excel.Cells[rowIndex + 1, 17] = "";
                        }

                    }
                    catch (Exception)
                    {
                        excel.Cells[rowIndex + 1, 17] = "";
                    }


                    excel.Visible = true;
                    var worksheet = (Worksheet)excel.ActiveSheet;
                    worksheet.Activate();
                }
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.ToString());
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
            catch (Exception exception)
            {
                //MessageBox.Show(exception.ToString());
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

                var vehicleInfo = _vehicleBOL.SelectByID(int.Parse(grdVehicle.SelectedRows[0].Cells["VehicleID"].Value.ToString()));

                if (MessageBox.Show(message.ToString(), "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    vehicleInfo.ExportDate = DateTime.Now;
                    vehicleInfo.ExportHour = DateTime.Now.ToString("HH:mm");
                    vehicleInfo.IsExport = true;
                    _vehicleBOL.Update(vehicleInfo);
                }
                // Bind to grid
                BindData();
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.ToString());
            }
        }

        private void btnXacNhanNhapCanhCoHang_Click(object sender, EventArgs e)
        {
            try
            {
                var message = new StringBuilder();
                message.Append("Thời gian nhập cảnh: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));

                var vehicleInfo = _vehicleBOL.SelectByID(int.Parse(grdVehicle.SelectedRows[0].Cells["VehicleID"].Value.ToString()));

                if (MessageBox.Show(message.ToString(), "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    vehicleInfo.ImportDate = DateTime.Now;
                    vehicleInfo.ImportHour = DateTime.Now.ToString("HH:mm");
                    vehicleInfo.IsImport = true;
                    vehicleInfo.HasGoodsImported = true;
                    vehicleInfo.ImportStatus = "Nhập cảnh có hàng";
                    _vehicleBOL.Update(vehicleInfo);
                }
                // Bind data to gridview
                BindData();
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.ToString());
            }
        }

        private void btnXacNhanXuatCanhKhongCoHang_Click(object sender, EventArgs e)
        {
            try
            {
                var message = new StringBuilder();
                message.Append("Thời gian nhập cảnh: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));

                var vehicleInfo = _vehicleBOL.SelectByID(int.Parse(grdVehicle.SelectedRows[0].Cells["VehicleID"].Value.ToString()));

                if (MessageBox.Show(message.ToString(), "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    vehicleInfo.ImportDate = DateTime.Now;
                    vehicleInfo.ImportHour = DateTime.Now.ToString("HH:mm");
                    vehicleInfo.IsImport = true;
                    vehicleInfo.HasGoodsImported = false;
                    vehicleInfo.ImportStatus = "Nhập cảnh không có hàng";
                    _vehicleBOL.Update(vehicleInfo);
                }
                // Bind data
                BindData();
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.ToString());
            }
        }

        private void btnLocalConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var vehicleInfo = _vehicleBOL.SelectByID(int.Parse(grdVehicle.SelectedRows[0].Cells["VehicleID"].Value.ToString()));
                vehicleInfo.ImportDate = DateTime.Now;
                vehicleInfo.ImportHour = DateTime.Now.ToString("HH:mm");
                vehicleInfo.IsGoodsImported = true;
                vehicleInfo.ImportedLocalTime = DateTime.Now;
                _vehicleBOL.Update(vehicleInfo);
                // Bind data to gridview
                BindData();
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.ToString());
            }
        }

    }
}
