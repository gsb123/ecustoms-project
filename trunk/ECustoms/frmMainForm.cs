using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ECustoms.Utilities;

namespace ECustoms
{
    public partial class frmMainForm : Form
    {
        private UserInfo _userInfo;
        public frmMainForm()
        {
            InitializeComponent();
        }

        public frmMainForm(UserInfo userInfo)
        {
            InitializeComponent();
            _userInfo = userInfo;
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            this.Text = "Khai báo xuất nhập cảnh" + ConstantInfo.MESSAGE_TITLE;
            InitData();
            this.FormClosed += new FormClosedEventHandler(frmMainForm_FormClosed);
        }

        void frmMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Init data
        /// </summary>
        private void  InitData()
        {
            toolstripLabelWelcome.Text = string.Format(ConstantInfo.MESSAGE_WELCOME, _userInfo.Name);
            // Show decleration form
            var frmDecleration = new frmDecleration(_userInfo, this);
            frmDecleration.MdiParent = this;
            frmDecleration.Show();

            //Set permission
            if (_userInfo.PermissionID == 2)
            {
                menuitemUser.Visible = true;
            }
            else
            {
                menuitemUser.Visible = false;
            }
        }

        private void mnExport_Click(object sender, EventArgs e)
        {
            var frmExport = new frmExport(_userInfo, 0);
            frmExport.MdiParent = this;            
            frmExport.Show();
        }

        private void vehicleSearch_Click(object sender, EventArgs e)
        {
            var vehicleSearch = new frmVehicleSearch(_userInfo);
            vehicleSearch.MdiParent = this;
            vehicleSearch.Show();
        }

        private void menuitemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuitemLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Close();
            frmLogin.Show();
        }

        private void menuitemDeclaration_Click(object sender, EventArgs e)
        {
            var frmDecleration = new frmDecleration(_userInfo, this);
            frmDecleration.MdiParent = this;
            frmDecleration.Show();
        }

        private void menuitemUser_Click(object sender, EventArgs e)
        {
            var frmUser = new frmUser();
            frmUser.MdiParent = this;            
            frmUser.Show();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var frmExport = new frmExport(_userInfo, 0);
            frmExport.MdiParent = this;
            frmExport.Show();
        }

        private void pictureSearch_Click(object sender, EventArgs e)
        {
            var vehicleSearch = new frmVehicleSearch();
            vehicleSearch.MdiParent = this;
            vehicleSearch.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var frmDecleration = new frmDecleration(_userInfo, this);
            frmDecleration.MdiParent = this;
            frmDecleration.Show();
        }

        private void toolStripButtonDeclarace_Click(object sender, EventArgs e)
        {
            var frmExport = new frmExport(_userInfo, 0);
            frmExport.MdiParent = this;
            frmExport.Show();
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            var vehicleSearch = new frmVehicleSearch(_userInfo);
            vehicleSearch.MdiParent = this;
            vehicleSearch.Show();
        }

        private void toolStripButtonListdeclarace_Click(object sender, EventArgs e)
        {
            var frmDecleration = new frmDecleration(_userInfo, this);
            frmDecleration.MdiParent = this;
            frmDecleration.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmChangePassword = new frmChangePassword(_userInfo);
            frmChangePassword.MdiParent = this;
            frmChangePassword.Show();

        }
    }
}
