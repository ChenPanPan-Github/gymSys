using GymManagementSystem.BLL;
using GymManagementSystem.FORMS;
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

namespace GymManagementSystem
{
    public partial class FormLogin : Form
    {
        FormRegister register;
        ManagerUser manager = new ManagerUser();
        FormMain main;
        public FormLogin()
        {
            InitializeComponent();
            InitLogin();
        }

        private void InitLogin()
        {
            cmbCharactar.Text = "管理员";
        }

        #region 事件

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbRegister_Click(object sender, EventArgs e)
        {
            register = new FormRegister();
            register.ShowDialog();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLogin_Click(object sender, EventArgs e)
        {
            member_tb ret = manager.UserQuery(this.txtUserName.Text, this.txtPassword.Text, this.cmbCharactar.Text);
            if (ret != null)
            {
                MessageBox.Show("登录成功");
                main = new FormMain();
                main.EventCloseProject += CloseForm;
                if (ret.permission != "777")
                {
                    main.isNormalUser = true;
                }
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("用户名、密码或者权限错误");
            }
        }

        #endregion

        /// <summary>
        /// main退出/注销
        /// </summary>
        /// <param name="demo"></param>
        private void CloseForm(int demo)
        {
            if (demo == 0)
            {
                main.Dispose();
                main.Close();
                this.Show();
            }
            else if (demo == 1)
            {
                this.Dispose();
                this.Close();
            }
        }
    }
}
