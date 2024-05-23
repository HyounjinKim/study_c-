using WinFormsApp6.aaa;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new Form2().Show();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new Form3().Show();
            Show();
        }
    }
}
