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
    public partial class 教练员 : Form
    {
        public 教练员()
        {
            InitializeComponent();

            init();
           // listView1.Columns.Add("折扣", 63, HorizontalAlignment.Center);
           // listView1.Columns.Add("状态", 63, HorizontalAlignment.Center);



        }

        private void init()
        {
            listView1.View = View.Details;
            listView1.CheckBoxes = true;
            listView1.GridLines = true;
            listView1.Columns.Add("教练id", 63, HorizontalAlignment.Center);
            listView1.Columns.Add("姓名", 63, HorizontalAlignment.Center);
            listView1.Columns.Add("性别", 63, HorizontalAlignment.Center);
            listView1.Columns.Add("联系电话", 63, HorizontalAlignment.Center);
            listView1.Columns.Add("备注", 63, HorizontalAlignment.Center);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlConnection conn = new SqlConnection("Server=.;Database=test;Trusted_Connection=yes");
            conn.Open();
            string str = "select * from JLY";
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                //构建一个ListView的数据，存入数据库数据，以便添加到listView1的行数据中
                ListViewItem lt = new ListViewItem();
                //将数据库数据转变成ListView类型的一行数据
                lt.Text = sdr["jlid"].ToString();
                lt.SubItems.Add(sdr["教练"].ToString());
                lt.SubItems.Add(sdr["性别"].ToString());
                lt.SubItems.Add(sdr["联系电话"].ToString());
                lt.SubItems.Add(sdr["备注"].ToString());
                //lt.SubItems.Add(sdr["折扣"].ToString());
               // lt.SubItems.Add(sdr["使用状态"].ToString());
                //将lt数据添加到listView1控件中
                listView1.Items.Add(lt);
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new 添加教练员信息().Show();
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
                string str = "delete from JLY where jlid ='" + b + "'";
                //string str = "delete from AuthorTable where name ='www'";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text, 
                name = textBox2.Text,
                sex = textBox3.Text,
                num = textBox4.Text, 
                remark = textBox5.Text;
            SqlConnection conn = new SqlConnection("Server=.;Database=test;Trusted_Connection=yes");
            conn.Open();

            string queryStr = "select * from JLY";
            SqlCommand cmdQue = new SqlCommand(queryStr, conn);
            if(cmdQue.ExecuteNonQuery() == 0)
            {
                MessageBox.Show("未知错误!");
                return;
            }
            else
            {
                SqlDataReader sdr = cmdQue.ExecuteReader();
                while(sdr.Read())
                {
                    id = id.Equals("")?(sdr["jlid"].ToString()):id;
                    name = name.Equals("")?sdr["教练"].ToString():name;
                    sex = sex.Equals("")?sdr["性别"].ToString():sex;
                    num = num.Equals("")?sdr["联系电话"].ToString():num;
                    remark = remark.Equals("")?sdr["备注"].ToString():remark;
                }
            }
            conn.Close();

            conn.Open();
            string sqlUpdate = "update JLY set jlid ='" + id + "',教练='" + name + "',性别='" + sex + "', 联系电话='" + num + "',备注='" + remark + "' where jlid ='" + id + "'";
            SqlCommand cmdUp = new SqlCommand(sqlUpdate, conn);
            if (cmdUp.ExecuteNonQuery() == 0)
            {
                MessageBox.Show(sqlUpdate+"\n未知错误!"+id+name+sex+num+remark);
                return;
            }
            else
            {
                MessageBox.Show("x!");

            }
            conn.Close();

            /*
            if (comboBox1.Text.Equals("教练"))
            {
                string sqlUpdate = "update JLY set 教练 ='" + textBox2.Text + "' where 教练 ='" + textBox1.Text + "'";
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
                string sqlUpdate = "update JLY set 性别 ='" + textBox2.Text + "' where 性别 ='" + textBox1.Text + "'";
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
            else if (comboBox1.Text.Equals("联系电话"))
            {
                string sqlUpdate = "update JLY set 联系电话 ='" + textBox2.Text + "' where 联系电话 ='" + textBox1.Text + "'";
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
            else if (comboBox1.Text.Equals("备注"))
            {
                string sqlUpdate = "update JLY set 备注 ='" + textBox2.Text + "' where 备注 ='" + textBox1.Text + "'";
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
            }*/


        }
    }
}
