namespace ECustoms
{
    partial class frmReport
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
            this.reportDocument1 = new ReportPrinting.ReportDocument();
            this.printControlToolBar1 = new ReportPrinting.PrintControlToolBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpExportTo = new System.Windows.Forms.DateTimePicker();
            this.dtpExportFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbReportType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportDocument1
            // 
            this.reportDocument1.Body = null;
            this.reportDocument1.PageFooter = null;
            this.reportDocument1.PageHeader = null;
            // 
            // printControlToolBar1
            // 
            this.printControlToolBar1.Document = this.reportDocument1;
            this.printControlToolBar1.Location = new System.Drawing.Point(1, 2);
            this.printControlToolBar1.Name = "printControlToolBar1";
            this.printControlToolBar1.Size = new System.Drawing.Size(774, 40);
            this.printControlToolBar1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(723, 330);
            this.dataGridView1.TabIndex = 1;
            // 
            // dtpExportTo
            // 
            this.dtpExportTo.CustomFormat = "dd/MM/yyyy";
            this.dtpExportTo.Enabled = false;
            this.dtpExportTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExportTo.Location = new System.Drawing.Point(234, 53);
            this.dtpExportTo.Name = "dtpExportTo";
            this.dtpExportTo.Size = new System.Drawing.Size(118, 20);
            this.dtpExportTo.TabIndex = 7;
            // 
            // dtpExportFrom
            // 
            this.dtpExportFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpExportFrom.Enabled = false;
            this.dtpExportFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExportFrom.Location = new System.Drawing.Point(48, 53);
            this.dtpExportFrom.Name = "dtpExportFrom";
            this.dtpExportFrom.Size = new System.Drawing.Size(118, 20);
            this.dtpExportFrom.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::ECustoms.Properties.Resources.search41;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(12, 459);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 33);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Từ:";
            // 
            // cbReportType
            // 
            this.cbReportType.FormattingEnabled = true;
            this.cbReportType.Location = new System.Drawing.Point(474, 54);
            this.cbReportType.Name = "cbReportType";
            this.cbReportType.Size = new System.Drawing.Size(121, 21);
            this.cbReportType.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tới:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kiểu report:";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 504);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbReportType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpExportTo);
            this.Controls.Add(this.dtpExportFrom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.printControlToolBar1);
            this.Name = "frmReport";
            this.Text = "frmReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReportPrinting.ReportDocument reportDocument1;
        private ReportPrinting.PrintControlToolBar printControlToolBar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpExportTo;
        private System.Windows.Forms.DateTimePicker dtpExportFrom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbReportType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}