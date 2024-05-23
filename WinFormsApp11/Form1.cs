namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        int gak = 10;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Cos((gak*Math.PI) / 180) * 100);
            Console.WriteLine(Math.Sin((gak*Math.PI) / 180) * 100);

            int x = 250 + (int) (Math.Cos((gak * Math.PI) / 180) * 100);
            int y = 250 + (int) (Math.Sin((gak * Math.PI) / 180) * 100);

            Console.WriteLine("Ãâ·Â");
            button1.Location = new Point(x, y);
            gak += 10;
        }
    }
}
