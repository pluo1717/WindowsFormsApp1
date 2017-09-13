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
    public partial class 会员信息 : Form
    {
        public 会员信息()
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
            listView1.CheckBoxes = true;
            listView1.GridLines = true;
            listView1.Columns.Add("编号", 63, HorizontalAlignment.Center);
            listView1.Columns.Add("姓名", 63, HorizontalAlignment.Center);
            listView1.Columns.Add("性别", 63, HorizontalAlignment.Center);
            listView1.Columns.Add("家庭住址", 63, HorizontalAlignment.Center);
            listView1.Columns.Add("身体状况", 63, HorizontalAlignment.Center);
            listView1.Columns.Add("手机号码", 63, HorizontalAlignment.Center);
            listView1.Columns.Add("注册时间", 63, HorizontalAlignment.Center);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlConnection conn = new SqlConnection("Server=.;Database=test;Trusted_Connection=yes");
            conn.Open();
            string str = "select * from HY";
            SqlCommand cmd = new SqlCommand(str,conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                //构建一个ListView的数据，存入数据库数据，以便添加到listView1的行数据中
                ListViewItem lt = new ListViewItem();
                //将数据库数据转变成ListView类型的一行数据
                lt.Text = sdr["编号"].ToString();
                lt.SubItems.Add(sdr["姓名"].ToString());
                lt.SubItems.Add(sdr["性别"].ToString());
                lt.SubItems.Add(sdr["家庭住址"].ToString());
                lt.SubItems.Add(sdr["身体状况"].ToString());
                lt.SubItems.Add(sdr["手机号码"].ToString());
                lt.SubItems.Add(sdr["注册时间"].ToString());
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
            new 添加会员会员卡信息().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView1.CheckedItems)
            {
                //i++;
                lvi.Remove();
                SqlConnection conn = new SqlConnection("Server=.;Database=test;Trusted_Connection=yes");
                conn.Open();
                string[] a = lvi.SubItems[0].ToString().Split('{');
                string b = a[1].Split('}')[0];
                string str = "delete from HY where 编号 ='" + b + "'" +
                    "delete from Card where 编号 ='" + b + "'";
                //string str = "delete from AuthorTable where name ='www'";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=.;Database=test;Trusted_Connection=yes");
            conn.Open();
            if (comboBox1.Text.Equals("姓名"))
            {
                string sqlUpdate = "update HY set 姓名 ='" + textBox2.Text + "' where 姓名 ='" + textBox1.Text + "'";
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
            else if (comboBox1.Text.Equals("性别"))
            {
                string sqlUpdate = "update HY set 性别 ='" + textBox2.Text + "' where 性别 ='" + textBox1.Text + "'";
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
            else if (comboBox1.Text.Equals("家庭住址"))
            {
                string sqlUpdate = "update HY set 家庭住址 ='" + textBox2.Text + "' where 家庭住址 ='" + textBox1.Text + "'";
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
            else if (comboBox1.Text.Equals("身体状况"))
            {
                string sqlUpdate = "update HY set 身体状况 ='" + textBox2.Text + "' where 身体状况 ='" + textBox1.Text + "'";
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
            else if (comboBox1.Text.Equals("手机号码"))
            {
                string sqlUpdate = "update HY set 手机号码 ='" + textBox2.Text + "' where 手机号码 ='" + textBox1.Text + "'";
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
            else if (comboBox1.Text.Equals("注册时间"))
            {
                string sqlUpdate = "update HY set 注册时间 ='" + textBox2.Text + "' where 注册时间 ='" + textBox1.Text + "'";
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

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlConnection conn = new SqlConnection("Server=.;Database=test;Trusted_Connection=yes");
            conn.Open();
            string str = "select * from HY where 编号='" + textBox3.Text + "'";
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                //构建一个ListView的数据，存入数据库数据，以便添加到listView1的行数据中
                ListViewItem lt = new ListViewItem();
                //将数据库数据转变成ListView类型的一行数据
                lt.Text = sdr["编号"].ToString();
                lt.SubItems.Add(sdr["姓名"].ToString());
                lt.SubItems.Add(sdr["性别"].ToString());
                lt.SubItems.Add(sdr["家庭住址"].ToString());
                lt.SubItems.Add(sdr["身体状况"].ToString());
                lt.SubItems.Add(sdr["手机号码"].ToString());
                lt.SubItems.Add(sdr["注册时间"].ToString());
                //将lt数据添加到listView1控件中
                listView1.Items.Add(lt);
            }
            conn.Close();
        }
    }
}
