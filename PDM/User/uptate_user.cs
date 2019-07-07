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
    public partial class uptate_user : Form
    {
        public uptate_user()
        {
            InitializeComponent();
        }

        private void uptate_user_Load(object sender, EventArgs e)
        {
            YHID.ReadOnly = true;//物料编号不允许修改
            YHID.Text = PublicPass.id;
            YHM.Text = PublicPass.username.ToString();
            YHMM.Text = PublicPass.userpass.ToString();
            YHQX.Text = PublicPass.userauthority.ToString();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
