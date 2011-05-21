using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ECustoms.BOL;
using ECustoms.Utilities;
using Microsoft.Office.Interop.Excel;
using Point = System.Drawing.Point;

namespace ECustoms
{
    public partial class frmDecleration : Form
    {
        private DeclarationBOL _declarationBOL;
        private UserInfo _userInfo;
        private Form _parrent;
        private List<DeclarationInfo> _listDeclarationinfo;
        public frmDecleration()
        {
            InitializeComponent();
        }

        public frmDecleration(UserInfo userInfo, Form parrent)
        {
            InitializeComponent();
            _userInfo = userInfo;
            _parrent = parrent;
        }

        private void frmDecleration_Load(object sender, EventArgs e)
        {
            this.Text = "Danh sách tờ khai" + ConstantInfo.MESSAGE_TITLE;
            // Show form to the center
            this.Location = new Point((this.ParentForm.Width - this.Width) / 2, (this.ParentForm.Height - this.Height) / 2);
            _declarationBOL = new DeclarationBOL();
            BindData();
            txtDeclaraceNumber.Focus();
            InitialPermission();
        }

        /// <summary>
        /// Personal check
        /// </summary>
        private void InitialPermission()
        {
            //throw new NotImplementedException();

            if (_userInfo.Type == UserType.Admin)
            {

            }
            else if (_userInfo.Type == UserType.Confirm)
            {
                btnDelete.Enabled = false;
                
               
            }
            else if (_userInfo.Type == UserType.Input)
            {


            }

        }

        private void BindData()
        {
            grvDecleration.AutoGenerateColumns = false;
            _listDeclarationinfo = _declarationBOL.GetDecleration();
            grvDecleration.DataSource = _listDeclarationinfo;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO: Need to delete multiple instanse one time
                if (grvDecleration.SelectedRows.Count > 0)
                {
                    var dr = MessageBox.Show("Bạn có chắc là muốn xóa?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        for (int i = 0; i < grvDecleration.SelectedRows.Count; i++)
                        {
                            var declerationID = Convert.ToInt32(grvDecleration.SelectedRows[i].Cells[0].Value);
                            _declarationBOL.DeleteByID(declerationID);
                        }
                        MessageBox.Show("Xóa xong");
                        BindData();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn cần chọn tờ khai.");
                }
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.ToString());
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (grvDecleration.SelectedRows.Count != 0)
                {
                    frmExport frmExport = new frmExport(_userInfo, 1, Convert.ToInt32(grvDecleration.SelectedRows[0].Cells[0].Value));
                    frmExport.MdiParent = _parrent;
                    frmExport.Show();
                }
                else
                {
                    MessageBox.Show("Bạn cần chọn 1 tờ khai cần cập nhật.");
                }
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.ToString());
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmExport = new frmExport(_userInfo, 0);
            frmExport.MdiParent = _parrent;
            frmExport.Show();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                var excel = new ApplicationClass();
                excel.Application.Workbooks.Add(true);

                var columnIndex = 0;
                for (var i = 0; i < grvDecleration.Columns.Count; i++)
                {
                    if (!grvDecleration.Columns[i].Visible) continue;
                    columnIndex++;
                    excel.Cells[1, columnIndex] = grvDecleration.Columns[i].HeaderText;
                    ((Range)excel.Cells[1, columnIndex]).Font.Bold = true;
                }
                int rowIndex = 0;
                foreach (var declarationInfo in _listDeclarationinfo)
                {
                    rowIndex++;
                    excel.Cells[rowIndex + 1, 1] = declarationInfo.Number;
                    excel.Cells[rowIndex + 1, 2] = declarationInfo.ImportNumber;                    
                    excel.Cells[rowIndex + 1, 3] = declarationInfo.ProductName;
                    excel.Cells[rowIndex + 1, 4] = declarationInfo.ImportProductName;
                    excel.Cells[rowIndex + 1, 5] = declarationInfo.CompanyName;
                    excel.Cells[rowIndex + 1, 6] = declarationInfo.ImportCompanyName;
                    excel.Cells[rowIndex + 1, 7] = declarationInfo.ProductAmount;
                    excel.Cells[rowIndex + 1, 8] = declarationInfo.ImportProductAmount;
                    excel.Cells[rowIndex + 1, 9] = declarationInfo.Unit;
                    excel.Cells[rowIndex + 1, 10] = declarationInfo.ImportUnit;
                    excel.Cells[rowIndex + 1, 11] = declarationInfo.ModifiedDate;
                    excel.Cells[rowIndex + 1, 12] = declarationInfo.CreatedBy;
                    excel.Cells[rowIndex + 1, 13] = declarationInfo.CreatedDate;

                }
                excel.Visible = true;
                var worksheet = (Worksheet)excel.ActiveSheet;
                worksheet.Activate();

            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.ToString());
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void grvDecleration_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    frmExport frmExport = new frmExport(_userInfo, 1, Convert.ToInt32(grvDecleration.Rows[e.RowIndex].Cells[0].Value));
                    frmExport.MdiParent = _parrent;
                    frmExport.Show();
                }
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var declarationNumber = txtDeclaraceNumber.Text.Trim();
            var companyName = txtCompanyName.Text.Trim();
            List<DeclarationInfo> result = null;
            if (!string.IsNullOrEmpty(declarationNumber))
            {
                result = _listDeclarationinfo.Where(d => d.Number.ToString().Equals(declarationNumber) || d.ImportNumber.ToString().Equals(declarationNumber))
                    .ToList();
            }

            if (!string.IsNullOrEmpty(companyName) && _listDeclarationinfo != null)
            {
                result = _listDeclarationinfo.Where(d => d.CompanyName.Contains(companyName) || d.ImportCompanyName.Contains(companyName))
                       .ToList();
            }

            grvDecleration.DataSource = result;

            if (string.IsNullOrEmpty(declarationNumber) && string.IsNullOrEmpty(companyName))
            {
                BindData();                
            }
        }
    }
}
