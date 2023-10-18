using GymManagementSystem.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.DAL
{
    public class MySqlHelp
    {
        /// <summary>
        /// 数据库配置
        /// </summary>
        private SqlSugarClient DB = new SqlSugarClient(new ConnectionConfig()
        {
            ConnectionString = "Data Source=127.0.0.1;User ID=root;Password=pan123;Database=gymsys_db;Charset=utf8",
            DbType = DbType.MySql,
            IsAutoCloseConnection = true,
            InitKeyType = InitKeyType.Attribute
        });

        #region 数据库操作

        /// <summary>
        /// 向member_tb表插入一条数据
        /// </summary>
        /// <param name="mb"></param>
        public void InsertUser(member_tb mb)
        {
            DB.Insertable<member_tb>(mb).ExecuteCommand();
        }

        /// <summary>
        /// 向consumption_tb插入一条数据
        /// </summary>
        /// <param name="ct"></param>
        public void AddConsumption(consumption_tb ct)
        {
            DB.Insertable<consumption_tb>(ct).ExecuteCommand();
        }

        /// <summary>
        /// 向commodity_tb插入一条数据
        /// </summary>
        /// <param name="ct"></param>
        public void AddCommodity_tb(commodity_tb ct)
        {
            DB.Insertable<commodity_tb>(ct).ExecuteCommand();
        }

        /// <summary>
        /// 连接数据库member_tb表查询所有用户信息
        /// </summary>
        /// <returns></returns>
        public List<member_tb> GetUserList()
        {
            return DB.Queryable<member_tb>().ToList();
        }

        /// <summary>
        /// 获取consumption_tb集合
        /// </summary>
        /// <returns></returns>
        public List<consumption_tb> GetConsumList()
        {
            return DB.Queryable<consumption_tb>().ToList();
        }

        /// <summary>
        /// 获取commodity_tb集合
        /// </summary>
        /// <returns></returns>
        public List<commodity_tb> GetCommodyList()
        {
            return DB.Queryable<commodity_tb>().ToList();
        }

        /// <summary>
        /// 删除member_tb一条用户的记录
        /// </summary>
        /// <param name="mb"></param>
        /// <returns></returns>
        public int DeleteMemberUser(member_tb mb)
        {
            return DB.Deleteable<member_tb>(mb).ExecuteCommand();
        }

        /// <summary>
        /// 修改member_tb数据
        /// </summary>
        /// <param name="mb"></param>
        /// <returns></returns>
        public int UpdateMemberUser(member_tb mb)
        {
            return DB.Updateable<member_tb>(mb).ExecuteCommand();
        }

        /// <summary>
        /// 修改commodity_tb数据
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        public int UpdateCommodity(commodity_tb ct)
        {
            return DB.Updateable<commodity_tb>(ct).ExecuteCommand();
        }

        #endregion

        #region table
        /// <summary>
        /// member_tb表
        /// </summary>
        public class member_tb
        {
            [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
            public int id { get; set; }//id自增
            public string userid { get; set; }//用户名
            public string password { get; set; }//密码
            public Double balance { get; set; }//余额
            public string permission { get; set; }//权限
            public DateTime createtime { get; set; }//时间
        }

        /// <summary>
        /// consumption_tb表
        /// </summary>
        public class consumption_tb
        {
            [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
            public int id { get; set; }//id自增
            public double totalout { get; set; }//收入总额
            public double totalin { get; set; }//进货总额
            public DateTime time { get; set; }//时间
        }

        /// <summary>
        /// commodity_tb表
        /// </summary>
        public class commodity_tb
        {
            [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
            public int id { get; set; }//id自增
            public string name { get; set; }//名称
            public string type { get; set; }//类型
            public int quantity { get; set; }//数量
            public double purchasingprice { get; set; }//进价
            public double price { get; set; }//售价
        }

        #endregion

    }
}
