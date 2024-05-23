namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(((Button)sender).ToString());
            MessageBox.Show(tb.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;

            int.TryParse(num1.Text,out n1);
            int.TryParse(num2.Text,out n2);

            MessageBox.Show((n1 + n2) + "");
            lb_result.Text = (n1 + n2) +"";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;

            int.TryParse(num1.Text,out n1);
            int.TryParse(num2.Text,out n2);

            MessageBox.Show((n1 - n2) + "");
            lb_result.Text = (n1 - n2) + "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;

            int.TryParse(num1.Text, out n1);
            int.TryParse(num2.Text, out n2);

            MessageBox.Show((n1 * n2)+"");
            lb_result.Text = (n1 * n2) + "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int n1;
                int n2;

                int.TryParse(num1.Text, out n1);
                int.TryParse(num2.Text, out n2);

                MessageBox.Show((n1 / n2) + "");
                lb_result.Text = (n1 / n2) + "";
            }
            catch (Exception)
            {
                MessageBox.Show("0으로 나눌 수 없습니다.");
            }
        }
    }
}
