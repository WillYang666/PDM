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
    public partial class Adduser : Form
    {
        public Adduser()
        {
            InitializeComponent();
        }

        private void Adduser_Load(object sender, EventArgs e)
        {

            //连接数据库
            DataBaseApplication.DataSource = "(local)";
            DataBaseApplication.DataBaseName = "Practice";
            DataBaseApplication.UserID = "sa";
            DataBaseApplication.PassWord = "sa";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Adduser防错
            if (YHQX.Text != "")
            {
                if (YHMM.Text != "")
                {
                    if (YHM.Text != "")
                    {
                        if (YHID.Text != "")
                        {
                            string sql = "insert into 用户权限表(用户id,用户名,用户密码,用户权限)values('" + YHID.Text.ToString() + "','" + YHM.Text.ToString() + "','" + YHMM.Text.ToString() + "','" + YHQX.Text.ToString() + "')";
                            DataBaseApplication.ExecuteNonQuery(sql);
                            MessageBox.Show("添加成功");
                            PublicPass.ii = 1;
                            this.Close();
                        }
                    }
                }
            }
            if (PublicPass.ii == 0)
            {
                MessageBox.Show("请补全信息！");
                return;
            }
            //Adduser防错
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
