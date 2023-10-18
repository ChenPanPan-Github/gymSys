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

namespace GymManagementSystem.FORMS
{
    public partial class FormSimulatedConsum : Form
    {
        ManagerUser manager = new ManagerUser();
        List<commodity_tb> list = new List<commodity_tb>();
        consumption_tb consumption = new consumption_tb();

        public event FreshConsum FreshConsum_Handle;
        public event FreshCommodity EventFresh;

        static int idNumber = 0;

        public FormSimulatedConsum()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 本页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSimulatedConsum_Load(object sender, EventArgs e)
        {
            //InitConsumption();
            dgvSimConsum.Rows.Clear();
            InitSimulate();
            txtUserId.Text = "请先输入会员卡号";
            txtUserId.ForeColor = Color.FromArgb(133, 109, 114);
        }

        /// <summary>
        /// 初始化comchoose选项
        /// </summary>
        public void InitSimulate()
        {
            comChoose.Items.Clear();
            list = manager.CommodityList();
            foreach (var item in list)
            {
                if (item.quantity > 0)
                {
                    comChoose.Items.Add(item.name);
                }
            }
        }

        /// <summary>
        /// 清单购买
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private bool CanBugSth(member_tb user)
        {
            consumption.totalin = 0;//收入
            consumption.totalout = 0;//进货
            commodity_tb ct;//商品
            int number;//商品数量
            string name;//商品名

            //统计收入和进货
            foreach (DataGridViewRow row in dgvSimConsum.Rows)
            {
                number = Convert.ToInt32(row.Cells["number"].Value);//数量
                name = Convert.ToString(row.Cells["name"].Value.ToString());

                ct = list.Find(com => com.name == name);

                consumption.totalin += number * ct.price;//收入
                consumption.totalout += number * ct.purchasingprice;//进货
            }

            //用户余额是否充足
            if (user.balance < consumption.totalin)
            {
                MessageBox.Show("账户余额不足");
                return false;
            }

            //更新用户表，数据余额变动
            user.balance -= consumption.totalin;
            if (!manager.UpdateUser(user))
            {
                return false;
            }

            //更新消费表，添加进消费表
            consumption.time = DateTime.Now;
            manager.InsertConsumption(consumption);

            //更新商品表，从商品表里面删除对应的数量
            foreach (DataGridViewRow row in dgvSimConsum.Rows)
            {
                number = Convert.ToInt32(row.Cells["number"].Value);//数量
                name = Convert.ToString(row.Cells["name"].Value.ToString());

                ct = list.Find(com => com.name == name);
                ct.quantity -= number;
                if (!manager.UpdateCommodity(ct))
                {
                    return false;
                }
            }

            //清空界面数据,刷新数据
            btClear_Click(null, null);
            FreshConsum_Handle();
            EventFresh();
            return true;
        }

        #region 事件
        /// <summary>
        /// 购买
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btBuy_Click(object sender, EventArgs e)
        {
            //是否有清单
            if (dgvSimConsum.Rows.Count == 0)
            {
                MessageBox.Show("请先下订单");
                return;
            }

            //是否有此用户
            var user = manager.FindUser(txtUserId.Text);
            if (user == null)
            {
                MessageBox.Show("账户错误");
                return;
            }
            if (CanBugSth(user))
            {
                MessageBox.Show("购买完成");
                return;
            }
        }

        /// <summary>
        /// 加入清单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAdd_Click(object sender, EventArgs e)
        {
            //是否填写商品和数量
            if (comChoose.Text == "")
            {
                MessageBox.Show("请选择商品");
                return;
            }
            else if (txtNumber.Text == "")
            {
                MessageBox.Show("数量不能为空");
                return;
            }
            else if (Convert.ToInt32(txtNumber.Text) == 0)
            {
                MessageBox.Show("数量不能为0");
                return;
            }
            commodity_tb ct = list.Find(com => com.name == comChoose.Text);
            if (ct.quantity == 0)
            {
                MessageBox.Show("加入清单失败，库存不足");
                return;
            }

            //查看清单中是否有该商品
            foreach (DataGridViewRow row in dgvSimConsum.Rows)
            {
                string name = Convert.ToString(row.Cells["name"].Value.ToString());

                //有就增加数量，然后退出
                if (name == comChoose.Text.ToString())
                {
                    int ComdNumber = Convert.ToInt32(txtNumber.Text) + Convert.ToInt32(row.Cells["number"].Value);
                    //商品库存是否充足
                    if (Convert.ToInt32(txtNumber.Text) > ct.quantity - ComdNumber)
                    {
                        MessageBox.Show("加入清单失败，库存不足");
                        return;
                    }
                    row.Cells["number"].Value = ComdNumber;
                    return;
                }
            }

            //创建一行将其加入到dgvSimConsum。
            DataGridViewRow dr = new DataGridViewRow();
            dr.CreateCells(dgvSimConsum);
            dr.Cells[idNumber].Value = idNumber;
            dgvSimConsum.Rows.Insert(idNumber, dr);

            var comd = list.Find(cd => cd.name == comChoose.Text);
            //
            dgvSimConsum.Rows[idNumber].Cells["id"].Value = idNumber + 1;
            dgvSimConsum.Rows[idNumber].Cells["name"].Value = comChoose.Text;
            dgvSimConsum.Rows[idNumber].Cells["price"].Value = comd.price;
            dgvSimConsum.Rows[idNumber].Cells["number"].Value = txtNumber.Text;
            dgvSimConsum.Rows[idNumber].Cells["totalPrice"].Value = comd.price * Convert.ToInt32(txtNumber.Text);
            dgvSimConsum.Rows[idNumber].Cells["deleCdy"].Value = "×";

            idNumber++;
        }

        /// <summary>
        /// 删除选定的那一行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSimConsum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (idNumber <= 0) return;
            dgvSimConsum.Rows.Remove(dgvSimConsum.SelectedRows[0]);
            idNumber--;
        }

        /// <summary>
        /// 验证数量输入格式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex rex = new System.Text.RegularExpressions.Regex(@"^\d+$");
            if (!rex.IsMatch(txtNumber.Text))
            {
                txtNumber.Text = "";
            }
        }

        /// <summary>
        /// 清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClear_Click(object sender, EventArgs e)
        {
            dgvSimConsum.Rows.Clear();
            idNumber = 0;
            txtUserId.Text = "";
            txtNumber.Text = "";
            comChoose.Text = "";
        }

        /// <summary>
        /// 清空用户名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbClear_Click(object sender, EventArgs e)
        {
            txtUserId.Text = "";
        }
        #endregion

    }
}
