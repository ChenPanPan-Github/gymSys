
namespace GymManagementSystem.FORMS
{
    partial class FormCommodity
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
            this.dgvCommodity = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasingprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommodity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCommodity
            // 
            this.dgvCommodity.AllowUserToDeleteRows = false;
            this.dgvCommodity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCommodity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommodity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.type,
            this.quantity,
            this.purchasingprice,
            this.price});
            this.dgvCommodity.Location = new System.Drawing.Point(0, 0);
            this.dgvCommodity.Name = "dgvCommodity";
            this.dgvCommodity.RowHeadersVisible = false;
            this.dgvCommodity.RowTemplate.Height = 23;
            this.dgvCommodity.Size = new System.Drawing.Size(576, 386);
            this.dgvCommodity.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.FillWeight = 176.6497F;
            this.id.HeaderText = "编号";
            this.id.Name = "id";
            this.id.Width = 58;
            // 
            // name
            // 
            this.name.FillWeight = 84.67005F;
            this.name.HeaderText = "商品名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // type
            // 
            this.type.FillWeight = 84.67005F;
            this.type.HeaderText = "类型";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.FillWeight = 84.67005F;
            this.quantity.HeaderText = "数量";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // purchasingprice
            // 
            this.purchasingprice.FillWeight = 84.67005F;
            this.purchasingprice.HeaderText = "进价";
            this.purchasingprice.Name = "purchasingprice";
            this.purchasingprice.ReadOnly = true;
            // 
            // price
            // 
            this.price.FillWeight = 84.67005F;
            this.price.HeaderText = "单价";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // btBuy
            // 
            this.btBuy.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btBuy.Location = new System.Drawing.Point(226, 392);
            this.btBuy.Name = "btBuy";
            this.btBuy.Size = new System.Drawing.Size(124, 46);
            this.btBuy.TabIndex = 1;
            this.btBuy.Text = "进货";
            this.btBuy.UseVisualStyleBackColor = true;
            this.btBuy.Click += new System.EventHandler(this.btBuy_Click);
            // 
            // FormCommodity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btBuy);
            this.Controls.Add(this.dgvCommodity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCommodity";
            this.Text = "FormCommodity";
            this.Load += new System.EventHandler(this.FormCommodity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommodity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCommodity;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasingprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button btBuy;
    }
}