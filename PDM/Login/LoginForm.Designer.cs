namespace PDM
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ok = new System.Windows.Forms.Button();
            this.retreat = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Nameid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "用户配置";
            this.barSubItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barSubItem1.Glyph")));
            this.barSubItem1.Id = 4;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "用户配置";
            this.barSubItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barSubItem2.Glyph")));
            this.barSubItem2.Id = 4;
            this.barSubItem2.Name = "barSubItem2";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.Ok);
            this.splitContainer1.Panel2.Controls.Add(this.retreat);
            this.splitContainer1.Panel2.Controls.Add(this.Password);
            this.splitContainer1.Panel2.Controls.Add(this.Nameid);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(531, 329);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.Color.Transparent;
            this.Ok.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ok.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ok.ForeColor = System.Drawing.Color.Black;
            this.Ok.Image = ((System.Drawing.Image)(resources.GetObject("Ok.Image")));
            this.Ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ok.Location = new System.Drawing.Point(392, 34);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(87, 27);
            this.Ok.TabIndex = 33;
            this.Ok.Tag = "1";
            this.Ok.Text = "  登 录";
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // retreat
            // 
            this.retreat.BackColor = System.Drawing.Color.Transparent;
            this.retreat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.retreat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.retreat.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.retreat.ForeColor = System.Drawing.Color.Black;
            this.retreat.Image = ((System.Drawing.Image)(resources.GetObject("retreat.Image")));
            this.retreat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.retreat.Location = new System.Drawing.Point(392, 72);
            this.retreat.Name = "retreat";
            this.retreat.Size = new System.Drawing.Size(87, 27);
            this.retreat.TabIndex = 32;
            this.retreat.Tag = "1";
            this.retreat.Text = "  退 出";
            this.retreat.UseVisualStyleBackColor = false;
            this.retreat.Click += new System.EventHandler(this.retreat_Click);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Password.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Password.ForeColor = System.Drawing.Color.Black;
            this.Password.Location = new System.Drawing.Point(137, 72);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(220, 29);
            this.Password.TabIndex = 31;
            this.Password.Tag = "1";
            this.Password.UseSystemPasswordChar = true;
            // 
            // Nameid
            // 
            this.Nameid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Nameid.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Nameid.ForeColor = System.Drawing.Color.Black;
            this.Nameid.Location = new System.Drawing.Point(137, 34);
            this.Nameid.Name = "Nameid";
            this.Nameid.Size = new System.Drawing.Size(220, 29);
            this.Nameid.TabIndex = 30;
            this.Nameid.Tag = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(51, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 29;
            this.label2.Tag = "1";
            this.label2.Text = "密   码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(51, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 28;
            this.label1.Tag = "1";
            this.label1.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Location = new System.Drawing.Point(442, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 34;
            this.label3.Text = "配置数据库->";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 329);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button retreat;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Nameid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}