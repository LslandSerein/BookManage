using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManage
{
    public partial class reader1 : Form
    {
        public reader1()
        {
            InitializeComponent();
            label1.Text = $"欢迎{Data.UName}登录";
        }

        private void 图书查看和借阅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reader2 reader = new reader2();
            reader.ShowDialog();
        }

        private void 当前借出图书和归还ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reader3 reader = new reader3();
            reader.ShowDialog();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HELP");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
