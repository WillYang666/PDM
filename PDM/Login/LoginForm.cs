using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDM
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //连接数据库
            DataBaseApplication.DataSource = "(local)";
            DataBaseApplication.DataBaseName = "Practice";
            DataBaseApplication.UserID = "sa";
            DataBaseApplication.PassWord = "sa";
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            //#1判断非空 trim用于删除空格
            if (this.Nameid.Text.ToString().Trim() == "" || this.Password.Text.ToString().Trim() == "")
            {
                MessageBox.Show("请补全用户名密码");
                return;
            }

            //判断用户是否存在
            DataTable dt = new DataTable();
            string user_name = "";
            string pass_word = "";
            //读取界面值
            user_name = this.Nameid.Text.ToString().Trim();
            pass_word = this.Password.Text.ToString().Trim();
            //sql
            string sql = "select * from PDM_users where 用户id='" + user_name + "'";
            dt = DataBaseApplication.GetDataTableValue(sql);
            //读取账号所有人的名字
            PublicPass.username = dt.Rows[0]["用户名"].ToString();
            //读取账号
            PublicPass.userid = dt.Rows[0]["用户id"].ToString();

            //判断用户是否存在
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("该用户不存在");
                return;
            }
            //判断密码和权限
            if (dt.Rows[0]["用户密码"].ToString() == pass_word)
            {

                SystemLog.loginState = "OK";
                SystemLog.user_name = user_name;
                SystemLog.user_key = dt.Rows[0]["用户密码"].ToString();
                this.Close();
                

            }
            if (dt.Rows[0]["用户密码"].ToString() != pass_word)
            {
                MessageBox.Show("用户名和密码不匹配");
            }
        }
    }
    }

