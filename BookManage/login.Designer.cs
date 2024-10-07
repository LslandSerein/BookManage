namespace BookManage
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            radioButtonUser = new RadioButton();
            radioButtonAdmin = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("华文新魏", 22.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(119, 46);
            label1.Name = "label1";
            label1.Size = new Size(387, 38);
            label1.TabIndex = 0;
            label1.Text = "欢迎登陆图书管理系统";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(119, 151);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "账户：";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(119, 230);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "密码：";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(210, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 30);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(210, 227);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(276, 30);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(147, 332);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "登录";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(326, 332);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "取消";
            button2.UseVisualStyleBackColor = true;
            // 
            // radioButtonUser
            // 
            radioButtonUser.AutoSize = true;
            radioButtonUser.Checked = true;
            radioButtonUser.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonUser.Location = new Point(147, 281);
            radioButtonUser.Name = "radioButtonUser";
            radioButtonUser.Size = new Size(72, 24);
            radioButtonUser.TabIndex = 7;
            radioButtonUser.TabStop = true;
            radioButtonUser.Text = "用户";
            radioButtonUser.UseVisualStyleBackColor = true;
            radioButtonUser.CheckedChanged += radioButtonUser_CheckedChanged;
            // 
            // radioButtonAdmin
            // 
            radioButtonAdmin.AutoSize = true;
            radioButtonAdmin.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonAdmin.Location = new Point(327, 281);
            radioButtonAdmin.Name = "radioButtonAdmin";
            radioButtonAdmin.Size = new Size(93, 24);
            radioButtonAdmin.TabIndex = 8;
            radioButtonAdmin.Text = "管理员";
            radioButtonAdmin.UseVisualStyleBackColor = true;
            radioButtonAdmin.CheckedChanged += radioButtonAdmin_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButtonAdmin);
            Controls.Add(radioButtonUser);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private RadioButton radioButtonUser;
        private RadioButton radioButtonAdmin;
    }
}