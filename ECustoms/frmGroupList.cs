using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ECustoms.BOL;
using ECustoms.Utilities.Enums;

namespace ECustoms
{
    public partial class frmGroupList : Form
    {
        RoleFactory factory = new RoleFactory();
        public frmGroupList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var addGroup = new frmAddGroup(Mode.Create, 0);
                addGroup.MdiParent = this.ParentForm;
                addGroup.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (grvUser.SelectedRows.Count != 0)
                {
                    frmAddGroup editGroup = new frmAddGroup(Mode.Edit, Convert.ToInt32(grvUser.SelectedRows[0].Cells["GroupID"].Value));
                    editGroup.MdiParent = this.ParentForm;
                    editGroup.Show();
                }
                else
                {
                    MessageBox.Show("Bạn cần chọn 1 nhóm cần cập nhật.");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
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
                            var groupID = Convert.ToInt32(grvUser.SelectedRows[i].Cells["GroupID"].Value);
                            factory.DeleteGroup(groupID);
                        }
                        MessageBox.Show("Xóa xong");
                        BindData();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn cần chọn nhóm.");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGroupList_Load(object sender, EventArgs e)
        {
            this.Location = new Point((this.ParentForm.Width - this.Width) / 2, (this.ParentForm.Height - this.Height) / 2);
            BindData();
        }

        private void BindData()
        {

            grvUser.DataSource = factory.GetAllGroups();

        }
    }
}
