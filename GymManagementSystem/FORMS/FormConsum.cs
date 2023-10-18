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

namespace GymManagementSystem.FORMS
{
    public partial class FormConsum : Form
    {
        ManagerUser manager = new ManagerUser();
        public FormConsum()
        {
            InitializeComponent();
        }

        private void FormConum_Load(object sender, EventArgs e)
        {
            InitFormConum();
        }

        /// <summary>
        /// 数据计算
        /// </summary>
        public void InitFormConum()
        {
            //统计会员数量
            lbMebQuantity.Text = manager.MebQuantityQuery().ToString() + "个";

            //计算毛利率
            lbGrossMargin.Text = manager.GrossMarginQuery(1).ToString("F3") + "%";

            //计算净利率
            lbNetMargin.Text = manager.GrossMarginQuery(2).ToString("F3") + "%";

            //计算月份消费额
            lbMonConsum.Text = manager.GrossMarginQuery(3).ToString("F2") + "￥";
        }

    }
}
