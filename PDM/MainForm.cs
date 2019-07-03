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

namespace PDM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        //结构树显示
        #region
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();//防止重复加载
            String rootFile = textedit_filepath.Text.ToString().Trim();
            if (!Directory.Exists(rootFile))
            {
                MessageBox.Show("文件夹位置错误！");
            }
            else
            {
                //根节点
                TreeNode rootNode = new TreeNode();
                rootNode.Text = rootFile;
                rootNode.ImageIndex = 0;
                //递归创建节点
                createNodes(rootFile, rootNode);
                //TreeView
                treeView1.Nodes.Add(rootNode);
                treeView1.ExpandAll();
            }
        }

        private void createNodes(String rootFile, TreeNode rootNode)
        {
            DirectoryInfo dInfo = new DirectoryInfo(rootFile);
            //遍历当前文件系统下的所有文件和文件夹
            foreach (FileSystemInfo info in dInfo.GetFileSystemInfos())
            {
                TreeNode node = new TreeNode();
                node.Text = info.Name;
                node.ImageIndex = 1;
                rootNode.Nodes.Add(node);
                //文件夹
                String file = info.FullName;
                if (Directory.Exists(file))
                {
                    createNodes(file, node);
                }
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textedit_filepath.Text = "";
            treeView1.Nodes.Clear();
        }
        #endregion

        //将treeview中选中的节点下的文件展示在右边的listview中
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            listView1.Items.Clear();
            string path = this.treeView1.SelectedNode.FullPath;//获取选中节点路径
            DirectoryInfo d = new DirectoryInfo(path);
            //实例化DirectoryInfo
            FileSystemInfo[] f = d.GetFileSystemInfos();
            //获取指定文件夹中子文件夹和文件

            foreach (FileSystemInfo fs in f)
            {
                if (fs is DirectoryInfo)
                {
                    //判断遍历出的是文件夹
                    DirectoryInfo di = new DirectoryInfo(fs.FullName);
                    //实例化并获取完整文件夹路径
                    listView1.Items.Add(di.Name);
                    //获取名称并添加到listView1中
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(
                        di.FullName);
                    //获取路径
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(
                        di.CreationTime.ToShortDateString());
                    //获取创建时间
                }
                //以上这一大段不太懂，难道在listView控件中，列序号从前往后是
                //从小到大排列的？而且后面的是前面的子控件？
                else
                {
                    //反之说明不是文件夹，是文件
                    FileInfo fi = new FileInfo(fs.FullName);
                    //实例化并获取完整文件路径
                    listView1.Items.Add(fi.Name);
                    //获取文件名并添加到listView1控件中
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(
                        fi.FullName);
                    //获取文件路径并添加到listView1控件中
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(
                        fi.CreationTime.ToShortDateString());
                    //获取创建时间

                }
            }
        }
    }
}
  

