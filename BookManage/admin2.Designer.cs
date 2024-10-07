namespace BookManage
{
    partial class admin2
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(667, 450);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // Column1
            // 
            Column1.HeaderText = "书号";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "书名";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "作者";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "出版社";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "库存";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // button1
            // 
            button1.Font = new Font("新宋体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(690, 87);
            button1.Name = "button1";
            button1.Size = new Size(127, 52);
            button1.TabIndex = 1;
            button1.Text = "添加图书";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("新宋体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(857, 87);
            button2.Name = "button2";
            button2.Size = new Size(127, 52);
            button2.TabIndex = 2;
            button2.Text = "修改图书";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("新宋体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(690, 172);
            button3.Name = "button3";
            button3.Size = new Size(127, 52);
            button3.TabIndex = 3;
            button3.Text = "删除图书";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("新宋体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(857, 172);
            button4.Name = "button4";
            button4.Size = new Size(127, 52);
            button4.TabIndex = 4;
            button4.Text = "刷新";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("新宋体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(857, 340);
            button5.Name = "button5";
            button5.Size = new Size(127, 52);
            button5.TabIndex = 5;
            button5.Text = "书名查询";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("新宋体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(857, 257);
            button6.Name = "button6";
            button6.Size = new Size(127, 52);
            button6.TabIndex = 6;
            button6.Text = "书号查询";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("微软雅黑", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(690, 273);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 36);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("微软雅黑", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(690, 356);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 36);
            textBox2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(688, 28);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 9;
            label1.Text = "当前选中的图书是：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(838, 28);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 10;
            label2.Text = "NULL";
            // 
            // admin2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "admin2";
            Text = "图书管理页面";
            Load += admin2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
    }
}