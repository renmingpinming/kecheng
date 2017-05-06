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
    public partial class main : Form
    {
        private login mylogin;
        String xuehao="";
        public main(login my_login)
        {
            InitializeComponent();
            this.mylogin = my_login;
            xuehao = mylogin.getxuehao();
            SqlConnection conn1 = new SqlConnection();
            conn1.ConnectionString = @"Server = localhost;Database=CLASSTEST;integrated security=true";
            conn1.Open();

            string strSqlq1 = "select * from student where 学号 = '" + xuehao + "'";
            SqlCommand cmd1 = new SqlCommand(strSqlq1, conn1);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                xingming.Text = dr1["姓名"].ToString();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        public void writetimu(int q1, int q2, int q3, int q4, int q5, int q6) 
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Server = localhost;Database=CLASSTEST;integrated security=true";
            conn.Open();

            string strSqlq1 = "select * from timu where 编号 = '" + q1 + "'";
            SqlCommand cmd1 = new SqlCommand(strSqlq1, conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read()) 
            {
                timu1.Text = dr1["题目"].ToString();
                A1.Text = dr1["选项A"].ToString();
                B1.Text = dr1["选项B"].ToString();
                C1.Text = dr1["选项C"].ToString();
                D1.Text = dr1["选项D"].ToString();
            }
            dr1.Close();
            cmd1.ExecuteNonQuery();

            string strSqlq2 = "select * from timu where 编号 = '" + q2 + "'";
            SqlCommand cmd2 = new SqlCommand(strSqlq2, conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                timu2.Text = dr2["题目"].ToString();
                A2.Text = dr2["选项A"].ToString();
                B2.Text = dr2["选项B"].ToString();
                C2.Text = dr2["选项C"].ToString();
                D2.Text = dr2["选项D"].ToString();
            }

            dr2.Close();
            cmd2.ExecuteNonQuery();

            string strSqlq3 = "select * from timu where 编号 = '" + q3 + "'";
            SqlCommand cmd3 = new SqlCommand(strSqlq3, conn);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                timu3.Text = dr3["题目"].ToString();
                A3.Text = dr3["选项A"].ToString();
                B3.Text = dr3["选项B"].ToString();
                C3.Text = dr3["选项C"].ToString();
                D3.Text = dr3["选项D"].ToString();
            }

            dr3.Close();
            cmd3.ExecuteNonQuery();

            string strSqlq4 = "select * from timu where 编号 = '" + q4 + "'";
            SqlCommand cmd4 = new SqlCommand(strSqlq4, conn);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            if (dr4.Read())
            {
                timu4.Text = dr4["题目"].ToString();
                A4.Text = dr4["选项A"].ToString();
                B4.Text = dr4["选项B"].ToString();
                C4.Text = dr4["选项C"].ToString();
                D4.Text = dr4["选项D"].ToString();
            }

            dr4.Close();
            cmd4.ExecuteNonQuery();

            string strSqlq5 = "select * from timu where 编号 = '" + q5 + "'";
            SqlCommand cmd5 = new SqlCommand(strSqlq5, conn);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            if (dr5.Read())
            {
                timu5.Text = dr5["题目"].ToString();
                A5.Text = dr5["选项A"].ToString();
                B5.Text = dr5["选项B"].ToString();
                C5.Text = dr5["选项C"].ToString();
                D5.Text = dr5["选项D"].ToString();
            }

            dr5.Close();
            cmd5.ExecuteNonQuery();

            string strSqlq6 = "select * from timu where 编号 = '" + q6 + "'";
            SqlCommand cmd6 = new SqlCommand(strSqlq6, conn);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            if (dr6.Read())
            {
                timu6.Text = dr6["题目"].ToString();
                A6.Text = dr6["选项A"].ToString();
                B6.Text = dr6["选项B"].ToString();
                C6.Text = dr6["选项C"].ToString();
                D6.Text = dr6["选项D"].ToString();
            }

            dr6.Close();
            cmd6.ExecuteNonQuery();
        }

        public void clearRadioButton() {
            A1.Checked = false;A2.Checked = false;A3.Checked = false;
            B1.Checked = false;B2.Checked = false;B3.Checked = false;
            C1.Checked = false;C2.Checked = false;C3.Checked = false;
            D1.Checked = false;D2.Checked = false;D3.Checked = false;        
            A4.Checked = false;A5.Checked = false;A6.Checked = false;
            B4.Checked = false;B5.Checked = false;B6.Checked = false;
            C4.Checked = false;C5.Checked = false;C6.Checked = false;
            D4.Checked = false;D5.Checked = false;D6.Checked = false;    
        }

        private void p1_Click(object sender, EventArgs e)
        {
            clearRadioButton();
            writetimu(1, 2, 3, 4, 5, 6);

        }

        private void p2_Click(object sender, EventArgs e)
        {
            clearRadioButton();
            writetimu(7,8,9,10,11,12);
        }

        
    }
}
