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
    public partial class 添加会员会员卡信息 : Form
    {
        public 添加会员会员卡信息()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Sql = "server=.;integrated security=sspi;database=test";
            SqlConnection con = new SqlConnection(Sql);
            string cmd = "INSERT INTO Card VALUES('" + textBox1.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "')"
                + "INSERT INTO HY VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')"
                + "Insert into UserTable values('" + textBox1.Text + "','123','会员')"; 
            SqlCommand com = new SqlCommand(cmd, con);
            con.Open();
            if (com.ExecuteNonQuery() != 0)//ExecuteNonQuery方法返回的值为0，则说明更新操作失败
            {
                MessageBox.Show("添加成功！默认密码为123");
            }
            else
                MessageBox.Show("添加失败！");
            con.Close();//关闭
        }
    }
}
