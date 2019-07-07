using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.OleDb;

namespace PDM
{
    public partial class ExcelToSQL : Form
    {
        public ExcelToSQL()
        {
            InitializeComponent();
            
        }
        DataTable dt = new DataTable();
        string connString = "Data Source=(local); Initial Catalog=Practice; user id=sa; password=sa;";
        SqlConnection conn;
        
       
            
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        private void bind(string fileName)
        {
            string fileExtenSion;
            fileExtenSion = Path.GetExtension(fileName);
            string connstr2003 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
            string connstr2007 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=\"Excel 12.0;HDR=YES\"";
            OleDbConnection conn;
           if (fileExtenSion.ToLower() == ".xls")
            {
                conn = new OleDbConnection(connstr2003);
            }
            else
            {
                conn = new OleDbConnection(connstr2007);
            }
            conn.Open();
            string sql = "select * from [Sheet1$]";//请注意这个sheet后面的数字！
            OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Close();
            try
            {
                da.Fill(ds);
                dt = ds.Tables[0];
                this.dataGridView1.DataSource = dt;
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());
            }  
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
           
        }   
        private void insertToSql(DataRow datarow)
        {
            conn = new SqlConnection(connString);
            conn.Open();
            //excel表中的列名和数据库中的列名一定要对应  
            string sql1;
            string sql2;
            string sql3;

            //确保操作的为物料管理表
            if (dt.Columns[0].ColumnName.ToString() == "物料编号" && dt.Columns[1].ColumnName.ToString() == "物料名称"&&PublicPass.category=="materials management")
            {
                string kehubianhao = datarow["物料编号"].ToString();
                string kehumingcheng = datarow["物料名称"].ToString();
                string kehudizhi = datarow["物料类型"].ToString();
                string kehuwangzhi = datarow["物料属性"].ToString();
                string suoshudijishi = datarow["物料图号"].ToString();
                sql1 = string.Format("insert into Books_Info(物料编号,物料名称,物料类型,物料属性,物料图号) values('{0}','{1}','{2}','{3}','{4}')", kehubianhao, kehumingcheng, kehudizhi, kehuwangzhi,suoshudijishi);
                SqlCommand cmd = new SqlCommand(sql1, conn);
                cmd.CommandText = sql1;
                cmd.ExecuteNonQuery();
            }
            //操作的为物料清单表
            else if (dt.Columns[0].ColumnName.ToString() == "物料编号" && dt.Columns[1].ColumnName.ToString() == "阶次"&&PublicPass.category=="bom")
            {
                string kehubianhao = datarow["物料编号"].ToString();
                string lianxiriqi = datarow["阶次"].ToString();
                string kehulianxiren = datarow["零部件名称"].ToString();
                string shouji = datarow["规格型号"].ToString();
                string guhua = datarow["单位"].ToString();
                string qq = datarow["用量"].ToString();
                string cx = datarow["车型"].ToString();
                string cj = datarow["车间"].ToString();
                string sszj = datarow["所属组件"].ToString();
                sql2 = string.Format("insert into bom(物料编号,阶次,零部件名称,规格型号,单位,用量,车型,所属组件,车间) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", kehubianhao, lianxiriqi, kehulianxiren, shouji, guhua, qq,cx,sszj,cj);
                SqlCommand cmd = new SqlCommand(sql2, conn);
                cmd.CommandText = sql2;
                cmd.ExecuteNonQuery();
            }
            //操作的为工艺路线表
            else if(dt.Columns[0].ColumnName.ToString() == "工艺序号" && dt.Columns[1].ColumnName.ToString() == "工艺名称" && PublicPass.category == "pr")
            {
                string gyxh = datarow["工艺序号"].ToString();
                string gymc= datarow["工艺名称"].ToString();
                string gysm= datarow["工艺说明"].ToString();
                string lbj= datarow["零部件"].ToString();
                string sysl= datarow["使用数量"].ToString();
                string gs= datarow["工时"].ToString();
                string lmyl= datarow["螺母用量"].ToString();
                sql3 = string.Format("insert into process_route(工艺序号,工艺名称,工艺说明,零部件,使用数量,工时,螺母用量)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", gyxh, gymc, gysm, lbj, sysl, gs, lmyl);
                SqlCommand cmd = new SqlCommand(sql3, conn);
                cmd.CommandText = sql3;
                cmd.ExecuteNonQuery();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string fileName = fd.FileName;
                bind(fileName);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                conn = new SqlConnection(connString);
                conn.Open();
                if (dataGridView1.Rows.Count > 0)
                {
                    DataRow datarow = null;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        datarow = dt.Rows[i];
                        insertToSql(datarow);
                    }
                    conn.Close();
                    MessageBox.Show("导入成功！");
                }
                else
                {
                    MessageBox.Show("导入失败！");
                }
            }
            else MessageBox.Show("请先选择表格！");
            this.Close();
        }
    }
}
