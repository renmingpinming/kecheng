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
        public addtimu(String _xuehao)
        {
            InitializeComponent();
            xuehao = _xuehao;
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
            String _ID = ID.Text.Trim();
            String _timu = timu.Text.Trim();
            String x1 = xA.Text.Trim();
            String x2 = xB.Text.Trim();
            String x3 = xC.Text.Trim();
            String x4 = xD.Text.Trim();
            String truea = xT.Text.Trim();
            if (_ID == String.Empty)
            {
                MessageBox.Show("题目不能为空！");
                timu.Focus();
            }
            else if (_timu == String.Empty) {
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
                int id = int.Parse(_ID);
                String A = 'A' + x1;
                String B = 'B' + x2;
                String C = 'C' + x3;
                String D = 'D' + x4;
                string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
                SqlConnection conn = new SqlConnection(_connectionString);
                conn.Open();
                string strSql = "insert into timu values ("+id+",'"+_timu+"','"+A+"','"+B+"','"+C+"','"+D+"','"+truea+"')";
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
