using Project.ticketprint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.maindisplay
{
    public partial class MainDisplay : UserControl
    {
        public MainDisplay()
        {
            InitializeComponent();
            timer_main.Start();
            ticketPrint11.SendToBack();
        }

        private void timer_main_Tick(object sender, EventArgs e)
        {
            lb_main_time.Text = DateTime.Now.ToString("yyyy-MM,dd\ntt hh:mm:ss");
        }

        private void btn_ticketPrint_Click_1(object sender, EventArgs e)
        {
            ticketPrint11.BringToFront();
        }
    }
}
