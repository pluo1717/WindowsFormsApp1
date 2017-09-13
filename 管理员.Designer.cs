namespace WindowsFormsApp1
{
    partial class 管理员
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.会员卡信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.会员信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教练员信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.会员卡信息ToolStripMenuItem,
            this.会员信息ToolStripMenuItem,
            this.教练员信息ToolStripMenuItem,
            this.课程信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(551, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 会员卡信息ToolStripMenuItem
            // 
            this.会员卡信息ToolStripMenuItem.Name = "会员卡信息ToolStripMenuItem";
            this.会员卡信息ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.会员卡信息ToolStripMenuItem.Text = "会员卡信息";
            this.会员卡信息ToolStripMenuItem.Click += new System.EventHandler(this.会员卡信息ToolStripMenuItem_Click);
            // 
            // 会员信息ToolStripMenuItem
            // 
            this.会员信息ToolStripMenuItem.Name = "会员信息ToolStripMenuItem";
            this.会员信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.会员信息ToolStripMenuItem.Text = "会员信息";
            this.会员信息ToolStripMenuItem.Click += new System.EventHandler(this.会员信息ToolStripMenuItem_Click);
            // 
            // 教练员信息ToolStripMenuItem
            // 
            this.教练员信息ToolStripMenuItem.Name = "教练员信息ToolStripMenuItem";
            this.教练员信息ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.教练员信息ToolStripMenuItem.Text = "教练员信息";
            this.教练员信息ToolStripMenuItem.Click += new System.EventHandler(this.教练员信息ToolStripMenuItem_Click);
            // 
            // 课程信息ToolStripMenuItem
            // 
            this.课程信息ToolStripMenuItem.Name = "课程信息ToolStripMenuItem";
            this.课程信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.课程信息ToolStripMenuItem.Text = "课程信息";
            this.课程信息ToolStripMenuItem.Click += new System.EventHandler(this.课程信息ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "会员转卡";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "转出会员编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "转入会员编号";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(197, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 管理员
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "管理员";
            this.Text = " ";
            this.Load += new System.EventHandler(this.管理员_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 会员卡信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 会员信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教练员信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程信息ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}