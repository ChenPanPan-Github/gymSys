using GymManagementSystem.BLL;
using GymManagementSystem.FORMS.OPERATOR;
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
    public delegate void FreshSimu();
    public partial class FormCommodity : Form
    {
        ManagerUser manager = new ManagerUser();
        FormPurchases purchases = new FormPurchases();

        public event FreshSimu EventSimu_Handle;

        public FormCommodity()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化商品页面
        /// </summary>
        public void InitCommodity()
        {
            dgvCommodity.Rows.Clear();
            var list = manager.CommodityList();

            EventSimu_Handle();

            if (list != null)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    dr.CreateCells(dgvCommodity);
                    dr.Cells[0].Value = i;
                    dgvCommodity.Rows.Insert(i, dr);
                }
                for (int i = 0; i < list.Count; i++)
                {
                    dgvCommodity.Rows[i].Cells["id"].Value = i + 1;
                    dgvCommodity.Rows[i].Cells["name"].Value = list[i].name;
                    dgvCommodity.Rows[i].Cells["type"].Value = list[i].type;
                    dgvCommodity.Rows[i].Cells["quantity"].Value = list[i].quantity;
                    dgvCommodity.Rows[i].Cells["purchasingprice"].Value = list[i].purchasingprice;
                    dgvCommodity.Rows[i].Cells["price"].Value = list[i].price;
                }
                return;
            }
            MessageBox.Show("没有商品");
        }

        private void FormCommodity_Load(object sender, EventArgs e)
        {
            purchases.Purchases_ChangeHandle += InitCommodity;
            InitCommodity();
        }

        private void btBuy_Click(object sender, EventArgs e)
        {
            purchases.ShowDialog();
        }
    }
}
