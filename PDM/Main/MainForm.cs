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
using Microsoft.Office.Core;

namespace PDM
{
    public partial class MainForm : Form
    {
        public TreeNode RootNode = new TreeNode();//全局根节点(文件管理）
        //3个根节点——物料清单
        public TreeNode RootNode1 = new TreeNode();
        public TreeNode RootNode2 = new TreeNode();
        public TreeNode RootNode3 = new TreeNode();
        public MainForm()
        {
            InitializeComponent();
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //连接数据库
            DataBaseApplication.DataSource = "(local)";
            DataBaseApplication.DataBaseName = "Practice";
            DataBaseApplication.UserID = "sa";
            DataBaseApplication.PassWord = "sa";

            AnimateWindow(this.Handle, 200, AW_BLEND);//即可实现淡入淡出渐变效果

            //时间显示
            timer1.Interval = 1000;
            timer1.Start();

            //底部用户名显示
            barStaticItem6.Caption = PublicPass.username;

            this.tabPage1.Parent = null; //开始运行时隐藏文档管理栏
            this.tabPage2.Parent = null; //开始运行时隐藏物料管理栏
            this.tabPage3.Parent = null; //开始运行时隐藏物料清单栏
            this.tabPage4.Parent = null;//开始运行时隐藏工艺路线栏
            this.tabPage5.Parent = null;//开始运行时隐藏预览栏

        }
        //没用的部分
        #region
        #region
        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void createNodes(String rootFile, TreeNode rootNode)
        {
           

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }
        #endregion

        //将treeview中选中的节点下的文件展示在右边的listview中
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {



        }

        private void dockPanel1_Click(object sender, EventArgs e)
        {

        }
        #endregion
        //上面为没用的
        #region
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //图片检索按钮
            PublicPass.category = "file_pic";//file_pic代表图片检索
            string sql = "select * from file_pictures";
            DataTable dt = new DataTable();
            dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
            gridControl1.DataSource = dt;
        }
        #endregion

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if(PublicPass.category==null)
            {
                MessageBox.Show("请先选择文件类型！");
            }
            else
            {
                insert abc = new insert();
                abc.ShowDialog();
            }
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //word文档检索按钮
            PublicPass.category = "file_word";//file_wordd代表word文档检索
            string sql = "select * from file_words";
            DataTable dt = new DataTable();
            dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
            gridControl1.DataSource = dt;
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            //导出文件
            if (this.gridView1.GetFocusedDataRow()[0].ToString() == "")
            {
                MessageBox.Show("请先选中！");
                return;
            }
            PublicPass.id = (string)gridView1.GetFocusedRowCellValue("编号");//获取文件的编号

            if(PublicPass.category=="file_pic")//判断导出的是否为图片文件
            {
                string conn = "server=(local);database=Practice;Uid=sa;Pwd=sa ";
                string str = "select 文件 from file_pictures where 编号='"+PublicPass.id+"' ";
                SqlConnection myconn = new SqlConnection(conn);
                SqlDataAdapter sda = new SqlDataAdapter(str, conn);
                DataSet myds = new DataSet();
                myconn.Open();
                sda.Fill(myds);
                myconn.Close();
                Byte[] Files = (Byte[])myds.Tables[0].Rows[0]["文件"];
                BinaryWriter bw = new BinaryWriter(File.Open(@"\\Mac\Home\Desktop\图片导出文件"+DateTime.Now.Second+".jpg", FileMode.OpenOrCreate));
                bw.Write(Files);
                bw.Close();
                MessageBox.Show("导出成功！");
            }
            if(PublicPass.category=="file_word")//判断导出的是否为word文件
            {
                string conn = "server=(local);database=Practice;Uid=sa;Pwd=sa ";
                string str = "select 文件 from file_words where 编号='" + PublicPass.id + "' ";
                SqlConnection myconn = new SqlConnection(conn);
                SqlDataAdapter sda = new SqlDataAdapter(str, conn);
                DataSet myds = new DataSet();
                myconn.Open();
                sda.Fill(myds);
                myconn.Close();
                Byte[] Files = (Byte[])myds.Tables[0].Rows[0]["文件"];
                BinaryWriter bw = new BinaryWriter(File.Open(@"\\Mac\Home\Desktop\Word导出文件" + DateTime.Now.Second + ".docx", FileMode.OpenOrCreate));
                bw.Write(Files);
                bw.Close();
                MessageBox.Show("导出成功！");
            }
            if (PublicPass.category == "file_cad")//判断导出的是否为cad文件
            {
                string conn = "server=(local);database=Practice;Uid=sa;Pwd=sa ";
                string str = "select 文件 from file_cads where 编号='" + PublicPass.id + "' ";
                SqlConnection myconn = new SqlConnection(conn);
                SqlDataAdapter sda = new SqlDataAdapter(str, conn);
                DataSet myds = new DataSet();
                myconn.Open();
                sda.Fill(myds);
                myconn.Close();
                Byte[] Files = (Byte[])myds.Tables[0].Rows[0]["文件"];
                BinaryWriter bw = new BinaryWriter(File.Open(@"\\Mac\Home\Desktop\CAD导出文件" + DateTime.Now.Second + ".dwg", FileMode.OpenOrCreate));
                bw.Write(Files);
                bw.Close();
                MessageBox.Show("导出成功！");
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            PublicPass.id=(string)gridView1.GetFocusedRowCellValue("编号");//获取文件的编号
            PublicPass.name=(string)gridView1.GetFocusedRowCellValue("名称");//获取文件的名称
            PublicPass.describe=(string)gridView1.GetFocusedRowCellValue("描述");//获取文件的描述
            PublicPass.founder=(string)gridView1.GetFocusedRowCellValue("建立者");//获取文件的建立者
            PublicPass.time=(string)gridView1.GetFocusedRowCellValue("建立时间");//获取文件的建立时间 
            
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount==0)
            {
                MessageBox.Show("请先选择文件!");
            }
            else
            {
                PublicPass.id = (string)gridView1.GetFocusedRowCellValue("编号");//获取文件的编号
                PublicPass.name = (string)gridView1.GetFocusedRowCellValue("名称");//获取文件的名称
                PublicPass.describe = (string)gridView1.GetFocusedRowCellValue("描述");//获取文件的描述
                PublicPass.founder = (string)gridView1.GetFocusedRowCellValue("建立者");//获取文件的建立者
                PublicPass.time = (string)gridView1.GetFocusedRowCellValue("建立时间");//获取文件的建立时间 
                Edit edit = new Edit();
                edit.ShowDialog();
            }
            
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            //删除按钮
            if(PublicPass.category=="file_pic")
            {
                DialogResult result = MessageBox.Show("确认删除？", "温馨提示", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string sql = "delete from file_pictures where 编号='" + PublicPass.id + "'";//执行删除语句
                    DataBaseApplication.ExecuteNonQuery(sql);
                    MessageBox.Show("删除成功！");
                } 
            }
            if(PublicPass.category=="file_word")
            {
                DialogResult result = MessageBox.Show("确认删除？", "温馨提示", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string sql = "delete from file_words where 编号='" + PublicPass.id + "'";//执行删除语句
                    DataBaseApplication.ExecuteNonQuery(sql);
                    MessageBox.Show("删除成功！");
                }
            }
            if(PublicPass.category=="file_cad")
            {
                DialogResult result = MessageBox.Show("确认删除？", "温馨提示", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string sql = "delete from file_cads where 编号='" + PublicPass.id + "'";//执行删除语句
                    DataBaseApplication.ExecuteNonQuery(sql);
                    MessageBox.Show("删除成功！");
                }
            }
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            //cad文件检索按钮
            PublicPass.category = "file_cad";//file_cad代表cad文档检索
            string sql = "select * from file_cads";
            DataTable dt = new DataTable();
            dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
            gridControl1.DataSource = dt;
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            //文档管理左侧栏按钮
            barButtonItem25.PerformClick();//两个按钮功能一样，跳转即可
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.tabPage1.Parent = this.tabControl1; //显示文档管理栏

            this.tabPage2.Parent = null; //隐藏物料管理栏
            this.tabPage3.Parent = null;//隐藏物料清单栏
            this.tabPage4.Parent = null;//隐藏工艺路线栏


            //显示结构树
            #region
            treeView1.Nodes.Clear();
            this.RootNode.Nodes.Clear();//在修改、删除后重新load节点，防止出现一样的复制

            //添加根节点、三个子节点（规定）
            RootNode.Text = "文件类型";
            RootNode.ImageIndex = 0;
            this.treeView1.Nodes.Add(RootNode);
            this.treeView1.ImageList = this.imageList1;//结构树中小图标

            TreeNode _nodes1 = new TreeNode();
                _nodes1.Text = "图片文件";
                _nodes1.ImageIndex = 1;
               // _nodes1.SelectedImageIndex = 4;
                 RootNode.Nodes.Add(_nodes1);
             DataTable dt = new DataTable();
            dt = SQLClass.SQLQuery("select * from file_pictures");
            if(dt.Rows.Count>0)
            {
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    TreeNode _nodes = new TreeNode();
                    _nodes.Text = dt.Rows[i]["名称"].ToString();
                     _nodes.ImageIndex = 1;
                    _nodes.SelectedImageIndex = 4;
                    _nodes1.Nodes.Add(_nodes);
                }
            }

            TreeNode _nodes2 = new TreeNode();
            _nodes2.Text = "CAD文件";
            _nodes2.ImageIndex = 3;
            //_nodes.SelectedImageIndex = 2;
            RootNode.Nodes.Add(_nodes2);
            DataTable dt1 = new DataTable();
            dt1 = SQLClass.SQLQuery("select * from file_cads");
            if (dt1.Rows.Count > 0)
            {
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    TreeNode _nodes = new TreeNode();
                    _nodes.Text = dt1.Rows[i]["名称"].ToString();
                     _nodes.ImageIndex = 3;
                    _nodes.SelectedImageIndex = 4;
                    _nodes2.Nodes.Add(_nodes);
                }
            }

            TreeNode _nodes3 = new TreeNode();
            _nodes3.Text = "Word文件";
            _nodes3.ImageIndex = 2;
            //_nodes.SelectedImageIndex = 2;
            RootNode.Nodes.Add(_nodes3);
            DataTable dt2 = new DataTable();
            dt2 = SQLClass.SQLQuery("select * from file_words");
            if (dt2.Rows.Count > 0)
            {
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    TreeNode _nodes = new TreeNode();
                    _nodes.Text = dt2.Rows[i]["名称"].ToString();
                     _nodes.ImageIndex = 2;
                    _nodes.SelectedImageIndex = 4;
                    _nodes3.Nodes.Add(_nodes);
                }
            }
            this.treeView1.ExpandAll();//展开所有节点
#endregion
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            this.tabPage2.Parent = this.tabControl1; //显示物料管理栏
            this.tabPage1.Parent = null; //隐藏文档管理栏
            this.tabPage3.Parent = null;//隐藏物料清单栏
            this.tabPage4.Parent = null;//隐藏工艺路线栏
            this.tabPage5.Parent = null;//隐藏预览栏
            PublicPass.category = "materials management"; //类型为物料管理，以便连接数据库中的表
            barButtonItem24.PerformClick();
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.tabPage2.Parent = this.tabControl1; //显示物料管理栏
            this.tabPage1.Parent = null; //隐藏文档管理栏
            this.tabPage3.Parent = null;//隐藏物料清单栏
            this.tabPage4.Parent = null;//隐藏工艺路线栏
            this.tabPage5.Parent = null;//隐藏预览栏
            PublicPass.category = "materials management"; //类型为物料管理，以便连接数据库中的表

        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            //物料管理--导入excel
            PublicPass.category = "materials management";
            ExcelToSQL ex = new ExcelToSQL();
            ex.ShowDialog();

        }
        //物料管理——查询搜索功能
        #region
        private void simpleButton11_Click(object sender, EventArgs e)
        {
            //防空
            if (comboBoxEdit1.Text != "全部")
            {
                if (comboBoxEdit1.Text == "" || textEdit1.Text == "")
                {
                    MessageBox.Show("请选择检索类型或补全关键字!");
                    return;
                }
            }
            //防空

            if (comboBoxEdit1.Text == "全部")
            {
                string sql = "select * from materials_management";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                gridControl2.DataSource = dt;
            }
            if (comboBoxEdit1.Text == "物料编号")
            {
                string sql = "select * from materials_management where 物料编号 like'%" + textEdit1.Text.ToString() + "%'";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                gridControl2.DataSource = dt;
            }
            if (comboBoxEdit1.Text == "物料名称")
            {
                string sql = "select * from materials_management where 物料名称 like'%" + textEdit1.Text.ToString() + "%'";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                gridControl2.DataSource = dt;
            }
            if (comboBoxEdit1.Text == "物料类型")
            {
                string sql = "select * from materials_management where 物料类型 like'%" + textEdit1.Text.ToString() + "%'";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                gridControl2.DataSource = dt;
            }
            if (comboBoxEdit1.Text == "物料属性")
            {
                string sql = "select * from materials_management where 物料属性 like'%" + textEdit1.Text.ToString() + "%'";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                gridControl2.DataSource = dt;
            }
            if (comboBoxEdit1.Text == "物料图号")
            {
                string sql = "select * from materials_management where 物料图号 like'%" + textEdit1.Text.ToString() + "%'";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                gridControl2.DataSource = dt;
            }
        }
        #endregion
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            AddWL add = new AddWL();
            add.ShowDialog();
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //数据库连接设置
            Database db = new Database();
            db.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            barStaticItem3.Caption =DateTime.Now.ToString();
        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            //删除物料
            PublicPass.id = (string)gridView2.GetFocusedRowCellValue("物料编号");

            DialogResult result = MessageBox.Show("确认删除？", "温馨提示", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string sql = "delete from materials_management where 物料编号='" + PublicPass.id + "'";//执行删除语句
                DataBaseApplication.ExecuteNonQuery(sql);
                MessageBox.Show("删除成功！");
            }
            //删除物料
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PublicPass.category = "bom";//类型为物料清单

            this.tabPage3.Parent = this.tabControl1; //显示物料清单栏
            this.tabPage1.Parent = null;//隐藏文档管理栏
            this.tabPage2.Parent = null;//隐藏物料管理栏
            this.tabPage4.Parent = null;//隐藏工艺路线栏
            this.tabPage5.Parent = null;//隐藏预览栏

            //结构树
            treeView2.Nodes.Clear();
            this.RootNode1.Nodes.Clear();//在修改、删除后重新load节点，防止出现一样的复制
            this.RootNode2.Nodes.Clear();
            this.RootNode3.Nodes.Clear();

            //绑定imagelist
              this.treeView2.ImageList = this.imageList2;//结构树中小图标

            //添加三个根节点
            RootNode1.Text = "自行车";
            this.treeView2.Nodes.Add(RootNode1);
            RootNode1.ImageIndex = 0;

            RootNode2.Text = "产品";
            this.treeView2.Nodes.Add(RootNode2);
            RootNode2.ImageIndex = 1;

            RootNode3.Text = "组件";
            this.treeView2.Nodes.Add(RootNode3);
            RootNode3.ImageIndex = 2;

            //加载自行车节点
            DataTable dt = new DataTable();
            dt = SQLClass.SQLQuery("select distinct 车型 from bom");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TreeNode _nodes = new TreeNode();
                    _nodes.Text = dt.Rows[i]["车型"].ToString();
                   // _nodes.ImageIndex = 1;
                    //_nodes.SelectedImageIndex = 4;
                    RootNode1.Nodes.Add(_nodes);
                }
            }
            treeView2.ExpandAll();



        }

        private void accordionControlElement1_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            PublicPass.category = "bom";//类型为物料清单

            this.tabPage3.Parent = this.tabControl1; //显示物料清单栏
            this.tabPage1.Parent = null;//隐藏文档管理栏
            this.tabPage2.Parent = null;//隐藏物料管理栏
            this.tabPage4.Parent = null;//隐藏工艺路线栏
            this.tabPage5.Parent = null;//隐藏预览栏

            barButtonItem23.PerformClick();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            BOM_add add = new BOM_add();
            add.ShowDialog();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            if (gridView2.SelectedRowsCount == 0)
            {
                MessageBox.Show("请先选择一条数据!");
            }
            else
            {
                PublicPass.material_id = (string)gridView2.GetFocusedRowCellValue("物料编号");//获取物料编号
                PublicPass.material_name = (string)gridView2.GetFocusedRowCellValue("物料名称");//获取物料名称
                PublicPass.material_category = (string)gridView2.GetFocusedRowCellValue("物料类型");//获取物料类型
                PublicPass.material_property = (string)gridView2.GetFocusedRowCellValue("物料属性");//获取物料属性
                PublicPass.material_picid = (string)gridView2.GetFocusedRowCellValue("物料图号");//获取物料图号
                WLGLuptate wl = new WLGLuptate();
                wl.ShowDialog();
            }
            
        }

        private void gridControl3_Click(object sender, EventArgs e)
        {
           
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            PublicPass.material_id = (string)gridView2.GetFocusedRowCellValue("物料编号");//获取物料编号
            PublicPass.material_name = (string)gridView2.GetFocusedRowCellValue("物料名称");//获取物料名称
            PublicPass.material_category = (string)gridView2.GetFocusedRowCellValue("物料类型");//获取物料类型
            PublicPass.material_property = (string)gridView2.GetFocusedRowCellValue("物料属性");//获取物料属性
            PublicPass.material_picid = (string)gridView2.GetFocusedRowCellValue("物料图号");//获取物料图号
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            if (gridView3.SelectedRowsCount == 0)
            {
                MessageBox.Show("请先选择一条数据!");
            }
            else
            {
                PublicPass.material_id = (string)gridView3.GetFocusedRowCellValue("物料编号");//获取物料编号
                PublicPass.material_level = (string)gridView3.GetFocusedRowCellValue("阶次");//获取阶次
                PublicPass.material_lbjname = (string)gridView3.GetFocusedRowCellValue("零部件名称");//获取零部件名称
                PublicPass.material_ggxh = (string)gridView3.GetFocusedRowCellValue("规格型号");//获取规格型号
                PublicPass.material_unit = (string)gridView3.GetFocusedRowCellValue("单位");//获取单位
                PublicPass.material_usagenumber = (string)gridView3.GetFocusedRowCellValue("用量");//获取用量
                PublicPass.material_chejian= (string)gridView3.GetFocusedRowCellValue("车间");//获取车间
                BOM_edit edit = new BOM_edit();
                edit.ShowDialog();
            }
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            PublicPass.category = "bom";
            ExcelToSQL ex = new ExcelToSQL();
            ex.ShowDialog();
        }
        //物料清单查询功能
        #region
        private void simpleButton17_Click(object sender, EventArgs e)
        {
            //防空
            if (comboBoxEdit2.Text != "全部")
            {
                if (comboBoxEdit2.Text == "" || textEdit2.Text == "")
                {
                    MessageBox.Show("请选择检索类型或补全关键字!");
                    return;
                }
            }
            //防空

            if(comboBoxEdit2.Text=="全部")
            {
                string sql = "select * from bom";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                gridControl3.DataSource = dt;
            }
            if(comboBoxEdit2.Text == "阶次")
            {
                string sql = "select * from bom where 阶次 like'%" + textEdit2.Text + "%'";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                gridControl3.DataSource = dt;
            }
            if (comboBoxEdit2.Text == "零部件名称")
            {
                string sql = "select * from bom where 零部件名称 like'%" + textEdit2.Text + "%'";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                gridControl3.DataSource = dt;
            }
            if (comboBoxEdit2.Text == "规格型号")
            {
                string sql = "select * from bom where 规格型号 like'%" + textEdit2.Text + "%'";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                gridControl3.DataSource = dt;
            }
            if (comboBoxEdit2.Text == "单位")
            {
                string sql = "select * from bom where 单位 like'%" + textEdit2.Text + "%'";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                gridControl3.DataSource = dt;
            }
            if (comboBoxEdit2.Text == "车间")
            {
                string sql = "select * from bom where 车间 like'%" + textEdit2.Text + "%'";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                gridControl3.DataSource = dt;
            }
        }
        #endregion

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            if (gridView2.DataRowCount == 0)
            {
                MessageBox.Show("无数据!");
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "导出Excel";
                saveFileDialog.Filter = "Excel文件(*.xls)|*.xls";
                DialogResult dialogResult = saveFileDialog.ShowDialog(this);
                if (dialogResult == DialogResult.OK)
                {
                    DevExpress.XtraPrinting.XlsExportOptions options = new DevExpress.XtraPrinting.XlsExportOptions();
                    gridControl2.ExportToXls(saveFileDialog.FileName, options);//将gridcontro中的数据导出
                    DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            if(gridView3.DataRowCount==0)
            {
                MessageBox.Show("无数据！");
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "导出Excel";
                saveFileDialog.Filter = "Excel文件(*.xls)|*.xls";
                DialogResult dialogResult = saveFileDialog.ShowDialog(this);
                if (dialogResult == DialogResult.OK)
                {
                    DevExpress.XtraPrinting.XlsExportOptions options = new DevExpress.XtraPrinting.XlsExportOptions();
                    gridControl3.ExportToXls(saveFileDialog.FileName, options);//将gridcontro中的数据导出
                    DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }

        private void barStaticItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PublicPass.category = "pr";//类型为工艺路线

            this.tabPage4.Parent = this.tabControl1; //显示工艺路线栏
            this.tabPage1.Parent = null;//隐藏文档管理栏
            this.tabPage2.Parent = null;//隐藏物料管理栏
            this.tabPage3.Parent = null;//隐藏物料清单栏
            this.tabPage5.Parent = null;//隐藏预览栏
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            PublicPass.category = "pr";//类型为工艺路线

            this.tabPage4.Parent = this.tabControl1; //显示工艺路线栏
            this.tabPage1.Parent = null;//隐藏文档管理栏
            this.tabPage2.Parent = null;//隐藏物料管理栏
            this.tabPage3.Parent = null;//隐藏物料清单栏
            this.tabPage5.Parent = null;//隐藏预览栏
            barButtonItem22.PerformClick();
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        {
            PublicPass.category = "pr";
            process_route pr = new process_route();
            pr.ShowDialog();
        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            string tr_name= this.treeView1.SelectedNode.Text;
            if(tr_name=="图片文件")
            {
                //图片检索按钮
                PublicPass.category = "file_pic";//file_pic代表图片检索
                string sql = "select * from file_pictures";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                gridControl1.DataSource = dt;
            }
            else if (tr_name == "CAD文件")
            {
                //cad文件检索按钮
                PublicPass.category = "file_cad";//file_cad代表cad文档检索
                string sql = "select * from file_cads";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                gridControl1.DataSource = dt;
            }
            else if (tr_name == "Word文件")
            {
                //word文档检索按钮
                PublicPass.category = "file_word";//file_wordd代表word文档检索
                string sql = "select * from file_words";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                gridControl1.DataSource = dt;
            }
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            //工艺路线——修改
            if (gridView4.SelectedRowsCount == 0)
            {
                MessageBox.Show("请先选择一条数据!");
            }
            else
            {
                PublicPass.process_id = (string)gridView4.GetFocusedRowCellValue("工艺序号");//获取工艺序号
                PublicPass.process_name = (string)gridView4.GetFocusedRowCellValue("工艺名称");//获取工艺名称
                PublicPass.process_describe = (string)gridView4.GetFocusedRowCellValue("工艺说明");//获取工艺说明
                PublicPass.process_lbj = (string)gridView4.GetFocusedRowCellValue("零部件");//获取零部件
                PublicPass.process_number = (string)gridView4.GetFocusedRowCellValue("使用数量");//获取使用数量
                PublicPass.process_gs = (string)gridView4.GetFocusedRowCellValue("工时");//获取工时
                PublicPass.process_lmyl = (string)gridView4.GetFocusedRowCellValue("螺母用量");//获取螺母用量
                pr_edit edit = new pr_edit();
                edit.ShowDialog();
            }
        }

        private void simpleButton20_Click(object sender, EventArgs e)
        {
            //工艺路线--导入excel
            PublicPass.category = "pr";
            ExcelToSQL ex = new ExcelToSQL();
            ex.ShowDialog();
        }

        private void simpleButton23_Click(object sender, EventArgs e)
        {
            //工艺路线检索
            //防空
            if (comboBoxEdit3.Text != "全部")
            {
                if (comboBoxEdit3.Text == "" || textEdit3.Text == "")
                {
                    MessageBox.Show("请选择检索类型或补全关键字!");
                    return;
                }
            }
            //防空

            if (comboBoxEdit3.Text == "全部")
            {
                string sql = "select * from  process_route";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                gridControl4.DataSource = dt;
            }
            if (comboBoxEdit3.Text == "工艺序号")
            {
                string sql = "select * from  process_route where 工艺序号 like'%" + textEdit3.Text.ToString() + "%'";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                gridControl4.DataSource = dt;
            }
            if (comboBoxEdit3.Text == "工艺名称")
            {
                string sql = "select * from process_route where 工艺名称 like'%" + textEdit3.Text.ToString() + "%'";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                gridControl4.DataSource = dt;
            }
            if (comboBoxEdit3.Text == "工艺说明")
            {
                string sql = "select * from  process_route where 工艺说明 like'%" + textEdit3.Text.ToString() + "%'";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                gridControl4.DataSource = dt;
            }
            if (comboBoxEdit3.Text == "零部件")
            {
                string sql = "select * from  process_route where 零部件 like'%" + textEdit3.Text.ToString() + "%'";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                gridControl4.DataSource = dt;
            }
            //工艺路线检索
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
            //删除工艺路线
            PublicPass.id = (string)gridView4.GetFocusedRowCellValue("工艺序号");

            DialogResult result = MessageBox.Show("确认删除？", "温馨提示", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string sql = "delete from process_route where 工艺序号='" + PublicPass.id + "'";//执行删除语句
                DataBaseApplication.ExecuteNonQuery(sql);
                MessageBox.Show("删除成功！");
            }
            //删除物料工艺路线
        }

        private void simpleButton24_Click(object sender, EventArgs e)
        {
            //此代码实现的时一个简单的打开功能
            /*
            // 预览文件
            //打开预览栏
            this.tabPage5.Parent = this.tabControl1;
            OpenFileDialog P_GetFile = new OpenFileDialog();//创建打开文件对话框对象
            //只能单选一个文件
            P_GetFile.Multiselect = false;
            P_GetFile.Filter = "word文档;cad文档;图片文件|*.doc;*.docx;*.dwg;*.jpg;*.png;*.pdf";
            DialogResult P_dr = P_GetFile.ShowDialog();//显示打开文件对话框
            
            if (P_dr == DialogResult.OK)//是否点击确定
            {
                webBrowser2.Navigate(P_GetFile.FileName);//打开Word文档并显示
            }
            */

            //如果预览的是图片文件
            //首先先导出文件
            if (PublicPass.category == "file_pic")
            {
                this.tabPage1.Parent = null;
                this.tabPage5.Parent = this.tabControl1;//打开预览栏
                this.tabPage1.Parent = this.tabControl1;
                string conn = "server=(local);database=Practice;Uid=sa;Pwd=sa ";
                string str = "select 文件 from file_pictures where 编号='" + PublicPass.id + "' ";
                SqlConnection myconn = new SqlConnection(conn);
                SqlDataAdapter sda = new SqlDataAdapter(str, conn);
                DataSet myds = new DataSet();
                myconn.Open();
                sda.Fill(myds);
                myconn.Close();
                Byte[] Files = (Byte[])myds.Tables[0].Rows[0]["文件"];
                BinaryWriter bw = new BinaryWriter(File.Open(@"\\Mac\Home\Desktop\图片导出文件" + DateTime.Now.Second + ".jpg", FileMode.OpenOrCreate));
                bw.Write(Files);
                bw.Close();
                //之后再查看文件
                OpenFileDialog P_GetFile = new OpenFileDialog();//创建打开文件对话框对象
                P_GetFile.FileName = @"\\Mac\Home\Desktop\图片导出文件" + DateTime.Now.Second + ".jpg";
                webBrowser2.Navigate(P_GetFile.FileName);
            }
           

            //如果预览的是Word文件
            if(PublicPass.category=="file_word")
            {
                //先导出文件
                string conn1 = "server=(local);database=Practice;Uid=sa;Pwd=sa ";
                string str1 = "select 文件 from file_words where 编号='" + PublicPass.id + "' ";
                SqlConnection myconn1 = new SqlConnection(conn1);
                SqlDataAdapter sda1 = new SqlDataAdapter(str1, conn1);
                DataSet myds1 = new DataSet();
                myconn1.Open();
                sda1.Fill(myds1);
                myconn1.Close();
                Byte[] Files1 = (Byte[])myds1.Tables[0].Rows[0]["文件"];
                BinaryWriter bw1 = new BinaryWriter(File.Open(@"\\Mac\Home\Desktop\Word导出文件" + DateTime.Now.Second + ".docx", FileMode.OpenOrCreate));
                bw1.Write(Files1);
                bw1.Close();
                //之后再查看文件
                OpenFileDialog P_GetFile1 = new OpenFileDialog();//创建打开文件对话框对象
                P_GetFile1.FileName = @"\\Mac\Home\Desktop\Word导出文件" + DateTime.Now.Second + ".docx";
                webBrowser2.Navigate(P_GetFile1.FileName);
            }

            //如果预览的是Cad文件
            if(PublicPass.category=="file_cad")
            {
                string conn2 = "server=(local);database=Practice;Uid=sa;Pwd=sa ";
                string str2 = "select 文件 from file_cads where 编号='" + PublicPass.id + "' ";
                SqlConnection myconn2 = new SqlConnection(conn2);
                SqlDataAdapter sda2 = new SqlDataAdapter(str2, conn2);
                DataSet myds2 = new DataSet();
                myconn2.Open();
                sda2.Fill(myds2);
                myconn2.Close();
                Byte[] Files2 = (Byte[])myds2.Tables[0].Rows[0]["文件"];
                BinaryWriter bw2 = new BinaryWriter(File.Open(@"\\Mac\Home\Desktop\Cad导出文件" + DateTime.Now.Second + ".dwg", FileMode.OpenOrCreate));
                bw2.Write(Files2);
                bw2.Close();
                //之后再查看文件
                OpenFileDialog P_GetFile2 = new OpenFileDialog();//创建打开文件对话框对象
                P_GetFile2.FileName = @"\\Mac\Home\Desktop\Word导出文件" + DateTime.Now.Second + ".dwg";
                webBrowser2.Navigate(P_GetFile2.FileName);
            }

        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            //删除物料清单
            PublicPass.id = (string)gridView3.GetFocusedRowCellValue("物料编号");

            DialogResult result = MessageBox.Show("确认删除？", "温馨提示", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string sql = "delete from bom where 物料编号='" + PublicPass.id + "'";//执行删除语句
                DataBaseApplication.ExecuteNonQuery(sql);
                MessageBox.Show("删除成功！");
            }
            //删除物料清单
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            if(gridView4.DataRowCount==0)
            {
                MessageBox.Show("无数据!");
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "导出Excel";
                saveFileDialog.Filter = "Excel文件(*.xls)|*.xls";
                DialogResult dialogResult = saveFileDialog.ShowDialog(this);
                if (dialogResult == DialogResult.OK)
                {
                    DevExpress.XtraPrinting.XlsExportOptions options = new DevExpress.XtraPrinting.XlsExportOptions();
                    gridControl4.ExportToXls(saveFileDialog.FileName, options);//将gridcontro中的数据导出
                    DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //如果选中节点为自行车的话,在结构树中显示，选中自行车的子节点后，在gridview中加载
            #region
            this.treeView3.ImageList = this.imageList3;
            DataTable dt = new DataTable();
            dt = SQLClass.SQLQuery("select distinct 车型 from bom");
            string check = this.treeView2.SelectedNode.Text;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if(check==dt.Rows[i][0].ToString())
                {
                    //在结构树中加载根节点
                    TreeNode tr = new TreeNode();
                    treeView3.Nodes.Clear();
                    tr.Nodes.Clear();
                    tr.Text = check;
                    this.treeView3.Nodes.Add(tr);
                    tr.ImageIndex = 0;

                    DataTable dt2 = new DataTable();
                    dt2 = SQLClass.SQLQuery("select * from bom where 车型='" + check + "'and 所属组件='自行车'");
                    gridControl3.DataSource = dt2;//将数据放入gridview中
                    for (int j=0;j<dt2.Rows.Count;j++)
                    {
                        TreeNode _nodes = new TreeNode();
                        _nodes.Text = dt2.Rows[j]["零部件名称"].ToString();
                        _nodes.ImageIndex = 1;
                        //_nodes.SelectedImageIndex = 4;
                        tr.Nodes.Add(_nodes);


                       DataTable dt3 = new DataTable();
                        dt3 = SQLClass.SQLQuery("select * from bom where 所属组件='" + dt2.Rows[j]["零部件名称"].ToString() + "'");
                        //gridControl3.DataSource = dt3;
                        for(int ii=0;ii<dt3.Rows.Count;ii++)
                        {
                            TreeNode nodes =new TreeNode();
                            nodes.Text = dt3.Rows[ii]["零部件名称"].ToString();
                            nodes.ImageIndex = 1;
                            _nodes.Nodes.Add(nodes);

                        }

                    }
                    
                }
            }
            treeView3.ExpandAll();
            #endregion
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //mainform的用户管理控件
            user_info use = new user_info();
            use.ShowDialog();
            //mainform的用户管理控件
        }

        private void treeView3_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string check2 = treeView3.SelectedNode.Text;
            DataTable dt3 = new DataTable();
            dt3 = SQLClass.SQLQuery("select * from bom where 所属组件='" + check2 + "'");
            gridControl3.DataSource = dt3;
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            user_authority us = new user_authority();
            us.ShowDialog();
        }

        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认关闭系统？", "系统提示", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Controls.Clear(); InitializeComponent();
        }

        //弹窗特效
        #region
        [System.Runtime.InteropServices.DllImport("user32")]

        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);

        const int AW_HOR_POSITIVE = 0x0001; //正面_水平方向

        const int AW_HOR_NEGATIVE = 0x0002;//负面_水平方向

        const int AW_VER_POSITIVE = 0x0004; //正面_垂直方向

        const int AW_VER_NEGATIVE = 0x0008;//负面_垂直方向

        const int AW_CENTER = 0x0010;//由中间四周展开或由四周向中间缩小

        const int AW_HIDE = 0x10000;  //隐藏对象

        const int AW_ACTIVATE = 0x20000;//显示对象

        const int AW_SLIDE = 0x40000;//拉幕滑动效果

        const int AW_BLEND = 0x80000;//淡入淡出渐变效果
        #endregion
    }
}
  

