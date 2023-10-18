using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Model
{
    public class Consumer
    {
        //会员数量
        public int userNum { get; set; }
        //毛利率
        public double Gross { get; set; }
        //净利率
        public double netMargin { get; set; }
        //月份消费额
        public double myProperty { get; set; }
    }
}
