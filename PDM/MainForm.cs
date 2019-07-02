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
            TreeNode tn = new TreeNode();

            tn.Text = "根目录";

            getDirectories("", tn);

            tv.Nodes.Add(tn);
        }
           

        private void getDirectories(string path, TreeNode tn)
        {


            string[] fileNames = Directory.GetFiles(path);
            string[] directories = Directory.GetDirectories(path);


            //先遍历这个目录下的文件夹
            foreach (string dir in directories)
            {

                TreeNode subtn = new TreeNode();

                subtn.Text = GetShorterFileName(dir);

                getDirectories(dir, subtn);

                tn.Nodes.Add(subtn);

            }
            //再遍历这个目录下的文件
            foreach (string file in fileNames)
            {

                TreeNode subtn = new TreeNode();

                subtn.Text = GetShorterFileName(file);

                tn.Nodes.Add(subtn);
            }
        }
        //去除路径
        private string GetShorterFileName(string filename)
        {

            return filename.Substring(filename.LastIndexOf("\\") + 1);

        }




    }
}
