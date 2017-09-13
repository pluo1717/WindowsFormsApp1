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
    public partial class 会员卡信息 : Form
    {
        public 会员卡信息()
        {
            InitializeComponent();
            LoadListView();
        }
        /// <summary>
        /// 初始化列表
        /// </summary>
        void LoadListView()
        {
            listView1.View = View.Details;
            //listView1.CheckBoxes = true;
            listView1.CheckBoxes = true;
            listView1.GridLines = true;
            listView1.Columns.Add("编号", 63, HorizontalAlignment.Center);
            listView1.Columns.Add("名称", 63, HorizontalAlignment.Center);
            listView1.Columns.Add("有效次数", 63, HorizontalAlignment.Center);
            listView1.Columns.Add("有效天数", 63, HorizontalAlignment.Center);
            listView1.Columns.Add("售价", 63, HorizontalAlignment.Center);
            listView1.Columns.Add("折扣", 63, HorizontalAlignment.Center);
            listView1.Columns.Add("状态", 63, HorizontalAlignment.Center);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlConnection conn = new SqlConnection("Server=.;Database=test;Trusted_Connection=yes");
            conn.Open();
            string str = "select * from Card";
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                //构建一个ListView的数据，存入数据库数据，以便添加到listView1的行数据中
                ListViewItem lt = new ListViewItem();
                //将数据库数据转变成ListView类型的一行数据
                lt.Text = sdr["编号"].ToString();
                lt.SubItems.Add(sdr["名称"].ToString());
                lt.SubItems.Add(sdr["有效次数"].ToString());
                lt.SubItems.Add(sdr["有效天数"].ToString());
                lt.SubItems.Add(sdr["售价"].ToString());
                lt.SubItems.Add(sdr["折扣"].ToString());
                lt.SubItems.Add(sdr["使用状态"].ToString());
                //将lt数据添加到listView1控件中
                listView1.Items.Add(lt);
            }
            conn.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            添加会员会员卡信息 tjhyhyk = new 添加会员会员卡信息();
            tjhyhyk.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=.;Database=test;Trusted_Connection=yes");
            conn.Open();
            if (comboBox1.Text.Equals("名称"))
            {
                string sqlUpdate = "update Card set 名称 ='" + textBox2.Text + "' where 名称 ='" + textBox1.Text + "'";
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
            else if (comboBox1.Text.Equals("有效次数"))
            {
                string sqlUpdate = "update Card set 有效次数 ='" + textBox2.Text + "' where 有效次数 ='" + textBox1.Text + "'";
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
            else if (comboBox1.Text.Equals("有效天数"))
            {
                string sqlUpdate = "update Card set 有效天数 ='" + textBox2.Text + "' where 有效天数 ='" + textBox1.Text + "'";
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
            else if (comboBox1.Text.Equals("售价"))
            {
                string sqlUpdate = "update Card set 售价 ='" + textBox2.Text + "' where 售价 ='" + textBox1.Text + "'";
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
            else if (comboBox1.Text.Equals("折扣"))
            {
                string sqlUpdate = "update Card set 折扣 ='" + textBox2.Text + "' where 折扣 ='" + textBox1.Text + "'";
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
            else if (comboBox1.Text.Equals("使用状态"))
            {
                string sqlUpdate = "update Card set 使用状态 ='" + textBox2.Text + "' where 使用状态 ='" + textBox1.Text + "'";
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

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView1.CheckedItems)
            {
            
                lvi.Remove();
                SqlConnection conn = new SqlConnection("Server=.;Database=test;Trusted_Connection=yes");
                conn.Open();
                string[] a = lvi.SubItems[0].ToString().Split('{');
                string b = a[1].Split('}')[0];
                string str = "delete from HY where 编号 ='" + b + "'" +
                    "delete from Card where 编号 ='" + b + "'";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
