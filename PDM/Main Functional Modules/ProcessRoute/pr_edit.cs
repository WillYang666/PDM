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
    public partial class pr_edit : Form
    {
        public pr_edit()
        {
            InitializeComponent();
        }

        private void pr_add_Load(object sender, EventArgs e)
        {
            GYXH.Text = PublicPass.process_id;
            GYXH.ReadOnly = true;
            GYMC.Text = PublicPass.process_name;
            GYSM.Text = PublicPass.process_describe;
            LBJ.Text = PublicPass.process_lbj;
            SYSL.Text = PublicPass.process_number;
            GS.Text = PublicPass.process_gs;
            LMYL.Text = PublicPass.process_lmyl;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string sql = "update process_route set 工艺名称='" + GYMC.Text + "',工艺说明='" + GYSM.Text + "',零部件='" + LBJ.Text + "',使用数量='" + SYSL.Text + "',工时='" + GS.Text + "',螺母用量='" + LMYL.Text + "'where 工艺序号='" + GYXH.Text + "'";
            DataBaseApplication.ExecuteNonQuery(sql);
            MessageBox.Show("修改成功");
            this.Close();
        }
    }
}
