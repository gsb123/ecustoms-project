using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ECustoms.Utilities.Enums;

namespace ECustoms
{
    public partial class frmAddGroup : Form
    {
        private Mode _mode;
        public frmAddGroup()
        {
            InitializeComponent();
        }

        public frmAddGroup(Mode mode)
        {
            InitializeComponent();
            InitialRole();
            _mode = mode;

        }

        private void InitialRole()
        {
            
        }


    }
}
