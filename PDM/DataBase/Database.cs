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
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataBaseApplication.DataSource ="'"+fwq.Text+"'";
            DataBaseApplication.DataBaseName = "'"+mc+"'";
            DataBaseApplication.UserID = "'"+yh.Text+"'";
            DataBaseApplication.PassWord = "'"+mm.Text+"'";
        }

        private void Database_Load(object sender, EventArgs e)
        {
            fwq.Text = PublicPass.db_host;
            yh.Text = PublicPass.db_username;
            mm.Text = PublicPass.db_userpassword;
            mc.Text = PublicPass.db_databasename;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
