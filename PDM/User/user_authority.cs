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
    public partial class user_authority : Form
    {
        public user_authority()
        {
            InitializeComponent();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void user_authority_Load(object sender, EventArgs e)
        {
            string sql = "select 用户id from PDM_users";
            DataTable dt = new DataTable();
            dt = DataBaseApplication.GetDataTableValue(sql);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "用户id";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string sql="update PDM_users set 用户权限='"+comboBox2.Text+"'where 用户id='"+comboBox1.Text+"'";
            DataBaseApplication.ExecuteNonQuery(sql);
            MessageBox.Show("修改成功！");

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
