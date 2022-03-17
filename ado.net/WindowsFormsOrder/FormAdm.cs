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
using System.Collections;

namespace WindowsFormsOrder
{
    public partial class FormAdm : System.Windows.Forms.Form
    {
        public FormAdm()
        {
            InitializeComponent();
        }

        private void FormAdm_Load(object sender, EventArgs e)
        {            
            店家cbox();
            店家lbox();
        }

        void 店家lbox()
        {
            string str店資訊 = "";
            ArrayList 店資訊 = new ArrayList();
            GlobalVar.ShopInfo.Clear();

            SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
            con.Open();
            string strShop = "select * from mySHOP";
            SqlCommand cmd = new SqlCommand(strShop, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) 
            {
                str店資訊 = string.Format("{0} {1}", reader["SHOP_NAME"], reader["PHONE"]);
                lbox店家資訊.Items.Add(str店資訊);
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
            foreach (string i in GlobalVar.list店家)
            {
                cbox店家.Items.Add(i);
                //lbox店家資訊.Items.Add(i);
            }
            cbox店家.SelectedIndex = 0;
            reader.Close();
            con.Close();
        }

        void 菜單資訊()
        {
            GlobalVar.list菜單.Clear();
            lbox菜單.Items.Clear();
            SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
            con.Open();
            string strMenu = "select myShop.SHOP_NAME, myMenu.MEAL from myMenu join myShop on myMenu.SHOP_ID = myShop.SHOP_ID where SHOP_NAME = @name";
            SqlCommand cmd = new SqlCommand(strMenu, con);
            cmd.Parameters.AddWithValue("@name", cbox店家.SelectedItem);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                GlobalVar.list菜單.Add((string)reader["MEAL"]);
            }
            foreach (string i in GlobalVar.list菜單)
            {
                lbox菜單.Items.Add(i);
            }
            //lbox菜單.SelectedIndex = 0;
            reader.Close();
            con.Close();
        }

        private void lbox菜單_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lboxIndex = lbox菜單.SelectedIndex;
        }

        private void cbox店家_SelectedIndexChanged(object sender, EventArgs e)
        {
            string menu = "";
            GlobalVar.list菜單.Clear();
            lbox菜單.Items.Clear();
            SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
            con.Open();
            string strMenu = "select * from myMenu where SHOP_NAME = @name";
            SqlCommand cmd = new SqlCommand(strMenu, con);
            cmd.Parameters.AddWithValue("@name", cbox店家.SelectedItem);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                menu = string.Format("{0} {1}元", reader["MEAL"], reader["PRICE"]);
                lbox菜單.Items.Add(menu);
            }
            reader.Close();
            con.Close();            
        }

        private void btn新增菜色_Click(object sender, EventArgs e)
        {
            if (txt菜名.Text != "" && txt價錢.Text != "")
            {
                SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
                con.Open();
                
                string strMeal = "insert into myMenu values(@shop, @meal, @price)"; 
                SqlCommand cmd = new SqlCommand(strMeal, con);                
                cmd.Parameters.AddWithValue("@shop", cbox店家.SelectedItem);
                cmd.Parameters.AddWithValue("@meal", txt菜名.Text);
                int 價錢 = 0;
                Int32.TryParse(txt價錢.Text, out 價錢);
                cmd.Parameters.AddWithValue("@price", 價錢);
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("菜色已新增，影響資料筆數：" + rows.ToString());
                con.Close();
            }
            else
            {
                MessageBox.Show("菜名 、 價錢 必填!!!");
            }
            店家cbox();
            清空欄位();
            //店家lbox();           
        }

        private void btn移除品項_Click(object sender, EventArgs e)
        {
            
            if (txt菜名.Text != "")
            {
                DialogResult check = MessageBox.Show("確定要刪除此菜單?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
                    con.Open();
                    
                    string strDelete = "delete from myMenu where MEAL = @meal "; //SHOP_ID = @shopid and
                    SqlCommand cmd = new SqlCommand(strDelete, con);
                    cmd.Parameters.AddWithValue("@meal", txt菜名.Text);
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show("菜色已刪除，影響資料筆數：" + rows.ToString());
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("請輸入要刪除的菜名");
            }            
            店家cbox();
            清空欄位();
        }

        private void btn新增店家_Click(object sender, EventArgs e)
        {
            lbox店家資訊.Items.Clear();
            if (txt店名.Text !="" && txt電話.Text != "")
            {
                lbox店家資訊.Items.Clear();
                SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
                con.Open();

                string update = "insert into mySHOP values(@shopname, @phone)";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.Parameters.AddWithValue("@shopname", txt店名.Text);
                int 電話 = 0;
                Int32.TryParse(txt電話.Text, out 電話);
                cmd.Parameters.AddWithValue("@phone", 電話);
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("店家已新增，影響資料筆數：" + rows.ToString());

                con.Close();                
            }
            else
            {
                MessageBox.Show("店名 、 電話 必填!!!");
            }
            店家lbox();
            店家cbox();
            清空欄位();
        }

        private void btn移除店家_Click(object sender, EventArgs e)
        {
            lbox店家資訊.Items.Clear();
            移除店家();

            店家lbox();
            店家cbox();
            清空欄位();
        }

        void 移除店家()
        {
            if (txt店名.Text != "")
            {
                DialogResult check = MessageBox.Show("確定要刪除此店家?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    lbox店家資訊.Items.Clear();
                    SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
                    con.Open();

                    string strDelete = "delete from myShop where SHOP_NAME = @shopname";
                    SqlCommand cmd = new SqlCommand(strDelete, con);
                    cmd.Parameters.AddWithValue("@shopname", txt店名.Text);
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show("店家已刪除，影響資料筆數：" + rows.ToString());

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("請輸入要刪除的店家");
            }
        }
        void 移除店家所有菜單()
        {
            SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
            con.Open();

            string strDeleteAll = "delete from myMenu where SHOP_NAME = @shopname";
            SqlCommand cmd = new SqlCommand(strDeleteAll, con);
            cmd.Parameters.AddWithValue("@shopname", txt店名.Text);
            int rows = cmd.ExecuteNonQuery();
            MessageBox.Show("店家已刪除，影響資料筆數：" + rows.ToString());

            con.Close();
        }

        private void btn刪除全部_Click(object sender, EventArgs e)
        {
            lbox店家資訊.Items.Clear();

            if (txt店名.Text != "")
            {
                DialogResult check = MessageBox.Show("確定要刪除此店家及其所有菜單?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    lbox店家資訊.Items.Clear();
                    SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
                    con.Open();

                    string strDelete = "delete from myShop where SHOP_NAME = @shopname";
                    SqlCommand cmd = new SqlCommand(strDelete, con);
                    cmd.Parameters.AddWithValue("@shopname", txt店名.Text);
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show("店家已刪除，影響資料筆數：" + rows.ToString());

                    con.Close();
                    移除店家所有菜單();
                }
            }
            else
            {
                MessageBox.Show("請輸入要刪除的店家");
            }
            店家lbox();
            店家cbox();
            清空欄位();
        }

        void 清空欄位()
        {
            txt菜名.Text = "";
            txt價錢.Text = "";
            txt店名.Text = "";
            txt電話.Text = "";
        }
    }
}
