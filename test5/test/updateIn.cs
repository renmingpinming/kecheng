using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test
{
    public partial class updateIn : Form
    {
        string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
        String xuehao = "";
        String right = "";
        public updateIn(String _xuehao)
        {
            InitializeComponent();
            xuehao = _xuehao;
            textBox1.Text = xuehao;
        }


        private void back_Click(object sender, EventArgs e)
        {
            main m = new main(xuehao);
            m.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String psdright = textBox2.Text.Trim();
            String psdnew = textBox3.Text.Trim();
            String psdagain = textBox4.Text.Trim();

            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();

            string strSql = "select * from student where 学号 = " + "'" + xuehao + "'";
            SqlCommand cmd1 = new SqlCommand(strSql, conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                right = dr1["密码"].ToString();
            }
            dr1.Close();
            cmd1.ExecuteNonQuery();
            if (!psdright.Equals(right)) {
                MessageBox.Show("原密码不正确");
                textBox2.Focus();
            }
            else if (psdnew == string.Empty)
            {
                MessageBox.Show("新密码不能为空");
                textBox3.Focus();
            }
            else if (!psdnew.Equals(psdagain))
            {
                MessageBox.Show("新密码不相同");
                textBox4.Focus();
            }
            else
            {
                string strSql2 = "update student set 密码 = '" + psdnew + "' where 学号 = '" + xuehao + "'";
                SqlCommand cmd2 = new SqlCommand(strSql2, conn);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                MessageBox.Show("修改成功！");
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
            }
            
        }
    }
}
