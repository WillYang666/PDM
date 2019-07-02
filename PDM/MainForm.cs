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
    }
}

