namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0;i < 10;i++)
            {
                Random rnd1 = new Random();
                Random rnd2 = new Random();
                Button btn1 = new Button();     
                btn1.Text = "OK";
                btn1.Location = new Point(rnd1.Next(0,818), rnd2.Next(0,497));
                btn1.UseVisualStyleBackColor = false;
                btn1.Click += Btn1_Click;
                Controls.Add(btn1);
            }
        }

        private void Btn1_Click(object? sender, EventArgs e)
        {

            Button btn = sender as Button;
            if (btn.BackColor != Color.Red)
            {
                Random rnd1 = new Random();
                Random rnd2 = new Random();

                btn.BackColor = Color.Red;
                btn.Text = "NOT OK";
                btn.Location = new Point(rnd1.Next(0,818),rnd2.Next(0,400));
            }
            else
            {
                Random rnd1 = new Random();
                Random rnd2 = new Random();

                btn.BackColor = Color.White;
                btn.Text = "OK";
                btn.Location = new Point(rnd1.Next(0, 818), rnd2.Next(0, 400));
            }
            
            

            Console.WriteLine("OK 버튼 누름");
        }
    }
}
