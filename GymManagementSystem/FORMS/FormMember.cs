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
using static GymManagementSystem.DAL.MySqlHelp;

namespace GymManagementSystem.FORMS
{
    public delegate void FreshCommodity();
    public delegate void FreshConsum();

    public partial class FormMember : Form
    {
        /// <summary>
        /// 子界面对象
        /// </summary>
        ManagerUser manager = new ManagerUser();
        FormAdd add = new FormAdd();
        FormDelete delete = new FormDelete();
        FormLookUp lookUp = new FormLookUp();
        FormUpdate update = new FormUpdate();

        public event FreshConsum FreshConsum_Handle;

        public FormMember()
        {
            InitializeComponent();
        }
        private void FormMember_Load(object sender, EventArgs e)
        {
            InitMember();
        }

        /// <summary>
        /// 初始化成员列表
        /// </summary>
        public void InitMember()
        {
            var list = manager.MebList();

            //刷新
            FreshConsum_Handle();

            //清空
            dgvMember.Rows.Clear();

            //添加数据单元
            if (list != null)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    dr.CreateCells(dgvMember);
                    dr.Cells[0].Value = i;
                    dgvMember.Rows.Insert(i, dr);
                }
                for (int i = 0; i < list.Count; i++)
                {
                    dgvMember.Rows[i].Cells["id"].Value = i + 1;
                    dgvMember.Rows[i].Cells["userid"].Value = list[i].userid;
                    dgvMember.Rows[i].Cells["password"].Value = list[i].password;
                    dgvMember.Rows[i].Cells["balance"].Value = list[i].balance;
                    if (list[i].permission == "0")
                    {
                        dgvMember.Rows[i].Cells["permission"].Value = "普通用户";
                    }
                    else if (list[i].permission == "777")
                    {
                        dgvMember.Rows[i].Cells["permission"].Value = "管理员";
                    }
                    dgvMember.Rows[i].Cells["createtime"].Value = list[i].createtime.ToString("yyyy.MM.dd");
                }
                return;
            }
            MessageBox.Show("没有会员");
        }

        #region 事件
        private void btAddUser_Click(object sender, EventArgs e)
        {
            add.EventFresh += InitMember;
            delete.Visible = false;
            lookUp.Visible = false;
            update.Visible = false;
            add.ShowDialog();
        }

        private void btDeleteUser_Click(object sender, EventArgs e)
        {
            delete.EventFresh += InitMember;
            add.Visible = false;
            lookUp.Visible = false;
            update.Visible = false;
            delete.ShowDialog();
        }

        private void btLookUpUser_Click(object sender, EventArgs e)
        {
            add.Visible = false;
            delete.Visible = false;
            update.Visible = false;
            lookUp.ShowDialog();
        }

        private void btUpDateUser_Click(object sender, EventArgs e)
        {
            add.Visible = false;
            delete.Visible = false;
            lookUp.Visible = false;
            update.EventFresh += InitMember;
            member_tb mb = new member_tb() {
                userid = dgvMember.Rows[dgvMember.CurrentCell.RowIndex].Cells["userid"].Value.ToString(),
                password = dgvMember.Rows[dgvMember.CurrentCell.RowIndex].Cells["password"].Value.ToString(),
                balance = Convert.ToDouble(dgvMember.Rows[dgvMember.CurrentCell.RowIndex].Cells["balance"].Value),
                permission = dgvMember.Rows[dgvMember.CurrentCell.RowIndex].Cells["permission"].Value.ToString(),
                createtime = Convert.ToDateTime(dgvMember.Rows[dgvMember.CurrentCell.RowIndex].Cells["createtime"].Value)
            };
            update.InitFormUpdateInfor(mb);
            update.ShowDialog();
        }

        private void btFresh_Click(object sender, EventArgs e)
        {
            InitMember();
        }

        #endregion


    }
}
