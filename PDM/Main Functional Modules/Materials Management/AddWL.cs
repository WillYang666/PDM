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
    public partial class AddWL : Form
    {
        public AddWL()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddWL_Load(object sender, EventArgs e)
        {
            /*
            //连接数据库
            DataBaseApplication.DataSource = "(local)";
            DataBaseApplication.DataBaseName = "Practice";
            DataBaseApplication.UserID = "sa";
            DataBaseApplication.PassWord = "sa";
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //AddWL防错
            if (WLTH.Text != "")
            {
                if (WLBH.Text != "")
                {
                    if (WLMC.Text != "")
                    {
                        if (WLLX.Text != "")
                        {
                            if (WLSX.Text != "")
                            {
                                string sql = "insert into materials_management(物料编号,物料名称,物料类型,物料属性,物料图号)values('" + WLBH.Text.ToString() + "','" + WLMC.Text.ToString() + "','" + WLLX.Text.ToString() + "','" + WLSX.Text.ToString() + "','" + WLTH.Text.ToString() + "')";
                                DataBaseApplication.ExecuteNonQuery(sql);
                                MessageBox.Show("添加成功");
                                PublicPass.ii = 1;
                                this.Close();
                            }
                        }
                    }
                }
            }
            if (PublicPass.ii == 0)
            {
                MessageBox.Show("请补全信息！");
                return;
            }
            //AddWL防错
        }
    }
}
