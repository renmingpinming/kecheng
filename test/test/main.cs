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
        String xuehao="";
        String [] yourAnswer = new String[100];
        
        String trueAnswer = "";
        
        string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
        int Tid = 0;
        int right = 0;
        int score = 0;
        int page = 1;
        int max = 0;
        public main(String _xuehao)
        {
            InitializeComponent();
            writetimu(Tid, Tid + 1, Tid + 2, Tid + 3, Tid + 4, Tid + 5);
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
        /// 
        public void gettrueasw()
        {
             SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();

            string newsql = "select * from timu";
            SqlDataAdapter da = new SqlDataAdapter(newsql,conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            int count = dt.Rows.Count;
            for (int i = 0; i < count; ++i)
            {
                trueAnswer += dt.Rows[i]["正确答案"].ToString();
            }
        }

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
            right = 0;
            score = 0;

            if (page <= 0)
            {
                Tid = 0;
                page = 1;
            }
            if (Tid < 0) {
                Tid = 0;
                MessageBox.Show("已经到头了");
            }
            if (Tid  >= max - 1) {
                Tid = max - 6;
                page = 7;
                MessageBox.Show("已经到头了");
            }
        }
        /// <summary>
        /// 改题目
        /// </summary>
        public void getasw() {
            if (A1.Checked == true)
                yourAnswer[(page - 1) * 6] = "A";
            else if (B1.Checked == true)
                yourAnswer[(page - 1) * 6] = "B";
            else if (C1.Checked == true)
                yourAnswer[(page - 1) * 6] = "C";
            else if (D1.Checked == true)
                yourAnswer[(page - 1) * 6] = "D";
            else
                yourAnswer[(page - 1) * 6] = " ";

            if (A2.Checked == true)
                yourAnswer[(page - 1) * 6 + 1] = "A";
            else if (B2.Checked == true)
                yourAnswer[(page - 1) * 6 + 1] = "B";
            else if (C2.Checked == true)
                yourAnswer[(page - 1) * 6 + 1] = "C";
            else if (D2.Checked == true)
                yourAnswer[(page - 1) * 6 + 1] = "D";
            else 
                yourAnswer[(page - 1) * 6 + 1] = " ";

            if (A3.Checked == true)
                yourAnswer[(page - 1) * 6 + 2] = "A";
            else if (B3.Checked == true)
                yourAnswer[(page - 1) * 6 + 2] = "B";
            else if (C3.Checked == true)
                yourAnswer[(page - 1) * 6 + 2] = "C";
            else if (D3.Checked == true)
                yourAnswer[(page - 1) * 6 + 2] = "D";
            else
                yourAnswer[(page - 1) * 6 + 2] = " ";

            if (A4.Checked == true)
                yourAnswer[(page - 1) * 6 + 3] = "A";
            else if (B4.Checked == true)
                yourAnswer[(page - 1) * 6 + 3] = "B";
            else if (C4.Checked == true)
                yourAnswer[(page - 1) * 6 + 3] = "C";
            else if (D4.Checked == true)
                yourAnswer[(page - 1) * 6 + 3] = "D";
            else
                yourAnswer[(page - 1) * 6 + 3] = " ";

            if (A5.Checked == true)
                yourAnswer[(page - 1) * 6 + 4] = "A";
            else if (B5.Checked == true)
                yourAnswer[(page - 1) * 6 + 4] = "B";
            else if (C5.Checked == true)
                yourAnswer[(page - 1) * 6 + 4] = "C";
            else if (D5.Checked == true)
                yourAnswer[(page - 1) * 6 + 4] = "D";
            else
                yourAnswer[(page - 1) * 6 + 4] = " ";

            if (A6.Checked == true)
                yourAnswer[(page - 1) * 6 + 5] = "A";
            else if (B6.Checked == true)
                yourAnswer[(page - 1) * 6 + 5] = "B";
            else if (C6.Checked == true)
                yourAnswer[(page - 1) * 6 + 5] = "C";
            else if (D6.Checked == true)
                yourAnswer[(page - 1) * 6 + 5] = "D";
            else
                yourAnswer[(page - 1) * 6 + 5] = " ";

        }

        public void check() 
        {
            string yourAsw = string.Join("", yourAnswer); 
            for (int i = 0; i < trueAnswer.Length; ++i)
            {
                if (yourAsw[i] != null && trueAnswer[i] != null)
                {
                    if (yourAsw[i].Equals(trueAnswer[i]))
                    {
                        //daan1.Text = "答案正确";
                        right++;
                    }
                }
            }
            score = (int)(100 / 42.0 * right);
            //label1.Text = score.ToString();
        }
        public void bddata()
        {
            if (yourAnswer[(page - 1) * 6] == "A")
                A1.Checked = true;
            else if (yourAnswer[(page - 1) * 6] == "B")
                B1.Checked = true;
            else if (yourAnswer[(page - 1) * 6] == "C")
                C1.Checked = true;
            else if (yourAnswer[(page - 1) * 6] == "D")
                D1.Checked = true;

            if (yourAnswer[(page - 1) * 6 + 1] == "A")
                A2.Checked = true;
            else if (yourAnswer[(page - 1) * 6 + 1] == "B")
                B2.Checked = true;
            else if (yourAnswer[(page - 1) * 6 + 1] == "C")
                C2.Checked = true;
            else if (yourAnswer[(page - 1) * 6 + 1] == "D")
                D3.Checked = true; 
            if (yourAnswer[(page - 1) * 6 + 2] == "A")
                A3.Checked = true;
            else if (yourAnswer[(page - 1) * 6 + 2] == "B")
                B3.Checked = true;
            else if (yourAnswer[(page - 1) * 6 + 2] == "C")
                C3.Checked = true;
            else if (yourAnswer[(page - 1) * 6 + 2] == "D")
                D3.Checked = true;
            if (yourAnswer[(page - 1) * 6 + 3] == "A")
                A4.Checked = true;
            else if (yourAnswer[(page - 1) * 6 + 3] == "B")
                B4.Checked = true;
            else if (yourAnswer[(page - 1) * 6 + 3] == "C")
                C4.Checked = true;
            else if (yourAnswer[(page - 1) * 6 + 3] == "D")
                D4.Checked = true;
            if (yourAnswer[(page - 1) * 6 + 4] == "A")
                A5.Checked = true;
            else if (yourAnswer[(page - 1) * 6 + 4] == "B")
                B5.Checked = true;
            else if (yourAnswer[(page - 1) * 6 + 4] == "C")
                C5.Checked = true;
            else if (yourAnswer[(page - 1) * 6 + 4] == "D")
                D5.Checked = true;
            if (yourAnswer[(page - 1) * 6 + 5] == "A")
                A6.Checked = true;
            else if (yourAnswer[(page - 1) * 6 + 5] == "B")
                B6.Checked = true;
            else if (yourAnswer[(page - 1) * 6 + 5] == "C")
                C6.Checked = true;
            else if (yourAnswer[(page - 1) * 6 + 5] == "D")
                D6.Checked = true;
            
        }
        public void showasw()
        {
            string yourAsw = string.Join("", yourAnswer);
            if (yourAsw[(page - 1) * 6].Equals(trueAnswer[(page - 1) * 6]))
            {
                daan1.Text = "答案正确";
            }
            else
                daan1.Text = "答案错误，你的答案：" + yourAsw[(page - 1) * 6] + "  正确答案：" + trueAnswer[(page - 1) * 6];
            if (yourAsw[(page - 1) * 6 + 1].Equals(trueAnswer[(page - 1) * 6 + 1]))
            {
                daan2.Text = "答案正确";
                right++;
            }
            else
                daan2.Text = "答案错误，你的答案：" + yourAsw[(page - 1) * 6 + 1] + "  正确答案：" + trueAnswer[(page - 1) * 6 + 1];
            if (yourAsw[(page - 1) * 6 + 2].Equals(trueAnswer[(page - 1) * 6 + 2]))
            {
                daan3.Text = "答案正确";
                right++;
            }
            else
                daan3.Text = "答案错误，你的答案：" + yourAsw[(page - 1) * 6 + 2] + "  正确答案：" + trueAnswer[(page - 1) * 6 + 2];
            if (yourAsw[(page - 1) * 6 + 3].Equals(trueAnswer[(page - 1) * 6 + 3]))
            {
                daan4.Text = "答案正确";
                right++;
            }
            else
                daan4.Text = "答案错误，你的答案：" + yourAsw[(page - 1) * 6 + 3] + "  正确答案：" + trueAnswer[(page - 1) * 6 + 3];
            if (yourAsw[(page - 1) * 6 + 4].Equals(trueAnswer[(page - 1) * 6 + 4]))
            {
                daan5.Text = "答案正确";
                right++;
            }
            else
                daan5.Text = "答案错误，你的答案：" + yourAsw[(page - 1) * 6 + 4] + "  正确答案：" + trueAnswer[(page - 1) * 6 + 4];
            if (yourAsw[(page - 1) * 6 + 5].Equals(trueAnswer[(page - 1) * 6 + 5]))
            {
                daan6.Text = "答案正确";
                right++;
            }
            else
                daan6.Text = "答案错误，你的答案：" + yourAsw[(page - 1) * 6 + 5] + "  正确答案：" + trueAnswer[(page - 1) * 6 + 5];
            
        }
        /// <summary>
        /// 添加成绩
        /// </summary>
        /// <param name="_page"></param>
        /// <param name="_score"></param>
        public void addScore(int _score) {
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            string strSqlq1 = "insert into score values('" + xuehao + "','" + _score + "')";    
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
            Tid -= 6;
            getasw();
            if(page>1)
            page--;
            label2.Text = page.ToString();
            
            clearRadioButton();
            bddata();
            if (submit.Enabled == false)
            {
                showasw();
            }
            writetimu(Tid, Tid + 1, Tid + 2, Tid + 3, Tid + 4, Tid + 5);
         }
        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void p2_Click(object sender, EventArgs e)
        {
            Tid += 6;
            getasw();
           // MessageBox.Show(yourAnswer[0]);
            page++;
            label2.Text = page.ToString();
            
            clearRadioButton();
            bddata();
            if (submit.Enabled == false)
            {
                showasw();
            }
            writetimu(Tid, Tid + 1, Tid + 2, Tid + 3, Tid + 4, Tid + 5);
        }
        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submit_Click(object sender, EventArgs e)
        {
           
            getasw();
            check();
            string str = string.Join( "",yourAnswer);    
          //  MessageBox.Show(str);
           // MessageBox.Show(trueAnswer);
           // MessageBox.Show(score.ToString());
            showasw();
            submit.Enabled = false;

            addScore(score);
            label5.Text = score.ToString();
        }
        private void update_Click(object sender, EventArgs e)
        {
            updateIn up = new updateIn(xuehao);
            up.Show();
            this.Hide();
        }

        private void main_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < yourAnswer.Length; ++i)
            {
                yourAnswer[i] = " ";
            }
            gettrueasw();
        }

        public string arrayToString(string[] strArray)
         {
             StringBuilder str = new StringBuilder();
            for (int i=0; i < strArray.Length; i++)
             {
                 if (i > 0)
                {   
                     //分割符可根据需要自行修改
                    str.Append(",");
                 }
                str.Append(strArray[i]);
             }
             return str.ToString();
         }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
