namespace WinFormsApp4
{
    public partial class Form1 : Form
    {

        private Button button1;

        private Button button2;

        public Form1()
        {
            InitializeComponent();

            button1 = new Button();
            button1.Location = new Point(295, 193);
            button1.Name = "button1";
            button1.Size = new Size(185, 65);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            Controls.Add(button1);

            button2 = new Button();
            button2.Location = new Point(100, 193);
            button2.Name = "button2";
            button2.Size = new Size(185, 65);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            Controls.Add(button2);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("æ»≥Á«œººø‰");
        }
    }
}
