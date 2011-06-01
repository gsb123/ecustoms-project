﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ECustoms.BOL;
using ECustoms.Utilities;

namespace ECustoms
{
    public partial class frmVehicleSelect : Form
    {

        public event OnSelectedVehicleHandler OnSelectedVehichle;
        public delegate void OnSelectedVehicleHandler(object sender, EventArgs e);
        private List<VehicleInfo> _vehicleList;
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
                var verhichBL = new VehicleBOL();

                _vehicleList = verhichBL.GetExportingVehicles(mode, declarationID, search);
                grdVehicle.AutoGenerateColumns = false;
                grdVehicle.DataSource = _vehicleList;
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

        private void btnAddVehichle_Click(object sender, EventArgs e)
        {
            AddVehicle();
        }

        private void AddVehicle()
        {
            try
            {
                var verhicleBL = new VehicleBOL();
                if (grdVehicle.SelectedRows.Count == 1)
                {
                    var vehicleInfo = verhicleBL.SelectByID(int.Parse(grdVehicle.SelectedRows[0].Cells["VehicleID"].Value.ToString()));
                    OnSelectedVehichle(this, new SelectedVehichleEventArgs() { Vehicle = vehicleInfo });
                    _vehicleList = _vehicleList.Where(v => v.VehicleID != vehicleInfo.VehicleID).ToList(); ;
                    grdVehicle.AutoGenerateColumns = false;
                    grdVehicle.DataSource = _vehicleList;
                }
                else
                {
                    MessageBox.Show("Bạn cần chọn 1 phương.");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                //throw;
            }
        }

        private void grdVehicle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddVehicle();
        }

        private void frmVehicleSelect_Load(object sender, EventArgs e)
        {
            this.Text = "Thêm từ phương tiện đã xuất khẩu" + ConstantInfo.MESSAGE_TITLE;
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Search
            // Exported
            int mode = 3;

            if (txtPlate.Text.Trim().Equals(""))
                MessageBox.Show("Bạn phải nhập đầy đủ BKS");
            else

                LoadExportedVehichles(mode, _declarationID, txtPlate.Text.Trim());
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