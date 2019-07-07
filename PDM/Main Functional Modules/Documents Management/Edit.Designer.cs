namespace PDM
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.textEdit_id = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_ok = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_time = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_founder = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_describe = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_time.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_founder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_describe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_name.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit_id
            // 
            this.textEdit_id.Location = new System.Drawing.Point(102, 21);
            this.textEdit_id.Name = "textEdit_id";
            this.textEdit_id.Size = new System.Drawing.Size(166, 20);
            this.textEdit_id.TabIndex = 26;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(36, 24);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 14);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "文件编号：";
            // 
            // simpleButton_ok
            // 
            this.simpleButton_ok.Location = new System.Drawing.Point(246, 211);
            this.simpleButton_ok.Name = "simpleButton_ok";
            this.simpleButton_ok.Size = new System.Drawing.Size(80, 43);
            this.simpleButton_ok.TabIndex = 24;
            this.simpleButton_ok.Text = "确定";
            this.simpleButton_ok.Click += new System.EventHandler(this.simpleButton_ok_Click);
            // 
            // simpleButton_cancel
            // 
            this.simpleButton_cancel.Location = new System.Drawing.Point(148, 211);
            this.simpleButton_cancel.Name = "simpleButton_cancel";
            this.simpleButton_cancel.Size = new System.Drawing.Size(80, 43);
            this.simpleButton_cancel.TabIndex = 23;
            this.simpleButton_cancel.Text = "取消";
            // 
            // textEdit_time
            // 
            this.textEdit_time.Location = new System.Drawing.Point(102, 163);
            this.textEdit_time.Name = "textEdit_time";
            this.textEdit_time.Size = new System.Drawing.Size(166, 20);
            this.textEdit_time.TabIndex = 22;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 166);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(84, 14);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "文件建立时间：";
            // 
            // textEdit_founder
            // 
            this.textEdit_founder.Location = new System.Drawing.Point(102, 130);
            this.textEdit_founder.Name = "textEdit_founder";
            this.textEdit_founder.Size = new System.Drawing.Size(166, 20);
            this.textEdit_founder.TabIndex = 20;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(24, 133);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 14);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "文件建立者：";
            // 
            // textEdit_describe
            // 
            this.textEdit_describe.Location = new System.Drawing.Point(102, 98);
            this.textEdit_describe.Name = "textEdit_describe";
            this.textEdit_describe.Size = new System.Drawing.Size(166, 20);
            this.textEdit_describe.TabIndex = 18;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(36, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "文件描述：";
            // 
            // textEdit_name
            // 
            this.textEdit_name.Location = new System.Drawing.Point(102, 58);
            this.textEdit_name.Name = "textEdit_name";
            this.textEdit_name.Size = new System.Drawing.Size(166, 20);
            this.textEdit_name.TabIndex = 16;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "文件名称：";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(274, 158);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(52, 30);
            this.simpleButton1.TabIndex = 27;
            this.simpleButton1.Text = "获取";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 268);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit_id);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.simpleButton_ok);
            this.Controls.Add(this.simpleButton_cancel);
            this.Controls.Add(this.textEdit_time);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.textEdit_founder);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.textEdit_describe);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textEdit_name);
            this.Controls.Add(this.labelControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit";
            this.Text = "修改";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_time.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_founder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_describe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_name.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit_id;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton simpleButton_ok;
        private DevExpress.XtraEditors.SimpleButton simpleButton_cancel;
        private DevExpress.XtraEditors.TextEdit textEdit_time;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEdit_founder;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit_describe;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit_name;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}