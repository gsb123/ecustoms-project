namespace ECustoms
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.khaiBáoXuấtNhậpKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemDeclaration = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExport = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewVehiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolstripLabelWelcome = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonDeclarace = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonListdeclarace = new System.Windows.Forms.ToolStripButton();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnMain
            // 
            this.mnMain.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.khaiBáoXuấtNhậpKhẩuToolStripMenuItem});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.Size = new System.Drawing.Size(1211, 29);
            this.mnMain.TabIndex = 0;
            this.mnMain.Tag = "";
            this.mnMain.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemUser,
            this.toolStripMenuItem1,
            this.menuitemLogout,
            this.toolStripSeparator1,
            this.menuitemExit,
            this.aboutUsToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // menuitemUser
            // 
            this.menuitemUser.Image = global::ECustoms.Properties.Resources.Users;
            this.menuitemUser.Name = "menuitemUser";
            this.menuitemUser.Size = new System.Drawing.Size(248, 26);
            this.menuitemUser.Text = "Quản lý người dùng";
            this.menuitemUser.Click += new System.EventHandler(this.menuitemUser_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::ECustoms.Properties.Resources.change_password_icon;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(248, 26);
            this.toolStripMenuItem1.Text = "Thay đổi mật khẩu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menuitemLogout
            // 
            this.menuitemLogout.Image = global::ECustoms.Properties.Resources.logout;
            this.menuitemLogout.Name = "menuitemLogout";
            this.menuitemLogout.Size = new System.Drawing.Size(248, 26);
            this.menuitemLogout.Text = "Đăng xuất";
            this.menuitemLogout.Click += new System.EventHandler(this.menuitemLogout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(245, 6);
            // 
            // menuitemExit
            // 
            this.menuitemExit.Image = global::ECustoms.Properties.Resources.exit;
            this.menuitemExit.Name = "menuitemExit";
            this.menuitemExit.Size = new System.Drawing.Size(248, 26);
            this.menuitemExit.Text = "Thoát Khỏi chương trình";
            this.menuitemExit.Click += new System.EventHandler(this.menuitemExit_Click);
            // 
            // khaiBáoXuấtNhậpKhẩuToolStripMenuItem
            // 
            this.khaiBáoXuấtNhậpKhẩuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemDeclaration,
            this.mnExport,
            this.vehicleSearch,
            this.addNewVehiceToolStripMenuItem});
            this.khaiBáoXuấtNhậpKhẩuToolStripMenuItem.Name = "khaiBáoXuấtNhậpKhẩuToolStripMenuItem";
            this.khaiBáoXuấtNhậpKhẩuToolStripMenuItem.Size = new System.Drawing.Size(192, 25);
            this.khaiBáoXuấtNhậpKhẩuToolStripMenuItem.Text = "Khai báo xuất nhập khẩu";
            // 
            // menuitemDeclaration
            // 
            this.menuitemDeclaration.Image = global::ECustoms.Properties.Resources.list;
            this.menuitemDeclaration.Name = "menuitemDeclaration";
            this.menuitemDeclaration.Size = new System.Drawing.Size(250, 26);
            this.menuitemDeclaration.Text = "Danh sách tờ khai";
            this.menuitemDeclaration.Click += new System.EventHandler(this.menuitemDeclaration_Click);
            // 
            // mnExport
            // 
            this.mnExport.Image = global::ECustoms.Properties.Resources.file_import1;
            this.mnExport.Name = "mnExport";
            this.mnExport.Size = new System.Drawing.Size(250, 26);
            this.mnExport.Text = "Khai báo xuất nhập khẩu";
            this.mnExport.Click += new System.EventHandler(this.mnExport_Click);
            // 
            // vehicleSearch
            // 
            this.vehicleSearch.Image = global::ECustoms.Properties.Resources.searchIcon;
            this.vehicleSearch.Name = "vehicleSearch";
            this.vehicleSearch.Size = new System.Drawing.Size(250, 26);
            this.vehicleSearch.Text = "Tìm kiếm phương tiện";
            this.vehicleSearch.Click += new System.EventHandler(this.vehicleSearch_Click);
            // 
            // addNewVehiceToolStripMenuItem
            // 
            this.addNewVehiceToolStripMenuItem.Image = global::ECustoms.Properties.Resources._001_01;
            this.addNewVehiceToolStripMenuItem.Name = "addNewVehiceToolStripMenuItem";
            this.addNewVehiceToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.addNewVehiceToolStripMenuItem.Text = "Thêm phương tiện";
            this.addNewVehiceToolStripMenuItem.Click += new System.EventHandler(this.addNewVehiceToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripLabelWelcome,
            this.toolStripButtonDeclarace,
            this.toolStripButtonSearch,
            this.toolStripButtonListdeclarace});
            this.toolStrip1.Location = new System.Drawing.Point(0, 29);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1211, 30);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolstripLabelWelcome
            // 
            this.toolstripLabelWelcome.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolstripLabelWelcome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolstripLabelWelcome.ForeColor = System.Drawing.Color.Red;
            this.toolstripLabelWelcome.Name = "toolstripLabelWelcome";
            this.toolstripLabelWelcome.Size = new System.Drawing.Size(93, 27);
            this.toolstripLabelWelcome.Text = "toolStripLabel1";
            // 
            // toolStripButtonDeclarace
            // 
            this.toolStripButtonDeclarace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeclarace.Image = global::ECustoms.Properties.Resources.file_import1;
            this.toolStripButtonDeclarace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeclarace.Name = "toolStripButtonDeclarace";
            this.toolStripButtonDeclarace.Size = new System.Drawing.Size(23, 27);
            this.toolStripButtonDeclarace.Text = "toolStripButton1";
            this.toolStripButtonDeclarace.ToolTipText = "Khai báo xuất nhập khẩu";
            this.toolStripButtonDeclarace.Click += new System.EventHandler(this.toolStripButtonDeclarace_Click);
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSearch.Image = global::ECustoms.Properties.Resources.searchIcon;
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(23, 27);
            this.toolStripButtonSearch.Text = "toolStripButton2";
            this.toolStripButtonSearch.ToolTipText = "Tìm kiếm phương tiện";
            this.toolStripButtonSearch.Click += new System.EventHandler(this.toolStripButtonSearch_Click);
            // 
            // toolStripButtonListdeclarace
            // 
            this.toolStripButtonListdeclarace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonListdeclarace.Image = global::ECustoms.Properties.Resources.list;
            this.toolStripButtonListdeclarace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonListdeclarace.Name = "toolStripButtonListdeclarace";
            this.toolStripButtonListdeclarace.Size = new System.Drawing.Size(23, 27);
            this.toolStripButtonListdeclarace.Text = "toolStripButton3";
            this.toolStripButtonListdeclarace.ToolTipText = "Danh sách tờ khai";
            this.toolStripButtonListdeclarace.Click += new System.EventHandler(this.toolStripButtonListdeclarace_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 723);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mnMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnMain;
            this.Name = "frmMainForm";
            this.Text = " Khai báo xuất nhập cảnh";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khaiBáoXuấtNhậpKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnExport;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolstripLabelWelcome;
        private System.Windows.Forms.ToolStripMenuItem vehicleSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuitemExit;
        private System.Windows.Forms.ToolStripMenuItem menuitemLogout;
        private System.Windows.Forms.ToolStripMenuItem menuitemDeclaration;
        private System.Windows.Forms.ToolStripMenuItem menuitemUser;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeclarace;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.ToolStripButton toolStripButtonListdeclarace;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewVehiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
    }
}