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
    public partial class FormDelete : Form
    {
        ManagerUser manager = new ManagerUser();
        member_tb user;

        public event FreshCommodity EventFresh;
        public FormDelete()
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
            user = new member_tb() {
                userid = txtuserid.Text
            };
            bool ret = manager.DeleteUser(user);
            if (ret)
            {
                MessageBox.Show("删除用户成功");
                //FreshConsum_Handle();
                EventFresh();
            }
            else
            {
                MessageBox.Show("删除用户失败");
            }
            btNo_Click(null, null);
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
