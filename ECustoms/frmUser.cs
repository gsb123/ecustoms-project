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
    public partial class frmUser : Form
    {
        private static log4net.ILog logger = LogManager.GetLogger("Ecustoms.frmUser");
        private UserFactory _userBOL;

        public frmUser()
        {
            InitializeComponent();            
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            this.Text = "Quản lý người dùng" + ConstantInfo.MESSAGE_TITLE;
            // Show form to the center
            this.Location = new Point((this.ParentForm.Width - this.Width) / 2, (this.ParentForm.Height - this.Height) / 2);            
            _userBOL = new UserFactory();
            grvUser.AutoGenerateColumns = false;
            BindData(_userBOL.SelectAll());
        }
        
        /// <summary>
        /// Bind Data to gridview
        /// </summary>
        /// <param name="uerInfos">UerInfo objcts</param>
        public void BindData(List<UserInfo> uerInfos)
        {
            grvUser.DataSource = uerInfos;
        }
               

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var addUser = new frmAddUser(this, 0);
                addUser.MdiParent = this.ParentForm;
                addUser.Show();
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
                if (grvUser.SelectedRows.Count != 0)
                {
                    frmAddUser addUser = new frmAddUser(this, 1, Convert.ToInt32(grvUser.SelectedRows[0].Cells[ConstantInfo.TBL_USER_USERID].Value));
                    addUser.MdiParent = this.ParentForm;
                    addUser.Show();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO: Need to delete multiple instanse one time
                if (grvUser.SelectedRows.Count > 0)
                {
                    var dr = MessageBox.Show("Bạn có chắc là muốn xóa?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        for (int i = 0; i < grvUser.SelectedRows.Count; i++)
                        {
                            var userID = Convert.ToInt32(grvUser.SelectedRows[i].Cells["UserID"].Value);
                            _userBOL.DeleteByID(userID);
                        }
                        MessageBox.Show("Xóa xong");
                        BindData(_userBOL.SelectAll());
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
    }
}
