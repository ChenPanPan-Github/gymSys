
namespace GymManagementSystem.FORMS
{
    partial class FormSimulatedConsum
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
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comChoose = new System.Windows.Forms.ComboBox();
            this.btBuy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.dgvSimConsum = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleCdy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btAdd = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.lbClear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimConsum)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserId.Location = new System.Drawing.Point(169, 313);
            this.txtUserId.MaxLength = 7;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(181, 29);
            this.txtUserId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(56, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "会员卡号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(56, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "商品选择：";
            // 
            // comChoose
            // 
            this.comChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comChoose.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comChoose.FormattingEnabled = true;
            this.comChoose.Location = new System.Drawing.Point(169, 357);
            this.comChoose.Name = "comChoose";
            this.comChoose.Size = new System.Drawing.Size(181, 29);
            this.comChoose.TabIndex = 3;
            // 
            // btBuy
            // 
            this.btBuy.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btBuy.Location = new System.Drawing.Point(395, 311);
            this.btBuy.Name = "btBuy";
            this.btBuy.Size = new System.Drawing.Size(91, 31);
            this.btBuy.TabIndex = 4;
            this.btBuy.Text = "购买";
            this.btBuy.UseVisualStyleBackColor = true;
            this.btBuy.Click += new System.EventHandler(this.btBuy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(73, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "数量：";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNumber.Location = new System.Drawing.Point(169, 397);
            this.txtNumber.MaxLength = 7;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(90, 29);
            this.txtNumber.TabIndex = 7;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // dgvSimConsum
            // 
            this.dgvSimConsum.AllowUserToAddRows = false;
            this.dgvSimConsum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSimConsum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimConsum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.price,
            this.number,
            this.totalPrice,
            this.deleCdy});
            this.dgvSimConsum.Location = new System.Drawing.Point(0, 0);
            this.dgvSimConsum.Name = "dgvSimConsum";
            this.dgvSimConsum.RowHeadersVisible = false;
            this.dgvSimConsum.RowTemplate.Height = 23;
            this.dgvSimConsum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSimConsum.Size = new System.Drawing.Size(576, 298);
            this.dgvSimConsum.TabIndex = 8;
            this.dgvSimConsum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSimConsum_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.HeaderText = "编号";
            this.id.Name = "id";
            this.id.Width = 58;
            // 
            // name
            // 
            this.name.HeaderText = "商品名称";
            this.name.Name = "name";
            // 
            // price
            // 
            this.price.HeaderText = "单价";
            this.price.Name = "price";
            // 
            // number
            // 
            this.number.HeaderText = "数量";
            this.number.Name = "number";
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "总价";
            this.totalPrice.Name = "totalPrice";
            // 
            // deleCdy
            // 
            this.deleCdy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.deleCdy.HeaderText = "删除";
            this.deleCdy.Name = "deleCdy";
            this.deleCdy.Width = 40;
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Location = new System.Drawing.Point(395, 357);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(91, 29);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "加入清单";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClear.Location = new System.Drawing.Point(395, 401);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(91, 29);
            this.btClear.TabIndex = 10;
            this.btClear.Text = "清空";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // lbClear
            // 
            this.lbClear.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbClear.ForeColor = System.Drawing.Color.Black;
            this.lbClear.Location = new System.Drawing.Point(356, 314);
            this.lbClear.Name = "lbClear";
            this.lbClear.Size = new System.Drawing.Size(20, 27);
            this.lbClear.TabIndex = 11;
            this.lbClear.Text = "×";
            this.lbClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbClear.Click += new System.EventHandler(this.lbClear_Click);
            // 
            // FormSimulatedConsum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.lbClear);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dgvSimConsum);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btBuy);
            this.Controls.Add(this.comChoose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSimulatedConsum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSimulatedConsum";
            this.Load += new System.EventHandler(this.FormSimulatedConsum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimConsum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comChoose;
        private System.Windows.Forms.Button btBuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.DataGridView dgvSimConsum;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label lbClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewButtonColumn deleCdy;
    }
}