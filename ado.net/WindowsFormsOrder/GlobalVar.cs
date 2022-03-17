using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;  // 新增


namespace WindowsFormsOrder
{
    class GlobalVar
    {
        public static string myDBconStr = @"Data Source=.;Initial Catalog=myOrder;Integrated Security=True";
        public static string 帳號, 密碼, 班級; 
        public static ArrayList ShopInfo = new ArrayList();        

        public static List<string> list店家 = new List<string>();
        public static List<string> list菜單 = new List<string>();
        public static List<string> list班級 = new List<string>();
        public static List<string> list訂單 = new List<string>();

    }
}
