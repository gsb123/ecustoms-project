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
            this.printControlToolBar1.Document = null;
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
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 504);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.printControlToolBar1);
            this.Name = "frmReport";
            this.Text = "frmReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReportPrinting.ReportDocument reportDocument1;
        private ReportPrinting.PrintControlToolBar printControlToolBar1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}