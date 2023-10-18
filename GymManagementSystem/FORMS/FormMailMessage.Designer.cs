
namespace GymManagementSystem.FORMS
{
    partial class FormMailMessage
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
            this.rtxContent = new System.Windows.Forms.RichTextBox();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.lbFile = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxContent
            // 
            this.rtxContent.Location = new System.Drawing.Point(55, 219);
            this.rtxContent.Name = "rtxContent";
            this.rtxContent.Size = new System.Drawing.Size(475, 176);
            this.rtxContent.TabIndex = 0;
            this.rtxContent.Text = "你好。";
            // 
            // txtTop
            // 
            this.txtTop.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTop.Location = new System.Drawing.Point(55, 133);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(209, 29);
            this.txtTop.TabIndex = 1;
            this.txtTop.Text = "健康管理系统";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(50, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "标题：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(50, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "内容：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(50, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "邮箱：";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMail.Location = new System.Drawing.Point(55, 61);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(209, 29);
            this.txtMail.TabIndex = 4;
            this.txtMail.Text = "2739034052@qq.com";
            // 
            // btSend
            // 
            this.btSend.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSend.Location = new System.Drawing.Point(435, 61);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(95, 33);
            this.btSend.TabIndex = 6;
            this.btSend.Text = "发布";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // lbFile
            // 
            this.lbFile.AutoSize = true;
            this.lbFile.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFile.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbFile.Location = new System.Drawing.Point(318, 105);
            this.lbFile.Name = "lbFile";
            this.lbFile.Size = new System.Drawing.Size(69, 25);
            this.lbFile.TabIndex = 7;
            this.lbFile.Text = "附件：";
            this.lbFile.Click += new System.EventHandler(this.lbFile_Click);
            // 
            // txtFile
            // 
            this.txtFile.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFile.Location = new System.Drawing.Point(323, 133);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(146, 29);
            this.txtFile.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClear.Location = new System.Drawing.Point(475, 133);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(55, 29);
            this.btClear.TabIndex = 9;
            this.btClear.Text = "清除";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // FormMailMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.lbFile);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTop);
            this.Controls.Add(this.rtxContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMailMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMailMessage";
            this.Load += new System.EventHandler(this.FormMailMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxContent;
        private System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Label lbFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btClear;
    }
}