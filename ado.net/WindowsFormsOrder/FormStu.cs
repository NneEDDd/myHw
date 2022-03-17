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
    public partial class FormStu : System.Windows.Forms.Form
    {
        public FormStu()
        {
            InitializeComponent();
        }

        private void FormStu_Load(object sender, EventArgs e)
        {
            lbl學員1.Text = GlobalVar.帳號;
            lbl學員2.Text = GlobalVar.帳號;
            int 數量 = 1;
            txt數量.Text = 數量.ToString();
            lbl總價.Text = "";
            lbl總金額.Text = "";
            
            店家cbox();
            訂單lbox();
            總金額lbl();
            
        }

        void 訂單lbox()
        {
            lbox訂單.Items.Clear();
            string 訂單 = "";
            SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
            con.Open();

            string strOrder = "select myOrder.ACCOUNT, myOrder.SHOP_NAME, myOrder.ITEM, myOrder.QTY, (myOrder.QTY * myMenu.PRICE) TOTAL from myOrder join myMenu on myOrder.ITEM = myMenu.MEAL where ACCOUNT = @acco";
            SqlCommand cmd = new SqlCommand(strOrder, con);
            cmd.Parameters.AddWithValue("@acco", GlobalVar.帳號);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                訂單 = string.Format("{0} {1} {2}份 {3}元",reader["SHOP_NAME"], reader["ITEM"], reader["QTY"], reader["TOTAL"]);
                lbox訂單.Items.Add(訂單);
            }

            reader.Close();
            con.Close();
        }
        
        void 總金額lbl()
        {
            lbl總金額.Text = "";
            SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
            con.Open();

            string strOrder = "select SUM(CONVERT(INT,(A.QTY * B.PRICE))) TOTAL from myOrder A, myMenu B where ITEM = MEAL and A.ACCOUNT = @acco group by A.ACCOUNT";
            SqlCommand cmd = new SqlCommand(strOrder, con);
            cmd.Parameters.AddWithValue("@acco", GlobalVar.帳號);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lbl總金額.Text = string.Format("{0}元", reader["TOTAL"]);
            }

            reader.Close();
            con.Close();
            
        }

        void 店家cbox()
        {
            GlobalVar.list店家.Clear();
            cbox店家.Items.Clear();
            SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
            con.Open();
            string strShop = "select * from myShop";
            SqlCommand cmd = new SqlCommand(strShop, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                GlobalVar.list店家.Add((string)reader["SHOP_NAME"]);
            }
            foreach (string 店名 in GlobalVar.list店家)
            {
                cbox店家.Items.Add(店名);
            }
            cbox店家.SelectedIndex = 0;
            reader.Close();
            con.Close();
        }

        void 找班級()
        {            
            SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
            con.Open();

            string strClass = "select CLASS from myAccount where ACCOUNT = @acco";
            SqlCommand cmd = new SqlCommand(strClass, con);
            cmd.Parameters.AddWithValue("@acco", lbl學員1.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                GlobalVar.班級 = String.Format("{0}", reader["CLASS"]);
            }
        }
        private void btn訂購_Click(object sender, EventArgs e)
        {
            if (lbox品項.SelectedIndex > -1)
            {
                lbox訂單.Items.Clear();
                找班級();

                SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
                con.Open();

                string strOrder = "insert into myOrder values(@acco, @class, @shopname, @item, @qty)";
                SqlCommand cmd = new SqlCommand(strOrder, con);
                cmd.Parameters.AddWithValue("@acco", GlobalVar.帳號);
                cmd.Parameters.AddWithValue("@class", GlobalVar.班級);
                cmd.Parameters.AddWithValue("@shopname", cbox店家.SelectedItem);
                cmd.Parameters.AddWithValue("@item", lbox品項.SelectedItem);
                int 數量 = 0;
                Int32.TryParse(txt數量.Text, out 數量);
                cmd.Parameters.AddWithValue("@qty", 數量);
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("訂單已新增：" + rows.ToString() + "筆");

                con.Close();
            }
            else
            {
                MessageBox.Show("請選擇商品");
            }
            

            訂單lbox();
            總金額lbl();
        }

        private void cbox店家_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str菜單資訊 = "";
            string strPrice = "";
            lbl單價.Text = "";
            lbl總價.Text = "";
            GlobalVar.list菜單.Clear();
            lbox品項.Items.Clear();
            SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
            con.Open();

            string strMenu = "select * from myMenu where SHOP_NAME = @name";
            SqlCommand cmd = new SqlCommand(strMenu, con);
            cmd.Parameters.AddWithValue("@name", cbox店家.SelectedItem);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) //價錢要怎麼靠右??
            {
                str菜單資訊 = string.Format("{0}", reader["MEAL"]);
                
                lbox品項.Items.Add(str菜單資訊);
                
                if(lbox品項.SelectedIndex > -1)
                {
                    lbl單價.Text = strPrice.ToString();
                }                
            }
            reader.Close();
            con.Close();         
        }

        private void lbox品項_SelectedIndexChanged(object sender, EventArgs e)
        {
            價錢();                        
        }

        private void txt數量_TextChanged(object sender, EventArgs e)
        {
            價錢();
        }
        void 價錢()
        {
            if (lbox品項.SelectedIndex > -1)
            {
                string price = "";
                int 單價 = 0;
                int 數量 = 1;
                
                string 顯示 = lbox品項.SelectedItem.ToString();

                SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
                con.Open();

                string strPrice = "select PRICE from myMenu where MEAL = @meal";
                SqlCommand cmd = new SqlCommand(strPrice, con);
                cmd.Parameters.AddWithValue("@meal", 顯示);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    price = string.Format("{0}", reader["PRICE"]);
                    lbl單價.Text = price + "元";

                    if (txt數量.Text != "")
                    {
                        Int32.TryParse(txt數量.Text, out 數量);
                        單價 = (int)reader["PRICE"];
                        lbl總價.Text = (數量 * 單價).ToString() + "元";   
                    }
                    else
                    {
                        //數量 = 1;
                    }
                }
            }
        }

        private void btn刪除項目_Click(object sender, EventArgs e)
        {
            lbox訂單.Items.Clear();
            
            if (txt刪除.Text != "")
            {
                DialogResult check = MessageBox.Show("確定要刪除這個品項?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
                    con.Open();

                    string strDelete = "delete from myOrder where ACCOUNT = @acco and ITEM = @item";
                    SqlCommand cmd = new SqlCommand(strDelete, con);
                    cmd.Parameters.AddWithValue("@acco", lbl學員2.Text);
                    cmd.Parameters.AddWithValue("@item", txt刪除.Text);
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show("品項已刪除");
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("請輸入要刪除的菜名");
            }
            訂單lbox();
            總金額lbl();
            txt刪除.Text = "";
        }

        private void btn清除訂單_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("確定要清空所有訂單?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (check == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
                con.Open();

                string strDeleteALL = "delete from myOrder where ACCOUNT = @acco";
                SqlCommand cmd = new SqlCommand(strDeleteALL, con);
                cmd.Parameters.AddWithValue("@acco", lbl學員2.Text);
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("訂單已全部清除，影響資料筆數：" + rows.ToString() + "筆");
                con.Close();                
            }
            訂單lbox();
            總金額lbl();
        }
    }
}
