using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GymManagementSystem.Model
{
    
    public class UserInfo
    {
        public string userid { get; set; }//用户名
        public string password { get; set; }//密码
        public Double balance { get; set; }//余额
        public string permission { get; set; }//权限
        public DateTime registime { get; set; }//时间

    }

}
