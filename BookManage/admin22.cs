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
    public partial class admin22 : Form
    {
        string ID = "";
        public admin22()
        {
            InitializeComponent();
        }
        public admin22(string id, string name, string author,string press,string number)
        {
            InitializeComponent();
            ID=textBox1.Text= id;
            textBox2.Text= name;
            textBox3.Text= author;
            textBox4.Text= press;
            textBox5.Text= number;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"update book set bookid ='{textBox1.Text}',bookname='{textBox2.Text}',author='{textBox3.Text}',publish='{textBox4.Text}',number={textBox5.Text} where bookid ='{ID}'";
                       //update book set bookid ='2212190100',bookname='测试1',author='作者',publish='测试',number=6 where bookid ='123'
            Dao dao = new Dao();
            if(dao.Execute(sql) > 0 )
            {
                MessageBox.Show("修改成功");
                this.Close();
            }
        }
    }
}
