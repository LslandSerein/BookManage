﻿namespace BookManage
{
    partial class admin21
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("新宋体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(207, 347);
            button1.Name = "button1";
            button1.Size = new Size(127, 52);
            button1.TabIndex = 10;
            button1.Text = "添加图书";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("新宋体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(422, 347);
            button2.Name = "button2";
            button2.Size = new Size(127, 52);
            button2.TabIndex = 11;
            button2.Text = "取消";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 53);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 12;
            label1.Text = "书号";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(344, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 27);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(344, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 27);
            textBox2.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 107);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 14;
            label2.Text = "书名";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(344, 165);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(216, 27);
            textBox3.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 165);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 16;
            label3.Text = "作者";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(344, 223);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(216, 27);
            textBox4.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 223);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 18;
            label4.Text = "出版社";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(344, 284);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(216, 27);
            textBox5.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(218, 287);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 20;
            label5.Text = "库存";
            label5.Click += label5_Click;
            // 
            // admin21
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 450);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "admin21";
            Text = "添加图书";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
    }
}