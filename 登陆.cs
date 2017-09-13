using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class 登陆 : Form
    {
        public 登陆()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chuanzhi.temp = textBox1.Text;
            string UserName = textBox1.Text.Trim();
            string UserPassWord = textBox2.Text.Trim();
            string typeStr = comboBox1.Text;
            //连接本地数据库
            SqlConnection conn = new SqlConnection("Server=.;Database=test;Trusted_Connection=yes");
            conn.Open();
            string str = "select count(*) from UserTable where UserName='" + UserName + "' and PassWord='" + UserPassWord + "' and Type='" + typeStr + "'";
            //用于检索表中第一行是否有数据！
            SqlCommand cmd = new SqlCommand(str, conn);
            int n = (int)cmd.ExecuteScalar();
            if (n >= 1)
            {
                if (comboBox1.Text.Equals("管理员"))
                {
                    管理员 f2 = new 管理员();//跳转到管理员模块
                    
                    f2.Show();
                }
                else if (comboBox1.Text.Equals("会员"))//会员登陆进入这里
                {
                    会员 f3 = new 会员();
                    f3.Text = UserName;
                    f3.Show();
                }
               
            }
            else
            {
                MessageBox.Show("您输入的用户名或密码有误，请重新输入！");
            }
        }
    }
}
