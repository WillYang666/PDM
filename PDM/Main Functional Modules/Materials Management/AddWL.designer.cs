﻿namespace PDM
{
    partial class AddWL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWL));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.WLBH = new System.Windows.Forms.TextBox();
            this.WLMC = new System.Windows.Forms.TextBox();
            this.WLTH = new System.Windows.Forms.TextBox();
            this.WLLX = new System.Windows.Forms.ComboBox();
            this.WLSX = new System.Windows.Forms.ComboBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "物料编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "物料名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "物料类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "物料属性";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(51, 183);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(53, 12);
            this.label123.TabIndex = 4;
            this.label123.Text = "物料图号";
            this.label123.Click += new System.EventHandler(this.label5_Click);
            // 
            // WLBH
            // 
            this.WLBH.Location = new System.Drawing.Point(128, 20);
            this.WLBH.Name = "WLBH";
            this.WLBH.Size = new System.Drawing.Size(153, 21);
            this.WLBH.TabIndex = 5;
            // 
            // WLMC
            // 
            this.WLMC.Location = new System.Drawing.Point(128, 60);
            this.WLMC.Name = "WLMC";
            this.WLMC.Size = new System.Drawing.Size(153, 21);
            this.WLMC.TabIndex = 6;
            // 
            // WLTH
            // 
            this.WLTH.Location = new System.Drawing.Point(128, 183);
            this.WLTH.Name = "WLTH";
            this.WLTH.Size = new System.Drawing.Size(153, 21);
            this.WLTH.TabIndex = 7;
            // 
            // WLLX
            // 
            this.WLLX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WLLX.FormattingEnabled = true;
            this.WLLX.Items.AddRange(new object[] {
            "零件",
            "产品"});
            this.WLLX.Location = new System.Drawing.Point(128, 99);
            this.WLLX.Name = "WLLX";
            this.WLLX.Size = new System.Drawing.Size(153, 20);
            this.WLLX.TabIndex = 8;
            // 
            // WLSX
            // 
            this.WLSX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WLSX.FormattingEnabled = true;
            this.WLSX.Items.AddRange(new object[] {
            "检修件",
            "必换件"});
            this.WLSX.Location = new System.Drawing.Point(128, 144);
            this.WLSX.Name = "WLSX";
            this.WLSX.Size = new System.Drawing.Size(153, 20);
            this.WLSX.TabIndex = 9;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(182, 225);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(113, 66);
            this.simpleButton2.TabIndex = 13;
            this.simpleButton2.Text = "取消添加";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(40, 225);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(113, 66);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "确认添加";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // AddWL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 312);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.WLSX);
            this.Controls.Add(this.WLLX);
            this.Controls.Add(this.WLTH);
            this.Controls.Add(this.WLMC);
            this.Controls.Add(this.WLBH);
            this.Controls.Add(this.label123);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddWL";
            this.Text = "物料管理——添加";
            this.Load += new System.EventHandler(this.AddWL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.TextBox WLBH;
        private System.Windows.Forms.TextBox WLMC;
        private System.Windows.Forms.TextBox WLTH;
        private System.Windows.Forms.ComboBox WLLX;
        private System.Windows.Forms.ComboBox WLSX;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}