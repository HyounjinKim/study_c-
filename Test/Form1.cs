using System.Collections;
using System.Timers;
using Timer = System.Timers.Timer;
using System.Media;
using WMPLib;
using System.Numerics;

namespace Test
{
    
    public partial class Form1 : Form
    {

        List<Color> list = new List<Color>();
        int i = 0;
        

        public Form1()
        {
            list.Add(Color.White);
            list.Add(Color.Orange);
            list.Add(Color.Yellow);
            InitializeComponent();
            time.Start();
            timer();
            pb_movie_poster.Visible = false;
            label1.Visible = false;
            panel_first_menu.Visible = false;
            panel_ticketing.BringToFront();

        }

        // Ã¹È­¸é
        private void button1_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = @"D:\student\TinyButtonPushSound.mp3";
            player.controls.play();

            panel_first_menu.Visible = true;
            label1.Visible = true;
            pb_movie_poster.Visible = true;
            btn_first_display.Visible = false;
        }

        private void time_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString("yyyy-MM-dd\ntt hh:mm:ss");
        }

        private void btn_menu_ticketPrint_Click(object sender, EventArgs e)
        {
            panel_ticketPrint.Visible = true;
        }

        private void btn_ticketing_Click(object sender, EventArgs e)
        {
            panel_ticketing.Visible = true;
        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            panel_ticketPrint.Visible = false;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            panel_ticketPrint.Visible = false;
        }

        private void btn_ticketing_pre_Click(object sender, EventArgs e)
        {
            panel_ticketing.Visible = false;
        }

        private void btn_ticketing_hom_Click(object sender, EventArgs e)
        {
            panel_ticketing.Visible = false;
        }

        private void timer()
        {
            Timer timer = new Timer(5000);
            timer.Elapsed += new ElapsedEventHandler(Timer_Elapsed);

            timer.Start();
        }
        delegate void timeEv();
        private void Timer_Elapsed(object? sender,ElapsedEventArgs e)
        {
            BeginInvoke(new timeEv(work));
        }

        private void work()
        {
            pb_movie_poster.Image = imageList1.Images[i];
            i++;
            if (i == 3)
            {
                i = 0;
            }
        }
    }
}
