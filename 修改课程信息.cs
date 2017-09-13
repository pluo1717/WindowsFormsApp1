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
    public partial class 修改课程信息 : Form
    {
        public 修改课程信息()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=.;Database=test;Trusted_Connection=yes");
            conn.Open();
            if (comboBox1.Text.Equals("课程内容"))
            {
                string sqlUpdate = "update KC set 课程内容 ='" + textBox2.Text + "' where 课程内容 ='" + textBox1.Text + "'";
                SqlCommand cmdUp = new SqlCommand(sqlUpdate, conn);
                if (cmdUp.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("未知错误!");
                    return;
                }
                else
                {
                    MessageBox.Show("恭喜你!修改成功!");
                }
            }
            else if (comboBox1.Text.Equals("上课时间"))
            {
                string sqlUpdate = "update KC set 上课时间 ='" + textBox2.Text + "' where 上课时间 ='" + textBox1.Text + "'";
                SqlCommand cmdUp = new SqlCommand(sqlUpdate, conn);
                if (cmdUp.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("未知错误!");
                    return;
                }
                else
                {
                    MessageBox.Show("恭喜你!修改成功!");
                }
            }
            else if (comboBox1.Text.Equals("上课地点"))
            {
                string sqlUpdate = "update KC set 上课地点 ='" + textBox2.Text + "' where 上课地点 ='" + textBox1.Text + "'";
                SqlCommand cmdUp = new SqlCommand(sqlUpdate, conn);
                if (cmdUp.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("未知错误!");
                    return;
                }
                else
                {
                    MessageBox.Show("恭喜你!修改成功!");
                }
            }
            else if (comboBox1.Text.Equals("教练"))
            {
                string sqlUpdate = "update KC set 教练 ='" + textBox2.Text + "' where 教练 ='" + textBox1.Text + "'";
                SqlCommand cmdUp = new SqlCommand(sqlUpdate, conn);
                if (cmdUp.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("未知错误!");
                    return;
                }
                else
                {
                    MessageBox.Show("恭喜你!修改成功!");
                }
            }
            else if (comboBox1.Text.Equals("课程学费"))
            {
                string sqlUpdate = "update KC set 课程学费 ='" + textBox2.Text + "' where 课程学费 ='" + textBox1.Text + "'";
                SqlCommand cmdUp = new SqlCommand(sqlUpdate, conn);
                if (cmdUp.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("未知错误!");
                    return;
                }
                else
                {
                    MessageBox.Show("恭喜你!修改成功!");
                }
            }
            conn.Close();
        }
    }
}
