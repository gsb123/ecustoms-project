using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ECustoms.BOL;
using ECustoms.DAL;
using ECustoms.Utilities.Enums;

namespace ECustoms
{
    public partial class frmAddGroup : Form
    {
        private RoleFactory factory = new RoleFactory();
        private Mode _mode;
        private int _groupID;
        public frmAddGroup()
        {
            InitializeComponent();
        }

        public frmAddGroup(Mode mode, int groupID)
        {
            InitializeComponent();
            InitialRole();
            _mode = mode;
            _groupID = groupID;

            if (mode == Mode.Edit)
                BindGroupData(groupID);



        }

        private void BindGroupData(int groupID)
        {
            tblGroup group = factory.GetGroupById(groupID);
            txtDescription.Text = group.Description;
            txtName.Text = group.Name;
        }

        private void InitialRole()
        {

            (clbRoles as ListBox).DataSource = factory.GetAllRoles();
            (clbRoles as ListBox).DisplayMember = "Name";
            (clbRoles as ListBox).ValueMember = "RoleID";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            //Create


        }


    }
}
