﻿namespace ECustoms
{
    partial class frmVehicleSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicleSearch));
            this.grbConditionSearch = new System.Windows.Forms.GroupBox();
            this.cbIsCompleted = new System.Windows.Forms.CheckBox();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.cbIsNotImport = new System.Windows.Forms.CheckBox();
            this.cbIsImport = new System.Windows.Forms.CheckBox();
            this.cbIsExport = new System.Windows.Forms.CheckBox();
            this.dtpImportTo = new System.Windows.Forms.DateTimePicker();
            this.dtpImportFrom = new System.Windows.Forms.DateTimePicker();
            this.lblImportTo = new System.Windows.Forms.Label();
            this.lblImportFrom = new System.Windows.Forms.Label();
            this.dtpExportTo = new System.Windows.Forms.DateTimePicker();
            this.dtpExportFrom = new System.Windows.Forms.DateTimePicker();
            this.lblExportTo = new System.Windows.Forms.Label();
            this.lblExportFrom = new System.Windows.Forms.Label();
            this.grbResult = new System.Windows.Forms.GroupBox();
            this.lblVaonoidia = new System.Windows.Forms.Label();
            this.label8333 = new System.Windows.Forms.Label();
            this.lblCoHangXC = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCohangNC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKhongNC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKhongXC = new System.Windows.Forms.Label();
            this.lblNotExported = new System.Windows.Forms.Label();
            this.grdVehicle = new System.Windows.Forms.DataGridView();
            this.btnXacNhanXuatCanh = new System.Windows.Forms.Button();
            this.btnXacNhanNhapCanhCoHang = new System.Windows.Forms.Button();
            this.btnXacNhanXuatCanhKhongCoHang = new System.Windows.Forms.Button();
            this.btnUpdateVehicle = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLocalConfirm = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportProductAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportedLocalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfirmExportByName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfirmImportByName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfirmLocalImportByName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbConditionSearch.SuspendLayout();
            this.grbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // grbConditionSearch
            // 
            this.grbConditionSearch.Controls.Add(this.cbIsCompleted);
            this.grbConditionSearch.Controls.Add(this.txtPlateNumber);
            this.grbConditionSearch.Controls.Add(this.lblPlateNumber);
            this.grbConditionSearch.Controls.Add(this.cbIsNotImport);
            this.grbConditionSearch.Controls.Add(this.cbIsImport);
            this.grbConditionSearch.Controls.Add(this.cbIsExport);
            this.grbConditionSearch.Controls.Add(this.dtpImportTo);
            this.grbConditionSearch.Controls.Add(this.dtpImportFrom);
            this.grbConditionSearch.Controls.Add(this.lblImportTo);
            this.grbConditionSearch.Controls.Add(this.lblImportFrom);
            this.grbConditionSearch.Controls.Add(this.dtpExportTo);
            this.grbConditionSearch.Controls.Add(this.dtpExportFrom);
            this.grbConditionSearch.Controls.Add(this.lblExportTo);
            this.grbConditionSearch.Controls.Add(this.lblExportFrom);
            this.grbConditionSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbConditionSearch.Location = new System.Drawing.Point(12, 12);
            this.grbConditionSearch.Name = "grbConditionSearch";
            this.grbConditionSearch.Size = new System.Drawing.Size(778, 102);
            this.grbConditionSearch.TabIndex = 0;
            this.grbConditionSearch.TabStop = false;
            this.grbConditionSearch.Text = "Điều kiện tìm kiếm";
            // 
            // cbIsCompleted
            // 
            this.cbIsCompleted.AutoSize = true;
            this.cbIsCompleted.Location = new System.Drawing.Point(11, 71);
            this.cbIsCompleted.Name = "cbIsCompleted";
            this.cbIsCompleted.Size = new System.Drawing.Size(94, 24);
            this.cbIsCompleted.TabIndex = 12;
            this.cbIsCompleted.Text = "Hoàn tất ";
            this.cbIsCompleted.UseVisualStyleBackColor = true;
            this.cbIsCompleted.CheckedChanged += new System.EventHandler(this.cbIsCompleted_CheckedChanged);
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtPlateNumber.Location = new System.Drawing.Point(10, 42);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(105, 26);
            this.txtPlateNumber.TabIndex = 1;
            this.txtPlateNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlateNumber_KeyPress);
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Location = new System.Drawing.Point(7, 19);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(113, 20);
            this.lblPlateNumber.TabIndex = 11;
            this.lblPlateNumber.Text = "Biển kiểm soát";
            // 
            // cbIsNotImport
            // 
            this.cbIsNotImport.AutoSize = true;
            this.cbIsNotImport.Location = new System.Drawing.Point(476, 12);
            this.cbIsNotImport.Name = "cbIsNotImport";
            this.cbIsNotImport.Size = new System.Drawing.Size(145, 24);
            this.cbIsNotImport.TabIndex = 6;
            this.cbIsNotImport.Text = "Chưa nhập cảnh";
            this.cbIsNotImport.UseVisualStyleBackColor = true;
            this.cbIsNotImport.CheckedChanged += new System.EventHandler(this.cbIsNotImport_CheckedChanged);
            // 
            // cbIsImport
            // 
            this.cbIsImport.AutoSize = true;
            this.cbIsImport.Location = new System.Drawing.Point(627, 12);
            this.cbIsImport.Name = "cbIsImport";
            this.cbIsImport.Size = new System.Drawing.Size(128, 24);
            this.cbIsImport.TabIndex = 7;
            this.cbIsImport.Text = "Đã nhập cảnh";
            this.cbIsImport.UseVisualStyleBackColor = true;
            this.cbIsImport.CheckedChanged += new System.EventHandler(this.cbIsImport_CheckedChanged);
            // 
            // cbIsExport
            // 
            this.cbIsExport.AutoSize = true;
            this.cbIsExport.Location = new System.Drawing.Point(187, 15);
            this.cbIsExport.Name = "cbIsExport";
            this.cbIsExport.Size = new System.Drawing.Size(122, 24);
            this.cbIsExport.TabIndex = 3;
            this.cbIsExport.Text = "Đã xuất cảnh";
            this.cbIsExport.UseVisualStyleBackColor = true;
            this.cbIsExport.CheckedChanged += new System.EventHandler(this.cbIsExport_CheckedChanged);
            // 
            // dtpImportTo
            // 
            this.dtpImportTo.CustomFormat = "dd/MM/yyyy";
            this.dtpImportTo.Enabled = false;
            this.dtpImportTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpImportTo.Location = new System.Drawing.Point(596, 70);
            this.dtpImportTo.Name = "dtpImportTo";
            this.dtpImportTo.Size = new System.Drawing.Size(122, 26);
            this.dtpImportTo.TabIndex = 9;
            // 
            // dtpImportFrom
            // 
            this.dtpImportFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpImportFrom.Enabled = false;
            this.dtpImportFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpImportFrom.Location = new System.Drawing.Point(596, 36);
            this.dtpImportFrom.Name = "dtpImportFrom";
            this.dtpImportFrom.Size = new System.Drawing.Size(122, 26);
            this.dtpImportFrom.TabIndex = 8;
            // 
            // lblImportTo
            // 
            this.lblImportTo.AutoSize = true;
            this.lblImportTo.Enabled = false;
            this.lblImportTo.Location = new System.Drawing.Point(471, 71);
            this.lblImportTo.Name = "lblImportTo";
            this.lblImportTo.Size = new System.Drawing.Size(121, 20);
            this.lblImportTo.TabIndex = 5;
            this.lblImportTo.Text = "Nhập cảnh đến:";
            // 
            // lblImportFrom
            // 
            this.lblImportFrom.AutoSize = true;
            this.lblImportFrom.Enabled = false;
            this.lblImportFrom.Location = new System.Drawing.Point(471, 39);
            this.lblImportFrom.Name = "lblImportFrom";
            this.lblImportFrom.Size = new System.Drawing.Size(108, 20);
            this.lblImportFrom.TabIndex = 4;
            this.lblImportFrom.Text = "Nhập cảnh từ:";
            // 
            // dtpExportTo
            // 
            this.dtpExportTo.CustomFormat = "dd/MM/yyyy";
            this.dtpExportTo.Enabled = false;
            this.dtpExportTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExportTo.Location = new System.Drawing.Point(307, 68);
            this.dtpExportTo.Name = "dtpExportTo";
            this.dtpExportTo.Size = new System.Drawing.Size(118, 26);
            this.dtpExportTo.TabIndex = 5;
            // 
            // dtpExportFrom
            // 
            this.dtpExportFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpExportFrom.Enabled = false;
            this.dtpExportFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExportFrom.Location = new System.Drawing.Point(307, 40);
            this.dtpExportFrom.Name = "dtpExportFrom";
            this.dtpExportFrom.Size = new System.Drawing.Size(118, 26);
            this.dtpExportFrom.TabIndex = 4;
            // 
            // lblExportTo
            // 
            this.lblExportTo.AutoSize = true;
            this.lblExportTo.Enabled = false;
            this.lblExportTo.Location = new System.Drawing.Point(185, 69);
            this.lblExportTo.Name = "lblExportTo";
            this.lblExportTo.Size = new System.Drawing.Size(117, 20);
            this.lblExportTo.TabIndex = 1;
            this.lblExportTo.Text = "Xuất cảnh đến:";
            // 
            // lblExportFrom
            // 
            this.lblExportFrom.AutoSize = true;
            this.lblExportFrom.Enabled = false;
            this.lblExportFrom.Location = new System.Drawing.Point(184, 42);
            this.lblExportFrom.Name = "lblExportFrom";
            this.lblExportFrom.Size = new System.Drawing.Size(104, 20);
            this.lblExportFrom.TabIndex = 0;
            this.lblExportFrom.Text = "Xuất cảnh từ:";
            // 
            // grbResult
            // 
            this.grbResult.Controls.Add(this.lblVaonoidia);
            this.grbResult.Controls.Add(this.label8333);
            this.grbResult.Controls.Add(this.lblCoHangXC);
            this.grbResult.Controls.Add(this.label6);
            this.grbResult.Controls.Add(this.lblCohangNC);
            this.grbResult.Controls.Add(this.label4);
            this.grbResult.Controls.Add(this.lblKhongNC);
            this.grbResult.Controls.Add(this.label2);
            this.grbResult.Controls.Add(this.lblKhongXC);
            this.grbResult.Controls.Add(this.lblNotExported);
            this.grbResult.Controls.Add(this.grdVehicle);
            this.grbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbResult.Location = new System.Drawing.Point(12, 131);
            this.grbResult.Name = "grbResult";
            this.grbResult.Size = new System.Drawing.Size(781, 453);
            this.grbResult.TabIndex = 1;
            this.grbResult.TabStop = false;
            this.grbResult.Text = "Kết quả tìm kiếm";
            // 
            // lblVaonoidia
            // 
            this.lblVaonoidia.AutoSize = true;
            this.lblVaonoidia.ForeColor = System.Drawing.Color.Red;
            this.lblVaonoidia.Location = new System.Drawing.Point(223, 81);
            this.lblVaonoidia.Name = "lblVaonoidia";
            this.lblVaonoidia.Size = new System.Drawing.Size(18, 20);
            this.lblVaonoidia.TabIndex = 10;
            this.lblVaonoidia.Text = "0";
            // 
            // label8333
            // 
            this.label8333.AutoSize = true;
            this.label8333.Location = new System.Drawing.Point(15, 81);
            this.label8333.Name = "label8333";
            this.label8333.Size = new System.Drawing.Size(191, 20);
            this.label8333.TabIndex = 9;
            this.label8333.Text = "Tổng số xe đã vào nội địa:";
            // 
            // lblCoHangXC
            // 
            this.lblCoHangXC.AutoSize = true;
            this.lblCoHangXC.ForeColor = System.Drawing.Color.Red;
            this.lblCoHangXC.Location = new System.Drawing.Point(503, 58);
            this.lblCoHangXC.Name = "lblCoHangXC";
            this.lblCoHangXC.Size = new System.Drawing.Size(18, 20);
            this.lblCoHangXC.TabIndex = 8;
            this.lblCoHangXC.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Số xe có hàng đã XC: ";
            // 
            // lblCohangNC
            // 
            this.lblCohangNC.AutoSize = true;
            this.lblCohangNC.ForeColor = System.Drawing.Color.Red;
            this.lblCohangNC.Location = new System.Drawing.Point(503, 30);
            this.lblCohangNC.Name = "lblCohangNC";
            this.lblCohangNC.Size = new System.Drawing.Size(18, 20);
            this.lblCohangNC.TabIndex = 6;
            this.lblCohangNC.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số xe có hàng đã NC :";
            // 
            // lblKhongNC
            // 
            this.lblKhongNC.AutoSize = true;
            this.lblKhongNC.ForeColor = System.Drawing.Color.Red;
            this.lblKhongNC.Location = new System.Drawing.Point(223, 58);
            this.lblKhongNC.Name = "lblKhongNC";
            this.lblKhongNC.Size = new System.Drawing.Size(18, 20);
            this.lblKhongNC.TabIndex = 4;
            this.lblKhongNC.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số xe không đã NC:";
            // 
            // lblKhongXC
            // 
            this.lblKhongXC.AutoSize = true;
            this.lblKhongXC.ForeColor = System.Drawing.Color.Red;
            this.lblKhongXC.Location = new System.Drawing.Point(223, 26);
            this.lblKhongXC.Name = "lblKhongXC";
            this.lblKhongXC.Size = new System.Drawing.Size(18, 20);
            this.lblKhongXC.TabIndex = 2;
            this.lblKhongXC.Text = "0";
            // 
            // lblNotExported
            // 
            this.lblNotExported.AutoSize = true;
            this.lblNotExported.Location = new System.Drawing.Point(15, 26);
            this.lblNotExported.Name = "lblNotExported";
            this.lblNotExported.Size = new System.Drawing.Size(149, 20);
            this.lblNotExported.TabIndex = 1;
            this.lblNotExported.Text = "Số xe không đã XC:";
            // 
            // grdVehicle
            // 
            this.grdVehicle.AllowUserToAddRows = false;
            this.grdVehicle.AllowUserToDeleteRows = false;
            this.grdVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVehicle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.ExportType,
            this.RegisterDate,
            this.PlateNumber,
            this.DriverName,
            this.Status,
            this.Note,
            this.CompanyName,
            this.ProductName,
            this.ProductAmount,
            this.Unit,
            this.ExportDate,
            this.ImportNumber,
            this.ImportType,
            this.ImportCompanyName,
            this.ImportProductName,
            this.ImportProductAmount,
            this.Importdate,
            this.ImportStatus,
            this.ImportedLocalTime,
            this.VehicleID,
            this.ConfirmExportByName,
            this.ConfirmImportByName,
            this.ConfirmLocalImportByName});
            this.grdVehicle.Location = new System.Drawing.Point(10, 117);
            this.grdVehicle.Name = "grdVehicle";
            this.grdVehicle.ReadOnly = true;
            this.grdVehicle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVehicle.Size = new System.Drawing.Size(768, 325);
            this.grdVehicle.TabIndex = 0;
            this.grdVehicle.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdVehicle_CellMouseDoubleClick);
            // 
            // btnXacNhanXuatCanh
            // 
            this.btnXacNhanXuatCanh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXacNhanXuatCanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanXuatCanh.Location = new System.Drawing.Point(796, 143);
            this.btnXacNhanXuatCanh.Name = "btnXacNhanXuatCanh";
            this.btnXacNhanXuatCanh.Size = new System.Drawing.Size(176, 52);
            this.btnXacNhanXuatCanh.TabIndex = 14;
            this.btnXacNhanXuatCanh.Text = "Xác nhận xuất cảnh";
            this.btnXacNhanXuatCanh.UseVisualStyleBackColor = true;
            this.btnXacNhanXuatCanh.Click += new System.EventHandler(this.btnXacNhanXuatCanh_Click);
            // 
            // btnXacNhanNhapCanhCoHang
            // 
            this.btnXacNhanNhapCanhCoHang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXacNhanNhapCanhCoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanNhapCanhCoHang.Location = new System.Drawing.Point(796, 201);
            this.btnXacNhanNhapCanhCoHang.Name = "btnXacNhanNhapCanhCoHang";
            this.btnXacNhanNhapCanhCoHang.Size = new System.Drawing.Size(176, 52);
            this.btnXacNhanNhapCanhCoHang.TabIndex = 15;
            this.btnXacNhanNhapCanhCoHang.Text = "Xác nhận nhập cảnh có hàng";
            this.btnXacNhanNhapCanhCoHang.UseVisualStyleBackColor = true;
            this.btnXacNhanNhapCanhCoHang.Click += new System.EventHandler(this.btnXacNhanNhapCanhCoHang_Click);
            // 
            // btnXacNhanXuatCanhKhongCoHang
            // 
            this.btnXacNhanXuatCanhKhongCoHang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXacNhanXuatCanhKhongCoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanXuatCanhKhongCoHang.Location = new System.Drawing.Point(796, 259);
            this.btnXacNhanXuatCanhKhongCoHang.Name = "btnXacNhanXuatCanhKhongCoHang";
            this.btnXacNhanXuatCanhKhongCoHang.Size = new System.Drawing.Size(176, 52);
            this.btnXacNhanXuatCanhKhongCoHang.TabIndex = 16;
            this.btnXacNhanXuatCanhKhongCoHang.Text = "Xác nhận nhập cảnh không có hàng";
            this.btnXacNhanXuatCanhKhongCoHang.UseVisualStyleBackColor = true;
            this.btnXacNhanXuatCanhKhongCoHang.Click += new System.EventHandler(this.btnXacNhanXuatCanhKhongCoHang_Click);
            // 
            // btnUpdateVehicle
            // 
            this.btnUpdateVehicle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdateVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateVehicle.Image = global::ECustoms.Properties.Resources._001_45;
            this.btnUpdateVehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateVehicle.Location = new System.Drawing.Point(271, 590);
            this.btnUpdateVehicle.Name = "btnUpdateVehicle";
            this.btnUpdateVehicle.Size = new System.Drawing.Size(196, 33);
            this.btnUpdateVehicle.TabIndex = 12;
            this.btnUpdateVehicle.Text = "Cập nhật phương tiện";
            this.btnUpdateVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateVehicle.UseVisualStyleBackColor = true;
            this.btnUpdateVehicle.Click += new System.EventHandler(this.btnUpdateVehicle_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Image = global::ECustoms.Properties.Resources.excel81;
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.Location = new System.Drawing.Point(122, 590);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(143, 33);
            this.btnExportExcel.TabIndex = 10;
            this.btnExportExcel.Text = "Export tờ khai";
            this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::ECustoms.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(473, 589);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 33);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Đóng";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::ECustoms.Properties.Resources.search41;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(5, 590);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 33);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLocalConfirm
            // 
            this.btnLocalConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLocalConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalConfirm.Location = new System.Drawing.Point(799, 317);
            this.btnLocalConfirm.Name = "btnLocalConfirm";
            this.btnLocalConfirm.Size = new System.Drawing.Size(176, 52);
            this.btnLocalConfirm.TabIndex = 17;
            this.btnLocalConfirm.Text = "Xác nhận hàng vào nội địa";
            this.btnLocalConfirm.UseVisualStyleBackColor = true;
            this.btnLocalConfirm.Click += new System.EventHandler(this.btnLocalConfirm_Click);
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Số tờ khai xuất";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 170;
            // 
            // ExportType
            // 
            this.ExportType.DataPropertyName = "ExportType";
            this.ExportType.HeaderText = "Loại hình xuất";
            this.ExportType.Name = "ExportType";
            this.ExportType.ReadOnly = true;
            this.ExportType.Width = 150;
            // 
            // RegisterDate
            // 
            this.RegisterDate.DataPropertyName = "RegisterDate";
            this.RegisterDate.HeaderText = "Ngày đăng ký";
            this.RegisterDate.Name = "RegisterDate";
            this.RegisterDate.ReadOnly = true;
            this.RegisterDate.Width = 170;
            // 
            // PlateNumber
            // 
            this.PlateNumber.DataPropertyName = "PlateNumber";
            this.PlateNumber.HeaderText = "Biển kiểm soát";
            this.PlateNumber.Name = "PlateNumber";
            this.PlateNumber.ReadOnly = true;
            this.PlateNumber.Width = 170;
            // 
            // DriverName
            // 
            this.DriverName.DataPropertyName = "DriverName";
            this.DriverName.HeaderText = "Tên lái xe";
            this.DriverName.Name = "DriverName";
            this.DriverName.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Diễn giải";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 150;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Ghi chú";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 150;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "Tên doanh nghiệp xuất";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            this.CompanyName.Width = 220;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Tên hàng xuất";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 150;
            // 
            // ProductAmount
            // 
            this.ProductAmount.DataPropertyName = "ProductAmount";
            this.ProductAmount.HeaderText = "Lượng hàng xuất";
            this.ProductAmount.Name = "ProductAmount";
            this.ProductAmount.ReadOnly = true;
            this.ProductAmount.Width = 170;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "Đơn vị tính xuât";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 170;
            // 
            // ExportDate
            // 
            this.ExportDate.DataPropertyName = "ExportDate";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.ExportDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.ExportDate.HeaderText = "Ngày xuất cảnh";
            this.ExportDate.Name = "ExportDate";
            this.ExportDate.ReadOnly = true;
            this.ExportDate.Width = 170;
            // 
            // ImportNumber
            // 
            this.ImportNumber.DataPropertyName = "ImportNumber";
            this.ImportNumber.HeaderText = "Số tờ khai nhập";
            this.ImportNumber.Name = "ImportNumber";
            this.ImportNumber.ReadOnly = true;
            this.ImportNumber.Width = 170;
            // 
            // ImportType
            // 
            this.ImportType.DataPropertyName = "ImportType";
            this.ImportType.HeaderText = "Loại hình nhập";
            this.ImportType.Name = "ImportType";
            this.ImportType.ReadOnly = true;
            this.ImportType.Width = 150;
            // 
            // ImportCompanyName
            // 
            this.ImportCompanyName.DataPropertyName = "ImportCompanyName";
            this.ImportCompanyName.HeaderText = "Tên doanh nghiệp nhập";
            this.ImportCompanyName.Name = "ImportCompanyName";
            this.ImportCompanyName.ReadOnly = true;
            this.ImportCompanyName.Width = 200;
            // 
            // ImportProductName
            // 
            this.ImportProductName.DataPropertyName = "ImportProductName";
            this.ImportProductName.HeaderText = "Tên hàng nhập";
            this.ImportProductName.Name = "ImportProductName";
            this.ImportProductName.ReadOnly = true;
            this.ImportProductName.Width = 200;
            // 
            // ImportProductAmount
            // 
            this.ImportProductAmount.DataPropertyName = "ImportProductAmount";
            this.ImportProductAmount.HeaderText = "Lượng hàng nhập";
            this.ImportProductAmount.Name = "ImportProductAmount";
            this.ImportProductAmount.ReadOnly = true;
            this.ImportProductAmount.Width = 200;
            // 
            // Importdate
            // 
            this.Importdate.DataPropertyName = "ImportDate";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.Importdate.DefaultCellStyle = dataGridViewCellStyle2;
            this.Importdate.HeaderText = "Ngày nhập cảnh";
            this.Importdate.Name = "Importdate";
            this.Importdate.ReadOnly = true;
            this.Importdate.Width = 170;
            // 
            // ImportStatus
            // 
            this.ImportStatus.DataPropertyName = "ImportStatus";
            this.ImportStatus.HeaderText = "Trạng thái nhập cảnh";
            this.ImportStatus.Name = "ImportStatus";
            this.ImportStatus.ReadOnly = true;
            this.ImportStatus.Width = 200;
            // 
            // ImportedLocalTime
            // 
            this.ImportedLocalTime.DataPropertyName = "ImportedLocalTime";
            this.ImportedLocalTime.HeaderText = "Ngày vào nội địa";
            this.ImportedLocalTime.Name = "ImportedLocalTime";
            this.ImportedLocalTime.ReadOnly = true;
            this.ImportedLocalTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ImportedLocalTime.Width = 200;
            // 
            // VehicleID
            // 
            this.VehicleID.DataPropertyName = "VehicleID";
            this.VehicleID.HeaderText = "VehicleID";
            this.VehicleID.Name = "VehicleID";
            this.VehicleID.ReadOnly = true;
            this.VehicleID.Visible = false;
            // 
            // ConfirmExportByName
            // 
            this.ConfirmExportByName.DataPropertyName = "ConfirmExportByName";
            this.ConfirmExportByName.HeaderText = "Xác nhận xuất";
            this.ConfirmExportByName.Name = "ConfirmExportByName";
            this.ConfirmExportByName.ReadOnly = true;
            this.ConfirmExportByName.Width = 150;
            // 
            // ConfirmImportByName
            // 
            this.ConfirmImportByName.DataPropertyName = "ConfirmImportByName";
            this.ConfirmImportByName.HeaderText = "Xác nhận nhập";
            this.ConfirmImportByName.Name = "ConfirmImportByName";
            this.ConfirmImportByName.ReadOnly = true;
            this.ConfirmImportByName.Width = 200;
            // 
            // ConfirmLocalImportByName
            // 
            this.ConfirmLocalImportByName.DataPropertyName = "ConfirmLocalImportByName";
            this.ConfirmLocalImportByName.HeaderText = "Xác nhận hàng nội địa";
            this.ConfirmLocalImportByName.Name = "ConfirmLocalImportByName";
            this.ConfirmLocalImportByName.ReadOnly = true;
            this.ConfirmLocalImportByName.Width = 200;
            // 
            // frmVehicleSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 633);
            this.Controls.Add(this.btnLocalConfirm);
            this.Controls.Add(this.btnXacNhanXuatCanhKhongCoHang);
            this.Controls.Add(this.btnXacNhanNhapCanhCoHang);
            this.Controls.Add(this.btnXacNhanXuatCanh);
            this.Controls.Add(this.btnUpdateVehicle);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grbResult);
            this.Controls.Add(this.grbConditionSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVehicleSearch";
            this.Text = "Tìm kếm thông tin xe";
            this.Load += new System.EventHandler(this.frmVehicleSearch_Load);
            this.grbConditionSearch.ResumeLayout(false);
            this.grbConditionSearch.PerformLayout();
            this.grbResult.ResumeLayout(false);
            this.grbResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehicle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbConditionSearch;
        private System.Windows.Forms.GroupBox grbResult;
        private System.Windows.Forms.DataGridView grdVehicle;
        private System.Windows.Forms.DateTimePicker dtpImportTo;
        private System.Windows.Forms.DateTimePicker dtpImportFrom;
        private System.Windows.Forms.Label lblImportTo;
        private System.Windows.Forms.Label lblImportFrom;
        private System.Windows.Forms.DateTimePicker dtpExportTo;
        private System.Windows.Forms.DateTimePicker dtpExportFrom;
        private System.Windows.Forms.Label lblExportTo;
        private System.Windows.Forms.Label lblExportFrom;
        private System.Windows.Forms.CheckBox cbIsImport;
        private System.Windows.Forms.CheckBox cbIsExport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox cbIsNotImport;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnUpdateVehicle;
        private System.Windows.Forms.Button btnXacNhanXuatCanh;
        private System.Windows.Forms.Button btnXacNhanNhapCanhCoHang;
        private System.Windows.Forms.Button btnXacNhanXuatCanhKhongCoHang;
        private System.Windows.Forms.Button btnLocalConfirm;
        private System.Windows.Forms.Label lblVaonoidia;
        private System.Windows.Forms.Label label8333;
        private System.Windows.Forms.Label lblCoHangXC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCohangNC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKhongNC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKhongXC;
        private System.Windows.Forms.Label lblNotExported;
        private System.Windows.Forms.CheckBox cbIsCompleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExportType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExportDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportProductAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportedLocalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfirmExportByName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfirmImportByName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfirmLocalImportByName;
    }
}