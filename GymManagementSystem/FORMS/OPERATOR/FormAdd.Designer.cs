
namespace GymManagementSystem.FORMS.OPERATOR
{
    partial class FormAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPermission = new System.Windows.Forms.ComboBox();
            this.dtRegsiterTime = new System.Windows.Forms.DateTimePicker();
            this.btYes = new System.Windows.Forms.Button();
            this.btNo = new System.Windows.Forms.Button();
            this.lbCheckId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCheckBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(69, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户卡号：";
            // 
            // txtuserid
            // 
            this.txtuserid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtuserid.Location = new System.Drawing.Point(149, 30);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(139, 23);
            this.txtuserid.TabIndex = 1;
            this.txtuserid.TextChanged += new System.EventHandler(this.txtuserid_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.Location = new System.Drawing.Point(149, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(139, 23);
            this.txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(69, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            // 
            // txtbalance
            // 
            this.txtbalance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtbalance.Location = new System.Drawing.Point(149, 108);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(139, 23);
            this.txtbalance.TabIndex = 5;
            this.txtbalance.Text = "0";
            this.txtbalance.TextChanged += new System.EventHandler(this.txtbalance_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(69, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "余额：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(69, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "权限：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(69, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "注册时间：";
            // 
            // cmbPermission
            // 
            this.cmbPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPermission.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbPermission.FormattingEnabled = true;
            this.cmbPermission.Items.AddRange(new object[] {
            "普通用户",
            "管理员"});
            this.cmbPermission.Location = new System.Drawing.Point(149, 148);
            this.cmbPermission.Name = "cmbPermission";
            this.cmbPermission.Size = new System.Drawing.Size(139, 25);
            this.cmbPermission.TabIndex = 10;
            // 
            // dtRegsiterTime
            // 
            this.dtRegsiterTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtRegsiterTime.Location = new System.Drawing.Point(149, 184);
            this.dtRegsiterTime.Name = "dtRegsiterTime";
            this.dtRegsiterTime.Size = new System.Drawing.Size(139, 23);
            this.dtRegsiterTime.TabIndex = 11;
            // 
            // btYes
            // 
            this.btYes.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btYes.Location = new System.Drawing.Point(348, 30);
            this.btYes.Name = "btYes";
            this.btYes.Size = new System.Drawing.Size(101, 58);
            this.btYes.TabIndex = 12;
            this.btYes.Text = "确认";
            this.btYes.UseVisualStyleBackColor = true;
            this.btYes.Click += new System.EventHandler(this.btYes_Click);
            // 
            // btNo
            // 
            this.btNo.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btNo.Location = new System.Drawing.Point(348, 124);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(101, 58);
            this.btNo.TabIndex = 13;
            this.btNo.Text = "取消";
            this.btNo.UseVisualStyleBackColor = true;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // lbCheckId
            // 
            this.lbCheckId.AutoSize = true;
            this.lbCheckId.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCheckId.ForeColor = System.Drawing.Color.Red;
            this.lbCheckId.Location = new System.Drawing.Point(294, 33);
            this.lbCheckId.Name = "lbCheckId";
            this.lbCheckId.Size = new System.Drawing.Size(15, 20);
            this.lbCheckId.TabIndex = 14;
            this.lbCheckId.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(294, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "*";
            // 
            // lbCheckBalance
            // 
            this.lbCheckBalance.AutoSize = true;
            this.lbCheckBalance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCheckBalance.ForeColor = System.Drawing.Color.Red;
            this.lbCheckBalance.Location = new System.Drawing.Point(294, 109);
            this.lbCheckBalance.Name = "lbCheckBalance";
            this.lbCheckBalance.Size = new System.Drawing.Size(15, 20);
            this.lbCheckBalance.TabIndex = 16;
            this.lbCheckBalance.Text = "*";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 243);
            this.ControlBox = false;
            this.Controls.Add(this.lbCheckBalance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbCheckId);
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
            this.Name = "FormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加商品";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPermission;
        private System.Windows.Forms.DateTimePicker dtRegsiterTime;
        private System.Windows.Forms.Button btYes;
        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Label lbCheckId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCheckBalance;
    }
}