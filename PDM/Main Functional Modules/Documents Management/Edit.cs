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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            textEdit_id.Text = PublicPass.id.ToString();
            textEdit_id.ReadOnly = true;
            textEdit_describe.Text = PublicPass.describe.ToString();
            textEdit_founder.Text = PublicPass.founder.ToString();
            textEdit_name.Text = PublicPass.name.ToString();
            textEdit_time.Text = PublicPass.time.ToString();
        }

        private void simpleButton_ok_Click(object sender, EventArgs e)
        {
            if(PublicPass.category=="file_pic")
            {
                string sql = "update file_pictures set 名称='" + textEdit_name.Text.ToString() + "',描述='" + textEdit_describe.Text.ToString() + "',建立者='" + textEdit_founder.Text.ToString() + "',建立时间='" + textEdit_time.Text + "',where 编号='" + textEdit_id.Text.ToString() + "'";
                DataBaseApplication.ExecuteNonQuery(sql);
            }
            if(PublicPass.category=="file_word")
            {
                string sql = "update file_words set 名称='" + textEdit_name.Text.ToString() + "',描述='" + textEdit_describe.Text.ToString() + "',建立者='" + textEdit_founder.Text.ToString() + "',建立时间='" + textEdit_time.Text + "' where 编号='" + textEdit_id.Text.ToString() + "'";
                DataBaseApplication.ExecuteNonQuery(sql);
            }
            if(PublicPass.category=="file_cad")
            {
                string sql = "update file_cads set 名称='" + textEdit_name.Text.ToString() + "',描述='" + textEdit_describe.Text.ToString() + "',建立者='" + textEdit_founder.Text.ToString() + "',建立时间='" + textEdit_time.Text + "' where 编号='" + textEdit_id.Text.ToString() + "'";
                DataBaseApplication.ExecuteNonQuery(sql);
            }
            MessageBox.Show("修改成功！");
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            textEdit_time.Text = DateTime.Now.ToString();
        }
    }
}
