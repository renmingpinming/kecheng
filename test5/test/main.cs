﻿using System;
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
        String xuehao="";
        String yourAnswer = "";
        String trueAnswer = "";
        string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
        int i = 0;
        int right = 0;
        int score = 0;
        int page = 1;
        int max = 0;
        public main(String _xuehao)
        {
            InitializeComponent();
            writetimu(i, i + 1, i + 2, i + 3, i + 4, i + 5);
            label2.Text = "1";

            xuehao = _xuehao;
            SqlConnection conn1 = new SqlConnection(_connectionString);
            conn1.Open();

            string strSqlq1 = "select * from student where 学号 = '" + xuehao + "'";
            SqlCommand cmd1 = new SqlCommand(strSqlq1, conn1);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                xingming.Text = dr1["姓名"].ToString();
            }
            dr1.Close();
            cmd1.ExecuteNonQuery();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 读出题目
        /// </summary>
        /// <param name="q1"></param>
        /// <param name="q2"></param>
        /// <param name="q3"></param>
        /// <param name="q4"></param>
        /// <param name="q5"></param>
        /// <param name="q6"></param>

        public void writetimu(int q1, int q2, int q3, int q4, int q5, int q6) 
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();

            string newsql = "select * from timu";
            SqlDataAdapter da = new SqlDataAdapter(newsql,conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            max = dt.Rows.Count;

            timu1.Text = dt.Rows[q1]["题目"].ToString();
            A1.Text = dt.Rows[q1]["选项A"].ToString();
            B1.Text = dt.Rows[q1]["选项B"].ToString();
            C1.Text = dt.Rows[q1]["选项C"].ToString();
            D1.Text = dt.Rows[q1]["选项D"].ToString();
            trueAnswer += dt.Rows[q1]["正确答案"].ToString();

            timu2.Text = dt.Rows[q2]["题目"].ToString();
            A2.Text = dt.Rows[q2]["选项A"].ToString();
            B2.Text = dt.Rows[q2]["选项B"].ToString();
            C2.Text = dt.Rows[q2]["选项C"].ToString();
            D2.Text = dt.Rows[q2]["选项D"].ToString();
            trueAnswer += dt.Rows[q2]["正确答案"].ToString();

            timu3.Text = dt.Rows[q3]["题目"].ToString();
            A3.Text = dt.Rows[q3]["选项A"].ToString();
            B3.Text = dt.Rows[q3]["选项B"].ToString();
            C3.Text = dt.Rows[q3]["选项C"].ToString();
            D3.Text = dt.Rows[q3]["选项D"].ToString();
            trueAnswer += dt.Rows[q3]["正确答案"].ToString();

            timu4.Text = dt.Rows[q4]["题目"].ToString();
            A4.Text = dt.Rows[q4]["选项A"].ToString();
            B4.Text = dt.Rows[q4]["选项B"].ToString();
            C4.Text = dt.Rows[q4]["选项C"].ToString();
            D4.Text = dt.Rows[q4]["选项D"].ToString();
            trueAnswer += dt.Rows[q4]["正确答案"].ToString();

            timu5.Text = dt.Rows[q5]["题目"].ToString();
            A5.Text = dt.Rows[q5]["选项A"].ToString();
            B5.Text = dt.Rows[q5]["选项B"].ToString();
            C5.Text = dt.Rows[q5]["选项C"].ToString();
            D5.Text = dt.Rows[q5]["选项D"].ToString();
            trueAnswer += dt.Rows[q5]["正确答案"].ToString();

            timu6.Text = dt.Rows[q6]["题目"].ToString();
            A6.Text = dt.Rows[q6]["选项A"].ToString();
            B6.Text = dt.Rows[q6]["选项B"].ToString();
            C6.Text = dt.Rows[q6]["选项C"].ToString();
            D6.Text = dt.Rows[q6]["选项D"].ToString();
            trueAnswer += dt.Rows[q6]["正确答案"].ToString();

        }

        /// <summary>
        /// 清空
        /// </summary>
        public void clearRadioButton() {
            A1.Checked = false;A2.Checked = false;A3.Checked = false;
            B1.Checked = false;B2.Checked = false;B3.Checked = false;
            C1.Checked = false;C2.Checked = false;C3.Checked = false;
            D1.Checked = false;D2.Checked = false;D3.Checked = false;        
            A4.Checked = false;A5.Checked = false;A6.Checked = false;
            B4.Checked = false;B5.Checked = false;B6.Checked = false;
            C4.Checked = false;C5.Checked = false;C6.Checked = false;
            D4.Checked = false;D5.Checked = false;D6.Checked = false;
            daan1.Text = ""; daan2.Text = ""; daan3.Text = "";
            daan4.Text = ""; daan5.Text = ""; daan6.Text = "";
            yourAnswer = "";
            trueAnswer = "";
            right = 0;
            score = 0;
            submit.Enabled = true;
            if (page <= 0)
            {
                i = 0;
                page = 1;
            }
            if (i < 0) {
                i = 0;
                MessageBox.Show("已结到头了");
            }
            if (i  >= max - 1) {
                i = max - 6;
                MessageBox.Show("已结到头了");
            }
        }
        /// <summary>
        /// 改题目
        /// </summary>
        public void check() {
            if (A1.Checked == true)
                yourAnswer += "A";
            if (B1.Checked == true)
                yourAnswer += "B";
            if (C1.Checked == true)
                yourAnswer += "C";
            if (D1.Checked == true)
                yourAnswer += "D";
            if (A2.Checked == true)
                yourAnswer += "A";
            if (B2.Checked == true)
                yourAnswer += "B";
            if (C2.Checked == true)
                yourAnswer += "C";
            if (D2.Checked == true)
                yourAnswer += "D";
            if (A3.Checked == true)
                yourAnswer += "A";
            if (B3.Checked == true)
                yourAnswer += "B";
            if (C3.Checked == true)
                yourAnswer += "C";
            if (D3.Checked == true)
                yourAnswer += "D";
            if (A4.Checked == true)
                yourAnswer += "A";
            if (B4.Checked == true)
                yourAnswer += "B";
            if (C4.Checked == true)
                yourAnswer += "C";
            if (D4.Checked == true)
                yourAnswer += "D";
            if (A5.Checked == true)
                yourAnswer += "A";
            if (B5.Checked == true)
                yourAnswer += "B";
            if (C5.Checked == true)
                yourAnswer += "C";
            if (D5.Checked == true)
                yourAnswer += "D";
            if (A6.Checked == true)
                yourAnswer += "A";
            if (B6.Checked == true)
                yourAnswer += "B";
            if (C6.Checked == true)
                yourAnswer += "C";
            if (D6.Checked == true)
                yourAnswer += "D";
            if (yourAnswer[0].Equals(trueAnswer[0]))
            {
                daan1.Text = "答案正确";
                right++;
            }
            else
                daan1.Text = "答案错误，你的答案：" + yourAnswer[0] + "  正确答案：" + trueAnswer[0];
            if (yourAnswer[1].Equals(trueAnswer[10]))
            {
                daan2.Text = "答案正确";
                right++;
            }
            else
                daan2.Text = "答案错误，你的答案：" + yourAnswer[1] + "  正确答案：" + trueAnswer[10];
            if (yourAnswer[2].Equals(trueAnswer[20]))
            {
                daan3.Text = "答案正确";
                right++;
            }
            else
                daan3.Text = "答案错误，你的答案：" + yourAnswer[2] + "  正确答案：" + trueAnswer[20];
            if (yourAnswer[3].Equals(trueAnswer[30]))
            {
                daan4.Text = "答案正确";
                right++;
            }
            else
                daan4.Text = "答案错误，你的答案：" + yourAnswer[3] + "  正确答案：" + trueAnswer[30];
            if (yourAnswer[4].Equals(trueAnswer[40]))
            {
                daan5.Text = "答案正确";
                right++;
            }
            else
                daan5.Text = "答案错误，你的答案：" + yourAnswer[4] + "  正确答案：" + trueAnswer[40];
            if (yourAnswer[5].Equals(trueAnswer[50]))
            {
                daan6.Text = "答案正确";
                right++;
            }
            else
                daan6.Text = "答案错误，你的答案：" + yourAnswer[5] + "  正确答案：" + trueAnswer[50];
            score = 100 / 6 * right;
            label1.Text = score.ToString();
        }

        /// <summary>
        /// 添加成绩
        /// </summary>
        /// <param name="_page"></param>
        /// <param name="_score"></param>
        public void addScore(int _page,int _score) {
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            string strSqlq1 = "insert into score values("+xuehao+"," + _page + "," + _score + ")";
            SqlCommand cmd1 = new SqlCommand(strSqlq1, conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
        }

        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void p1_Click(object sender, EventArgs e)
        {
            i -= 6;
            page--;
            label2.Text = page.ToString();
            clearRadioButton();
            writetimu(i, i + 1, i + 2, i + 3, i + 4, i + 5);
        }
        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void p2_Click(object sender, EventArgs e)
        {
            i += 6;
            page++;
            label2.Text = page.ToString();
            clearRadioButton();
            writetimu(i, i + 1, i + 2, i + 3, i + 4, i + 5);
        }
        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submit_Click(object sender, EventArgs e)
        {
            check();
            submit.Enabled = false;
            addScore(page,score);
        }

        private void read_Click(object sender, EventArgs e)
        {
            history his = new history(xuehao);
            his.Show();
            this.Hide();
        }

        private void update_Click(object sender, EventArgs e)
        {
            updateIn up = new updateIn(xuehao);
            up.Show();
            this.Hide();
        }

        
    }
}
