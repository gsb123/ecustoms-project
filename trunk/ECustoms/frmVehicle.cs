using System;
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
    public partial class frmVehicle : Form
    {
        private frmExport _parrent;
        private List<VehicleInfo> _vehicleInfosTemp;
        private List<VehicleInfo> _newAddingVehicles = new List<VehicleInfo>();
        private int _mode = 0;
        private int _vehicleID;
        private VehicleBOL _vehicleBOL;
        private int _declarationID;
        private bool _isExport = false;
        private bool _isImport = false;
        private tblDeclaration _parrentDeclaration;
        private UserInfo _userInfo;
        private bool _isCompleted = false;
        private int _count;
        private string _currentModifyPlateNumber = string.Empty;

        public frmVehicle()
        {
            InitializeComponent();
            grdVehicle.AutoGenerateColumns = false;

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
                btnConfirmExport.Visible = false;
                btnConfirmImport.Visible = false;
                btnSearch.Visible = false;

            }

        }

        public frmVehicle(int mode, frmExport parrent, ref  List<VehicleInfo> vehicleInfosTemp, tblDeclaration declarationInfo, UserInfo userInfo)
        {
            InitializeComponent();
            grdVehicle.AutoGenerateColumns = false;

            _mode = mode;
            _parrent = parrent;
            _vehicleInfosTemp = vehicleInfosTemp;
            _parrentDeclaration = declarationInfo;
            _userInfo = userInfo;

            //InitialPermission();
        }

        public frmVehicle(int mode, frmExport parrent, ref  List<VehicleInfo> vehicleInfosTemp, int count, tblDeclaration parrentDeclaration, UserInfo userInfo)
        {
            InitializeComponent();
            grdVehicle.AutoGenerateColumns = false;

            _mode = mode;
            _parrent = parrent;
            _vehicleInfosTemp = vehicleInfosTemp;
            _count = count;
            _parrentDeclaration = parrentDeclaration;
            _userInfo = userInfo;
            //InitialPermission();
        }

        public frmVehicle(int mode, int vehicleID, UserInfo userInfo)
        {
            InitializeComponent();
            _mode = mode;
            _vehicleID = vehicleID;
            _userInfo = userInfo;
            //InitialPermission();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Validate()
        {
            // comments code because new requirements
            // allow empty when inserting new verhicle,
            // the driver name might be filled later

            
            if (string.IsNullOrEmpty(txtPlateNumber.Text.Trim()))
            {
                MessageBox.Show("BKS không được để trống!");
                txtPlateNumber.Focus();
                return false;
            }
           

            return true;
        }

        private void ResetForm()
        {
            txtDriverName.Text = "";
            txtPlateNumber.Text = "";
            txtNumberOfContainer.Text = "";
            dtpExportDate.Value = DateTime.Now;
            mtxtExportHour.Text = "";
            txtStatus.Text = "";
            txtNote.Text = "";
            dtpExportDate.Visible = false;
            mtxtExportHour.Visible = false;
            _isExport = false;
            lblIsExport.Visible = true;

            dtpImportDate.Visible = false;
            mtxtImportHour.Visible = false;
            lblIsImport.Visible = true;
            _isImport = false;
            // Set focus
            txtPlateNumber.Focus();
        }

        private void frmVehicle_Load(object sender, EventArgs e)
        {
            this.Text = "Khai báo phương tiện" + ConstantInfo.MESSAGE_TITLE;
            this.Location = new Point((this.ParentForm.Width - this.Width) / 2, (this.ParentForm.Height - this.Height) / 2);
            Init();
        }

        private void Init()
        {
            // TODO: Need to handler it
            if (_mode == 3)
            {
                btnDelete.Enabled = false;
            }
            btnSearch.Enabled = false;

            if (_mode == 0 || _mode == 4) // Add mode - Click on Add New
            {
                dtpImportDate.Visible = false;
                mtxtImportHour.Visible = false;
                dtpExportDate.Visible = false;
                mtxtExportHour.Visible = false;
                lblIsExport.Visible = true;
                lblIsImport.Visible = true;
                btnUpdate.Enabled = false;
                btnAdd.Enabled = true;
                btnDelete.Enabled = false;
                btnConfirmImport.Enabled = true;
                btnConfirmExport.Enabled = true;
                btnAdd.Enabled = true;
                ResetForm();
                btnAdd.Text = "Lưu trữ phương tiện";
                btnSearch.Enabled = true;

            }
            else if (_mode == 1) // Add mode - CLick on Update
            {
                dtpImportDate.Visible = false;
                mtxtImportHour.Visible = false;
                btnUpdate.Enabled = true;
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnConfirmImport.Enabled = true;
                foreach (VehicleInfo vehicleInfo in _vehicleInfosTemp)
                {
                    if (vehicleInfo.Count == _count)
                    {
                        BindDataToControls(vehicleInfo);
                        break;
                    }

                }
                btnAdd.Text = "Lưu trữ phương tiện";
            }
            else if (_mode == 2 || _mode == 3) // EditMode - Update
            {
                btnAdd.Enabled = false;
                // Get data from database
                _vehicleBOL = new VehicleBOL();

                var vehicleInfo = _vehicleBOL.SelectByID(_vehicleID);

                if (_vehicleID == 0) // If vehicleID > 0 --> this form is opened form search form. so get data from database. If vehicle=0--> get by Count
                {
                    foreach (VehicleInfo vehicleInfoTemp in _vehicleInfosTemp)
                    {
                        if (vehicleInfoTemp.Count == _count)
                        {
                            vehicleInfo = vehicleInfoTemp;
                        }
                    }
                }
                if (vehicleInfo.ImportDate != null && vehicleInfo.IsImport)
                {
                    if (vehicleInfo.ImportDate.Value.Year.Equals(1900))
                    {
                        vehicleInfo.ImportDate = null;
                        dtpImportDate.Visible = false;
                        mtxtImportHour.Visible = false;
                        lblIsImport.Visible = true;
                    }

                    if (vehicleInfo.ExportDate != null && vehicleInfo.IsExport)
                        if (vehicleInfo.ExportDate.Value.Year.Equals(1900))
                        {
                            vehicleInfo.ImportDate = null;
                            dtpExportDate.Visible = false;
                            mtxtExportHour.Visible = false;
                            lblIsExport.Visible = true;
                        }
                }

                // Bind data to Controls

                //if(vehicleInfo.IsExport){
                //if(vehicleInfo.ConfirmExportBy != _userInfo.UserID)
                //}

                BindDataToControls(vehicleInfo);

                _declarationID = vehicleInfo.DeclarationID;
                btnAdd.Text = "Thêm mới phương tiện";
            }

            //// Check permission
            //if (_userInfo.PermissionID != 2) // Not is admin
            //{
            //    btnConfirmExport.Enabled = false;
            //    btnConfirmImport.Enabled = false;
            //}

            InitialPermission();
        }

        private void BindDataToControls(VehicleInfo vehicleInfo)
        {
            txtDriverName.Text = vehicleInfo.DriverName;
            txtPlateNumber.Text = vehicleInfo.PlateNumber;
            txtNumberOfContainer.Text = vehicleInfo.NumberOfContainer.ToString();

            if (vehicleInfo.IsImport)
            {
                dtpImportDate.Value = (DateTime)vehicleInfo.ImportDate;
                dtpImportDate.Visible = true;
                mtxtImportHour.Text = vehicleInfo.ImportHour;
                mtxtImportHour.Visible = true;
                lblIsImport.Visible = false;
            }
            else
            {
                dtpImportDate.Visible = false;
                mtxtImportHour.Visible = false;
                lblIsImport.Visible = true;
            }

            if (vehicleInfo.IsExport)
            {
                dtpExportDate.Value = (DateTime)vehicleInfo.ExportDate;
                dtpExportDate.Visible = true;
                mtxtExportHour.Text = vehicleInfo.ExportHour;
                mtxtExportHour.Visible = true;
                lblIsExport.Visible = false;
            }
            else
            {
                dtpExportDate.Visible = false;
                mtxtExportHour.Visible = false;
                lblIsExport.Visible = true;
            }

            mtxtImportHour.Text = vehicleInfo.ImportHour;
            txtStatus.Text = vehicleInfo.Status;
            txtNote.Text = vehicleInfo.Note;
            _isImport = vehicleInfo.IsImport;
            _isExport = vehicleInfo.IsExport;

            if (vehicleInfo.ConfirmImportBy != 0 && vehicleInfo.ConfirmImportBy != _userInfo.UserID)
                btnConfirmImport.Enabled = false;

            if (vehicleInfo.ConfirmExportBy != 0 && vehicleInfo.ConfirmExportBy != _userInfo.UserID)
                btnConfirmExport.Enabled = false;
        }

        /// <summary>
        /// Bind data to controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_mode == 1) // AddNew- Edit
            {
                foreach (VehicleInfo vehicleInfo in _vehicleInfosTemp)
                {
                    if (vehicleInfo.VehicleID == _vehicleID)
                    {
                        vehicleInfo.DriverName = txtDriverName.Text.Trim();
                        vehicleInfo.PlateNumber = txtPlateNumber.Text.Trim();
                        vehicleInfo.NumberOfContainer = Convert.ToInt32(txtNumberOfContainer.Text.Trim());
                        vehicleInfo.ExportDate = dtpExportDate.Value;
                        vehicleInfo.ExportHour = mtxtExportHour.Text;
                        vehicleInfo.Status = txtStatus.Text;
                        vehicleInfo.Note = txtNote.Text;
                        vehicleInfo.IsExport = _isExport;
                    }
                    break;
                }
                _parrent.BindVehicle(_vehicleInfosTemp);
                MessageBox.Show("Cập nhật thành công.");
                this.Close();
            }

            if (_mode == 2) // Edit Mode - Edit
            {
                var vehicleInfo = new VehicleInfo();
                vehicleInfo.DriverName = txtDriverName.Text.Trim();
                vehicleInfo.PlateNumber = txtPlateNumber.Text.Trim();
                vehicleInfo.NumberOfContainer = Convert.ToInt32(txtNumberOfContainer.Text.Trim());
                vehicleInfo.ExportDate = dtpExportDate.Value;
                vehicleInfo.ImportDate = dtpImportDate.Value;
                vehicleInfo.Status = txtStatus.Text;
                vehicleInfo.Note = txtNote.Text;
                vehicleInfo.IsExport = _isExport;
                vehicleInfo.IsImport = _isImport;
                vehicleInfo.VehicleID = _vehicleID;
                vehicleInfo.IsCompleted = _isCompleted;
                _vehicleBOL.Update(vehicleInfo);
                // Get Vehicle by DeclarationID
                var listVehicle = _vehicleBOL.SelectByDeclarationID(_declarationID);
                _parrent.BindVehicle(listVehicle);
                MessageBox.Show("Cập nhật thành công.");
                this.Close();
            }

            if (_mode == 3) // Edit mode from Search form
            {
                var vehicleInfo = new VehicleInfo();
                vehicleInfo.DriverName = txtDriverName.Text.Trim();
                vehicleInfo.PlateNumber = txtPlateNumber.Text.Trim();
                vehicleInfo.NumberOfContainer = Convert.ToInt32(txtNumberOfContainer.Text.Trim());
                vehicleInfo.ExportDate = dtpExportDate.Value;
                vehicleInfo.ImportDate = dtpImportDate.Value;
                vehicleInfo.Status = txtStatus.Text;
                vehicleInfo.Note = txtNote.Text;
                vehicleInfo.IsExport = _isExport;
                vehicleInfo.IsImport = _isImport;
                vehicleInfo.IsCompleted = _isCompleted;
                vehicleInfo.VehicleID = _vehicleID;
                _vehicleBOL.Update(vehicleInfo);
                MessageBox.Show("Cập nhật thành công.");
                this.Close();
            }
        }

        private void btnConfirmExport_Click(object sender, EventArgs e)
        {
            try
            {
                var message = new StringBuilder();
                message.Append("Thời gian xuất cảnh: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                if (_parrentDeclaration != null && _parrentDeclaration.HasDeclaration.Value)
                {
                    message.Append("; Số tờ khai: " + _parrentDeclaration.Number);
                    message.Append("; Ngày khai: " + DateTime.Now.ToString("dd/MM/yyy HH:mm"));
                    message.Append("; Tên hàng: " + _parrentDeclaration.ProductName);
                    message.Append("; Số lượng: " + _parrentDeclaration.ProductAmount);
                }

                if (MessageBox.Show(message.ToString(), "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dtpExportDate.Visible = true;
                    dtpExportDate.Value = DateTime.Now;
                    mtxtExportHour.Visible = true;
                    mtxtExportHour.Text = string.Format("{0:HH:mm}", DateTime.Now);
                    lblIsExport.Visible = false;

                    if (_mode == 1 || _mode == 2) // AddNew- Edit 
                    {
                        foreach (VehicleInfo vehicleInfo in _vehicleInfosTemp)
                        {
                            if (vehicleInfo.Count == _count)
                            {
                                if (vehicleInfo.ConfirmExportBy == 0)
                                {
                                    _isExport = true;
                                    vehicleInfo.IsExport = _isExport;
                                    vehicleInfo.ConfirmExportBy = _userInfo.UserID;

                                }
                                else
                                {
                                    if (vehicleInfo.ConfirmExportBy != _userInfo.UserID)
                                        throw new Exception("Phương tiện này đã được xác nhận xuất khẩu bởi người khác!");
                                }

                            }
                        }
                    }
                    else if (_mode == 4 || _mode == 3)
                    {
                        _isExport = true;
                    }

                }
                else
                {
                    dtpExportDate.Visible = false;
                    mtxtExportHour.Visible = false;
                    lblIsExport.Visible = true;
                    _isExport = false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnConfirmImport_Click(object sender, EventArgs e)
        {
            try
            {
                var message = new StringBuilder();
                message.Append("Thời gian nhập cảnh: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                if (_parrentDeclaration != null && _parrentDeclaration.HasDeclaration.Value)
                {
                    message.Append("; Số tờ khai: " + _parrentDeclaration.Number);
                    message.Append("; Ngày khai: " + DateTime.Now.ToString("dd/MM/yyy HH:mm"));
                    message.Append("; Tên hàng: " + _parrentDeclaration.ProductName);
                    message.Append("; Số lượng: " + _parrentDeclaration.ProductAmount);
                }

                if (MessageBox.Show(message.ToString(), "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dtpImportDate.Visible = true;
                    dtpImportDate.Value = DateTime.Now;
                    mtxtImportHour.Visible = true;
                    mtxtImportHour.Text = string.Format("{0:HH:mm}", DateTime.Now);
                    lblIsImport.Visible = false;
                    //_isImport = true;
                    _isCompleted = true;

                    if (_mode == 1 || _mode == 2) // AddNew- Edit - Update mode
                    {
                        foreach (VehicleInfo vehicleInfo in _vehicleInfosTemp)
                        {
                            if (vehicleInfo.Count == _count)
                            {
                                if (vehicleInfo.ConfirmImportBy == 0)
                                {
                                    _isImport = true;
                                    vehicleInfo.IsImport = _isImport;
                                    vehicleInfo.ConfirmImportBy = _userInfo.UserID;
                                }
                                else
                                {
                                    if (vehicleInfo.ConfirmImportBy != _userInfo.UserID)
                                        throw new Exception("Phương tiện này đã được xác nhận xuất khẩu bởi người khác!");
                                }

                            }
                        }
                    }
                    else if (_mode == 4 || _mode == 3)
                    {
                        _isImport = true;
                    }

                }
                else
                {
                    dtpImportDate.Visible = false;
                    mtxtImportHour.Visible = false;
                    lblIsImport.Visible = true;
                    _isImport = false;
                    _isCompleted = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // add new vehicle
            try
            {
                if (!Validate()) return;
                
                // Add data to veicleInfo list
                var vehicleInfo = new VehicleInfo();
                vehicleInfo.DriverName = txtDriverName.Text.Trim();
                vehicleInfo.PlateNumber = txtPlateNumber.Text.Trim();
                if (txtNumberOfContainer.Text != "")
                {
                    vehicleInfo.NumberOfContainer = Convert.ToInt32(txtNumberOfContainer.Text.Trim());
                }

                if (_isExport)
                {
                    vehicleInfo.ExportDate = dtpExportDate.Value;
                    vehicleInfo.ExportHour = mtxtExportHour.Text;
                    vehicleInfo.ConfirmExportBy = _userInfo.UserID;
                }

                if (_isImport)
                {
                    vehicleInfo.ImportDate = dtpImportDate.Value;
                    vehicleInfo.ImportHour = mtxtImportHour.Text;
                    vehicleInfo.ConfirmImportBy = _userInfo.UserID;
                }

                vehicleInfo.Status = txtStatus.Text;
                vehicleInfo.Note = txtNote.Text;
                vehicleInfo.VehicleID = _vehicleInfosTemp.Count + 1;
                vehicleInfo.IsExport = _isExport;
                vehicleInfo.IsImport = _isImport;
                vehicleInfo.IsCompleted = _isCompleted;
                vehicleInfo.DeclarationID = _parrentDeclaration.DeclarationID;
                if (vehicleInfo.ExportDate != null && vehicleInfo.ExportDate.Value.Year.Equals(1900))
                {
                    vehicleInfo.ExportDate = null;
                }
                if (vehicleInfo.ImportDate != null && vehicleInfo.ImportDate.Value.Year.Equals(1900))
                {
                    vehicleInfo.ImportDate = null;
                }

                // Add Mode
                if (_mode == 0)
                {
                    // Bind to gridview.
                    _vehicleInfosTemp.Add(vehicleInfo);
                    _newAddingVehicles.Add(vehicleInfo);
                    _parrent.BindVehicle(_vehicleInfosTemp);
                }
                else
                {
                    _vehicleBOL = new VehicleBOL();
                    // Insert into database
                    // _vehicleBOL.Insert(vehicleInfo);
                    _newAddingVehicles.Add(vehicleInfo);
                    // Bind to gridview.
                    // Get Vehicle by DeclarationID
                    var listVehicle = _vehicleBOL.SelectByDeclarationID(vehicleInfo.DeclarationID);
                    _parrent.BindVehicle(listVehicle);

                }
                grdVehicle.DataSource = null;
                grdVehicle.DataSource = _newAddingVehicles;

                //Set curent cell for poiter to bottom
                this.grdVehicle.CurrentCell = this.grdVehicle[0, this.grdVehicle.Rows.Count - 1];

                // MessageBox.Show(ConstantInfo.MESSAGE_INSERT_SUCESSFULLY);
                ResetForm();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            // process when user updating new vehicle input
            if (!string.IsNullOrEmpty(_currentModifyPlateNumber))
            {
                // update to list
                var result = _newAddingVehicles.Where(v => v.PlateNumber.ToString().Equals(_currentModifyPlateNumber, StringComparison.InvariantCultureIgnoreCase)).ToList().FirstOrDefault();
                if (result == null)
                {
                    return;
                }
                result.DriverName = txtDriverName.Text.Trim();
                result.PlateNumber = txtPlateNumber.Text.Trim();
                result.NumberOfContainer = Convert.ToInt16(txtNumberOfContainer.Text);
                result.Status = txtStatus.Text;
                result.Note = txtNote.Text;

                grdVehicle.Refresh();
                _parrent.grdVehicle.DataSource = null;
                _parrent.grdVehicle.DataSource = _vehicleInfosTemp;
                // assign to emty when finsih proccessing
                _currentModifyPlateNumber = string.Empty;

                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                ResetForm();

                return;
            }


            try
            {
                if (!Validate()) return;
                if (_mode == 1 || _mode == 2) // AddNew- Edit
                {
                    foreach (VehicleInfo vehicleInfo in _vehicleInfosTemp)
                    {
                        if (vehicleInfo.Count == _count)
                        {
                            vehicleInfo.DriverName = txtDriverName.Text.Trim();
                            vehicleInfo.PlateNumber = txtPlateNumber.Text.Trim();
                            vehicleInfo.NumberOfContainer = Convert.ToInt32(txtNumberOfContainer.Text.Trim());
                            vehicleInfo.ExportDate = dtpExportDate.Value;
                            vehicleInfo.ImportDate = dtpImportDate.Value;
                            vehicleInfo.ExportHour = mtxtExportHour.Text;
                            vehicleInfo.ImportHour = mtxtImportHour.Text;
                            vehicleInfo.Status = txtStatus.Text;
                            vehicleInfo.Note = txtNote.Text;
                            vehicleInfo.IsCompleted = _isCompleted;
                            vehicleInfo.IsExport = _isExport;
                            vehicleInfo.IsImport = _isImport;

                            if (vehicleInfo.ConfirmExportBy == 0 && vehicleInfo.IsExport)
                                vehicleInfo.ConfirmExportBy = _userInfo.UserID;

                            if (vehicleInfo.ConfirmImportBy == 0 && vehicleInfo.IsImport)
                                vehicleInfo.ConfirmImportBy = _userInfo.UserID;



                            break;
                        }
                    }
                    _parrent.BindVehicle(_vehicleInfosTemp);
                    MessageBox.Show("Lưu thành công.");
                    this.Close();
                }

                //if (_mode == 2) // Edit Mode - Edit
                //{
                //    var vehicleInfo = new VehicleInfo();
                //    vehicleInfo.DriverName = txtDriverName.Text.Trim();
                //    vehicleInfo.PlateNumber = txtPlateNumber.Text.Trim();
                //    if (!string.IsNullOrEmpty(txtNumberOfContainer.Text.Trim()))
                //    {
                //        vehicleInfo.NumberOfContainer = Convert.ToInt32(txtNumberOfContainer.Text.Trim());    
                //    }
                //    vehicleInfo.ExportDate = dtpExportDate.Value;
                //    vehicleInfo.ImportDate = dtpImportDate.Value;
                //    vehicleInfo.ImportHour = mtxtImportHour.Text;
                //    vehicleInfo.ExportHour = mtxtExportHour.Text;

                //    vehicleInfo.Status = txtStatus.Text;
                //    vehicleInfo.Note = txtNote.Text;
                //    vehicleInfo.IsExport = _isExport;
                //    vehicleInfo.IsImport = _isImport;
                //    vehicleInfo.IsCompleted = _isCompleted;
                //    vehicleInfo.IsGoodsImported = chkGoodsImported.Checked;
                //    vehicleInfo.VehicleID = _vehicleID;
                //    _vehicleBOL.Update(vehicleInfo);

                //    // Get Vehicle by DeclarationID
                //    var listVehicle = _vehicleBOL.SelectByDeclarationID(_declarationID);
                //    _parrent.BindVehicle(listVehicle);
                //    MessageBox.Show("Cập nhật thành công.");
                //    this.Close();
                //}

                if (_mode == 3) // Edit mode from Search form
                {
                    var vehicleInfo = new VehicleInfo();
                    _vehicleBOL = new VehicleBOL();
                    vehicleInfo = _vehicleBOL.SelectByID(_vehicleID);
                    vehicleInfo.DriverName = txtDriverName.Text.Trim();
                    vehicleInfo.PlateNumber = txtPlateNumber.Text.Trim();
                    if (!string.IsNullOrEmpty(txtNumberOfContainer.Text.Trim()))
                    {
                        vehicleInfo.NumberOfContainer = Convert.ToInt32(txtNumberOfContainer.Text.Trim());
                    }


                    vehicleInfo.Status = txtStatus.Text;
                    vehicleInfo.Note = txtNote.Text;
                    vehicleInfo.IsExport = _isExport;
                    vehicleInfo.IsImport = _isImport;
                    vehicleInfo.ImportDate = dtpImportDate.Value;
                    vehicleInfo.ExportDate = dtpExportDate.Value;


                    //vehicleInfo.IsExport = _isExport;
                    //vehicleInfo.IsImport = _isImport;


                    if (vehicleInfo.ConfirmExportBy == 0 && vehicleInfo.IsExport)
                        vehicleInfo.ConfirmExportBy = _userInfo.UserID;

                    if (vehicleInfo.ConfirmImportBy == 0 && vehicleInfo.IsImport)
                        vehicleInfo.ConfirmImportBy = _userInfo.UserID;


                    vehicleInfo.ImportedLocalTime = new DateTime(1900, 1, 1);

                    vehicleInfo.IsCompleted = _isCompleted;
                    vehicleInfo.VehicleID = _vehicleID;
                    _vehicleBOL.Update(vehicleInfo);
                    MessageBox.Show("Cập nhật thành công.");
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_mode == 1) // Add new - delete mode
                {
                    foreach (VehicleInfo vehicleInfo in _vehicleInfosTemp)
                    {
                        if (vehicleInfo.VehicleID == _vehicleID)
                        {
                            _vehicleInfosTemp.Remove(vehicleInfo);
                            MessageBox.Show("Xóa xong");
                        }
                        break;
                    }
                    _parrent.BindVehicle(_vehicleInfosTemp);
                    this.Close();
                }
                if (_mode == 2) // Edit Mode - delete
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        VehicleBOL.DeleteByID(_vehicleID);
                        // Get Vehicle by DeclarationID
                        var listVehicle = _vehicleBOL.SelectByDeclarationID(_declarationID);
                        _parrent.BindVehicle(listVehicle);
                        MessageBox.Show("Xóa thành công.");
                        this.Close();
                    }

                }
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.ToString());
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDriverName.Text = "";
            txtPlateNumber.Text = "";
            txtNumberOfContainer.Text = "";
            dtpImportDate.Visible = false;
            dtpExportDate.Visible = false;
            mtxtImportHour.Visible = false;
            mtxtExportHour.Visible = false;
            lblIsImport.Visible = true;
            lblIsExport.Visible = true;
            _isImport = false;
            _isExport = false;
            txtStatus.Text = "";
            txtNote.Text = "";
        }

        /// <summary>
        /// Handles the KeyPress event of the txtPlateNumber control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.KeyPressEventArgs"/> instance containing the event data.</param>
        private void txtPlateNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((_mode == 0 || _mode == 4) && e.KeyChar == 13)
            {
                if (!Validate()) return;

                // Add data to veicleInfo list
                var vehicleInfo = new VehicleInfo();
                vehicleInfo.DriverName = txtDriverName.Text.Trim();
                vehicleInfo.PlateNumber = txtPlateNumber.Text.Trim();
                if (txtNumberOfContainer.Text != "")
                {
                    vehicleInfo.NumberOfContainer = Convert.ToInt32(txtNumberOfContainer.Text.Trim());
                }

                if (_isExport)
                {
                    vehicleInfo.ExportDate = dtpExportDate.Value;
                    vehicleInfo.ExportHour = mtxtExportHour.Text;
                }

                if (_isImport)
                {
                    vehicleInfo.ImportDate = dtpImportDate.Value;
                    vehicleInfo.ImportHour = mtxtImportHour.Text;
                }

                vehicleInfo.Status = txtStatus.Text;
                vehicleInfo.Note = txtNote.Text;
                vehicleInfo.VehicleID = _vehicleInfosTemp.Count + 1;
                vehicleInfo.IsExport = _isExport;
                vehicleInfo.IsImport = _isImport;
                vehicleInfo.IsCompleted = _isCompleted;
                vehicleInfo.DeclarationID = _parrentDeclaration.DeclarationID;
                if (vehicleInfo.ExportDate != null && vehicleInfo.ExportDate.Value.Year.Equals(1900))
                {
                    vehicleInfo.ExportDate = null;
                }
                if (vehicleInfo.ImportDate != null && vehicleInfo.ImportDate.Value.Year.Equals(1900))
                {
                    vehicleInfo.ImportDate = null;
                }

                _vehicleInfosTemp.Add(vehicleInfo);
                _newAddingVehicles.Add(vehicleInfo);
                ResetForm();
                grdVehicle.DataSource = null;
                grdVehicle.DataSource = _newAddingVehicles;
                grdVehicle.Refresh();
                //Set curent cell for poiter to bottom
                this.grdVehicle.CurrentCell = this.grdVehicle[0, this.grdVehicle.Rows.Count - 1];


                _parrent.BindVehicle(_vehicleInfosTemp);
                txtPlateNumber.Focus();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var driverName = txtDriverName.Text.Trim();
            var plateNumber = txtPlateNumber.Text.Trim();

            if (string.IsNullOrEmpty(driverName) && string.IsNullOrEmpty(plateNumber))
            {
                grdVehicle.DataSource = _newAddingVehicles;
                this.grdVehicle.CurrentCell = this.grdVehicle[0, this.grdVehicle.Rows.Count- 1];
            }

            var result = _newAddingVehicles.Where(v => (v.DriverName.IndexOf(driverName, StringComparison.InvariantCultureIgnoreCase) >= 0)
                                                           && (v.PlateNumber.IndexOf(plateNumber, StringComparison.InvariantCultureIgnoreCase) >= 0)).ToList();
            grdVehicle.DataSource = result;
            this.grdVehicle.CurrentCell = this.grdVehicle[0, this.grdVehicle.Rows.Count- 1];
        }

        private void grdVehicle_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var plateNumber = grdVehicle.Rows[e.RowIndex].Cells["PlateNumber"].Value.ToString();
            var result = _newAddingVehicles.Where(v => v.PlateNumber.ToString().Equals(plateNumber, StringComparison.InvariantCultureIgnoreCase)).ToList().FirstOrDefault();
            txtDriverName.Text = result.DriverName;
            txtPlateNumber.Text = result.PlateNumber;
            txtNumberOfContainer.Text = result.NumberOfContainer.ToString();
            txtStatus.Text = result.Status;
            txtNote.Text = result.Note;
            mtxtImportHour.Text = result.ImportHour;
            mtxtExportHour.Text = result.ExportHour;
            _currentModifyPlateNumber = plateNumber;

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void frmVehicle_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (_parrentDeclaration == null || _parrentDeclaration.DeclarationID == 0)
                {
                    return;
                }
                // add to database when closing form
                _vehicleBOL = new VehicleBOL();

                foreach (var vehicle in _newAddingVehicles)
                {
                    _vehicleBOL.Insert(vehicle);
                }


                _parrent.grdVehicle.DataSource = null;
                var listVehicle = _vehicleBOL.SelectByDeclarationID(_parrentDeclaration.DeclarationID);
                _parrent.BindVehicle(listVehicle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
