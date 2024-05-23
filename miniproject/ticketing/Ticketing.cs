using miniproject.Properties;

namespace miniproject.ticketing
{

    public partial class Ticketing : Form
    {
        int timetable_index1;
        int timetable_index2;
        int timetable_index3;

        public Ticketing()
        {
            DBsql dBsql = new DBsql();
            List<int> list = new List<int>();

            InitializeComponent();
            timer1.Start();
            list = dBsql.timetableIndex();
            timetable_index1 = list[0];
            timetable_index2 = list[1];
            timetable_index3 = list[2];
            pictureBox1.Image = Resources._1;
            pictureBox2.Image = Resources._2;
            pictureBox3.Image = Resources._3;
            dBsql.test();
            dBsql.movieSelect(lb_title1, lb_sTime1, lb_summa1, DBsql.ints[0]);
            dBsql.movieSelect(lb_title2, lb_sTime2, lb_summa2, DBsql.ints[1]);
            dBsql.movieSelect(lb_title3, lb_sTime3, lb_summa3, DBsql.ints[2]);
        }

        // 추천 영화 누르면 Tickting3으로 가는 기능 만들어야함

        // 시계
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        // 모든영화보기 가는 버튼
        private void btn_allMovie_Click(object sender, EventArgs e)
        {
            Ticketing2 ticketing2 = new Ticketing2();
            Hide();
            ticketing2.ShowDialog();
        }

        // 메인화면 가는 버튼
        private void btn_goHome_Click(object sender, EventArgs e)
        {
            MainDisplay mainDisplay = new MainDisplay();
            Hide();
            mainDisplay.ShowDialog();
        }

        // 선택한 영화 예매화면 가는 버튼
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Ticketing3_1 ticketing3_1 = new Ticketing3_1();
            ticketing3_1.timetable(timetable_index1);
            Hide();
            ticketing3_1.ShowDialog();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            Ticketing3_1 ticketing3_1 = new Ticketing3_1();
            ticketing3_1.timetable(timetable_index2);
            Hide();
            ticketing3_1.ShowDialog();
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            Ticketing3_1 ticketing3_1 = new Ticketing3_1();
            ticketing3_1.timetable(timetable_index3);
            Hide();
            ticketing3_1.ShowDialog();
        }
    }
}
