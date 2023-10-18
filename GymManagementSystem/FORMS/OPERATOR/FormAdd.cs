using GymManagementSystem.BLL;
using GymManagementSystem.Model;
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

    public partial class FormAdd : Form
    {
        ManagerUser manager;
        member_tb user;

        public event FreshCommodity EventFresh;

        public FormAdd()
        {
            InitializeComponent();
        }
        private void FormAdd_Load(object sender, EventArgs e)
        {
            this.cmbPermission.Text = "普通用户";
            this.dtRegsiterTime.Text = DateTime.Now.ToString("yyyy.MM.dd");
        }

        #region 事件
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
            if (cmbPermission.Text == "普通用户")
            {
                user.permission = "0";
            }
            else
            {
                user.permission = "777";
            }

            if (user.userid.Length == 0 || user.password.Length == 0 || user.balance <0)
            {
                //判断格式
                //...
                //System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex();

                MessageBox.Show("格式错误");
                return;
            }
            bool ret = manager.AddUser(user);
            if (ret)
            {
                MessageBox.Show("增加成功");
                EventFresh();
                btNo_Click(null, null);
                return;
            }
            MessageBox.Show("增加失败");

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

        /// <summary>
        /// 用户名输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtuserid_TextChanged(object sender, EventArgs e)
        {
            if (txtuserid.Text.Length > 0)
            {
                btYes.Enabled = true;
                lbCheckId.Text = "✅";
                lbCheckId.ForeColor = Color.Green;
            }
            else
            {
                btYes.Enabled = false;
                lbCheckId.Text = "*";
                lbCheckId.ForeColor = Color.Red;
            }
        }

        private void txtbalance_TextChanged(object sender, EventArgs e)
        {
/*            if (Convert.ToInt32(txtbalance.Text) >= 0)
            {
                btYes.Enabled = true;
                lbCheckBalance.Text = "✅";
                lbCheckBalance.ForeColor = Color.Green;
            }
            else
            {
                btYes.Enabled = false;
                lbCheckBalance.Text = "*";
                lbCheckBalance.ForeColor = Color.Red;
            }*/
        }
        #endregion
    }
}
