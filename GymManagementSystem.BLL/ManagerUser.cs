
using GymManagementSystem.DAL;
using GymManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GymManagementSystem.DAL.MySqlHelp;

namespace GymManagementSystem.BLL
{
    public class ManagerUser
    {
        MySqlHelp MySql = new MySqlHelp();

        /// <summary>
        /// 查询用户验证密码
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="password"></param>
        /// <param name="permission"></param>
        /// <returns></returns>
        public member_tb UserQuery(string userid, string password, string permission)
        {
            member_tb list = MySql.GetUserList().Find(num => num.userid == userid && num.password == password);
            if (list != null)
            {
                if (permission == "管理员" && list.permission == "777")
                {
                    return list;
                }
                else if (permission == "普通用户" && list.permission == "0")
                {
                    return list;
                }
            }
            return null;
        }

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="id"></param>
        /// <param name="psw"></param>
        /// <returns></returns>
        public bool RegisterUser(string id, string psw)
        {
            //验证是否重名
            var list = MySql.GetUserList().Find(num => num.userid == id);
            if (list != null)
            {
                return false;
            }

            member_tb user = new member_tb()
            {
                userid = id,
                password = psw,
                balance = 0,
                permission = "0",
                createtime = DateTime.Now
            };

            //插入数据
            MySql.InsertUser(user);

            return true;
        }

        /// <summary>
        /// 增加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool AddUser(member_tb user)
        {

            var list = MySql.GetUserList().Find(num => num.userid == user.userid);
            if (list != null)
            {
                return false;
            }
            MySql.InsertUser(user);
            return true;
        }

        /// <summary>
        /// 增加商品
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        public bool AddCommodity(commodity_tb ct)
        {
            var list = MySql.GetCommodyList().Find(num => num.name == ct.name);
            if (list != null)
            {
                return false;
            }
            MySql.AddCommodity_tb(ct);
            return true;
        }

        /// <summary>
        /// 增加consumption_tb
        /// </summary>
        /// <param name="ct"></param>
        public void InsertConsumption(consumption_tb ct)
        {
            MySql.AddConsumption(ct);
        }

        /// <summary>
        /// 查询用户数量
        /// </summary>
        /// <returns></returns>
        public int MebQuantityQuery()
        {
            var list = MySql.GetUserList();
            return list.Count;
        }

        /// <summary>
        /// 查询成员
        /// </summary>
        /// <returns></returns>
        public List<member_tb> MebList()
        {
            return MySql.GetUserList();
        }
        
        /// <summary>
        /// 查询商品
        /// </summary>
        /// <returns></returns>
        public List<commodity_tb> CommodityList()
        {
            return MySql.GetCommodyList();
        }

        /// <summary>
        /// 毛利率 净利率 月份消费额
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public Double GrossMarginQuery(int mode)
        {
            var list = MySql.GetConsumList().FindAll(user => user.time.ToString("MM") == DateTime.Now.ToString("MM"));
            if (list != null)
            {
                double totalin = 0;
                double totalout = 0;
                foreach (var item in list)
                {
                    totalin += item.totalin;
                    totalout += item.totalout;
                }
                if (mode == 1)
                {
                    return (1 - totalout / totalin) * 100;
                }
                else if (mode == 2)
                {
                    return (1 - (totalout + 500) / totalin) * 100;
                }
                else if (mode == 3)
                {
                    return totalin;
                }
            }
            return 0;
        }

        /// <summary>
        /// 根据id查询某一个用户
        /// </summary>
        /// <param name="mb"></param>
        /// <returns></returns>
        public member_tb FindUser(member_tb mb)
        {
            return MySql.GetUserList().Find(user => user.userid == mb.userid);
        }
        public member_tb FindUser(string mb)
        {
            return MySql.GetUserList().Find(user => user.userid == mb);
        }


        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="mb"></param>
        /// <returns></returns>
        public bool DeleteUser(member_tb mb)
        {
            //先查询是否有此实例
            var list = MySql.GetUserList().Find(num => num.userid == mb.userid);
            if (list != null)
            {
                //有的话删除
                int ret = MySql.DeleteMemberUser(list);
                if (ret != 0)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 修改member_tb
        /// </summary>
        /// <param name="mb"></param>
        /// <returns></returns>
        public bool UpdateUser(member_tb mb)
        {
            //先查询是否有此实例
            var list = MySql.GetUserList().Find(num => num.userid == mb.userid);
            if (list != null)
            {
                mb.id = list.id;
                int ret = MySql.UpdateMemberUser(mb);
                if (ret != 0)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 修改commodity_tb
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        public bool UpdateCommodity(commodity_tb ct)
        {
            //先查询是否有此实例
            var list = MySql.GetCommodyList().Find(num => num.name == ct.name);
            if (list != null)
            {
                ct.id = list.id;
                int ret = MySql.UpdateCommodity(ct);
                if (ret != 0)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
