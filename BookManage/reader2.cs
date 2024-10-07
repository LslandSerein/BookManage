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
    public partial class reader2 : Form
    {
        public reader2()
        {
            InitializeComponent();
            Table();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //从数据库中读取数据显示在表格控件中
        public void Table()
        {
            dataGridView1.Rows.Clear();  //清空旧数据
            Dao dao = new Dao();
            string sql = "select * from book";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }

        private void reader2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.Rows[0].Cells[0].Value.ToString();   //获取书号
            int number = int.Parse(dataGridView1.Rows[0].Cells[4].Value.ToString());  //库存
            if (number < 1)
            {
                MessageBox.Show("库存不足，请联系管理员购入");
            }
            else
            {
                string sql = $"insert into borrow ([readerid],bookid,[datetime])values('{Data.UID}','{id}',getdate());update book set number=number-1 where bookid='{id}'";
                Dao dao =new Dao();
                if(dao.Execute(sql)>1)  //执行两条sql，大于1才是都成功
                {
                    MessageBox.Show($"用户{Data.UName}借出图书{id}!");
                    Table();
                }
            }
        }
    }
}
