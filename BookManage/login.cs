using System.Data;

namespace BookManage
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null)
            {
                Login();
            }
            else
            {
                MessageBox.Show("�����п������������");
            }
        }
        public void Login()  //��½��������֤�Ƿ������¼����������
        {     //�û�
            if (radioButtonUser.Checked == true)
            {
                Dao dao = new Dao();
                string sql = $"select* from reader where readerid='{textBox1.Text}' and psw='{textBox2.Text}'";
                //string sql2 = String.Format("select* from reader where readerid='{0}' and psw='{1}'", textBox1.Text, textBox2.Text);
                //string sql3 = "select* from reader where readerid='"+textBox1.Text+"' and psw='"+textBox2.Text+"'";
                //if (sql == sql2 && sql == sql3)
                //{
                //    MessageBox.Show("1");
                //}
                //MessageBox.Show(sql);
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    Data.UID = dc["readerid"].ToString();
                    Data.UName = dc["rname"].ToString();

                    MessageBox.Show("��½�ɹ�");
                    reader1 reader = new reader1();
                    this.Hide();
                    reader.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("��½ʧ��");
                }
                //MessageBox.Show(dc[0].ToString(), dc["rname"].ToString());
                dao.Daoclose();
                
            }
            //����Ա
            if (radioButtonAdmin.Checked == true)
            {
                Dao dao = new Dao();
                string sql = $"select* from theadmin where adminid='{textBox1.Text}' and psw='{textBox2.Text}'";
                //                     select* from theadmin where adminid = 'admin' and psw = '1'
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    MessageBox.Show("��½�ɹ�");
                    admin1 a = new admin1();
                    this.Hide();
                    a.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("��½ʧ��");
                }
                dao.Daoclose();
            }
            //MessageBox.Show("����ѡ�е�ѡ��");
        }

        private void radioButtonUser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}