using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test3
{
    public partial class Form1 : Form
    {
        int score = 0;
        public Form1()
        {
            InitializeComponent();
            label2.Text = score.ToString();
        }

        public void Score(Button btn)
        {
            score++;
            label2.Text = score.ToString();
            btn.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Score(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Score(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Score(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Score(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Score(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Score(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Score(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Score(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Score(button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            timer1.Interval = 800;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<Button> list = new List<Button>() { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            Random rand = new Random();
            int i = rand.Next(0, 9);
            list[i].Visible = true;
            timer2.Start();
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            List<Button> list = new List<Button>() { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            timer2.Interval = 800;

            for (int i = 0; i<list.Count;i++)
            {
                list[i].Visible = false;
            }
        }
    }
}
