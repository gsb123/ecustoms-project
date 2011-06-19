namespace ECustoms
{
    partial class frmAddGroup
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clbRoles = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(159, 46);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '*';
            this.txtDescription.Size = new System.Drawing.Size(290, 72);
            this.txtDescription.TabIndex = 9;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(44, 46);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(49, 20);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Mô tả";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(159, 6);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(290, 20);
            this.txtName.TabIndex = 8;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(57, 9);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(36, 20);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Tên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clbRoles);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(159, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 292);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quyền";
            // 
            // clbRoles
            // 
            this.clbRoles.FormattingEnabled = true;
            this.clbRoles.Location = new System.Drawing.Point(16, 25);
            this.clbRoles.Name = "clbRoles";
            this.clbRoles.Size = new System.Drawing.Size(485, 235);
            this.clbRoles.TabIndex = 0;
            // 
            // frmAddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 447);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblUsername);
            this.Name = "frmAddGroup";
            this.Text = "frmAddGroup";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox clbRoles;
    }
}