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
    public partial class user_info : Form
    {
        public user_info()
        {
            InitializeComponent();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void user_info_Load(object sender, EventArgs e)
        {
            //load sql*
            string sql = "select * from PDM_users";
            DataTable dt = new DataTable();
            dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
            gridControl1.DataSource = dt;
            //load sql*
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //删除用户
            PublicPass.id = (string)gridView1.GetFocusedRowCellValue("用户id");

            DialogResult result = MessageBox.Show("确认删除？", "温馨提示", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string sql = "delete from PDM_users where 用户id='" + PublicPass.id + "'";//执行删除语句
                DataBaseApplication.ExecuteNonQuery(sql);
                MessageBox.Show("删除成功！");
            }
            //删除用户
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //user_info里的添加控件
            Adduser add = new Adduser();
            add.ShowDialog();
            //user_info里的添加控件
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            PublicPass.id= (string)gridView1.GetFocusedRowCellValue("用户id");//获取用户id
            PublicPass.username = (string)gridView1.GetFocusedRowCellValue("用户名");//获取用户名
            PublicPass.userpass = (string)gridView1.GetFocusedRowCellValue("用户密码");
            PublicPass.userauthority = (string)gridView1.GetFocusedRowCellValue("用户权限");

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            user_authority us = new user_authority();
            us.ShowDialog();
        }
    }
}
