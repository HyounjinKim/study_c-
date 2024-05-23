using Test2.maindisplay;

namespace Test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }
    }
}
