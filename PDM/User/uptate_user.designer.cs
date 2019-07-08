namespace PDM
{
    partial class uptate_user
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uptate_user));
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.YHQX = new System.Windows.Forms.TextBox();
            this.YHMM = new System.Windows.Forms.TextBox();
            this.YHM = new System.Windows.Forms.TextBox();
            this.YHID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(190, 251);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(119, 52);
            this.simpleButton2.TabIndex = 19;
            this.simpleButton2.Text = "取消修改";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(40, 251);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(119, 52);
            this.simpleButton1.TabIndex = 18;
            this.simpleButton1.Text = "确认修改";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // YHQX
            // 
            this.YHQX.Location = new System.Drawing.Point(125, 185);
            this.YHQX.Name = "YHQX";
            this.YHQX.Size = new System.Drawing.Size(184, 21);
            this.YHQX.TabIndex = 17;
            // 
            // YHMM
            // 
            this.YHMM.Location = new System.Drawing.Point(125, 142);
            this.YHMM.Name = "YHMM";
            this.YHMM.Size = new System.Drawing.Size(184, 21);
            this.YHMM.TabIndex = 16;
            // 
            // YHM
            // 
            this.YHM.Location = new System.Drawing.Point(125, 100);
            this.YHM.Name = "YHM";
            this.YHM.Size = new System.Drawing.Size(184, 21);
            this.YHM.TabIndex = 15;
            // 
            // YHID
            // 
            this.YHID.Location = new System.Drawing.Point(125, 57);
            this.YHID.Name = "YHID";
            this.YHID.Size = new System.Drawing.Size(184, 21);
            this.YHID.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "用户权限";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "用户密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "用户名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "用户id";
            // 
            // uptate_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 372);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.YHQX);
            this.Controls.Add(this.YHMM);
            this.Controls.Add(this.YHM);
            this.Controls.Add(this.YHID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "uptate_user";
            this.Text = "用户信息修改";
            this.Load += new System.EventHandler(this.uptate_user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox YHQX;
        private System.Windows.Forms.TextBox YHMM;
        private System.Windows.Forms.TextBox YHM;
        private System.Windows.Forms.TextBox YHID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}