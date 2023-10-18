using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem.FORMS
{
    public partial class FormMailMessage : Form
    {
        public FormMailMessage()
        {
            InitializeComponent();
        }

        string str = "1447784828@qq.com";

        private void FormMailMessage_Load(object sender, EventArgs e)
        {
            //设置附件初始路径
            openFileDialog1.InitialDirectory = @"F:\";//设置起始文件夹
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";//设置文件筛选类型
            openFileDialog1.FileName = "";//设施初始的文件名为空
            openFileDialog1.CheckFileExists = true;//检查文件是否存在
            openFileDialog1.CheckPathExists = true;//检查路径是否存在

            saveFileDialog1.InitialDirectory = @"F:\";
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FileName = "文件名";
        }

        #region 事件

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSend_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            //添加邮件接收地址,可以添加多个接收邮箱地址
            Console.WriteLine(txtMail.Text);
            message.To.Add(txtMail.Text);
            //添加抄送人,抄送同样可以添加多个
            message.CC.Add(str);
            //设置发件人地址，发件人姓名，以及编码
            message.From = new MailAddress(str, "健康管理系统", System.Text.Encoding.UTF8);
            message.Subject = txtTop.Text.ToString();
            message.SubjectEncoding = System.Text.Encoding.UTF8;  //邮件标题编码
            message.Body = rtxContent.Text.ToString();
            message.BodyEncoding = System.Text.Encoding.UTF8;   //邮件内内容的编码
            message.IsBodyHtml = false;//设置邮件是否为HTML邮件
            message.Priority = MailPriority.Normal; //设置邮件优先级

            if (txtFile.Text.Length > 0)
            {
                Attachment attachment = new Attachment(txtFile.Text);
                message.Attachments.Add(attachment);
            }
            SmtpClient client = new SmtpClient();
            //设置发件人的邮箱和授权码。相当于登录邮箱
            client.Credentials = new NetworkCredential(str, "iwconkqjnauaiebh");

            //设置邮箱使用的端口
            client.Port = 587;
            //设置smtp的服务地址
            client.Host = "smtp.qq.com";

            try
            {
                //发送邮件
                client.Send(message);
                MessageBox.Show("发送成功");
            }
            catch (SmtpException ex)
            {
                MessageBox.Show("发送邮件出错");
            }
        }

        /// <summary>
        /// 添加附件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();//显示对话框接返回值
            if (result == DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.FileName;
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtFile.Text = "";
        }

        #endregion

    }
}
