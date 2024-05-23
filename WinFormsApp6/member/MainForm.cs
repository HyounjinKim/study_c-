namespace WinFormsApp6.member
{
    public partial class MainForm : Form
    {
        public MainForm(string id, string password)
        {
            InitializeComponent();

            label1.Text = id;
            label2.Text = password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl21.BringToFront();
        }
    }
}
