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
    public partial class 课程信息 : Form
    {
        public 课程信息()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.CheckBoxes = true;
            listView1.GridLines = true;
            listView1.Columns.Add("课程内容", 63, HorizontalAlignment.Center);
            listView1.Columns.Add("上课时间", 63, HorizontalAlignment.Center);
            listView1.Columns.Add("上课地点", 63, HorizontalAlignment.Center);
            listView1.Columns.Add("教练ID", 63, HorizontalAlignment.Center);
            listView1.Columns.Add("课程学费", 63, HorizontalAlignment.Center);
            // listView1.Columns.Add("折扣", 63, HorizontalAlignment.Center);
            // listView1.Columns.Add("状态", 63, HorizontalAlignment.Center);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlConnection conn = new SqlConnection("Server=.;Database=test;Trusted_Connection=yes");
            conn.Open();
            string str = "select * from KC";
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                //构建一个ListView的数据，存入数据库数据，以便添加到listView1的行数据中
                ListViewItem lt = new ListViewItem();
                //将数据库数据转变成ListView类型的一行数据
                lt.Text = sdr["课程内容"].ToString();
                lt.SubItems.Add(sdr["上课时间"].ToString());
                lt.SubItems.Add(sdr["上课地点"].ToString());
                lt.SubItems.Add(sdr["jlid"].ToString());
                lt.SubItems.Add(sdr["课程学费"].ToString());
                //lt.SubItems.Add(sdr["折扣"].ToString());
                // lt.SubItems.Add(sdr["使用状态"].ToString());
                //将lt数据添加到listView1控件中
                listView1.Items.Add(lt);
            }
            conn.Close();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView1.CheckedItems)
            {
                //i++;
                lvi.Remove();
                SqlConnection conn = new SqlConnection("Server=.;Database=test;Trusted_Connection=yes");
                conn.Open();
                string[] a = lvi.SubItems[0].ToString().Split('{');
                string b = a[1].Split('}')[0];
                string str = "delete from KC where 课程内容 ='" + b + "'";
                //string str = "delete from AuthorTable where name ='www'";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            增加课程信息 kc = new 增加课程信息();
            kc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            修改课程信息 xg = new 修改课程信息();
            xg.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlConnection conn = new SqlConnection("Server=.;Database=test;Trusted_Connection=yes");
            conn.Open();
            if (comboBox1.Text.Equals("课程内容"))
            {
                string str = "select * from KC where 课程内容 = '" + textBox1.Text + "' ";
                SqlCommand cmd = new SqlCommand(str, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    //构建一个ListView的数据，存入数据库数据，以便添加到listView1的行数据中
                    ListViewItem lt = new ListViewItem();
                    //将数据库数据转变成ListView类型的一行数据
                    lt.Text = sdr["课程内容"].ToString();
                    lt.SubItems.Add(sdr["上课时间"].ToString());
                    lt.SubItems.Add(sdr["上课地点"].ToString());
                    lt.SubItems.Add(sdr["jlid"].ToString());
                    lt.SubItems.Add(sdr["课程学费"].ToString());
                    //将lt数据添加到listView1控件中
                    listView1.Items.Add(lt);
                }
            }
            else if (comboBox1.Text.Equals("上课时间"))
            {
                string str = "select * from KC where 上课时间 = '" + textBox1.Text + "' ";
                SqlCommand cmd = new SqlCommand(str, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    //构建一个ListView的数据，存入数据库数据，以便添加到listView1的行数据中
                    ListViewItem lt = new ListViewItem();
                    //将数据库数据转变成ListView类型的一行数据
                    lt.Text = sdr["课程内容"].ToString();
                    lt.SubItems.Add(sdr["上课时间"].ToString());
                    lt.SubItems.Add(sdr["上课地点"].ToString());
                    lt.SubItems.Add(sdr["jlid"].ToString());
                    lt.SubItems.Add(sdr["课程学费"].ToString());
                    //将lt数据添加到listView1控件中
                    listView1.Items.Add(lt);
                }
            }
            else if (comboBox1.Text.Equals("上课地点"))
            {
                string str = "select * from KC where 上课地点 = '" + textBox1.Text + "' ";
                SqlCommand cmd = new SqlCommand(str, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    //构建一个ListView的数据，存入数据库数据，以便添加到listView1的行数据中
                    ListViewItem lt = new ListViewItem();
                    //将数据库数据转变成ListView类型的一行数据
                    lt.Text = sdr["课程内容"].ToString();
                    lt.SubItems.Add(sdr["上课时间"].ToString());
                    lt.SubItems.Add(sdr["上课地点"].ToString());
                    lt.SubItems.Add(sdr["jlid"].ToString());
                    lt.SubItems.Add(sdr["课程学费"].ToString());
                    //将lt数据添加到listView1控件中
                    listView1.Items.Add(lt);
                }
            }
            else if (comboBox1.Text.Equals("jlid"))
            {
                string str = "select * from KC where jlid = '" + textBox1.Text + "' ";
                SqlCommand cmd = new SqlCommand(str, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    //构建一个ListView的数据，存入数据库数据，以便添加到listView1的行数据中
                    ListViewItem lt = new ListViewItem();
                    //将数据库数据转变成ListView类型的一行数据
                    lt.Text = sdr["课程内容"].ToString();
                    lt.SubItems.Add(sdr["上课时间"].ToString());
                    lt.SubItems.Add(sdr["上课地点"].ToString());
                    lt.SubItems.Add(sdr["jlid"].ToString());
                    lt.SubItems.Add(sdr["课程学费"].ToString());
                    //将lt数据添加到listView1控件中
                    listView1.Items.Add(lt);
                }
            }
            else if (comboBox1.Text.Equals("课程学费"))
            {
                string str = "select * from KC where 课程学费 = '" + textBox1.Text + "' ";
                SqlCommand cmd = new SqlCommand(str, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    //构建一个ListView的数据，存入数据库数据，以便添加到listView1的行数据中
                    ListViewItem lt = new ListViewItem();
                    //将数据库数据转变成ListView类型的一行数据
                    lt.Text = sdr["课程内容"].ToString();
                    lt.SubItems.Add(sdr["上课时间"].ToString());
                    lt.SubItems.Add(sdr["上课地点"].ToString());
                    lt.SubItems.Add(sdr["jlid"].ToString());
                    lt.SubItems.Add(sdr["课程学费"].ToString());
                    //将lt数据添加到listView1控件中
                    listView1.Items.Add(lt);
                }
            }
        }
    }
}
