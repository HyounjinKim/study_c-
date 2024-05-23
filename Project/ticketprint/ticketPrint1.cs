using Project.maindisplay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.ticketprint
{
    public partial class ticketPrint1 : UserControl
    {
        public ticketPrint1()
        {
            InitializeComponent();
            timer_tkPrint.Start();
        }

        private void timer_tkPrint_Tick(object sender, EventArgs e)
        {
            lb_tkPrint_time.Text = DateTime.Now.ToString("yyyy-MM,dd\ntt hh:mm:ss");
        }

        private void btn_ticketingNum_Click(object sender, EventArgs e)
        {

        }

        private void btn_phoneNum_Click(object sender, EventArgs e)
        {

        }

        private void btn_ticketingHome_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.btn_first_display_Click(sender, e);
        }
    }
}
