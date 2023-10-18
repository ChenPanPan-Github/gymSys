
namespace GymManagementSystem.FORMS.OPERATOR
{
    partial class FormLookUp
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
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxShowInfor = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btNo
            // 
            this.btNo.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btNo.Location = new System.Drawing.Point(386, 117);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(101, 58);
            this.btNo.TabIndex = 29;
            this.btNo.Text = "退出";
            this.btNo.UseVisualStyleBackColor = true;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // btYes
            // 
            this.btYes.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btYes.Location = new System.Drawing.Point(386, 25);
            this.btYes.Name = "btYes";
            this.btYes.Size = new System.Drawing.Size(101, 58);
            this.btYes.TabIndex = 28;
            this.btYes.Text = "确认";
            this.btYes.UseVisualStyleBackColor = true;
            this.btYes.Click += new System.EventHandler(this.btYes_Click);
            // 
            // txtuserid
            // 
            this.txtuserid.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtuserid.Location = new System.Drawing.Point(130, 25);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(211, 29);
            this.txtuserid.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "用户卡号：";
            // 
            // rtxShowInfor
            // 
            this.rtxShowInfor.Location = new System.Drawing.Point(42, 63);
            this.rtxShowInfor.Name = "rtxShowInfor";
            this.rtxShowInfor.Size = new System.Drawing.Size(299, 147);
            this.rtxShowInfor.TabIndex = 30;
            this.rtxShowInfor.Text = "";
            // 
            // FormLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 248);
            this.ControlBox = false;
            this.Controls.Add(this.rtxShowInfor);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btYes);
            this.Controls.Add(this.txtuserid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormLookUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询用户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Button btYes;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxShowInfor;
    }
}