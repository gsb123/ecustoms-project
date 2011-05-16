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
        public frmVehicleSelect()
        {
            InitializeComponent();
            // Export not Import
            int mode = 1;
            LoadExportedVehichles(mode);
        }

        private void LoadExportedVehichles(int mode)
        {
            try
            {
                var verhichBL = new VehicleBOL();

                _vehicleList = verhichBL.GetExportingVehicles(mode);
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



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            // Import not export
            LoadExportedVehichles(1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            // Import and Export with status = 'co hang'
            LoadExportedVehichles(2);
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