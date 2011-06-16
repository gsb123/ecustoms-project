using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ECustoms.BOL;
using ECustoms.Utilities;
using log4net;

namespace ECustoms
{
    public partial class frmLogin : Form
    {
        //private readonly ILog logger;
        private UserBOL _userBOL;
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger("Ecustoms.frmLogin");

        public frmLogin()
        {            
            InitializeComponent();                        
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {                
                logger.Info("btnLogin_Click");
                if (Validate())
                {
                    var objUserInfo = new UserInfo
                                          {
                                              UserName = txtUsername.Text.Trim(),
                                              Password = txtPassword.Text.Trim()
                                          };

                    var userInfo = _userBOL.GetUser(objUserInfo);
                    if (userInfo != null) // Login sucessfully
                    {
                        // Redirect to the main form
                        var mainForm = new frmMainForm(userInfo);
                        mainForm.WindowState = FormWindowState.Maximized;                    
                        mainForm.Show();                    
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(ConstantInfo.MESSAGE_LOGIN_FAIL, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());                
            }
            
        }

        private bool  Validate()
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                lblValidateUserName.Visible = true;
                txtUsername.Focus();
                return false;
            }
            else
            {
                lblValidateUserName.Visible = false;
            }

            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                lblValidatePassword.Visible = true;
                txtPassword.Focus();
                return false;
            }
            else
            {
                lblValidatePassword.Visible = false;
            }
            return true;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "Đăng nhập" + ConstantInfo.MESSAGE_TITLE;
            _userBOL = new UserBOL();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // Enter key
            {
                try
                {
                    logger.Info("txtPassword_KeyPress");
                    if (Validate())
                    {
                        var objUserInfo = new UserInfo
                        {
                            UserName = txtUsername.Text.Trim(),
                            Password = txtPassword.Text.Trim()
                        };

                        var userInfo = _userBOL.GetUser(objUserInfo);
                        if (userInfo != null) // Login sucessfully
                        {
                            // Redirect to the main form
                            var mainForm = new frmMainForm(userInfo);
                            mainForm.WindowState = FormWindowState.Maximized;
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show(ConstantInfo.MESSAGE_LOGIN_FAIL, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {

                    logger.Error(ex.ToString());
                }               
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // Enter key
            {
                if (Validate())
                {
                    var objUserInfo = new UserInfo
                    {
                        UserName = txtUsername.Text.Trim(),
                        Password = txtPassword.Text.Trim()
                    };

                    var userInfo = _userBOL.GetUser(objUserInfo);
                    if (userInfo != null) // Login sucessfully
                    {
                        // Redirect to the main form
                        var mainForm = new frmMainForm(userInfo);
                        mainForm.WindowState = FormWindowState.Maximized;
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(ConstantInfo.MESSAGE_LOGIN_FAIL, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }       
    }
}
