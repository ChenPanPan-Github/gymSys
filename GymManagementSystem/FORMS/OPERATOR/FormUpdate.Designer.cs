
namespace GymManagementSystem.FORMS.OPERATOR
{
    partial class FormUpdate
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
            this.btNo = new System.Windows.Forms.Button();
            this.btYes = new System.Windows.Forms.Button();
            this.dtRegsiterTime = new System.Windows.Forms.DateTimePicker();
            this.cmbPermission = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btNo
            // 
            this.btNo.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btNo.Location = new System.Drawing.Point(347, 125);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(101, 58);
            this.btNo.TabIndex = 25;
            this.btNo.Text = "取消";
            this.btNo.UseVisualStyleBackColor = true;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // btYes
            // 
            this.btYes.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btYes.Location = new System.Drawing.Point(347, 31);
            this.btYes.Name = "btYes";
            this.btYes.Size = new System.Drawing.Size(101, 58);
            this.btYes.TabIndex = 24;
            this.btYes.Text = "确认";
            this.btYes.UseVisualStyleBackColor = true;
            this.btYes.Click += new System.EventHandler(this.btYes_Click);
            // 
            // dtRegsiterTime
            // 
            this.dtRegsiterTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtRegsiterTime.Location = new System.Drawing.Point(148, 185);
            this.dtRegsiterTime.Name = "dtRegsiterTime";
            this.dtRegsiterTime.Size = new System.Drawing.Size(139, 23);
            this.dtRegsiterTime.TabIndex = 23;
            // 
            // cmbPermission
            // 
            this.cmbPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPermission.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbPermission.FormattingEnabled = true;
            this.cmbPermission.Items.AddRange(new object[] {
            "普通用户",
            "管理员"});
            this.cmbPermission.Location = new System.Drawing.Point(148, 149);
            this.cmbPermission.Name = "cmbPermission";
            this.cmbPermission.Size = new System.Drawing.Size(139, 25);
            this.cmbPermission.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(68, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "注册时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(68, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "权限：";
            // 
            // txtbalance
            // 
            this.txtbalance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtbalance.Location = new System.Drawing.Point(148, 109);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(139, 23);
            this.txtbalance.TabIndex = 19;
            this.txtbalance.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(68, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "余额：";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.Location = new System.Drawing.Point(148, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(139, 23);
            this.txtPassword.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(68, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "密码：";
            // 
            // txtuserid
            // 
            this.txtuserid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtuserid.Location = new System.Drawing.Point(148, 31);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(139, 23);
            this.txtuserid.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(68, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "用户卡号：";
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 243);
            this.ControlBox = false;
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btYes);
            this.Controls.Add(this.dtRegsiterTime);
            this.Controls.Add(this.cmbPermission);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtuserid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更新数据";
            this.Load += new System.EventHandler(this.FormUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Button btYes;
        private System.Windows.Forms.DateTimePicker dtRegsiterTime;
        private System.Windows.Forms.ComboBox cmbPermission;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.Label label1;
    }
}