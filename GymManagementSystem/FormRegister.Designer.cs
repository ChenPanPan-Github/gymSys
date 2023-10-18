
namespace GymManagementSystem
{
    partial class FormRegister
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btRegister = new System.Windows.Forms.Button();
            this.btBackLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comPermission = new System.Windows.Forms.ComboBox();
            this.lbTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserName.Location = new System.Drawing.Point(316, 79);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(186, 33);
            this.txtUserName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(232, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.Location = new System.Drawing.Point(316, 136);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(186, 33);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(232, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "密码：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btRegister
            // 
            this.btRegister.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRegister.Location = new System.Drawing.Point(245, 257);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(90, 54);
            this.btRegister.TabIndex = 6;
            this.btRegister.Text = "注册";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btBackLogin
            // 
            this.btBackLogin.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btBackLogin.Location = new System.Drawing.Point(403, 257);
            this.btBackLogin.Name = "btBackLogin";
            this.btBackLogin.Size = new System.Drawing.Size(89, 52);
            this.btBackLogin.TabIndex = 7;
            this.btBackLogin.Text = "返回";
            this.btBackLogin.UseVisualStyleBackColor = true;
            this.btBackLogin.Click += new System.EventHandler(this.btBackLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(232, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "权限：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comPermission
            // 
            this.comPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPermission.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comPermission.FormattingEnabled = true;
            this.comPermission.Items.AddRange(new object[] {
            "普通用户",
            "管理员"});
            this.comPermission.Location = new System.Drawing.Point(316, 198);
            this.comPermission.Name = "comPermission";
            this.comPermission.Size = new System.Drawing.Size(186, 33);
            this.comPermission.TabIndex = 9;
            this.comPermission.SelectedIndexChanged += new System.EventHandler(this.comPermission_SelectedIndexChanged);
            // 
            // lbTip
            // 
            this.lbTip.AutoSize = true;
            this.lbTip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTip.ForeColor = System.Drawing.Color.Red;
            this.lbTip.Location = new System.Drawing.Point(314, 336);
            this.lbTip.Name = "lbTip";
            this.lbTip.Size = new System.Drawing.Size(128, 17);
            this.lbTip.TabIndex = 10;
            this.lbTip.Text = "该权限需要联系管理员";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 387);
            this.ControlBox = false;
            this.Controls.Add(this.lbTip);
            this.Controls.Add(this.comPermission);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btBackLogin);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btBackLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comPermission;
        private System.Windows.Forms.Label lbTip;
    }
}