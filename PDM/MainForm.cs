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
            string path = "/Users/will/Desktop/File";
            string[] dirs = Directory.GetDirectories(path);
            foreach (string item in dirs)
            {
                tv.Nodes.Add(Path.GetFileName(item));
            }
            string[] files = Directory.GetFiles(path);
            foreach (string item in files)
            {
                tv.Nodes.Add(Path.GetFileName(item));
            }

            //调用该方法实现将指定路径下的子文件与子目录按照层次结构加载到TreeView
            LoadFilesAndDirectoriesToTree(path, tv.Nodes);
        }

        private void LoadFilesAndDirectoriesToTree(string path, TreeNodeCollection treeNodeCollection)
        {
            //1.先根据路径获取所有的子文件和子文件夹
            string[] files = Directory.GetFiles(path);
            string[] dirs = Directory.GetDirectories(path);
            //2.把所有的子文件与子目录加到TreeView上。
            foreach (string item in files)
            {
                //把每一个子文件加到TreeView上
                treeNodeCollection.Add(Path.GetFileName(item));
            }
            //文件夹
            foreach (string item in dirs)
            {
                TreeNode node = treeNodeCollection.Add(Path.GetFileName(item));

                //由于目录，可能下面还存在子目录，所以这时要对每个目录再次进行获取子目录与子文件的操作
                //这里进行了递归
                LoadFilesAndDirectoriesToTree(item, node.Nodes);
            }
        }
    }
}
