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

namespace ECustoms
{
    public partial class frmChangePassword : Form
    {
        private UserInfo _userInfo;
        private UserFactory _userBOL = new UserFactory();
        public frmChangePassword(UserInfo userInfor)
        {
            InitializeComponent();
            txtPassOld.Focus();
            _userInfo = _userBOL.SelectByID(userInfor.UserID);

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {                
                if (Validate())
                {
                
                _userInfo.UserName = _userInfo.UserName;
                _userInfo.Password = txtPassword.Text.Trim();
              
                    // Update
                    _userBOL.Update(_userInfo);

                    //TODO: Need to check number of rows are effected
                    MessageBox.Show(ConstantInfo.MESSAGE_UPDATE_SUCESSFULLY);
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.ToString());
            }
        }

        private bool Validate()
        {
            if (string.IsNullOrEmpty(txtPassOld.Text.Trim()))
            {
                MessageBox.Show(ConstantInfo.MESSAGE_BLANK_PASSWORD);
                txtPassOld.Focus();
                return false;
            }

            if (!Common.Encode(txtPassOld.Text.Trim()).Equals(_userInfo.Password))
            {
                MessageBox.Show(ConstantInfo.MESSAGE_INCORRECT_PASS);
                txtPassOld.Focus();
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


            return true;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            txtPassOld.Focus();
        }
    }
}
