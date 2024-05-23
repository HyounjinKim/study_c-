namespace WinFormsApp10class
{

    class Car
    {
        public string name { get; set; }
    }

    public partial class Form1 : Form
    {
        int y = 10;

        List<Car> list = new List<Car>();
        

        public Form1()
        {
            InitializeComponent();
            
            Car car1 = new Car() { name = "자동차 1" };
            Car car2 = new Car() { name = "자동차 2" };

            list.Add(car1);
            list.Add(car2);

            foreach (var car in list)
            {
                MakeLabel(10, y, car.name);
                y += 40;
            }
        }

        public void MakeLabel(int x, int y, string text)
        {
            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Location = new Point(x, y);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = text;
            label1.Font = new Font("배달의민족", 20);
            Controls.Add(label1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeLabel(10, y += 40, textBox1.Text);
            textBox1.Text = "";
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(null, null);
            }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3_Click(null, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MakeLabel(10, y += 40, textBox2.Text);
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MakeLabel(10, y += 40, textBox3.Text);
            textBox3.Text = "";
        }
    }
}
