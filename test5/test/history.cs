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
    public partial class history : Form
    {
        string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
        String xuehao="";
        int num = 0;
        public history(String _xuehao)
        {
            InitializeComponent();
            xuehao = _xuehao;
        }

        public void showScore() {
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();

            string newsql = "select * from score where 学号 ='" + xuehao + "'";
            SqlDataAdapter da = new SqlDataAdapter(newsql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            DataTable dt = ds.Tables[0];
            int count = dt.Rows.Count;
            if (count == 0)
                MessageBox.Show("无记录");
            else
            {
                if (num >= count - 1)
                    num = count - 1;
                if (num <= 0)
                    num = 0;

                p1.Text = dt.Rows[num]["页"].ToString();
                s1.Text = dt.Rows[num]["成绩"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num++;
            showScore();
        }

        private void back_Click(object sender, EventArgs e)
        {
            main m = new main(xuehao);
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num--;
            showScore();
        }

        private void history_Load(object sender, EventArgs e)
        {

        }
    }
}
