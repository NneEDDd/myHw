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
    public partial class FormLogin : System.Windows.Forms.Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }       
        
        private void FormLogin_Load(object sender, EventArgs e)
        {           
                //btn學員.Enabled = true;           
        }

        private void btn學員_Click(object sender, EventArgs e)
        {
            string 學員 = "100";
            GlobalVar.帳號 = txt帳號.Text;
            GlobalVar.密碼 = txt密碼.Text;
            SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
            con.Open();

            string strSQL = "select * from myAccount where ACCOUNT = @acco and PASSWORD = @pass and CAN_DO = @can";
           
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@acco", GlobalVar.帳號);
            cmd.Parameters.AddWithValue("@pass", GlobalVar.密碼);
            cmd.Parameters.AddWithValue("@can", 學員);
            
            SqlDataReader reader = cmd.ExecuteReader();

            if (txt帳號.Text !="" && txt密碼.Text != "")
            {
                if (reader.HasRows)
                {
                    //this.Hide();
                    FormStu form學員登入 = new FormStu();
                    form學員登入.ShowDialog();
                }
                else
                {
                    MessageBox.Show("權限不足");
                }
            }
            else
            {
                MessageBox.Show("帳號或密碼輸入錯誤");
            }
            
        }

        private void btn值日生_Click(object sender, EventArgs e)
        {            
            string 值日生 = "10";
            GlobalVar.帳號 = txt帳號.Text;
            GlobalVar.密碼 = txt密碼.Text;
            SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
            con.Open();

            string strSQL = "select * from myAccount where ACCOUNT = @acco and PASSWORD = @pass and CAN_DO = @can";
            
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@acco", GlobalVar.帳號);
            cmd.Parameters.AddWithValue("@pass", GlobalVar.密碼);
            cmd.Parameters.AddWithValue("@can", 值日生);
            SqlDataReader reader = cmd.ExecuteReader();
            
            if (txt帳號.Text !="" && txt密碼.Text != "")
            {
                if (reader.HasRows)
                {
                    //this.Hide();
                    FormOrder form值日生登入 = new FormOrder();
                    form值日生登入.ShowDialog();
                }
                else
                {
                    MessageBox.Show("權限不足");
                }
            }            
            else
            {
                MessageBox.Show("帳號或密碼輸入錯誤");
            }
            
        }

        private void btn管理員_Click(object sender, EventArgs e)
        {
            string 管理員 = "1";
            GlobalVar.帳號 = txt帳號.Text;
            GlobalVar.密碼 = txt密碼.Text;
            SqlConnection con = new SqlConnection(GlobalVar.myDBconStr);
            con.Open();

            string strSQL = "select * from myAccount where ACCOUNT = @acco and PASSWORD = @pass and CAN_DO = @can";
            
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@acco", GlobalVar.帳號);
            cmd.Parameters.AddWithValue("@pass", GlobalVar.密碼);
            cmd.Parameters.AddWithValue("@can", 管理員);
            SqlDataReader reader = cmd.ExecuteReader();

            if (txt帳號.Text !="" && txt密碼.Text != "")
            {
                if (reader.HasRows)
                {
                    //this.Hide();
                    FormAdm form管理員登入 = new FormAdm();
                    form管理員登入.ShowDialog();
                }
                else
                {
                    MessageBox.Show("權限不足");
                }
            }            
            else
            {
                MessageBox.Show("帳號或密碼輸入錯誤");
            }
        }

        private void btn關閉_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
