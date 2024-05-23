using NAudio.Wave;
using System.Security.Cryptography.Xml;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                panel1.BackColor = Color.Yellow;
                WaveOutEvent woe = new WaveOutEvent();
                woe.Init(new AudioFileReader(@"D:\cs_work\WinFormsApp7\od\\µµ.mp3"));
                woe.Play();
            }
            else if (e.KeyCode == Keys.W)
            {
                panel2.BackColor = Color.Blue;
            }
            else if (e.KeyCode == Keys.E)
            {
                panel3.Visible = false;
            }
            else if (e.KeyCode == Keys.R)
            {
                panel4.BackColor = Color.Red;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                panel1.BackColor = Color.MidnightBlue;
            }
            else if (e.KeyCode == Keys.W)
            {
                panel2.BackColor = Color.MidnightBlue;
            }
            else if (e.KeyCode == Keys.E)
            {
                panel3.Visible = true;
            }
            else if (e.KeyCode == Keys.R)
            {
                panel4.BackColor = Color.MidnightBlue;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
    }
}
