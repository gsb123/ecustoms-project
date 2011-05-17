using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ECustoms.BOL;
using ECustoms.Utilities;

namespace ECustoms
{
    public partial class frmAddUser : Form
    {
        private frmUser _parrent;
        private int _mode;
        private int _userID;
        private UserBOL _userBOL;
        private PermissionBOL _permissionBOL;
        public frmAddUser()
        {
            InitializeComponent();
        }

        public frmAddUser(frmUser parrent, int mode)
        {
            InitializeComponent();
            _parrent = parrent;
            _mode = mode;
        }

        public frmAddUser(frmUser parrent, int mode, int userID)
        {
            InitializeComponent();
            _parrent = parrent;
            _mode = mode;
            _userID = userID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            this.Text = "Thông tin người dùng" + ConstantInfo.MESSAGE_TITLE;
            // Show form to the center
            this.Location = new Point((this.ParentForm.Width - this.Width) / 2, (this.ParentForm.Height - this.Height) / 2);
            _userBOL = new UserBOL();
            _permissionBOL = new PermissionBOL();
            Init();
        }

        /// <summary>
        /// Init data
        /// </summary>
        private void Init()
        {
            // Bind Data to combobox
            cbbPermission.DataSource = _permissionBOL.GetAllPermission();
            cbbPermission.DisplayMember = ConstantInfo.TBL_PERMISSION_PERMISSION;
            cbbPermission.ValueMember = ConstantInfo.TBL_PERMISSION_PERMISSION_ID;
            if (_mode == 0) // Add new Mode
            {
                btnUpdate.Enabled = false;
                btnAdd.Enabled = true;
            }
            else // Update Mode
            {
                btnUpdate.Enabled = true;
                btnAdd.Enabled = false;
                // Get User by ID
                var userInfo = _userBOL.SelectByID(_userID);
                // Bind data to the UI
                txtUserName.Text = userInfo.UserName;

                // Don't allow you edit username
                txtUserName.Enabled = false;

                txtPassword.Text = userInfo.Password;
                txtRetypePassword.Text = userInfo.Password;
                txtEmail.Text = userInfo.Email;
                txtName.Text = userInfo.Name;
                txtAddress.Text = userInfo.Address;
                txtPhone.Text = userInfo.PhoneNumber;
                cbbPermission.SelectedValue = userInfo.PermissionID;
                cbActive.Checked = userInfo.IsActive;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate
                if (Validate())
                {
                    // Check the existing username   
                    if (!_userBOL.IsUserExisting(txtUserName.Text.Trim()))
                    {
                        // Insert to database
                        var userInfo = new UserInfo();
                        BindControlToData(ref userInfo);
                        // Insert to database
                        _userBOL.Insert(userInfo);
                        _parrent.BindData(_userBOL.SelectAll());
                        //TODO: Need to check number of rows are effected
                        MessageBox.Show(ConstantInfo.MESSAGE_INSERT_SUCESSFULLY);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show(ConstantInfo.MESSAGE_USERNAME_EXISTING);
                    }
                }
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.ToString());
            }

        }


        private bool Validate()
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                MessageBox.Show(ConstantInfo.MESSAGE_BLANK_USERNAME);
                txtUserName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show(ConstantInfo.MESSAGE_BLANK_PASSWORD);
                txtPassword.Focus();
                return false;
            }


            if (!txtPassword.Text.Trim().Equals(txtRetypePassword.Text.Trim()))
            {
                MessageBox.Show(ConstantInfo.MESSAGE_COMPARE_PASSWORD);
                txtPassword.Focus();
                return false;
            }

            Regex rEMail = new Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                MessageBox.Show(ConstantInfo.MESSAGE_BLANK_EMAIL);
                txtEmail.Focus();
                return false;
            }
            else if (!rEMail.IsMatch(txtEmail.Text.Trim()))
            {
                MessageBox.Show(ConstantInfo.MESSAGE_WRONG_EMAIL);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var userInfo = new UserInfo();
                BindControlToData(ref userInfo);
                userInfo.UserID = _userID;
                // Update
                _userBOL.Update(userInfo);
                _parrent.BindData(_userBOL.SelectAll());
                //TODO: Need to check number of rows are effected
                MessageBox.Show(ConstantInfo.MESSAGE_UPDATE_SUCESSFULLY);
                this.Close();
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.ToString());
            }

        }

        /// <summary>
        /// Bind data to controls
        /// </summary>
        private void BindControlToData(ref UserInfo userInfo)
        {
            userInfo.UserName = txtUserName.Text.Trim();
            userInfo.Password = txtPassword.Text.Trim();
            userInfo.Email = txtEmail.Text;
            userInfo.Name = txtName.Text;
            userInfo.Address = txtAddress.Text;
            userInfo.PhoneNumber = txtPhone.Text;
            userInfo.PermissionID = Convert.ToInt32(cbbPermission.SelectedValue);
            userInfo.IsActive = cbActive.Checked;
        }
    }
}
