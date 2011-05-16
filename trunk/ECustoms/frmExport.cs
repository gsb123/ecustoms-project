﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ECustoms.BOL;
using ECustoms.Utilities;

namespace ECustoms
{
    public partial class frmExport : Form
    {
        private DeclarationBOL _declarationBOL;
        private VehicleBOL _vehicleBOL;
        private UserInfo _userInfo;
        private int _mode;
        private int _declerationID;
        private List<VehicleInfo> _vehicleInfosTemp = new List<VehicleInfo>(); // This variable is used to store data in the gridview
        private bool _hasDeclaration;
        public frmExport()
        {
            InitializeComponent();
        }

        public frmExport(UserInfo userInfo, int mode)
        {
            InitializeComponent();
            _userInfo = userInfo;
            _mode = mode;
        }

        public frmExport(UserInfo userInfo, int mode, int declerationID)
        {
            InitializeComponent();
            _userInfo = userInfo;
            _mode = mode;
            _declerationID = declerationID;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validate()) return;
                var declarationInfo = GetDeclarationInfo();
                var listVehicleInfo = new List<VehicleInfo>();
                VehicleInfo vehicleInfo;
                // Validate Vehicle information
                if (grdVehicle.Rows.Count > 0)
                {
                    for (int i = 0; i < grdVehicle.Rows.Count; i++)
                    {
                        vehicleInfo = new VehicleInfo();
                        if (grdVehicle.Rows[i].Cells["PlateNumber"].Value != null)
                        {
                            vehicleInfo.PlateNumber = grdVehicle.Rows[i].Cells["PlateNumber"].Value.ToString();
                            if (grdVehicle.Rows[i].Cells["NumberOfContainer"].Value != null)
                            {
                                vehicleInfo.NumberOfContainer = Convert.ToInt32(grdVehicle.Rows[i].Cells["NumberOfContainer"].Value);
                            }

                            if (grdVehicle.Rows[i].Cells["DriverName"].Value != null)
                            {
                                vehicleInfo.DriverName = grdVehicle.Rows[i].Cells["DriverName"].Value.ToString();
                            }

                            if (grdVehicle.Rows[i].Cells["ExportHour"].Value != null)
                            {
                                vehicleInfo.ExportHour = grdVehicle.Rows[i].Cells["ExportHour"].Value.ToString();
                            }

                            if (grdVehicle.Rows[i].Cells["ExportDate"].Value != null)
                            {
                                vehicleInfo.ExportDate = Convert.ToDateTime(grdVehicle.Rows[i].Cells["ExportDate"].Value);
                            }

                            if (grdVehicle.Rows[i].Cells["ImportHour"].Value != null)
                            {
                                vehicleInfo.ImportHour = grdVehicle.Rows[i].Cells["ImportHour"].Value.ToString();
                            }

                            if (grdVehicle.Rows[i].Cells["ImportDate"].Value != null)
                            {
                                vehicleInfo.ImportDate = Convert.ToDateTime(grdVehicle.Rows[i].Cells["ImportDate"].Value);
                            }

                            if (grdVehicle.Rows[i].Cells["Note"].Value != null)
                            {
                                vehicleInfo.Note = grdVehicle.Rows[i].Cells["Note"].Value.ToString();
                            }
                            if (grdVehicle.Rows[i].Cells["Status"].Value != null)
                            {
                                vehicleInfo.Status = grdVehicle.Rows[i].Cells["Status"].Value.ToString();
                            }

                            if (grdVehicle.Rows[i].Cells["IsExport"].Value != null)
                            {
                                vehicleInfo.IsExport = Convert.ToBoolean(grdVehicle.Rows[i].Cells["IsExport"].Value);
                            }

                            if (grdVehicle.Rows[i].Cells["IsImport"].Value != null)
                            {
                                vehicleInfo.IsImport = Convert.ToBoolean(grdVehicle.Rows[i].Cells["IsImport"].Value);
                            }
                            if (!string.IsNullOrEmpty(txtImportNumber.Text) && Convert.ToInt32(txtImportNumber.Text) > 0)
                            {
                                vehicleInfo.HasGoodsImported = true;
                            }
                            else
                            {
                                vehicleInfo.HasGoodsImported = false;
                            }

                            listVehicleInfo.Add(vehicleInfo);
                        }
                    }
                }
                // TODO: Need to check return value
                _declarationBOL.AddDeclaration(declarationInfo, listVehicleInfo);
                MessageBox.Show(ConstantInfo.MESSAGE_INSERT_SUCESSFULLY);
                // Reset form
                ResetForm();
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.ToString());
            }

        }

        private bool Validate()
        {
            // Validate export declaration
            if (rdoExport.Checked)
            {
                if (string.IsNullOrEmpty(txtExportNumber.Text.Trim()) && cbExportHasDeclaration.Checked)
                {
                    MessageBox.Show(ConstantInfo.MESSAGE_BLANK_DECLARATION_NUMBER);
                    txtExportNumber.Focus();
                    return false;
                }
                return true;
            }
            if (string.IsNullOrEmpty(txtImportNumber.Text.Trim()) && cbImportHasDeclaration.Checked)
            {
                MessageBox.Show(ConstantInfo.MESSAGE_BLANK_DECLARATION_NUMBER);
                txtExportNumber.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Get Declaration from Controls
        /// </summary>
        /// <returns></returns>
        private DeclarationInfo GetDeclarationInfo()
        {
            var declarationInfo = new DeclarationInfo();
            if (!string.IsNullOrEmpty(txtExportNumber.Text))
            {
                declarationInfo.Number = Convert.ToInt32(txtExportNumber.Text.Trim());
            }

            declarationInfo.ProductName = txtExportProductName.Text;
            declarationInfo.CompanyName = txtExportCompanyName.Text;
            declarationInfo.ProductAmount = txtExportProductAmount.Text.Trim();
            declarationInfo.Unit = txtExportUnit.Text.Trim();
            declarationInfo.CreatedByID = _userInfo.UserID;
            declarationInfo.ModifiedByID = _userInfo.UserID;
            declarationInfo.ModifiedDate = DateTime.Now;
            declarationInfo.HasDeclaration = cbExportHasDeclaration.Checked;


            // import
            if (!string.IsNullOrEmpty(txtImportNumber.Text.Trim()))
            {
                declarationInfo.ImportNumber = Convert.ToInt32(txtImportNumber.Text.Trim());
            }
            declarationInfo.ImportProductName = txtImportProductName.Text;
            declarationInfo.ImportCompanyName = txtImportCompanyName.Text;
            declarationInfo.ImportProductAmount = txtImportProductAmount.Text.Trim();
            declarationInfo.ImportUnit = txtImportUnit.Text.Trim();
            declarationInfo.ModifiedByID = _userInfo.UserID;
            declarationInfo.ModifiedDate = DateTime.Now;
            declarationInfo.ImportHasDeclaration = cbImportHasDeclaration.Checked;

            return declarationInfo;
        }

        private void ResetForm()
        {
            txtExportNumber.Text = "";
            txtExportProductName.Text = "";
            txtExportCompanyName.Text = "";
            txtExportProductAmount.Text = "";
            txtExportUnit.Text = "";
            txtExportTotalVehicles.Text = "";
            grdVehicle.DataSource = null;
        }

        private void frmExport_Load(object sender, EventArgs e)
        {
            txtExportTotalVehicles.Focus();
            this.Text = "Khai báo xuất nhập cảnh" + ConstantInfo.MESSAGE_TITLE;
            // Show form to the center
            this.Location = new Point((this.ParentForm.Width - this.Width) / 2, (this.ParentForm.Height - this.Height) / 2);
            _declarationBOL = new DeclarationBOL();
            _vehicleBOL = new VehicleBOL();
            // Init form.
            Init();
        }

        /// <summary>
        /// Init data
        /// </summary>
        private void Init()
        {

            grdVehicle.AutoGenerateColumns = false;
            // New mode))
            if (this._mode == 0)
            {
                btnUpdate.Enabled = false;
                btnAdd.Enabled = true;
                btnReset.Enabled = true;

            }
            else // Edit mode
            {
                btnUpdate.Enabled = true;
                btnAdd.Enabled = false;
                btnReset.Enabled = false;

                // Get Decleration information
                var declarationInfo = _declarationBOL.SelectByID(this._declerationID);
                // Bind Declaration to controls
                if (declarationInfo != null)
                {
                    txtExportNumber.Text = declarationInfo.Number.ToString();
                    txtExportProductName.Text = declarationInfo.ProductName;
                    txtExportCompanyName.Text = declarationInfo.CompanyName;
                    txtExportProductAmount.Text = declarationInfo.ProductAmount;
                    txtExportUnit.Text = declarationInfo.Unit;
                    if (!declarationInfo.HasDeclaration)
                    {
                        cbExportHasDeclaration.Checked = true;
                        gbExportDeclaration.Enabled = false;
                    }

                    txtImportNumber.Text = declarationInfo.ImportNumber.ToString();
                    txtImportProductName.Text = declarationInfo.ImportProductName;
                    txtImportCompanyName.Text = declarationInfo.ImportCompanyName;
                    txtImportProductAmount.Text = declarationInfo.ImportProductAmount;
                    txtImportUnit.Text = declarationInfo.ImportUnit;
                    if (!declarationInfo.ImportHasDeclaration)
                    {
                        cbImportHasDeclaration.Checked = true;
                        gbImportDeclaration.Enabled = false;
                    }
                }

                // Get Vehicle by DeclarationID
                var listVehicle = _vehicleBOL.SelectByDeclarationID(this._declerationID);
                BindVehicle(listVehicle);
            }
        }

        public void BindVehicle(List<VehicleInfo> vehicleInfos)
        {

            grdVehicle.DataSource = null;
            // Bind count column
            for (int i = 0; i < vehicleInfos.Count; i++)
            {
                vehicleInfos[i].Count = i + 1;
            }

            grdVehicle.DataSource = vehicleInfos;
            // Set number of vehicle
            if (!string.Equals(txtExportTotalVehicles.Text, grdVehicle.Rows.Count.ToString()) || grdVehicle.Rows.Count > 0)
            {
                txtExportTotalVehicles.Text = grdVehicle.Rows.Count.ToString();
            }
            _vehicleInfosTemp = vehicleInfos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (_declerationID != 0)
                {
                    var declerationInfo = GetDeclarationInfo();
                    // Set DeclerationID
                    declerationInfo.DeclarationID = this._declerationID;
                    // Update Decleration 
                    _declarationBOL.UpdateDecleration(declerationInfo);
                    // update vehicle list
                    var vehicleBL = new VehicleBOL();

                    foreach (var v in this._vehicleInfosTemp)
                    {
                        //update declationId
                        v.DeclarationID = declerationInfo.DeclarationID;
                        vehicleBL.Update(v);
                    }

                    MessageBox.Show("Cập nhật thành công");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                txtExportNumber.Text = "";
                txtExportProductName.Text = "";
                txtExportCompanyName.Text = "";
                txtExportProductAmount.Text = "";
                txtExportUnit.Text = "";
                grdVehicle.Rows.Clear();
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.ToString());
            }

        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                var declarationInfo = new DeclarationInfo();
                if (!string.IsNullOrEmpty(txtExportNumber.Text))
                {
                    declarationInfo.Number = Convert.ToInt32(txtExportNumber.Text);
                }
                declarationInfo.CreatedDate = DateTime.Now;
                declarationInfo.ProductName = txtExportProductName.Text;
                declarationInfo.ProductAmount = txtExportProductAmount.Text;
                declarationInfo.HasDeclaration = cbExportHasDeclaration.Checked;
                // Add Mode
                if (_mode == 0)
                {
                    var vehicle = new frmVehicle(0, this, ref _vehicleInfosTemp, declarationInfo, _userInfo);
                    vehicle.MdiParent = this.ParentForm;
                    vehicle.Show();
                }
                else
                {
                    declarationInfo = _declarationBOL.SelectByID(_declerationID);
                    if (!string.IsNullOrEmpty(txtExportNumber.Text))
                    {
                        declarationInfo.Number = Convert.ToInt32(txtExportNumber.Text);
                    }
                    declarationInfo.CreatedDate = DateTime.Now;
                    declarationInfo.ProductName = txtExportProductName.Text;
                    declarationInfo.ProductAmount = txtExportProductAmount.Text;
                    declarationInfo.HasDeclaration = cbExportHasDeclaration.Checked;
                    // Update Mode
                    var vehicle = new frmVehicle(4, this, ref _vehicleInfosTemp, declarationInfo, _userInfo);
                    vehicle.MdiParent = this.ParentForm;
                    vehicle.Show();
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
                var declarationInfo = new DeclarationInfo();
                if (!string.IsNullOrEmpty(txtExportNumber.Text))
                {
                    declarationInfo.Number = Convert.ToInt32(txtExportNumber.Text);
                }
                declarationInfo.CreatedDate = DateTime.Now;
                declarationInfo.ProductName = txtExportProductName.Text;
                declarationInfo.ProductAmount = txtExportProductAmount.Text;
                declarationInfo.HasDeclaration = cbExportHasDeclaration.Checked;
                // New mode
                if (grdVehicle.SelectedRows.Count == 1 && this._mode == 0)
                {
                    var vehicle = new frmVehicle(1, this, ref _vehicleInfosTemp, Convert.ToInt32(grdVehicle.SelectedRows[0].Cells["Count"].Value), declarationInfo, _userInfo);
                    vehicle.MdiParent = this.ParentForm;
                    vehicle.Show();
                }
                else if (grdVehicle.SelectedRows.Count == 1 && this._mode == 1) // Update Mode
                {
                    var vehicle = new frmVehicle(2, this, ref _vehicleInfosTemp, Convert.ToInt32(grdVehicle.SelectedRows[0].Cells["Count"].Value), declarationInfo, _userInfo);
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

        private void btnDeleteVehicle_Click_1(object sender, EventArgs e)
        {
            try
            {
                //TODO: Support delete multiple
                if (grdVehicle.SelectedRows.Count == 1 && _mode == 0) // New mode
                {
                    var dr = MessageBox.Show("Bạn có chắc là muốn xóa?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        foreach (VehicleInfo vehicleInfo in _vehicleInfosTemp)
                        {
                            if (vehicleInfo.Count == Convert.ToInt32(grdVehicle.SelectedRows[0].Cells["Count"].Value))
                            {
                                _vehicleInfosTemp.Remove(vehicleInfo);
                                break;
                            }

                        }
                        this.BindVehicle(_vehicleInfosTemp);
                    }
                }
                else if (grdVehicle.SelectedRows.Count == 1 && _mode == 1) // New mode
                {
                    var dr = MessageBox.Show("Bạn có chắc là muốn xóa?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        _vehicleBOL.DeleteByID(Convert.ToInt32(grdVehicle.SelectedRows[0].Cells["VehicleID"].Value));
                        // Get Vehicle by DeclarationID
                        var listVehicle = _vehicleBOL.SelectByDeclarationID(this._declerationID);
                        BindVehicle(listVehicle);
                    }

                }
                else
                {
                    MessageBox.Show("Bạn cần chọn 1 phương tiện cần xóa.");
                }
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.ToString());

            }

        }

        private void cbHasDeclaration_CheckedChanged(object sender, EventArgs e)
        {
            if (cbExportHasDeclaration.Checked)
            {
                gbExportDeclaration.Enabled = true;
            }
            else
            {
                gbExportDeclaration.Enabled = false;
            }
        }

        private void grdVehicle_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && grdVehicle.SelectedRows.Count == 1)
                {

                    var declarationInfo = new DeclarationInfo();
                    if (!string.IsNullOrEmpty(txtExportNumber.Text))
                    {
                        declarationInfo.Number = Convert.ToInt32(txtExportNumber.Text);
                    }
                    declarationInfo.CreatedDate = DateTime.Now;
                    declarationInfo.ProductName = txtExportProductName.Text;
                    declarationInfo.ProductAmount = txtExportProductAmount.Text;
                    declarationInfo.HasDeclaration = cbExportHasDeclaration.Checked;
                    // Bind the gridview data to the vehicleInfo object, make sure, the vehicleInfotem dat is same as the gridview.
                    // Validate data of the gridview.
                    // Clear the tem data

                    //_vehicleInfosTemp.Clear();

                    _vehicleInfosTemp = (List<VehicleInfo>)grdVehicle.DataSource;
                    //VehicleInfo vehicleInfo;
                    //// Add data to the tem object
                    //for (int i = 0; i < grdVehicle.Rows.Count; i++)
                    //{
                    //    var row = grdVehicle.Rows[i];
                    //     vehicleInfo = new VehicleInfo();
                    //     if (row.Cells[ConstantInfo.TBL_VEHICLE_PLATE_NUMBER].Value != null)
                    //    {
                    //        vehicleInfo.PlateNumber = row.Cells[ConstantInfo.TBL_VEHICLE_PLATE_NUMBER].Value.ToString();    
                    //    }

                    //    if (row.Cells[ConstantInfo.TBL_VEHICLE_DRIVER_NAME].Value != null)
                    //    {
                    //        vehicleInfo.DriverName = row.Cells[ConstantInfo.TBL_VEHICLE_DRIVER_NAME].Value.ToString();    
                    //    }

                    //    if (row.Cells[ConstantInfo.TBL_VEHICLE_STATUS].Value != null)
                    //    {
                    //        vehicleInfo.Status = row.Cells[ConstantInfo.TBL_VEHICLE_STATUS].Value.ToString();    
                    //    }
                    //    if (row.Cells[ConstantInfo.TBL_VEHICLE_NOTE].Value != null)
                    //    {
                    //        vehicleInfo.Note = row.Cells[ConstantInfo.TBL_VEHICLE_NOTE].Value.ToString();    
                    //    }

                    //    if (row.Cells[ConstantInfo.TBL_VEHICLE_EXPORT_HOUR].Value != null)
                    //    {
                    //        vehicleInfo.ExportHour = row.Cells[ConstantInfo.TBL_VEHICLE_EXPORT_HOUR].Value.ToString();    
                    //    }

                    //    if (row.Cells[ConstantInfo.TBL_VEHICLE_IS_EXPORT].Value != null)
                    //        vehicleInfo.IsExport = Convert.ToBoolean(row.Cells[ConstantInfo.TBL_VEHICLE_IS_EXPORT].Value.ToString());{
                    //    }

                    //    if (row.Cells[ConstantInfo.TBL_VEHICLE_EXPORT_DATE].Value != null)
                    //    {
                    //        vehicleInfo.ExportDate =
                    //        Convert.ToDateTime(row.Cells[ConstantInfo.TBL_VEHICLE_EXPORT_DATE].Value.ToString());    
                    //    }
                    //    if ((row.Cells[ConstantInfo.TBL_VEHICLE_IMPORT_DATE].Value != null))
                    //    {
                    //        vehicleInfo.ImportDate = Convert.ToDateTime(row.Cells[ConstantInfo.TBL_VEHICLE_IMPORT_DATE].Value.ToString());    
                    //    }

                    //    if (row.Cells[ConstantInfo.TBL_VEHICLE_IMPORT_HOUR].Value != null)
                    //    {
                    //        vehicleInfo.ImportHour = row.Cells[ConstantInfo.TBL_VEHICLE_IMPORT_HOUR].Value.ToString();                                
                    //    }

                    //    if (row.Cells[ConstantInfo.TBL_VEHICLE_IS_IMPORT].Value != null)
                    //    {
                    //        vehicleInfo.IsImport = Convert.ToBoolean(row.Cells[ConstantInfo.TBL_VEHICLE_IS_IMPORT].Value.ToString());    
                    //    }

                    //    if (row.Cells[ConstantInfo.TBL_VEHICLE_VEHICLE_ID].Value != null)
                    //    {
                    //        vehicleInfo.VehicleID = Convert.ToInt32(row.Cells[ConstantInfo.TBL_VEHICLE_VEHICLE_ID].Value.ToString());    
                    //    }

                    //    if (row.Cells[ConstantInfo.TBL_VEHICLE_NUMBER_OF_CONTAINER].Value != null)
                    //    {
                    //        vehicleInfo.NumberOfContainer = Convert.ToInt32(row.Cells[ConstantInfo.TBL_VEHICLE_NUMBER_OF_CONTAINER].Value.ToString());    
                    //    }

                    //    if (row.Cells[ConstantInfo.TBL_VEHICLE_IMPORT_HOUR].Value != null )
                    //    {
                    //        vehicleInfo.ImportHour = row.Cells[ConstantInfo.TBL_VEHICLE_IMPORT_HOUR].Value.ToString();    
                    //    }

                    //    // If it is new mode, use Count as the flash, it store item count
                    //    if (this._mode == 0)
                    //    {
                    //        if (row.Cells["Count"].Value !=  null)
                    //        {
                    //            vehicleInfo.Count = Convert.ToInt32(row.Cells["Count"].Value);
                    //        }

                    //    }
                    //    _vehicleInfosTemp.Add(vehicleInfo);
                    //}


                    // New mode
                    if (this._mode == 0)
                    {
                        var vehicle = new frmVehicle(1, this, ref _vehicleInfosTemp, Convert.ToInt32(grdVehicle.Rows[e.RowIndex].Cells["Count"].Value), declarationInfo, _userInfo);
                        vehicle.MdiParent = this.ParentForm;
                        vehicle.Show();
                    }
                    else if (this._mode == 1) // Update Mode
                    {
                        var vehicle = new frmVehicle(2, this, ref _vehicleInfosTemp, Convert.ToInt32(grdVehicle.Rows[e.RowIndex].Cells["Count"].Value), declarationInfo, _userInfo);
                        vehicle.MdiParent = this.ParentForm;
                        vehicle.Show();
                    }
                }
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.ToString());
            }
        }

        private void rdoExport_CheckedChanged(object sender, EventArgs e)
        {
            cbImportHasDeclaration.Enabled = false;
            gbImportDeclaration.Enabled = false;
            cbExportHasDeclaration.Enabled = true;
            gbExportDeclaration.Enabled = true;
            cbExportHasDeclaration.Checked = true;
            grdVehicle.TabIndex = 9;
            btnAddExisting.Enabled = false;

        }

        private void rdoImport_CheckedChanged(object sender, EventArgs e)
        {
            cbImportHasDeclaration.Enabled = true;
            gbImportDeclaration.Enabled = true;
            cbExportHasDeclaration.Enabled = false;
            gbExportDeclaration.Enabled = false;
            cbImportHasDeclaration.Checked = true;
            grdVehicle.TabIndex = 16;
            btnAddExisting.Enabled = true;

            var declarationInfo = _declarationBOL.SelectByID(this._declerationID);


            if (_mode == 0 || (declarationInfo != null && declarationInfo.ImportNumber < 1))
            {
                txtImportNumber.Text = txtExportNumber.Text;
                txtImportCompanyName.Text = txtExportCompanyName.Text;
                txtImportProductName.Text = txtExportProductName.Text;
                txtImportProductAmount.Text = txtExportProductAmount.Text;
                txtImportUnit.Text = txtExportUnit.Text;
            }
        }

        private void cbImportHasDeclaration_CheckedChanged(object sender, EventArgs e)
        {
            if (cbImportHasDeclaration.Checked)
            {
                gbImportDeclaration.Enabled = true;
            }
            else
            {
                gbImportDeclaration.Enabled = false;
            }
        }

        private void txtExportTotalVehicles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(13))// Enter key
            {
                if (string.IsNullOrEmpty(txtExportTotalVehicles.Text)) return;
                var totalVehicles = Convert.ToInt32(txtExportTotalVehicles.Text);
                VehicleInfo vehicleInfo;
                for (int i = 0; i < totalVehicles; i++)
                {
                    vehicleInfo = new VehicleInfo();
                    // Add to the list object
                    _vehicleInfosTemp.Add(vehicleInfo);
                }
                // Bind to datagrid
                BindVehicle(_vehicleInfosTemp);
            }
        }

        private void groupBoxVehicle_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxVehicle_Enter_1(object sender, EventArgs e)
        {

        }

        private void txtExportTotalVehicles_Leave(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtExportTotalVehicles.Text)) return;
                var totalVehicles = Convert.ToInt32(txtExportTotalVehicles.Text);
                VehicleInfo vehicleInfo;
                for (int i = 0; i < totalVehicles - grdVehicle.Rows.Count; i++)
                {
                    vehicleInfo = new VehicleInfo();
                    // Add to the list object
                    _vehicleInfosTemp.Add(vehicleInfo);
                }
                // Bind to datagrid
                BindVehicle(_vehicleInfosTemp);
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.ToString());
            }
        }

        private void txtExportUnit_Leave(object sender, EventArgs e)
        {
            grdVehicle.Focus();
        }

        private void txtImportUnit_Leave(object sender, EventArgs e)
        {
            grdVehicle.Focus();
        }

        private void grdVehicle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddExisting_Click(object sender, EventArgs e)
        {
            var frmSelect = new frmVehicleSelect();
            frmSelect.OnSelectedVehichle += new frmVehicleSelect.OnSelectedVehicleHandler(frmSelect_OnSelectedVehichle);
            frmSelect.ShowDialog();

        }

        void frmSelect_OnSelectedVehichle(object sender, EventArgs e)
        {

            var arg = (SelectedVehichleEventArgs)(e);
            var vehicleInfo = arg.Vehicle;

            foreach (VehicleInfo v in _vehicleInfosTemp)
            {
                if (v.VehicleID == vehicleInfo.VehicleID)
                    throw new Exception("Phương tiện này đã tồn tại trong tờ khai!");
            }
            _vehicleInfosTemp.Add(vehicleInfo);
            this.BindVehicle(_vehicleInfosTemp);

        }

        private void txtImportProductName_TextChanged(object sender, EventArgs e)
        {

        }


    }
}