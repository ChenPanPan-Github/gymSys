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
    public delegate void FreshFromPurchases();
    public partial class FormPurchases : Form
    {
        ManagerUser manager;

        public event FreshFromPurchases Purchases_ChangeHandle;

        public FormPurchases()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btYes_Click(object sender, EventArgs e)
        {
            //判断txt输入是否为空
            bool ret = iSEmptyTxt();
            if (!ret) return;

            //将数据插入数据库对应的表
            commodity_tb ct = new commodity_tb() {
                name = txtName.Text,
                quantity = Convert.ToInt32(txtNumber.Text),
                type = txtType.Text + "/元",
                purchasingprice = Convert.ToDouble(txtPerchasing.Text),
                price = Convert.ToDouble(txtPrice.Text)
            };

            manager = new ManagerUser();
            bool isAdd = manager.AddCommodity(ct); //插入数据
            if (!isAdd)
            {
                MessageBox.Show("进货失败,商品名称不能重复");
                return;
            }
            MessageBox.Show("进货成功");
            Purchases_ChangeHandle();//刷新商品管理页面
            btNo_Click(null, null);//退出本页面
        }
        /// <summary>
        /// 进货数量输入格式是否正确
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void My_TextChanged(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex rex = new System.Text.RegularExpressions.Regex(@"^\d+$");
            if (!rex.IsMatch(txtNumber.Text))
            {
                txtNumber.Text = "";
            }
        }

        private void txtPerchasing_TextChanged(object sender, EventArgs e)
        {
/*            System.Text.RegularExpressions.Regex rex = new System.Text.RegularExpressions.Regex(@"^([1-9]\d*|([1-9]\d*|0)\.\d+)$");
            if (!rex.IsMatch(txtPerchasing.Text))
            {
                txtPerchasing.Text = "";
            }*/
        }
        /// <summary>
        /// 文本框文本是否为空
        /// </summary>
        /// <returns></returns>
        private bool iSEmptyTxt()
        {
            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("请输入商品名称");
                return false;
            }
            else if (txtNumber.Text.Length == 0 || txtNumber.Text == "0")
            {
                MessageBox.Show("请输入进价数量");
                return false;
            }
            else if (txtPerchasing.Text.Length == 0 || txtPerchasing.Text == "0")
            {
                MessageBox.Show("进价有误");
                return false;
            }
            else if (txtPrice.Text.Length == 0 || txtPrice.Text == "0")
            {
                MessageBox.Show("售价有误");
                return false;
            }
            else if (txtType.Text.Length == 0)
            {
                MessageBox.Show("请输入单位");
                return false;
            }
            return true;
        }
    }
}
