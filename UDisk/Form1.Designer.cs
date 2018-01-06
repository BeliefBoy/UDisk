namespace UDisk
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CheckU = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.listBoxMessage = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttondisable3 = new System.Windows.Forms.Button();
            this.buttonable3 = new System.Windows.Forms.Button();
            this.buttonopen3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttondisable2 = new System.Windows.Forms.Button();
            this.buttondisable1 = new System.Windows.Forms.Button();
            this.buttonable2 = new System.Windows.Forms.Button();
            this.buttonopen2 = new System.Windows.Forms.Button();
            this.buttonable1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonopen1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelmessage = new System.Windows.Forms.Label();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttoncopy = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttoncopydir = new System.Windows.Forms.Button();
            this.buttondeletedir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckU
            // 
            this.CheckU.BackColor = System.Drawing.SystemColors.Highlight;
            this.CheckU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckU.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckU.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CheckU.Location = new System.Drawing.Point(623, 20);
            this.CheckU.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CheckU.Name = "CheckU";
            this.CheckU.Size = new System.Drawing.Size(120, 40);
            this.CheckU.TabIndex = 0;
            this.CheckU.Text = "刷新";
            this.CheckU.UseVisualStyleBackColor = false;
            this.CheckU.Click += new System.EventHandler(this.CheckUClick);
            // 
            // buttonback
            // 
            this.buttonback.BackColor = System.Drawing.Color.Lime;
            this.buttonback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonback.Location = new System.Drawing.Point(623, 385);
            this.buttonback.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(120, 40);
            this.buttonback.TabIndex = 2;
            this.buttonback.Text = "返回主页";
            this.buttonback.UseVisualStyleBackColor = false;
            this.buttonback.Click += new System.EventHandler(this.buttonbackClick);
            // 
            // listBoxMessage
            // 
            this.listBoxMessage.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxMessage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxMessage.FormattingEnabled = true;
            this.listBoxMessage.ItemHeight = 16;
            this.listBoxMessage.Location = new System.Drawing.Point(12, 309);
            this.listBoxMessage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listBoxMessage.Name = "listBoxMessage";
            this.listBoxMessage.Size = new System.Drawing.Size(578, 116);
            this.listBoxMessage.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(578, 253);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "已插入U盘 0 个（最多显示3个U盘）";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.buttondisable3);
            this.panel1.Controls.Add(this.buttonable3);
            this.panel1.Controls.Add(this.buttonopen3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.buttondisable2);
            this.panel1.Controls.Add(this.buttondisable1);
            this.panel1.Controls.Add(this.buttonable2);
            this.panel1.Controls.Add(this.buttonopen2);
            this.panel1.Controls.Add(this.buttonable1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonopen1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 218);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(340, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // buttondisable3
            // 
            this.buttondisable3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttondisable3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondisable3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondisable3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttondisable3.Location = new System.Drawing.Point(189, 149);
            this.buttondisable3.Name = "buttondisable3";
            this.buttondisable3.Size = new System.Drawing.Size(70, 40);
            this.buttondisable3.TabIndex = 16;
            this.buttondisable3.Text = "禁用";
            this.buttondisable3.UseVisualStyleBackColor = false;
            this.buttondisable3.Visible = false;
            this.buttondisable3.Click += new System.EventHandler(this.buttondisable3Click);
            // 
            // buttonable3
            // 
            this.buttonable3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonable3.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonable3.Enabled = false;
            this.buttonable3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonable3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonable3.Location = new System.Drawing.Point(103, 149);
            this.buttonable3.Name = "buttonable3";
            this.buttonable3.Size = new System.Drawing.Size(70, 40);
            this.buttonable3.TabIndex = 15;
            this.buttonable3.Text = "已开启";
            this.buttonable3.UseVisualStyleBackColor = false;
            this.buttonable3.Visible = false;
            this.buttonable3.Click += new System.EventHandler(this.buttonable3Click);
            // 
            // buttonopen3
            // 
            this.buttonopen3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonopen3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonopen3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonopen3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonopen3.Location = new System.Drawing.Point(17, 149);
            this.buttonopen3.Name = "buttonopen3";
            this.buttonopen3.Size = new System.Drawing.Size(70, 40);
            this.buttonopen3.TabIndex = 14;
            this.buttonopen3.Text = "查看";
            this.buttonopen3.UseVisualStyleBackColor = false;
            this.buttonopen3.Visible = false;
            this.buttonopen3.Click += new System.EventHandler(this.buttonopen3Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // buttondisable2
            // 
            this.buttondisable2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttondisable2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondisable2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondisable2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttondisable2.Location = new System.Drawing.Point(189, 84);
            this.buttondisable2.Name = "buttondisable2";
            this.buttondisable2.Size = new System.Drawing.Size(70, 40);
            this.buttondisable2.TabIndex = 11;
            this.buttondisable2.Text = "禁用";
            this.buttondisable2.UseVisualStyleBackColor = false;
            this.buttondisable2.Visible = false;
            this.buttondisable2.Click += new System.EventHandler(this.buttondisable2Click);
            // 
            // buttondisable1
            // 
            this.buttondisable1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttondisable1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondisable1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondisable1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttondisable1.Location = new System.Drawing.Point(189, 21);
            this.buttondisable1.Name = "buttondisable1";
            this.buttondisable1.Size = new System.Drawing.Size(70, 40);
            this.buttondisable1.TabIndex = 6;
            this.buttondisable1.Text = "禁用";
            this.buttondisable1.UseVisualStyleBackColor = false;
            this.buttondisable1.Visible = false;
            this.buttondisable1.Click += new System.EventHandler(this.buttondisable1Click);
            // 
            // buttonable2
            // 
            this.buttonable2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonable2.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonable2.Enabled = false;
            this.buttonable2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonable2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonable2.Location = new System.Drawing.Point(103, 84);
            this.buttonable2.Name = "buttonable2";
            this.buttonable2.Size = new System.Drawing.Size(70, 40);
            this.buttonable2.TabIndex = 10;
            this.buttonable2.Text = "已开启";
            this.buttonable2.UseVisualStyleBackColor = false;
            this.buttonable2.Visible = false;
            this.buttonable2.Click += new System.EventHandler(this.buttonable2Click);
            // 
            // buttonopen2
            // 
            this.buttonopen2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonopen2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonopen2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonopen2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonopen2.Location = new System.Drawing.Point(17, 84);
            this.buttonopen2.Name = "buttonopen2";
            this.buttonopen2.Size = new System.Drawing.Size(70, 40);
            this.buttonopen2.TabIndex = 9;
            this.buttonopen2.Text = "查看";
            this.buttonopen2.UseVisualStyleBackColor = false;
            this.buttonopen2.Visible = false;
            this.buttonopen2.Click += new System.EventHandler(this.buttonopen2Click);
            // 
            // buttonable1
            // 
            this.buttonable1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonable1.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonable1.Enabled = false;
            this.buttonable1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonable1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonable1.Location = new System.Drawing.Point(103, 21);
            this.buttonable1.Name = "buttonable1";
            this.buttonable1.Size = new System.Drawing.Size(70, 40);
            this.buttonable1.TabIndex = 5;
            this.buttonable1.Text = "已开启";
            this.buttonable1.UseVisualStyleBackColor = false;
            this.buttonable1.Visible = false;
            this.buttonable1.Click += new System.EventHandler(this.buttonable1Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // buttonopen1
            // 
            this.buttonopen1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonopen1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonopen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonopen1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonopen1.Location = new System.Drawing.Point(17, 21);
            this.buttonopen1.Name = "buttonopen1";
            this.buttonopen1.Size = new System.Drawing.Size(70, 40);
            this.buttonopen1.TabIndex = 2;
            this.buttonopen1.Text = "查看";
            this.buttonopen1.UseVisualStyleBackColor = false;
            this.buttonopen1.Visible = false;
            this.buttonopen1.Click += new System.EventHandler(this.buttonopen1Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // labelmessage
            // 
            this.labelmessage.AutoSize = true;
            this.labelmessage.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelmessage.Location = new System.Drawing.Point(13, 290);
            this.labelmessage.Name = "labelmessage";
            this.labelmessage.Size = new System.Drawing.Size(119, 16);
            this.labelmessage.TabIndex = 6;
            this.labelmessage.Text = "U盘消息列表：";
            // 
            // buttonclear
            // 
            this.buttonclear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonclear.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonclear.Location = new System.Drawing.Point(530, 281);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(60, 30);
            this.buttonclear.TabIndex = 7;
            this.buttonclear.Text = "清空";
            this.buttonclear.UseVisualStyleBackColor = false;
            this.buttonclear.Click += new System.EventHandler(this.buttonclearClick);
            // 
            // buttoncopy
            // 
            this.buttoncopy.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttoncopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoncopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncopy.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttoncopy.Location = new System.Drawing.Point(623, 82);
            this.buttoncopy.Name = "buttoncopy";
            this.buttoncopy.Size = new System.Drawing.Size(120, 40);
            this.buttoncopy.TabIndex = 8;
            this.buttoncopy.Text = "复制文件";
            this.buttoncopy.UseVisualStyleBackColor = false;
            this.buttoncopy.Click += new System.EventHandler(this.buttoncopyClick);
            // 
            // buttondelete
            // 
            this.buttondelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttondelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttondelete.Location = new System.Drawing.Point(623, 202);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(120, 40);
            this.buttondelete.TabIndex = 9;
            this.buttondelete.Text = "删除文件";
            this.buttondelete.UseVisualStyleBackColor = false;
            this.buttondelete.Click += new System.EventHandler(this.buttondeleteClick);
            // 
            // buttoncopydir
            // 
            this.buttoncopydir.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttoncopydir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoncopydir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncopydir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttoncopydir.Location = new System.Drawing.Point(623, 142);
            this.buttoncopydir.Name = "buttoncopydir";
            this.buttoncopydir.Size = new System.Drawing.Size(120, 40);
            this.buttoncopydir.TabIndex = 10;
            this.buttoncopydir.Text = "复制目录";
            this.buttoncopydir.UseVisualStyleBackColor = false;
            this.buttoncopydir.Click += new System.EventHandler(this.buttoncopydirClick);
            // 
            // buttondeletedir
            // 
            this.buttondeletedir.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttondeletedir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondeletedir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondeletedir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttondeletedir.Location = new System.Drawing.Point(623, 264);
            this.buttondeletedir.Name = "buttondeletedir";
            this.buttondeletedir.Size = new System.Drawing.Size(120, 40);
            this.buttondeletedir.TabIndex = 11;
            this.buttondeletedir.Text = "删除目录";
            this.buttondeletedir.UseVisualStyleBackColor = false;
            this.buttondeletedir.Click += new System.EventHandler(this.buttondeletedirClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 446);
            this.Controls.Add(this.buttondeletedir);
            this.Controls.Add(this.buttoncopydir);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttoncopy);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.labelmessage);
            this.Controls.Add(this.listBoxMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.CheckU);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UDisk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formclose);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckU;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.ListBox listBoxMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonopen1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttondisable3;
        private System.Windows.Forms.Button buttonable3;
        private System.Windows.Forms.Button buttonopen3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttondisable2;
        private System.Windows.Forms.Button buttondisable1;
        private System.Windows.Forms.Button buttonable2;
        private System.Windows.Forms.Button buttonopen2;
        private System.Windows.Forms.Button buttonable1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelmessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button buttoncopy;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttoncopydir;
        private System.Windows.Forms.Button buttondeletedir;
    }
}

