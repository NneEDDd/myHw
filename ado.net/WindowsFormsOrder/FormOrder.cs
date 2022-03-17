using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //ADO.net元件

namespace WindowsFormsOrder
{
    public partial class FormOrder : System.Windows.Forms.Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            班級cbox();            
        }
        
        void 班級cbox()
        {
            GlobalVar.list班級.Clear();
            cbox班級.Items.Clear();

            SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
            con.Open();

            string strClass = "select CLASS from myOrder GROUP BY CLASS";
            SqlCommand cmd = new SqlCommand(strClass, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                GlobalVar.list班級.Add((string)reader["CLASS"]);                
            }
            foreach (string 班級 in GlobalVar.list班級)
            {
                cbox班級.Items.Add(班級);
            }
            cbox班級.SelectedIndex = 0;
            reader.Close();
            con.Close();

        }

        
        void 店家lbox()
        {
            SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
            con.Open();

            string strShopInfo = "select * from myShop";
            SqlCommand cmd = new SqlCommand(strShopInfo, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string str店家資訊 = string.Format("{0} {1}", reader["SHOP_NAME"], reader["PHONE"]);
                lbox店家.Items.Add(str店家資訊);
            }
            reader.Close();
            con.Close();

        }

        private void cbox班級_SelectedIndexChanged(object sender, EventArgs e)
        {            
            lbox品項.Items.Clear();
            lbox店家.Items.Clear();

            品項();
            總金額();
            商店();            
        }
        void 品項()
        {
            lbox品項.Items.Clear();
            SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
            con.Open();

            string order = "";
            string strMenu = "select (select CLASS from myAccount where myAccount.ACCOUNT = myOrder.ACCOUNT) AS CLASS, myOrder.ACCOUNT, myOrder.SHOP_NAME, myOrder.ITEM, myOrder.QTY, (myOrder.QTY * myMenu.PRICE) TOTAL FROM myOrder JOIN myMenu ON myOrder.ITEM = myMenu.MEAL where CLASS = @class order by SHOP_NAME";
            SqlCommand cmd = new SqlCommand(strMenu, con);
            cmd.Parameters.AddWithValue("@class", cbox班級.SelectedItem);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                order = string.Format("帳號:{0} {1} {2} {3}份 {4}元", reader["ACCOUNT"], reader["SHOP_NAME"], reader["ITEM"], reader["QTY"], reader["TOTAL"]);
                lbox品項.Items.Add(order);
            }
            reader.Close();
            con.Close();
        }

        void 總金額()
        {
            SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
            con.Open();
            string Total_price = "select C.CLASS, SUM(CONVERT(INT,(B.PRICE * A.QTY))) TOTAL from myOrder A, myMenu B ,myAccount C where A.ITEM = B.MEAL AND A.ACCOUNT = C.ACCOUNT AND A.CLASS = C.CLASS AND A.CLASS = @class group by C.CLASS";
            SqlCommand cmd = new SqlCommand(Total_price, con);
            cmd.Parameters.AddWithValue("@class", cbox班級.SelectedItem);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lbl金額.Text = string.Format("{0}", reader["TOTAL"]);
            }

            reader.Close();
            con.Close();
        }

        void 商店()
        {
            SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
            con.Open();

            string shop = "";            
            string strshop = "select myOrder.CLASS, myOrder.SHOP_NAME, myShop.PHONE from myShop join myOrder on myShop.SHOP_NAME = myOrder.SHOP_NAME WHERE CLASS = @class group by myOrder.CLASS, myOrder.SHOP_NAME, myShop.PHONE";
            SqlCommand cmd = new SqlCommand(strshop, con);
            cmd.Parameters.AddWithValue("@class", cbox班級.SelectedItem);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                shop = string.Format("{0} {1}", reader["SHOP_NAME"], reader["PHONE"]);
                lbox店家.Items.Add(shop);
            }
            reader.Close();
            con.Close();
        }
    }
}
