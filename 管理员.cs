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
    public partial class 管理员 : Form
    {
        public 管理员()
        {
            InitializeComponent();
        }

        private void 会员卡信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            会员卡信息 hyk = new 会员卡信息();
            hyk.Show();
        }

        private void 教练员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            教练员 f = new 教练员();
            f.Show();
        }

        private void 课程信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new 课程信息().Show();
        }

        private void 会员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new 会员信息().Show();
        }

        private void 管理员_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string outStr = "";
            string inStr = "";
            SqlConnection conn = new SqlConnection("Server=.;Database=test;Trusted_Connection=yes");
            conn.Open();
            string str = "select * from Card where 编号 = '" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                outStr = sdr["有效天数"].ToString();
                
            }

            SqlConnection conn1 = new SqlConnection("Server=.;Database=test;Trusted_Connection=yes");
            conn1.Open();
            string str1 = "select * from Card where 编号 = '" + textBox2.Text + "'";
            SqlCommand cmd1 = new SqlCommand(str1, conn1);
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            while (sdr1.Read())
            {
                inStr = sdr1["有效天数"].ToString();
            }
            //得到新的天数
            inStr = (int.Parse(inStr) + int.Parse(outStr)).ToString();

            //更新到数据库

            SqlConnection conn2 = new SqlConnection("Server=.;Database=test;Trusted_Connection=yes");
            conn2.Open();
            string sqlUpdate = "update Card set 有效天数 ='" + inStr + "' where 编号 ='" + textBox2.Text + "'" + 
                               "update Card set 有效天数 ='" + "0"   + "' where 编号 ='" + textBox1.Text + "'";
            SqlCommand cmdUp = new SqlCommand(sqlUpdate, conn2);
            if (cmdUp.ExecuteNonQuery() == 0)
            {
                MessageBox.Show("未知错误!");
                return;
            }
            else
            {
                MessageBox.Show("恭喜你!修改成功!");
            }
            conn1.Close();
            conn2.Close();
            conn.Close();
        }
    }
}
