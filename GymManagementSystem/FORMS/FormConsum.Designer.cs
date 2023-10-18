
namespace GymManagementSystem.FORMS
{
    partial class FormConsum
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbGrossMargin = new System.Windows.Forms.Label();
            this.lbMebQuantity = new System.Windows.Forms.Label();
            this.lbMonConsum = new System.Windows.Forms.Label();
            this.lbNetMargin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(68, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "会员数量：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(343, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "净利润：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(68, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "毛利率：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(343, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "月份消费额：";
            // 
            // lbGrossMargin
            // 
            this.lbGrossMargin.AutoSize = true;
            this.lbGrossMargin.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbGrossMargin.Location = new System.Drawing.Point(164, 252);
            this.lbGrossMargin.Name = "lbGrossMargin";
            this.lbGrossMargin.Size = new System.Drawing.Size(63, 27);
            this.lbGrossMargin.TabIndex = 5;
            this.lbGrossMargin.Text = "NULL";
            // 
            // lbMebQuantity
            // 
            this.lbMebQuantity.AutoSize = true;
            this.lbMebQuantity.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMebQuantity.Location = new System.Drawing.Point(164, 139);
            this.lbMebQuantity.Name = "lbMebQuantity";
            this.lbMebQuantity.Size = new System.Drawing.Size(63, 27);
            this.lbMebQuantity.TabIndex = 4;
            this.lbMebQuantity.Text = "NULL";
            // 
            // lbMonConsum
            // 
            this.lbMonConsum.AutoSize = true;
            this.lbMonConsum.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMonConsum.Location = new System.Drawing.Point(470, 251);
            this.lbMonConsum.Name = "lbMonConsum";
            this.lbMonConsum.Size = new System.Drawing.Size(63, 27);
            this.lbMonConsum.TabIndex = 7;
            this.lbMonConsum.Text = "NULL";
            // 
            // lbNetMargin
            // 
            this.lbNetMargin.AutoSize = true;
            this.lbNetMargin.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNetMargin.Location = new System.Drawing.Point(433, 140);
            this.lbNetMargin.Name = "lbNetMargin";
            this.lbNetMargin.Size = new System.Drawing.Size(63, 27);
            this.lbNetMargin.TabIndex = 6;
            this.lbNetMargin.Text = "NULL";
            // 
            // FormConsum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.lbMonConsum);
            this.Controls.Add(this.lbNetMargin);
            this.Controls.Add(this.lbGrossMargin);
            this.Controls.Add(this.lbMebQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsum";
            this.Text = "FormConum";
            this.Load += new System.EventHandler(this.FormConum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbGrossMargin;
        private System.Windows.Forms.Label lbMebQuantity;
        private System.Windows.Forms.Label lbMonConsum;
        private System.Windows.Forms.Label lbNetMargin;
    }
}