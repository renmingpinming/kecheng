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
    public partial class addtimu : Form
    {
        String xuehao;
        int max = 0;
        int _ID = 0;
        public addtimu(String _xuehao)
        {
            InitializeComponent();
            xuehao = _xuehao;
            string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            string newsql = "select * from timu";
            SqlDataAdapter da = new SqlDataAdapter(newsql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            max = dt.Rows.Count;
            _ID = max + 1;
            ID.Text = _ID.ToString();
        }

        private void addtimu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            String _timu = timu.Text.Trim();
            String x1 = xA.Text.Trim();
            String x2 = xB.Text.Trim();
            String x3 = xC.Text.Trim();
            String x4 = xD.Text.Trim();
            String truea = xT.Text.Trim();
            if (_timu == String.Empty) {
                MessageBox.Show("题目不能为空！");
                timu.Focus();
            }
            else if (x1 == String.Empty)
            {
                MessageBox.Show("答案不能为空！");
                xA.Focus();
            }
            else if (x2 == String.Empty)
            {
                MessageBox.Show("答案不能为空！");
                xB.Focus();
            }
            else if (x3 == String.Empty)
            {
                MessageBox.Show("答案不能为空！");
                xC.Focus();
            }
            else if (x4 == String.Empty)
            {
                MessageBox.Show("答案不能为空！");
                xD.Focus();
            }
            else if (truea == String.Empty)
            {
                MessageBox.Show("答案不能为空！");
                xT.Focus();
            }
            else {
                String A = 'A' + x1;
                String B = 'B' + x2;
                String C = 'C' + x3;
                String D = 'D' + x4;
                string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
                SqlConnection conn = new SqlConnection(_connectionString);
                conn.Open();
                string strSql = "insert into timu values ("+_ID+",'"+_timu+"','"+A+"','"+B+"','"+C+"','"+D+"','"+truea+"')";
                SqlCommand cmd = new SqlCommand(strSql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("提交成功！");
                ID.Text = null;
                timu.Text = null;
                xA.Text = null;
                xB.Text = null;
                xC.Text = null;
                xD.Text = null;
                xT.Text = null;
            }
        }
    }
}
