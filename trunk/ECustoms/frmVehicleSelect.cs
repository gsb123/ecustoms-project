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
using ECustoms.DAL;

namespace ECustoms
{
    public partial class frmVehicleSelect : Form
    {
        private static log4net.ILog logger = LogManager.GetLogger("Ecustoms.frmVehicleSelect");
        public event OnSelectedVehicleHandler OnSelectedVehichle;
        public delegate void OnSelectedVehicleHandler(object sender, EventArgs e);
        private List<VehicleInfo> _vehicleList;
        private List<tblVehicle> _vehicles;
        private int _declarationID;
        public frmVehicleSelect(int declarationID)
        {
            InitializeComponent();
            _declarationID = declarationID;
        }

        private void LoadExportedVehichles(int mode, int declarationID, string search)
        {
            try
            {
                var verhichBL = new VehicleFactory();

                _vehicleList = verhichBL.GetExportingVehicles(mode, declarationID, search);
                grdVehicle.AutoGenerateColumns = false;
                grdVehicle.DataSource = _vehicleList;
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
                if (GlobalInfo.IsDebug) MessageBox.Show(ex.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddVehichle_Click(object sender, EventArgs e)
        {
            AddVehicle();
        }

        private void AddVehicle()
        {
            try
            {
                var verhicleBL = new VehicleFactory();
                if (grdVehicle.SelectedRows.Count == 1)
                {
                    var vehicleInfo = verhicleBL.SelectByID(int.Parse(grdVehicle.SelectedRows[0].Cells["VehicleID"].Value.ToString()));
                    try
                    {
                        OnSelectedVehichle(this, new SelectedVehichleEventArgs() { Vehicle = vehicleInfo });
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Phương tiện này đã tồn tại trong tờ khai!");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn cần chọn 1 phương.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
                if (GlobalInfo.IsDebug) MessageBox.Show(ex.ToString());
            }
        }

        private void grdVehicle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddVehicle();
        }

        private void frmVehicleSelect_Load(object sender, EventArgs e)
        {
            this.Text = "Thêm từ phương tiện đã xuất khẩu" + ConstantInfo.MESSAGE_TITLE;
            BindData();
        }

        private void BindData() {
            _vehicles = VehicleFactory.GetExported();
            grdVehicle.AutoGenerateColumns = false;
            grdVehicle.DataSource = _vehicles;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlate.Text))
            {
                BindData();
            }
            else
            {
                _vehicles = _vehicles.Where(g => g.PlateNumber.ToUpper().Contains(txtPlate.Text.ToUpper())).ToList();
                grdVehicle.DataSource = _vehicles;
            }
        }
    }

    public class SelectedVehichleEventArgs : EventArgs
    {
        public VehicleInfo Vehicle
        {
            get;
            set;
        }
    }
}
