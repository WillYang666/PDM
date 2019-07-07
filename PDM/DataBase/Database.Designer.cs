namespace PDM
{
    partial class Database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Database));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.mc = new DevExpress.XtraEditors.TextEdit();
            this.fwq = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.mm = new DevExpress.XtraEditors.TextEdit();
            this.yh = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fwq.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.mc);
            this.groupControl1.Controls.Add(this.fwq);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.mm);
            this.groupControl1.Controls.Add(this.yh);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(432, 280);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "参数配置";
            // 
            // mc
            // 
            this.mc.Location = new System.Drawing.Point(155, 163);
            this.mc.Name = "mc";
            this.mc.Size = new System.Drawing.Size(210, 20);
            this.mc.TabIndex = 16;
            // 
            // fwq
            // 
            this.fwq.Location = new System.Drawing.Point(155, 43);
            this.fwq.Name = "fwq";
            this.fwq.Size = new System.Drawing.Size(210, 20);
            this.fwq.TabIndex = 15;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(229, 202);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(112, 45);
            this.simpleButton2.TabIndex = 14;
            this.simpleButton2.Text = "取消";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(84, 202);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(112, 45);
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Text = "确认";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // mm
            // 
            this.mm.Location = new System.Drawing.Point(155, 123);
            this.mm.Name = "mm";
            this.mm.Size = new System.Drawing.Size(210, 20);
            this.mm.TabIndex = 7;
            // 
            // yh
            // 
            this.yh.Location = new System.Drawing.Point(155, 83);
            this.yh.Name = "yh";
            this.yh.Size = new System.Drawing.Size(210, 20);
            this.yh.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(55, 166);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 14);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "数据库名称 ：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(71, 126);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "用户密码：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(59, 86);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "数据库用户：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(47, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "数据库服务器：";
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 280);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Database";
            this.Text = "配置数据库";
            this.Load += new System.EventHandler(this.Database_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fwq.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yh.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit mm;
        private DevExpress.XtraEditors.TextEdit yh;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit mc;
        private DevExpress.XtraEditors.TextEdit fwq;
    }
}