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

namespace GymManagementSystem
{
    public partial class FormRegister : Form
    {

        ManagerUser manager = new ManagerUser();
        public FormRegister()
        {
            InitializeComponent();
            comPermission.Text = "普通用户";
        }

        # region 事件

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRegister_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length < 2)
            {
                //以及格式判断

                MessageBox.Show("注册失败，名称字符不能低于2位");
                return;
            }
            if (txtPassword.Text.Length < 2)
            {
                MessageBox.Show("注册失败，密码不能低于2位");
                return;
            }

            bool ret = manager.RegisterUser(txtUserName.Text, txtPassword.Text);
            if (ret)
            {
                MessageBox.Show("注册成功");
                this.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show("注册失败，该用户已存在");
            }
        }

        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btBackLogin_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        /// <summary>
        /// 权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comPermission_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comPermission.Text == "管理员")
            {
                btRegister.Enabled = false;
                lbTip.Visible = true;
            }
            else
            {
                btRegister.Enabled = true;
                lbTip.Visible = false;
            }
        }
        #endregion
    }
}
