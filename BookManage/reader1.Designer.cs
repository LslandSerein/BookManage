namespace BookManage
{
    partial class reader1
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
            menuStrip1 = new MenuStrip();
            系统ToolStripMenuItem = new ToolStripMenuItem();
            帮助ToolStripMenuItem = new ToolStripMenuItem();
            退出ToolStripMenuItem = new ToolStripMenuItem();
            联系管理员ToolStripMenuItem = new ToolStripMenuItem();
            图书查看和借阅ToolStripMenuItem = new ToolStripMenuItem();
            当前借出图书和归还ToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 系统ToolStripMenuItem, 图书查看和借阅ToolStripMenuItem, 当前借出图书和归还ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            系统ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 帮助ToolStripMenuItem, 退出ToolStripMenuItem, 联系管理员ToolStripMenuItem });
            系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            系统ToolStripMenuItem.Size = new Size(53, 24);
            系统ToolStripMenuItem.Text = "系统";
            // 
            // 帮助ToolStripMenuItem
            // 
            帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            帮助ToolStripMenuItem.Size = new Size(224, 26);
            帮助ToolStripMenuItem.Text = "帮助";
            帮助ToolStripMenuItem.Click += 帮助ToolStripMenuItem_Click;
            // 
            // 退出ToolStripMenuItem
            // 
            退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            退出ToolStripMenuItem.Size = new Size(224, 26);
            退出ToolStripMenuItem.Text = "退出";
            退出ToolStripMenuItem.Click += 退出ToolStripMenuItem_Click;
            // 
            // 联系管理员ToolStripMenuItem
            // 
            联系管理员ToolStripMenuItem.Name = "联系管理员ToolStripMenuItem";
            联系管理员ToolStripMenuItem.Size = new Size(224, 26);
            联系管理员ToolStripMenuItem.Text = "联系管理员";
            // 
            // 图书查看和借阅ToolStripMenuItem
            // 
            图书查看和借阅ToolStripMenuItem.Name = "图书查看和借阅ToolStripMenuItem";
            图书查看和借阅ToolStripMenuItem.Size = new Size(128, 24);
            图书查看和借阅ToolStripMenuItem.Text = "图书查看和借阅";
            图书查看和借阅ToolStripMenuItem.Click += 图书查看和借阅ToolStripMenuItem_Click;
            // 
            // 当前借出图书和归还ToolStripMenuItem
            // 
            当前借出图书和归还ToolStripMenuItem.Name = "当前借出图书和归还ToolStripMenuItem";
            当前借出图书和归还ToolStripMenuItem.Size = new Size(158, 24);
            当前借出图书和归还ToolStripMenuItem.Text = "当前借出图书和归还";
            当前借出图书和归还ToolStripMenuItem.Click += 当前借出图书和归还ToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("华文行楷", 22.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(255, 156);
            label1.Name = "label1";
            label1.Size = new Size(276, 39);
            label1.TabIndex = 2;
            label1.Text = "欢迎管理员登录";
            label1.Click += label1_Click;
            // 
            // reader1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "reader1";
            Text = "读者主页面";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 系统ToolStripMenuItem;
        private ToolStripMenuItem 帮助ToolStripMenuItem;
        private ToolStripMenuItem 退出ToolStripMenuItem;
        private ToolStripMenuItem 联系管理员ToolStripMenuItem;
        private ToolStripMenuItem 图书查看和借阅ToolStripMenuItem;
        private ToolStripMenuItem 当前借出图书和归还ToolStripMenuItem;
        private Label label1;
    }
}