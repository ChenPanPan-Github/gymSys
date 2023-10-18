
namespace GymManagementSystem.FORMS
{
    partial class FormMember
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
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAddUser = new System.Windows.Forms.Button();
            this.btUpDateUser = new System.Windows.Forms.Button();
            this.btDeleteUser = new System.Windows.Forms.Button();
            this.btLookUpUser = new System.Windows.Forms.Button();
            this.btFresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMember
            // 
            this.dgvMember.AllowUserToDeleteRows = false;
            this.dgvMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.userid,
            this.password,
            this.balance,
            this.permission,
            this.createtime});
            this.dgvMember.Location = new System.Drawing.Point(0, 0);
            this.dgvMember.MultiSelect = false;
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowHeadersVisible = false;
            this.dgvMember.RowTemplate.Height = 23;
            this.dgvMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMember.Size = new System.Drawing.Size(576, 391);
            this.dgvMember.TabIndex = 0;
            // 
            // id
            // 
            this.id.FillWeight = 60.9137F;
            this.id.HeaderText = "编号";
            this.id.Name = "id";
            // 
            // userid
            // 
            this.userid.FillWeight = 107.8173F;
            this.userid.HeaderText = "用户卡号";
            this.userid.Name = "userid";
            // 
            // password
            // 
            this.password.FillWeight = 107.8173F;
            this.password.HeaderText = "密码";
            this.password.Name = "password";
            // 
            // balance
            // 
            this.balance.FillWeight = 107.8173F;
            this.balance.HeaderText = "余额";
            this.balance.Name = "balance";
            // 
            // permission
            // 
            this.permission.FillWeight = 107.8173F;
            this.permission.HeaderText = "权限";
            this.permission.Name = "permission";
            // 
            // createtime
            // 
            this.createtime.FillWeight = 107.8173F;
            this.createtime.HeaderText = "注册时间";
            this.createtime.Name = "createtime";
            // 
            // btAddUser
            // 
            this.btAddUser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAddUser.Location = new System.Drawing.Point(270, 397);
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(70, 41);
            this.btAddUser.TabIndex = 1;
            this.btAddUser.Text = "增加用户";
            this.btAddUser.UseVisualStyleBackColor = true;
            this.btAddUser.Click += new System.EventHandler(this.btAddUser_Click);
            // 
            // btUpDateUser
            // 
            this.btUpDateUser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btUpDateUser.Location = new System.Drawing.Point(199, 397);
            this.btUpDateUser.Name = "btUpDateUser";
            this.btUpDateUser.Size = new System.Drawing.Size(65, 41);
            this.btUpDateUser.TabIndex = 2;
            this.btUpDateUser.Text = "修改信息";
            this.btUpDateUser.UseVisualStyleBackColor = true;
            this.btUpDateUser.Click += new System.EventHandler(this.btUpDateUser_Click);
            // 
            // btDeleteUser
            // 
            this.btDeleteUser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDeleteUser.Location = new System.Drawing.Point(418, 397);
            this.btDeleteUser.Name = "btDeleteUser";
            this.btDeleteUser.Size = new System.Drawing.Size(70, 41);
            this.btDeleteUser.TabIndex = 3;
            this.btDeleteUser.Text = "删除用户";
            this.btDeleteUser.UseVisualStyleBackColor = true;
            this.btDeleteUser.Click += new System.EventHandler(this.btDeleteUser_Click);
            // 
            // btLookUpUser
            // 
            this.btLookUpUser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btLookUpUser.Location = new System.Drawing.Point(346, 397);
            this.btLookUpUser.Name = "btLookUpUser";
            this.btLookUpUser.Size = new System.Drawing.Size(66, 41);
            this.btLookUpUser.TabIndex = 4;
            this.btLookUpUser.Text = "查找用户";
            this.btLookUpUser.UseVisualStyleBackColor = true;
            this.btLookUpUser.Click += new System.EventHandler(this.btLookUpUser_Click);
            // 
            // btFresh
            // 
            this.btFresh.Location = new System.Drawing.Point(98, 397);
            this.btFresh.Name = "btFresh";
            this.btFresh.Size = new System.Drawing.Size(78, 41);
            this.btFresh.TabIndex = 5;
            this.btFresh.Text = "刷新";
            this.btFresh.UseVisualStyleBackColor = true;
            this.btFresh.Click += new System.EventHandler(this.btFresh_Click);
            // 
            // FormMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btFresh);
            this.Controls.Add(this.btLookUpUser);
            this.Controls.Add(this.btDeleteUser);
            this.Controls.Add(this.btUpDateUser);
            this.Controls.Add(this.btAddUser);
            this.Controls.Add(this.dgvMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMember";
            this.Text = "FormMember";
            this.Load += new System.EventHandler(this.FormMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.Button btAddUser;
        private System.Windows.Forms.Button btUpDateUser;
        private System.Windows.Forms.Button btDeleteUser;
        private System.Windows.Forms.Button btLookUpUser;
        private System.Windows.Forms.Button btFresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn permission;
        private System.Windows.Forms.DataGridViewTextBoxColumn createtime;
    }
}