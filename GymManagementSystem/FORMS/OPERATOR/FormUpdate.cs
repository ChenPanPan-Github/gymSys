using GymManagementSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GymManagementSystem.DAL.MySqlHelp;

namespace GymManagementSystem.FORMS.OPERATOR
{
    public partial class FormUpdate : Form
    {
        ManagerUser manager;
        member_tb user;

        public event FreshCommodity EventFresh;
        public FormUpdate()
        {
            InitializeComponent();
        }
        private void FormUpdate_Load(object sender, EventArgs e)
        {
            this.cmbPermission.Text = "普通用户";
            this.dtRegsiterTime.Text = DateTime.Now.ToString("yyyy.MM.dd");
        }

        public void InitFormUpdateInfor(member_tb mb)
        {
            txtuserid.Text = mb.userid;
            txtPassword.Text = mb.password;
            txtbalance.Text = mb.balance.ToString();
            cmbPermission.Text = mb.permission;
            dtRegsiterTime.Text = mb.createtime.ToString("yy.MM.dd");
        }

        /// <summary>
        /// 确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btYes_Click(object sender, EventArgs e)
        {
            manager = new ManagerUser();
            user = new member_tb() {
                userid = txtuserid.Text,
                password = txtPassword.Text,
                balance = Convert.ToDouble(txtbalance.Text),
                //permission = cmbPermission.Text,
                createtime = dtRegsiterTime.Value
            };
            if (user.userid.Length == 0 || user.password.Length == 0 || user.balance < 0)
            {
                //判断格式
                //...

                MessageBox.Show("增加失败");
                return;
            }
            if (cmbPermission.Text == "管理员")
            {
                user.permission = "777";
            }
            else if (cmbPermission.Text == "普通用户")
            {
                user.permission = "0";
            }
            bool ret = manager.UpdateUser(user);
            if (ret)
            {
                MessageBox.Show("修改数据成功");
                EventFresh();
                btNo_Click(null, null);
            }
            else
            {
                MessageBox.Show("修改数据失败");
            }
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
