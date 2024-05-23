using System.Timers;
using Timer = System.Timers.Timer;

namespace Project
{

    public partial class Form1 : Form
    {
        List<Color> color = new List<Color>();
        int i = 0;
        public Form1()
        {
            color.Add(Color.Yellow);
            color.Add(Color.Green);
            color.Add(Color.Blue);
            InitializeComponent();
            btn_first_display.BringToFront();
            timer1.Start();
        }

        public void btn_first_display_Click(object sender, EventArgs e)
        {
            mainDisplay1.BringToFront();
            MessageBox.Show("Test");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer timer = new Timer(3000);
            timer.Elapsed += new ElapsedEventHandler(onClickEvent);

            timer.Start();
            timer1.Enabled = false;
        }

        delegate void onEv();

        private void onClickEvent(object? sender, ElapsedEventArgs e)
        {
            BeginInvoke(new onEv(work));
        }

        private void work()
        {
            btn_first_display.BackColor = color[i];
            i++;
            if (i == color.Count)
            {
                i = 0;
            }
        }
    }
}
