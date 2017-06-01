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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void zuce_Click(object sender, EventArgs e)
        {
            String _zhanghao = zhanghao.Text.Trim();
            String _name = name.Text.Trim();
            String _psd = psw.Text.Trim();
            String _psdagain = psdagain.Text.Trim();
            if (_zhanghao == string.Empty) {
                MessageBox.Show("账号不能为空！");
                zhanghao.Focus();
            }
            else if (_name == string.Empty)
            {
                MessageBox.Show("姓名不能为空！");
                name.Focus();
            }
            else if (_psd == string.Empty) {
                MessageBox.Show("密码不能为空！");
                psw.Focus();
            }
            else if (!_psd.Equals(_psdagain))
            {
                MessageBox.Show("密码不同！");
                psdagain.Focus();
            }
            else
            {
                string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
                SqlConnection conn = new SqlConnection(_connectionString);
                conn.Open();
                string strSql = "insert into student(学号,姓名,密码) values ('" + _zhanghao + "','" + _name + "','" + _psd + "')";
                SqlCommand cmd = new SqlCommand(strSql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("注册成功！");
                zhanghao.Text = null;
                name.Text = null;
                psw.Text = null;
                psdagain.Text = null;
            }
        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
}
