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

  
    public partial class 会员 : Form
    {

        string str3 = "";
        public 会员()
        {
            InitializeComponent();

            textBox2.Text = chuanzhi.temp;

            listView3.View = View.Details;
         
            listView3.GridLines = true;
            listView3.Columns.Add("编号", 63, HorizontalAlignment.Center);
            listView3.Columns.Add("姓名", 63, HorizontalAlignment.Center);
            listView3.Columns.Add("性别", 63, HorizontalAlignment.Center);
            listView3.Columns.Add("家庭住址", 63, HorizontalAlignment.Center);
            listView3.Columns.Add("身体状况", 63, HorizontalAlignment.Center);
            listView3.Columns.Add("手机号码", 63, HorizontalAlignment.Center);
            listView3.Columns.Add("注册时间", 63, HorizontalAlignment.Center);

            listView4.View = View.Details;

            listView4.GridLines = true;
            listView4.Columns.Add("编号", 63, HorizontalAlignment.Center);
            listView4.Columns.Add("名称", 63, HorizontalAlignment.Center);
            listView4.Columns.Add("有效次数", 63, HorizontalAlignment.Center);
            listView4.Columns.Add("有效天数", 63, HorizontalAlignment.Center);
            listView4.Columns.Add("售价", 63, HorizontalAlignment.Center);
            listView4.Columns.Add("折扣", 63, HorizontalAlignment.Center);
            listView4.Columns.Add("使用状态", 63, HorizontalAlignment.Center);


            SqlConnection conn = new SqlConnection("Server=.;Database=test;Trusted_Connection=yes");
            conn.Open();
            string str = "select * from HY where 编号 = '" + chuanzhi.temp + "'";
            
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
                listView3.Items.Add(lt);
            }

            conn.Close();
            SqlConnection conn1 = new SqlConnection("Server=.;Database=test;Trusted_Connection=yes");
            conn1.Open();

            string str1 = "select * from Card where 编号 = '" + chuanzhi.temp + "'";

            SqlCommand cmd1 = new SqlCommand(str1, conn1);
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            while (sdr1.Read())
            {
                //构建一个ListView的数据，存入数据库数据，以便添加到listView1的行数据中
                ListViewItem lt1 = new ListViewItem();
                //将数据库数据转变成ListView类型的一行数据   
                
                lt1.Text = sdr1["编号"].ToString();
                lt1.SubItems.Add(sdr1["名称"].ToString());
                lt1.SubItems.Add(sdr1["有效次数"].ToString());
                lt1.SubItems.Add(sdr1["有效天数"].ToString());
                lt1.SubItems.Add(sdr1["售价"].ToString());
                lt1.SubItems.Add(sdr1["折扣"].ToString());
                lt1.SubItems.Add(sdr1["使用状态"].ToString());

                str3 = sdr1["有效天数"].ToString();

                //将lt数据添加到listView1控件中
                listView4.Items.Add(lt1);
            }

            conn1.Close();

        }

      
  
      
        private void 会员_Load(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=.;Database=test;Trusted_Connection=yes");
            conn.Open();
            if (comboBox1.Text.Equals("请假"))
            {
                int old = int.Parse(str3);
                int newn = old + int.Parse(textBox1.Text);
                string sqlUpdate = "update Card set 有效天数 ='" + newn.ToString() + "' where 编号 ='" + chuanzhi.temp + "'";
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
            else if (comboBox1.Text.Equals("续费"))
            {
                int old = int.Parse(str3);
                int newn = old + int.Parse(textBox1.Text) / 20;
                string sqlUpdate = "update Card set 有效天数 ='" + newn.ToString() + "' where 编号 ='" +chuanzhi.temp + "'";
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


            // 刷新
            listView4.Items.Clear();

            SqlConnection conn1 = new SqlConnection("Server=.;Database=test;Trusted_Connection=yes");
            conn1.Open();

            string str1 = "select * from Card where 编号 = '" + chuanzhi.temp + "'";

            SqlCommand cmd1 = new SqlCommand(str1, conn1);
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            while (sdr1.Read())
            {
                //构建一个ListView的数据，存入数据库数据，以便添加到listView1的行数据中
                ListViewItem lt1 = new ListViewItem();
                //将数据库数据转变成ListView类型的一行数据   

                lt1.Text = sdr1["编号"].ToString();
                lt1.SubItems.Add(sdr1["名称"].ToString());
                lt1.SubItems.Add(sdr1["有效次数"].ToString());
                lt1.SubItems.Add(sdr1["有效天数"].ToString());
                lt1.SubItems.Add(sdr1["售价"].ToString());
                lt1.SubItems.Add(sdr1["折扣"].ToString());
                lt1.SubItems.Add(sdr1["使用状态"].ToString());

                //将lt数据添加到listView1控件中
                listView4.Items.Add(lt1);
            }



            conn.Close();
            conn1.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn1 = new SqlConnection("Server=.;Database=test;Trusted_Connection=yes");
            conn1.Open();

            string str1 = "update UserTable set password = '" + textBox3.Text + "' where username = '" + chuanzhi.temp + "'";

            SqlCommand cmd1 = new SqlCommand(str1, conn1);

            if (cmd1.ExecuteNonQuery() == 0)
            {
                MessageBox.Show("未知错误!");
                return;
            }
            else
            {
                MessageBox.Show("恭喜你!修改成功!");
            }
        }
    }
}
