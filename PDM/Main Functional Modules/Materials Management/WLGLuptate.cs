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
    public partial class WLGLuptate : Form
    {
        public WLGLuptate()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string sql = "update materials_management set 物料名称='" + WLMC.Text.ToString() + "',物料类型='" + WLLX.Text.ToString() + "',物料属性='" + WLSX.Text.ToString() + "',物料图号='" + WLTH.Text.ToString() + "'  where 物料编号='" + WLBH.Text.ToString() + "'";
            DataBaseApplication.ExecuteNonQuery(sql);
            MessageBox.Show("修改成功");
            this.Close();
        }

        private void WLGLuptate_Load(object sender, EventArgs e)
        {
            WLBH.ReadOnly = true;//物料编号不允许修改

            WLBH.Text = PublicPass.material_id.ToString();
            WLMC.Text = PublicPass.material_name.ToString();
            WLLX.Text = PublicPass.material_category.ToString();
            WLSX.Text = PublicPass.material_property.ToString();
            WLTH.Text = PublicPass.material_picid.ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
