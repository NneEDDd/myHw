using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            FLP.Controls.Clear();
            int i;
            Int32.TryParse(txt.Text, out i);
            for (int j = 0; j < i; j++)
            {                
                Button button1 = new Button();
                //button1.DialogResult = DialogResult.OK;                
                string k = Convert.ToString(j + 1);
                button1.Text = k; // .Text = j.ToString()
                FLP.Controls.Add(button1);                
                button1.Click += Button1_Click;
            }
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {  
            
            MessageBox.Show("這是第" + ((Button)(sender)).Text + "個");
            
        }
    }
}
