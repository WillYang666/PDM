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
    public partial class BOM_edit : Form
    {
        public BOM_edit()
        {
            InitializeComponent();
        }

        private void BOM_edit_Load(object sender, EventArgs e)
        {
            WLBH.Text = PublicPass.material_id;
            WLBH.ReadOnly = true;
            JC.Text = PublicPass.material_level;
            LBJMC.Text = PublicPass.material_lbjname;
            GGXH.Text = PublicPass.material_ggxh;
            DW.Text = PublicPass.material_unit;
            YL.Text = PublicPass.material_usagenumber;
            CJ.Text = PublicPass.material_chejian;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string sql = "update bom set 物料编号='" + WLBH.Text + "',阶次='" + JC.Text + "',零部件名称='" + LBJMC.Text + "',规格型号='"+GGXH.Text+"',单位='"+DW.Text+"',用量='"+YL.Text+"',车间='"+CJ.Text+"'";
            DataBaseApplication.ExecuteNonQuery(sql);
            MessageBox.Show("修改成功！");
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
