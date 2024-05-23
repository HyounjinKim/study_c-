namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        List<string> listboxdata = new List<string>() { "홍길동", "이길동", "박길동" };
        List<Person> personlist = new List<Person>() { new Person() { name = "홍길동", age = 20 }, new Person { name = "이길동", age = 30 } }; 

        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personlist;
        }

        //public void myThread()
        //{
        //    Random random = new Random();
        //    int x = random.Next(0, 500);
        //    int y = random.Next(0, 500);
        //    double ran = random.NextDouble();
        //    button1.Text = ran.ToString();

        //    while (true)
        //    {
        //        Thread.Sleep(1000);
        //        button1.Location = new Point(x, y);
        //    }

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //Thread th1 = new Thread(myThread);
            //th1.Start();

            button1.Text = "버튼생성";
            button1.Width = 200;

            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                Controls.Add(button);
                button.Text = i.ToString();

                Point point = new Point();
                point.X = 10;
                point.Y = 100 + 40 * i;
                button.Location = point;

                bool visible = new Random().Next(2) == 0 ? true : false;

                Thread.Sleep(10);
                button.Visible = visible;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            A a = new A() { x = 10, y = 20 };
            A b = a;

            AA aa = new AA() { x = 10, y = 20 };
            AA bb = aa;

            a.x = 100;
            Console.WriteLine($"a.x = {a.x}");
            Console.WriteLine($"b.x = {b.x}");

            aa.x = 100;
            Console.WriteLine($"aa.x = {aa.x}");
            Console.WriteLine($"bb.x = {bb.x}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>() { 10, 20, 30, 40, 50 };
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listboxdata.Add("김길동");
            listBox1.DataSource = listboxdata;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            personlist.Add(new Person() { name = "박길동", age = 30 });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personlist;
        }
    }
}
