using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace PDM
{
    public partial class insert : Form
    {
        public insert()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //用户打开文件浏览
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                //只能单选一个文件
                dialog.Multiselect = false;
                //格式筛选
                if(PublicPass.category=="file_pic")
                {
                    dialog.Filter = "图片文件|*.jpg;*.png;*.pdf";
                }
                else if(PublicPass.category=="file_word")
                {
                    dialog.Filter = "word文档|*.doc;*.docx";
                }
                else if(PublicPass.category=="file_cad")
                {
                    dialog.Filter = "cad文档|*.dwg";
                }
                //选择一个文件
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //把选择的文件路径给Path
                        textEdit_path.Text = dialog.FileName.ToString();
                    }
                    catch (Exception ex)
                    {
                        //抛出异常
                        throw (ex);
                    }
                }
            }
        }

        private void simpleButton_ok_Click(object sender, EventArgs e)
        {
            //以下为导入部分
            if (textEdit_path != null&&PublicPass.category=="file_pic")//判断是否为文档管理——图片
            {
                FileStream fs = new FileStream(textEdit_path.Text, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                Byte[] byData = br.ReadBytes((int)fs.Length);//获取长度

                string conn = "server=(local);database=Practice;Uid=sa;Pwd=sa ";//连接数据库
                SqlConnection myconn = new SqlConnection(conn);
                myconn.Open();
                string str = "insert into file_pictures (名称,描述,建立者,建立时间,文件,编号) values('"+textEdit_name.Text.ToString()+"','"+textEdit_describe.Text.ToString() + "','"+textEdit_founder.Text.ToString() + "','"+textEdit_time.Text.ToString()+ "',@file,'"+textEdit_id.Text.ToString()+"')";
                SqlCommand mycomm = new SqlCommand(str, myconn);
                mycomm.Parameters.Add("@file", SqlDbType.Binary, byData.Length);
                mycomm.Parameters["@file"].Value = byData;
                mycomm.ExecuteNonQuery();
                myconn.Close();
                MessageBox.Show("添加成功！");
                this.Close();

            }
            if (textEdit_path != null && PublicPass.category == "file_word")//判断是否为文档管理——word文档
            {
                FileStream fs = new FileStream(textEdit_path.Text, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                Byte[] byData = br.ReadBytes((int)fs.Length);//获取长度

                string conn = "server=(local);database=Practice;Uid=sa;Pwd=sa ";//连接数据库
                SqlConnection myconn = new SqlConnection(conn);
                myconn.Open();
                string str = "insert into file_words (名称,描述,建立者,建立时间,文件,编号) values('" + textEdit_name.Text.ToString() + "','" + textEdit_describe.Text.ToString() + "','" + textEdit_founder.Text.ToString() + "','" + DateTime.Now.ToString() + "',@file,'" + textEdit_id.Text.ToString() + "')";
                SqlCommand mycomm = new SqlCommand(str, myconn);
                mycomm.Parameters.Add("@file", SqlDbType.Binary, byData.Length);
                mycomm.Parameters["@file"].Value = byData;
                mycomm.ExecuteNonQuery();
                myconn.Close();
                MessageBox.Show("添加成功");
                this.Close();
            }
        }

        private void insert_Load(object sender, EventArgs e)
        {
            textEdit_time.ReadOnly = true;
            textEdit_time.Text = DateTime.Now.ToString();
        }
    }
}
