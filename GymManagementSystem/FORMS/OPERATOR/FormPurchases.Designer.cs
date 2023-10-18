
namespace GymManagementSystem.FORMS.OPERATOR
{
    partial class FormPurchases
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPerchasing = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btNo = new System.Windows.Forms.Button();
            this.btYes = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品名称：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(115, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 29);
            this.txtName.TabIndex = 1;
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtType.Location = new System.Drawing.Point(115, 130);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(58, 29);
            this.txtType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(51, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "单位：";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNumber.Location = new System.Drawing.Point(115, 79);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(120, 29);
            this.txtNumber.TabIndex = 5;
            this.txtNumber.TextChanged += new System.EventHandler(this.My_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(30, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "进货数量：";
            // 
            // txtPerchasing
            // 
            this.txtPerchasing.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPerchasing.Location = new System.Drawing.Point(343, 79);
            this.txtPerchasing.Name = "txtPerchasing";
            this.txtPerchasing.Size = new System.Drawing.Size(120, 29);
            this.txtPerchasing.TabIndex = 7;
            this.txtPerchasing.TextChanged += new System.EventHandler(this.txtPerchasing_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(279, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "进价：";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPrice.Location = new System.Drawing.Point(343, 123);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(120, 29);
            this.txtPrice.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(279, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "售价：";
            // 
            // btNo
            // 
            this.btNo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btNo.Location = new System.Drawing.Point(311, 180);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(90, 41);
            this.btNo.TabIndex = 10;
            this.btNo.Text = "取消";
            this.btNo.UseVisualStyleBackColor = true;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // btYes
            // 
            this.btYes.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btYes.Location = new System.Drawing.Point(135, 180);
            this.btYes.Name = "btYes";
            this.btYes.Size = new System.Drawing.Size(90, 41);
            this.btYes.TabIndex = 11;
            this.btYes.Text = "确认";
            this.btYes.UseVisualStyleBackColor = true;
            this.btYes.Click += new System.EventHandler(this.btYes_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(179, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "/元";
            // 
            // FormPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 243);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btYes);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPerchasing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormPurchases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "进货";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPerchasing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Button btYes;
        private System.Windows.Forms.Label label6;
    }
}