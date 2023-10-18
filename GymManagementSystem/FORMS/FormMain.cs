using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem.FORMS
{
    public delegate void CloseProject(int demo);
    public partial class FormMain : Form
    {
        /// <summary>
        /// 子界面对象实例
        /// </summary>
        FormConsum consum = new FormConsum();
        FormCommodity commodity = new FormCommodity();
        FormMember member = new FormMember();
        FormMailMessage message = new FormMailMessage();
        FormSimulatedConsum simulatedConsum = new FormSimulatedConsum();

        public event CloseProject EventCloseProject;

        /// <summary>
        /// 登录用户
        /// </summary>
        public bool isNormalUser { get; set; } = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //事件注册
            member.FreshConsum_Handle += consum.InitFormConum;
            simulatedConsum.FreshConsum_Handle += consum.InitFormConum;
            simulatedConsum.FreshConsum_Handle += member.InitMember;
            simulatedConsum.EventFresh += commodity.InitCommodity;
            commodity.EventSimu_Handle += simulatedConsum.InitSimulate;
            InitPower();
        }

        /// <summary>
        /// 成员管理权限
        /// </summary>
        public void InitPower()
        {
            if(isNormalUser)
            {
                this.button3.Enabled = false;
            }
            button1_Click(null, null);
        }

        #region 事件
        private void button1_Click(object sender, EventArgs e)
        {
            commodity.Visible = false;
            member.Visible = false;
            message.Visible = false;
            simulatedConsum.Visible = false;
            OpenWindow(consum);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            member.Visible = false;
            consum.Visible = false;
            message.Visible = false;
            simulatedConsum.Visible = false;
            OpenWindow(commodity);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            commodity.Visible = false;
            consum.Visible = false;
            message.Visible = false;
            simulatedConsum.Visible = false;
            OpenWindow(member);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            commodity.Visible = false;
            consum.Visible = false;
            member.Visible = false;
            simulatedConsum.Visible = false;
            OpenWindow(message);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            commodity.Visible = false;
            consum.Visible = false;
            member.Visible = false;
            message.Visible = false;
            OpenWindow(simulatedConsum);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            EventCloseProject(0);
            this.Dispose();
            this.Close();
        }
        private void btQuit_Click(object sender, EventArgs e)
        {
            EventCloseProject(1);
            this.Dispose();
            this.Close();
        }
        private void OpenWindow(Form Frm)
        {
            Frm.TopMost = true;
            Frm.TopLevel = false;
            Frm.FormBorderStyle = FormBorderStyle.None;
            Frm.Dock = DockStyle.Fill;
            Frm.Parent = panel2;
            //BackColorSet(Frm.Tag);
            Frm.Show();
        }
        #endregion
        
    }
}
