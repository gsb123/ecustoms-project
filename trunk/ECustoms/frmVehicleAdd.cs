﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ECustoms.Utilities;
using ECustoms.BOL;
using ECustoms.DAL;

namespace ECustoms
{
    public partial class frmVehicleAdd : Form
    {
        #region Priority
        private List<VehicleInfo> _vehicleInfosTemp = new List<VehicleInfo>();
        private VehicleBOL _vehicleBOL = new VehicleBOL();
        private UserInfo _userInfo;

        public List<VehicleInfo> VehicleInfosTemp
        {
            get { return _vehicleInfosTemp; }
            set { _vehicleInfosTemp = value; }
        }

        public VehicleBOL VehicleBol
        {
            get { return _vehicleBOL; }
            set { _vehicleBOL = value; }
        }

        public UserInfo UserInfo
        {
            get { return _userInfo; }
            set { _userInfo = value; }
        }

        #endregion

        #region Validate
        private bool Validate()
        {
            // comments code because new requirements
            // allow empty when inserting new verhicle,
            // the driver name might be filled later


            if (string.IsNullOrEmpty(txtPlateNumber.Text.Trim()))
            {
                MessageBox.Show("Biểm kiểm soát không được để trống!");
                txtPlateNumber.Focus();
                return false;
            }
            if (pictureBoxInvalid.Visible)
            {
                MessageBox.Show("Biểm kiểm soát đã được nhập");
                txtPlateNumber.Focus();
                return false;
            }


            return true;
        }

        #endregion

        private void ResetForm()
        {
            txtDriverName.Text = "";
            txtPlateNumber.Text = "";
            txtNumberOfContainer.Text = "";
            txtStatus.Text = "";
            txtNote.Text = "";


            dateTimePickerExport.Visible = false;
            mtxtExportHour.Visible = false;
            lblIsExport.Visible = true;
            cbConfirmExport.Checked = false;

            dateTimePickerImport.Visible = false;
            mtxtImportHour.Visible = false;
            lblIsImport.Visible = true;
            cbConfirmImport.Checked = false;

            pictureBoxInvalid.Visible = false;
            pictureBoxValid.Visible = false;

            // Set focus
            txtPlateNumber.Focus();
        }

        private VehicleInfo GetVehicle()
        {
            if (!Validate())
                return null;
            // Add data to veicleInfo list
            var vehicleInfo = new VehicleInfo();
            vehicleInfo.DriverName = txtDriverName.Text.Trim();
            vehicleInfo.PlateNumber = txtPlateNumber.Text.Trim();
            if (txtNumberOfContainer.Text != "")
            {
                vehicleInfo.NumberOfContainer = Convert.ToInt32(txtNumberOfContainer.Text.Trim());
            }

            if (cbConfirmExport.Checked)
            {
                vehicleInfo.ExportDate = dateTimePickerExport.Value;
                vehicleInfo.ExportHour = mtxtExportHour.Text;
                vehicleInfo.ConfirmExportBy = _userInfo.UserID;
            }

            if (cbConfirmImport.Checked)
            {
                vehicleInfo.ImportDate = dateTimePickerImport.Value;
                vehicleInfo.ImportHour = mtxtImportHour.Text;
                vehicleInfo.ConfirmImportBy = _userInfo.UserID;
            }

            vehicleInfo.Status = txtStatus.Text;
            vehicleInfo.Note = txtNote.Text;
            vehicleInfo.VehicleID = _vehicleInfosTemp.Count + 1;
            vehicleInfo.IsExport = cbConfirmExport.Checked;
            vehicleInfo.IsImport = cbConfirmImport.Checked;
            vehicleInfo.IsCompleted = false;
            //vehicleInfo.DeclarationID = _parrentDeclaration.DeclarationID;
            if (vehicleInfo.ExportDate != null && vehicleInfo.ExportDate.Value.Year.Equals(1900))
            {
                vehicleInfo.ExportDate = null;
            }
            if (vehicleInfo.ImportDate != null && vehicleInfo.ImportDate.Value.Year.Equals(1900))
            {
                vehicleInfo.ImportDate = null;
            }

            return vehicleInfo;
        }

        public frmVehicleAdd(UserInfo userInfor)
        {
            InitializeComponent();
            grdVehicle.AutoGenerateColumns = false;
            _userInfo = userInfor;

        }
        #region Action Handler

        private void frmVehicleAdd_Load(object sender, EventArgs e)
        {
            this.Text = "Khai báo phương tiện" + ConstantInfo.MESSAGE_TITLE;
            this.Location = new Point((this.ParentForm.Width - this.Width) / 2, (this.ParentForm.Height - this.Height) / 2);

            txtPlateNumber.LostFocus += new EventHandler(txtPlateNumber_LostFocus);

            pictureBoxInvalid.Visible = false;
            pictureBoxValid.Visible = false;
            InitialPermission();
        }

        void txtPlateNumber_LostFocus(object sender, EventArgs e)
        {

            if (_vehicleBOL.CheckVehicle(txtPlateNumber.Text.Trim()) && !txtPlateNumber.Text.Trim().Equals(""))
            {
                pictureBoxInvalid.Visible = false;
                pictureBoxValid.Visible = true;

            }
            else
            {
                pictureBoxInvalid.Visible = true;
                pictureBoxValid.Visible = false;
            }
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
                cbConfirmExport.Enabled = false;
                cbConfirmImport.Enabled = false;
                lblIsExport.Text = "Bạn không có quyền";
                lblIsImport.Text = "Bạn không có quyền";

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                var vehicleInfo = GetVehicle();
                if (vehicleInfo != null)
                {

                    // Bind to gridview.
                    VehicleInfosTemp.Add(vehicleInfo);
                    BindVehicle(VehicleInfosTemp);

                    ResetForm();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

            //Set curent cell for poiter to bottom
            this.grdVehicle.CurrentCell = this.grdVehicle[0, this.grdVehicle.Rows.Count - 1];

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {

                if (grdVehicle.SelectedRows.Count == 1) // New mode
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

                else
                {
                    MessageBox.Show("Bạn cần chọn 1 phương tiện cần xóa.");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbConfirmExport_CheckedChanged(object sender, EventArgs e)
        {
            if (cbConfirmExport.Checked)
            {
                dateTimePickerExport.Visible = true;
                mtxtExportHour.Visible = true;
                dateTimePickerExport.Value = DateTime.Now;
                mtxtExportHour.Text = string.Format("{0:HH:mm}", DateTime.Now);
                lblIsExport.Visible = false;

            }
            else
            {
                dateTimePickerExport.Visible = false;
                mtxtExportHour.Visible = false;
                lblIsExport.Visible = true;

            }

        }

        private void cbConfirmImport_CheckedChanged(object sender, EventArgs e)
        {
            if (cbConfirmImport.Checked)
            {
                dateTimePickerImport.Visible = true;
                mtxtImportHour.Visible = true;
                dateTimePickerImport.Value = DateTime.Now;
                mtxtImportHour.Text = string.Format("{0:HH:mm}", DateTime.Now);
                lblIsImport.Visible = false;

            }
            else
            {
                dateTimePickerImport.Visible = false;
                mtxtImportHour.Visible = false;
                lblIsImport.Visible = true;

            }
        }
        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            try
            {
                DeclarationBOL _declarationBOL = new DeclarationBOL();
                var declarationInfo = GetDeclarationInfo();
                declarationInfo.ModifiedDate = DateTime.Now;                
                declarationInfo.ModifiedByID = _userInfo.UserID;
                declarationInfo.tblUser = UserBOL.GetByID(_userInfo.UserID);
                if (VehicleInfosTemp.Count == 0)
                    throw new Exception("Phương tiện không được để trống");
                // TODO: Need to check- vuongdd comment ---------------------------------------------------------------
                ///_declarationBOL.AddDeclaration(declarationInfo, VehicleInfosTemp, _userInfo.UserID);
                MessageBox.Show(ConstantInfo.MESSAGE_INSERT_SUCESSFULLY);
                // Reset form
                ResetForm();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private tblDeclaration GetDeclarationInfo()
        {
            var declarationInfo = new tblDeclaration();
            declarationInfo.Number = 0;
            declarationInfo.ImportNumber = 0;
            return declarationInfo;
        }

        #endregion




    }
}