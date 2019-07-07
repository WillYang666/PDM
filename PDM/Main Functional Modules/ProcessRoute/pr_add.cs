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
    public partial class process_route : Form
    {
        public process_route()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //pr_add防错
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
                                        string sql = "insert into process_route(工艺序号,工艺名称,工艺说明,零部件,使用数量,工时,螺母用量)values('" + GYXH.Text.ToString() + "','" + GYMC.Text.ToString() + "','" + GYSM.Text.ToString() + "','" + LBJ.Text.ToString() + "','" + SYSL.Text.ToString() + "','" + GS.Text.ToString() + "','" + LMYL.Text.ToString() + "')";
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
            //pr_add防错
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void process_route_Load(object sender, EventArgs e)
        {
            //连接数据库
            DataBaseApplication.DataSource = "(local)";
            DataBaseApplication.DataBaseName = "Practice";
            DataBaseApplication.UserID = "sa";
            DataBaseApplication.PassWord = "sa"; ;
        }
    }
}
