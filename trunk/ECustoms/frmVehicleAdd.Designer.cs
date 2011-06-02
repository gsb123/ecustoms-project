﻿namespace ECustoms
{
    partial class frmVehicleAdd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicleAdd));
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.txtNumberOfContainer = new System.Windows.Forms.TextBox();
            this.lblNumberOfContainer = new System.Windows.Forms.Label();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.lblDriverName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdVehicle = new System.Windows.Forms.DataGridView();
            this.cbConfirmExport = new System.Windows.Forms.CheckBox();
            this.dateTimePickerExport = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerImport = new System.Windows.Forms.DateTimePicker();
            this.cbConfirmImport = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtExportHour = new System.Windows.Forms.MaskedTextBox();
            this.mtxtImportHour = new System.Windows.Forms.MaskedTextBox();
            this.lblIsExport = new System.Windows.Forms.Label();
            this.lblIsImport = new System.Windows.Forms.Label();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBoxValid = new System.Windows.Forms.PictureBox();
            this.pictureBoxInvalid = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsExport = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ImportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsImport = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfContainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInvalid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlateNumber.Location = new System.Drawing.Point(11, 16);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(113, 20);
            this.lblPlateNumber.TabIndex = 0;
            this.lblPlateNumber.Text = "Biển kiểm soát";
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPlateNumber.Location = new System.Drawing.Point(130, 16);
            this.txtPlateNumber.MaxLength = 12;
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(115, 20);
            this.txtPlateNumber.TabIndex = 1;
            // 
            // txtNumberOfContainer
            // 
            this.txtNumberOfContainer.Location = new System.Drawing.Point(695, 21);
            this.txtNumberOfContainer.MaxLength = 4;
            this.txtNumberOfContainer.Name = "txtNumberOfContainer";
            this.txtNumberOfContainer.Size = new System.Drawing.Size(33, 20);
            this.txtNumberOfContainer.TabIndex = 3;
            // 
            // lblNumberOfContainer
            // 
            this.lblNumberOfContainer.AutoSize = true;
            this.lblNumberOfContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfContainer.Location = new System.Drawing.Point(587, 20);
            this.lblNumberOfContainer.Name = "lblNumberOfContainer";
            this.lblNumberOfContainer.Size = new System.Drawing.Size(102, 20);
            this.lblNumberOfContainer.TabIndex = 2;
            this.lblNumberOfContainer.Text = "Số Container";
            // 
            // txtDriverName
            // 
            this.txtDriverName.Location = new System.Drawing.Point(396, 19);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(173, 20);
            this.txtDriverName.TabIndex = 2;
            // 
            // lblDriverName
            // 
            this.lblDriverName.AutoSize = true;
            this.lblDriverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverName.Location = new System.Drawing.Point(306, 19);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(75, 20);
            this.lblDriverName.TabIndex = 4;
            this.lblDriverName.Text = "Tên lái xe";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(11, 117);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(80, 20);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Trạng thái";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(130, 119);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(607, 50);
            this.txtStatus.TabIndex = 9;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(130, 175);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(607, 55);
            this.txtNote.TabIndex = 10;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(14, 175);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(64, 20);
            this.lblNote.TabIndex = 14;
            this.lblNote.Text = "Ghi chú";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.grdVehicle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 334);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các xe vừa nhập";
            // 
            // grdVehicle
            // 
            this.grdVehicle.AllowUserToAddRows = false;
            this.grdVehicle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVehicle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVehicle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Count,
            this.PlateNumber,
            this.DriverName,
            this.Status,
            this.Note,
            this.ExportHour,
            this.IsExport,
            this.ImportDate,
            this.ImportHour,
            this.IsImport,
            this.VehicleID,
            this.NumberOfContainer,
            this.ExportDate});
            this.grdVehicle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdVehicle.Location = new System.Drawing.Point(11, 25);
            this.grdVehicle.Name = "grdVehicle";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdVehicle.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grdVehicle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVehicle.Size = new System.Drawing.Size(816, 284);
            this.grdVehicle.TabIndex = 10;
            // 
            // cbConfirmExport
            // 
            this.cbConfirmExport.AutoSize = true;
            this.cbConfirmExport.Location = new System.Drawing.Point(130, 55);
            this.cbConfirmExport.Name = "cbConfirmExport";
            this.cbConfirmExport.Size = new System.Drawing.Size(15, 14);
            this.cbConfirmExport.TabIndex = 22;
            this.cbConfirmExport.UseVisualStyleBackColor = true;
            this.cbConfirmExport.CheckedChanged += new System.EventHandler(this.cbConfirmExport_CheckedChanged);
            // 
            // dateTimePickerExport
            // 
            this.dateTimePickerExport.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerExport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerExport.Location = new System.Drawing.Point(151, 52);
            this.dateTimePickerExport.Name = "dateTimePickerExport";
            this.dateTimePickerExport.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerExport.TabIndex = 23;
            this.dateTimePickerExport.Visible = false;
            // 
            // dateTimePickerImport
            // 
            this.dateTimePickerImport.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerImport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerImport.Location = new System.Drawing.Point(151, 90);
            this.dateTimePickerImport.Name = "dateTimePickerImport";
            this.dateTimePickerImport.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerImport.TabIndex = 25;
            this.dateTimePickerImport.Visible = false;
            // 
            // cbConfirmImport
            // 
            this.cbConfirmImport.AutoSize = true;
            this.cbConfirmImport.Location = new System.Drawing.Point(130, 93);
            this.cbConfirmImport.Name = "cbConfirmImport";
            this.cbConfirmImport.Size = new System.Drawing.Size(15, 14);
            this.cbConfirmImport.TabIndex = 24;
            this.cbConfirmImport.UseVisualStyleBackColor = true;
            this.cbConfirmImport.CheckedChanged += new System.EventHandler(this.cbConfirmImport_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Xuất cảnh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nhập cảnh";
            // 
            // mtxtExportHour
            // 
            this.mtxtExportHour.Location = new System.Drawing.Point(251, 55);
            this.mtxtExportHour.Mask = "00:00";
            this.mtxtExportHour.Name = "mtxtExportHour";
            this.mtxtExportHour.Size = new System.Drawing.Size(33, 20);
            this.mtxtExportHour.TabIndex = 28;
            this.mtxtExportHour.ValidatingType = typeof(System.DateTime);
            this.mtxtExportHour.Visible = false;
            // 
            // mtxtImportHour
            // 
            this.mtxtImportHour.Location = new System.Drawing.Point(251, 88);
            this.mtxtImportHour.Mask = "00:00";
            this.mtxtImportHour.Name = "mtxtImportHour";
            this.mtxtImportHour.Size = new System.Drawing.Size(33, 20);
            this.mtxtImportHour.TabIndex = 29;
            this.mtxtImportHour.ValidatingType = typeof(System.DateTime);
            this.mtxtImportHour.Visible = false;
            // 
            // lblIsExport
            // 
            this.lblIsExport.AutoSize = true;
            this.lblIsExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsExport.ForeColor = System.Drawing.Color.Red;
            this.lblIsExport.Location = new System.Drawing.Point(151, 52);
            this.lblIsExport.Name = "lblIsExport";
            this.lblIsExport.Size = new System.Drawing.Size(120, 20);
            this.lblIsExport.TabIndex = 18;
            this.lblIsExport.Text = "Chưa xuất cảnh";
            // 
            // lblIsImport
            // 
            this.lblIsImport.AutoSize = true;
            this.lblIsImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsImport.ForeColor = System.Drawing.Color.Red;
            this.lblIsImport.Location = new System.Drawing.Point(151, 88);
            this.lblIsImport.Name = "lblIsImport";
            this.lblIsImport.Size = new System.Drawing.Size(126, 20);
            this.lblIsImport.TabIndex = 30;
            this.lblIsImport.Text = "Chưa nhập cảnh";
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSaveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAll.Image = global::ECustoms.Properties.Resources.save_icon;
            this.btnSaveAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveAll.Location = new System.Drawing.Point(198, 248);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(236, 33);
            this.btnSaveAll.TabIndex = 21;
            this.btnSaveAll.Text = "Lưu toàn bộ phương tiện";
            this.btnSaveAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = global::ECustoms.Properties.Resources._001_39;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(519, 248);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 33);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Thiết lập lại";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::ECustoms.Properties.Resources._001_05;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(440, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 33);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::ECustoms.Properties.Resources._001_01;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(6, 248);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(186, 33);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thêm phương tiện";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::ECustoms.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(648, 248);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 33);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Đóng";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBoxValid
            // 
            this.pictureBoxValid.Image = global::ECustoms.Properties.Resources.icon_check2_16x16;
            this.pictureBoxValid.InitialImage = global::ECustoms.Properties.Resources.checkIcon;
            this.pictureBoxValid.Location = new System.Drawing.Point(251, 19);
            this.pictureBoxValid.Name = "pictureBoxValid";
            this.pictureBoxValid.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxValid.TabIndex = 32;
            this.pictureBoxValid.TabStop = false;
            // 
            // pictureBoxInvalid
            // 
            this.pictureBoxInvalid.Image = global::ECustoms.Properties.Resources.Icon_Error_16x16_GreyBckgrnd;
            this.pictureBoxInvalid.InitialImage = global::ECustoms.Properties.Resources.checkIcon;
            this.pictureBoxInvalid.Location = new System.Drawing.Point(251, 19);
            this.pictureBoxInvalid.Name = "pictureBoxInvalid";
            this.pictureBoxInvalid.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxInvalid.TabIndex = 33;
            this.pictureBoxInvalid.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblIsImport);
            this.groupBox2.Controls.Add(this.lblIsExport);
            this.groupBox2.Controls.Add(this.dateTimePickerImport);
            this.groupBox2.Controls.Add(this.pictureBoxInvalid);
            this.groupBox2.Controls.Add(this.dateTimePickerExport);
            this.groupBox2.Controls.Add(this.pictureBoxValid);
            this.groupBox2.Controls.Add(this.lblPlateNumber);
            this.groupBox2.Controls.Add(this.txtPlateNumber);
            this.groupBox2.Controls.Add(this.lblNumberOfContainer);
            this.groupBox2.Controls.Add(this.txtNumberOfContainer);
            this.groupBox2.Controls.Add(this.mtxtImportHour);
            this.groupBox2.Controls.Add(this.lblDriverName);
            this.groupBox2.Controls.Add(this.mtxtExportHour);
            this.groupBox2.Controls.Add(this.txtDriverName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtStatus);
            this.groupBox2.Controls.Add(this.lblNote);
            this.groupBox2.Controls.Add(this.cbConfirmImport);
            this.groupBox2.Controls.Add(this.txtNote);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.cbConfirmExport);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnSaveAll);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Location = new System.Drawing.Point(16, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(825, 293);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phương tiện";
            // 
            // Count
            // 
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "STT";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 50;
            // 
            // PlateNumber
            // 
            this.PlateNumber.DataPropertyName = "PlateNumber";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlateNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.PlateNumber.HeaderText = "Biển Kiểm soát";
            this.PlateNumber.Name = "PlateNumber";
            this.PlateNumber.Width = 155;
            // 
            // DriverName
            // 
            this.DriverName.DataPropertyName = "DriverName";
            this.DriverName.HeaderText = "Tên lái xe";
            this.DriverName.Name = "DriverName";
            this.DriverName.Width = 200;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Diễn giải";
            this.Status.Name = "Status";
            this.Status.Width = 250;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Ghi chú";
            this.Note.Name = "Note";
            this.Note.Width = 117;
            // 
            // ExportHour
            // 
            this.ExportHour.DataPropertyName = "ExportHour";
            dataGridViewCellStyle3.NullValue = null;
            this.ExportHour.DefaultCellStyle = dataGridViewCellStyle3;
            this.ExportHour.HeaderText = "Giờ xuất cảnh";
            this.ExportHour.Name = "ExportHour";
            this.ExportHour.Visible = false;
            // 
            // IsExport
            // 
            this.IsExport.DataPropertyName = "IsExport";
            this.IsExport.HeaderText = "Đã Xuất";
            this.IsExport.Name = "IsExport";
            this.IsExport.Visible = false;
            // 
            // ImportDate
            // 
            this.ImportDate.DataPropertyName = "ImportDate";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.ImportDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.ImportDate.HeaderText = "Ngày nhập cảnh";
            this.ImportDate.Name = "ImportDate";
            this.ImportDate.Visible = false;
            this.ImportDate.Width = 115;
            // 
            // ImportHour
            // 
            this.ImportHour.DataPropertyName = "ImportHour";
            this.ImportHour.HeaderText = "Giờ nhập cảnh";
            this.ImportHour.Name = "ImportHour";
            this.ImportHour.Visible = false;
            this.ImportHour.Width = 110;
            // 
            // IsImport
            // 
            this.IsImport.DataPropertyName = "IsImport";
            this.IsImport.HeaderText = "Đã nhập";
            this.IsImport.Name = "IsImport";
            this.IsImport.Visible = false;
            // 
            // VehicleID
            // 
            this.VehicleID.DataPropertyName = "VehicleID";
            this.VehicleID.HeaderText = "VehicleID";
            this.VehicleID.Name = "VehicleID";
            this.VehicleID.Visible = false;
            // 
            // NumberOfContainer
            // 
            this.NumberOfContainer.DataPropertyName = "NumberOfContainer";
            this.NumberOfContainer.HeaderText = "Số Container";
            this.NumberOfContainer.Name = "NumberOfContainer";
            this.NumberOfContainer.Visible = false;
            // 
            // ExportDate
            // 
            this.ExportDate.DataPropertyName = "ExportDate";
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            dataGridViewCellStyle5.NullValue = null;
            this.ExportDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.ExportDate.HeaderText = "Ngày xuất cảnh";
            this.ExportDate.Name = "ExportDate";
            this.ExportDate.Visible = false;
            this.ExportDate.Width = 110;
            // 
            // frmVehicleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 639);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVehicleAdd";
            this.Text = "Khai báo phương tiện";
            this.Load += new System.EventHandler(this.frmVehicleAdd_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInvalid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.TextBox txtNumberOfContainer;
        private System.Windows.Forms.Label lblNumberOfContainer;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.Label lblDriverName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView grdVehicle;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.CheckBox cbConfirmExport;
        private System.Windows.Forms.DateTimePicker dateTimePickerExport;
        private System.Windows.Forms.DateTimePicker dateTimePickerImport;
        private System.Windows.Forms.CheckBox cbConfirmImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtExportHour;
        private System.Windows.Forms.MaskedTextBox mtxtImportHour;
        private System.Windows.Forms.Label lblIsExport;
        private System.Windows.Forms.Label lblIsImport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxValid;
        private System.Windows.Forms.PictureBox pictureBoxInvalid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExportHour;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportHour;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfContainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExportDate;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}