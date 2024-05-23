using miniproject.admin;

namespace miniproject
{
    public partial class Login : Form
    {
        public Login()
        {
            DBsql dBsql = new DBsql();
            dBsql.dbLoad();
            InitializeComponent();
        }

        // admin / 고객 로그인
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("1234") && textBox2.Text.Equals("admin"))
            {
                AdminMain adminMain = new AdminMain();
                Hide();
                adminMain.ShowDialog();
                Show();
            }
            else if (textBox1.Text.Equals("") && textBox2.Text.Equals(""))
            {
                FirstDisplay form1 = new FirstDisplay();
                Hide();
                form1.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("아이디 비번 확인");
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
