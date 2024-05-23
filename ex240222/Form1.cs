using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex240222
{
    public partial class Form1 : Form
    {
        List<int> ints = new List<int>();

        int size = 3;
        public Form1()
        {
            InitializeComponent();

            addButtons();
            setLabel1List();
        }

        private void Button_Click1(object sender, EventArgs e)
        {
            //MessageBox.Show("T");
            Button btn = (Button)sender;
            int temp = int.Parse(btn.Text);
            ints.Remove(temp);
            setLabel1List();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            int temp = int.Parse(btn.Text);
            ints.Add(temp);
            setLabel1List();
        }

        void setLabel1List()
        {
            string result = "";
            for (int i = 0; i < ints.Count; i++)
            {
                if (ints.Count != (i + 1))
                {
                    result = result + (ints[i] + ", ");
                }
                else
                {
                    result = result + (ints[i]);
                }
            }
            label2.Text = result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("추가");
        }

        void addButtons()
        {
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {

                Button button = new Button();
                button.Text = rand.Next(100).ToString();
                button.Location = new Point(80 + (i * 100), 120);
                button.Click += Button_Click;


                //button.Click += new System.EventHandler(Button_Click1);
                //button.Click += (aa, bb) =>
                //{
                //    MessageBox.Show("람다" + aa+""+bb);
                //};
                Controls.Add(button);

                Button button1 = new Button();
                button1.Text = button.Text;
                button1.Location = new Point(80 + (i * 100), 180);
                button1.Click += Button_Click1;
                //button1.Click += (a, b) =>
                //{
                //    Button temp = a as Button;
                //    int itemp = int.Parse(temp.Text);
                //    ints.Remove(itemp);
                //    ints.RemoveAt(0);
                //    setLabel1List();
                //};

                Controls.Add(button1);
            }
        }
    }
}
