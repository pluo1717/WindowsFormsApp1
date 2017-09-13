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
    public partial class 添加教练员信息 : Form
    {
        public 添加教练员信息()
        {
            InitializeComponent();
        }

        private void 添加教练员信息_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Sql = "server=.;integrated security=sspi;database=test";
            SqlConnection con = new SqlConnection(Sql);
            string cmd = "INSERT INTO JLY VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            SqlCommand com = new SqlCommand(cmd, con);
            con.Open();
            if (com.ExecuteNonQuery() != 0)//ExecuteNonQuery方法返回的值为0，则说明更新操作失败
            {
                MessageBox.Show("添加成功！");
            }
            else
                MessageBox.Show("添加失败！");
            con.Close();//关闭
        }
    }
}
