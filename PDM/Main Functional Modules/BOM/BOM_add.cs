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
    public partial class BOM_add : Form
    {
        public BOM_add()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //BOM_add防错
            if (GYXH.Text != "")
            {
                if (GYMC.Text != "")
                {
                    if (GYSM.Text != "")
                    {
                        if (LBJ.Text != "")
                        {
                            if (SYSL.Text != "")
                            {
                                if (GS.Text != "")
                                {
                                    if (LMYL.Text != "")
                                    {
                                        string sql = "insert into bom(物料编号,阶次,零部件名称,规格型号,单位,用量,车间)values('" + GYXH.Text.ToString() + "','" + GYMC.Text.ToString() + "','" + GYSM.Text.ToString() + "','" + LBJ.Text.ToString() + "','" + SYSL.Text.ToString() + "','" + GS.Text.ToString() + "','" + LMYL.Text.ToString() + "')";
                                        DataBaseApplication.ExecuteNonQuery(sql);
                                        MessageBox.Show("添加成功");
                                        PublicPass.ii = 1;
                                        this.Close();
                                    }
                                }
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
            //BOM_add防错
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
