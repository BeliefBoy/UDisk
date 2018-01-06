namespace UDisk
{
    partial class welcome
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
            this.buttongoto = new System.Windows.Forms.Button();
            this.buttonquit = new System.Windows.Forms.Button();
            this.welcometext = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttongoto
            // 
            this.buttongoto.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttongoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttongoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttongoto.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttongoto.ForeColor = System.Drawing.SystemColors.Info;
            this.buttongoto.Location = new System.Drawing.Point(66, 174);
            this.buttongoto.Margin = new System.Windows.Forms.Padding(5);
            this.buttongoto.Name = "buttongoto";
            this.buttongoto.Size = new System.Drawing.Size(137, 48);
            this.buttongoto.TabIndex = 0;
            this.buttongoto.Text = "进入助手";
            this.buttongoto.UseVisualStyleBackColor = false;
            this.buttongoto.Click += new System.EventHandler(this.buttongotoClick);
            // 
            // buttonquit
            // 
            this.buttonquit.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonquit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonquit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonquit.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonquit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonquit.Location = new System.Drawing.Point(278, 174);
            this.buttonquit.Margin = new System.Windows.Forms.Padding(5);
            this.buttonquit.Name = "buttonquit";
            this.buttonquit.Size = new System.Drawing.Size(137, 48);
            this.buttonquit.TabIndex = 1;
            this.buttonquit.Text = "退出助手";
            this.buttonquit.UseVisualStyleBackColor = false;
            this.buttonquit.Click += new System.EventHandler(this.buttonquitClick);
            // 
            // welcometext
            // 
            this.welcometext.AutoSize = true;
            this.welcometext.Font = new System.Drawing.Font("楷体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.welcometext.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.welcometext.Location = new System.Drawing.Point(51, 47);
            this.welcometext.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.welcometext.Name = "welcometext";
            this.welcometext.Size = new System.Drawing.Size(388, 48);
            this.welcometext.TabIndex = 2;
            this.welcometext.Text = "欢迎使用U盘助手";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("新宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(148, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "作者：14软二赵鹏";
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcometext);
            this.Controls.Add(this.buttonquit);
            this.Controls.Add(this.buttongoto);
            this.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeToUDisk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formclose);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttongoto;
        private System.Windows.Forms.Button buttonquit;
        private System.Windows.Forms.Label welcometext;
        private System.Windows.Forms.Label label1;
    }
}