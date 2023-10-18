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
    public partial class FormLookUp : Form
    {
        ManagerUser manager;
        member_tb user;
        public FormLookUp()
        {
            InitializeComponent();
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
                userid = txtuserid.Text
            };
            var list = manager.FindUser(user);
            if (list != null)
            {
                MessageBox.Show("查询成功");
                rtxShowInfor.Text = list.userid + " " + list.password + " " + list.balance + " " + list.permission + " " + list.createtime.ToString("yyyy.MM.dd");
            }
            else
            {
                MessageBox.Show("查询失败");
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
