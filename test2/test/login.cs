﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace test
{
    public partial class login : Form
    {
        String xuehao;
        public login()
        {
            InitializeComponent();

        }
        public string getxuehao()
        {
            return xuehao ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xuehao = textBox1.Text;
            string mima = textBox2.Text;
            login my_login = new login();
            my_login.xuehao = xuehao;
            string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            if (radioButton1.Checked)
            {
                string strSql = "select * from student where 学号 = '" + xuehao + "'";
                SqlCommand cmd = new SqlCommand(strSql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (mima.Equals(dr["密码"].ToString()))
                    {
                        MessageBox.Show("登陆成功！");
                        main zuoti = new main(my_login);
                        zuoti.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("密码错误！");
                    }
                }
                else
                {
                    MessageBox.Show("账号不存在！");
                }
            }
            if (radioButton2.Checked)
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
