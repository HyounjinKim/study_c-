using Oracle.ManagedDataAccess.Client;

namespace miniproject.ticketing
{
    public partial class Ticketing4_1 : Form
    {
        DBsql dbsql = new DBsql();

        #region 변수
        int sum = 0;
        int adult = 0;
        int teen = 0;
        int dis = 0;
        int old = 0;
        int seatCount;
        int theaterNum;
        int ttindex;
        bool seatSelect1 = false;
        bool seatSelect2 = false;
        bool seatSelect3 = false;
        bool seatSelect4 = false;
        bool seatSelect5 = false;
        bool seatSelect6 = false;
        bool seatSelect7 = false;
        bool seatSelect8 = false;
        bool seatSelect9 = false;
        bool seatSelect10 = false;
        bool seatSelect11 = false;
        bool seatSelect12 = false;
        bool seatSelect13 = false;
        bool seatSelect14 = false;
        bool seatSelect15 = false;
        #endregion

        #region 겟셋
        public void setSum(int sum, int adult, int teen, int dis, int old)
        {
            this.sum = sum;
            this.adult = adult;
            this.teen = teen;
            this.dis = dis;
            this.old = old;
        }
        public int getSum()
        {
            return sum;
        }
        public int getAdult()
        {
            return adult;
        }
        public int getTeen()
        {
            return teen;
        }
        public int getDis()
        {
            return dis;
        }
        public int getold()
        {
            return old;
        }

        public int getTtindex()
        {
            return ttindex;
        }

        public void setTtindex(int ttindex)
        {
            this.ttindex = ttindex;
        }

        public int getTheaterNum()
        {
            return theaterNum;
        }

        public void setTheaterNum(int theaterNum)
        {
            this.theaterNum = theaterNum;
        }
        #endregion 겟셋

        public Ticketing4_1()
        {
            InitializeComponent();
            timer1.Start();
        }

        public void peopleSum(int a, int b, int c, int d)
        {
            sum = a + b + c + d;
            setSum(sum, a, b, c, d);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
         
        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (seatCount == getSum())
            {

                int sum = dbsql.price(getAdult(),getTeen(),getDis(),getold());
                MessageBox.Show(sum.ToString());
                MessageBox.Show("결제완료");
                Hide();

            }
            else if (seatCount != getSum())
            {
                MessageBox.Show("좌석을 선택해주세요.");
            }
        }

        private void btn_goPre_Click(object sender, EventArgs e)
        {
            Ticketing3_1 ticketing3_1 = new Ticketing3_1();
            ticketing3_1.timetable(getTtindex());
            Hide();
            ticketing3_1.ShowDialog();
        }

        private void btn_goHome_Click(object sender, EventArgs e)
        {
            MainDisplay mainDisplay = new MainDisplay();
            Hide();
            mainDisplay.ShowDialog();
        }

        public void seatsold(int seatNum)
        {
            List<Button> list = new List<Button>() 
            { btn_seat1, btn_seat2, btn_seat3, btn_seat4, btn_seat5, btn_seat6, btn_seat7, btn_seat8, 
                btn_seat9, btn_seat10, btn_seat11, btn_seat12, btn_seat13, btn_seat14, btn_seat15 };

            for (int i = 0;i < list.Count;i++)
            {
                if (list[i].Text.Equals(seatNum.ToString()))
                {
                    list[i].Enabled = false;
                    list[i].BackColor = Color.Gray;
                    list[i].Text = "예";
                }
            }
        }

        #region 좌석버튼 모음
        private void btn_seat1_Click(object sender, EventArgs e)
        {
            if (getSum() > seatCount && seatSelect1 == false)
            {
                seatCount++;
                seatSelect1 = true;
                btn_seat1.BackColor = Color.Gray;
            }
            else if (getSum() >= seatCount && seatSelect1 == true)
            {
                seatCount--;
                seatSelect1 = false;
                btn_seat1.BackColor = Color.White;
            }
        }

        private void btn_seat2_Click(object sender, EventArgs e)
        {
            if (getSum() > seatCount && seatSelect2 == false)
            {
                seatCount++;
                seatSelect2 = true;
                btn_seat2.BackColor = Color.Gray;
            }
            else if (getSum() >= seatCount && seatSelect2 == true)
            {
                seatCount--;
                seatSelect2 = false;
                btn_seat2.BackColor = Color.White;
            }
        }

        private void btn_seat3_Click(object sender, EventArgs e)
        {
            if (getSum() > seatCount && seatSelect3 == false)
            {
                seatCount++;
                seatSelect3 = true;
                btn_seat3.BackColor = Color.Gray;
            }
            else if (getSum() >= seatCount && seatSelect3 == true)
            {
                seatCount--;
                seatSelect3 = false;
                btn_seat3.BackColor = Color.White;
            }
        }

        private void btn_seat4_Click(object sender, EventArgs e)
        {
            if (getSum() > seatCount && seatSelect4 == false)
            {
                seatCount++;
                seatSelect4 = true;
                btn_seat4.BackColor = Color.Gray;
            }
            else if (getSum() >= seatCount && seatSelect4 == true)
            {
                seatCount--;
                seatSelect4 = false;
                btn_seat4.BackColor = Color.White;
            }
        }

        private void btn_seat5_Click(object sender, EventArgs e)
        {
            if (getSum() > seatCount && seatSelect5 == false)
            {
                seatCount++;
                seatSelect5 = true;
                btn_seat5.BackColor = Color.Gray;
            }
            else if (getSum() >= seatCount && seatSelect5 == true)
            {
                seatCount--;
                seatSelect5 = false;
                btn_seat5.BackColor = Color.White;
            }
        }

        private void btn_seat6_Click(object sender, EventArgs e)
        {
            if (getSum() > seatCount && seatSelect6 == false)
            {
                seatCount++;
                seatSelect6 = true;
                btn_seat6.BackColor = Color.Gray;
            }
            else if (getSum() >= seatCount && seatSelect6 == true)
            {
                seatCount--;
                seatSelect6 = false;
                btn_seat6.BackColor = Color.White;
            }
        }

        private void btn_seat7_Click(object sender, EventArgs e)
        {
            if (getSum() > seatCount && seatSelect7 == false)
            {
                seatCount++;
                seatSelect7 = true;
                btn_seat7.BackColor = Color.Gray;
            }
            else if (getSum() >= seatCount && seatSelect7 == true)
            {
                seatCount--;
                seatSelect7 = false;
                btn_seat7.BackColor = Color.White;
            }
        }

        private void btn_seat8_Click(object sender, EventArgs e)
        {
            if (getSum() > seatCount && seatSelect8 == false)
            {
                seatCount++;
                seatSelect8 = true;
                btn_seat8.BackColor = Color.Gray;
            }
            else if (getSum() >= seatCount && seatSelect8 == true)
            {
                seatCount--;
                seatSelect8 = false;
                btn_seat8.BackColor = Color.White;
            }
        }

        private void btn_seat9_Click(object sender, EventArgs e)
        {
            if (getSum() > seatCount && seatSelect9 == false)
            {
                seatCount++;
                seatSelect9 = true;
                btn_seat9.BackColor = Color.Gray;
            }
            else if (getSum() >= seatCount && seatSelect9 == true)
            {
                seatCount--;
                seatSelect9 = false;
                btn_seat9.BackColor = Color.White;
            }
        }

        private void btn_seat10_Click(object sender, EventArgs e)
        {
            if (getSum() > seatCount && seatSelect10 == false)
            {
                seatCount++;
                seatSelect10 = true;
                btn_seat10.BackColor = Color.Gray;
            }
            else if (getSum() >= seatCount && seatSelect10 == true)
            {
                seatCount--;
                seatSelect10 = false;
                btn_seat10.BackColor = Color.White;
            }
        }

        private void btn_seat11_Click(object sender, EventArgs e)
        {
            if (getSum() > seatCount && seatSelect11 == false)
            {
                seatCount++;
                seatSelect11 = true;
                btn_seat11.BackColor = Color.Gray;
            }
            else if (getSum() >= seatCount && seatSelect11 == true)
            {
                seatCount--;
                seatSelect11 = false;
                btn_seat11.BackColor = Color.White;
            }
        }

        private void btn_seat12_Click(object sender, EventArgs e)
        {
            if (getSum() > seatCount && seatSelect12 == false)
            {
                seatCount++;
                seatSelect12 = true;
                btn_seat12.BackColor = Color.Gray;
            }
            else if (getSum() >= seatCount && seatSelect12 == true)
            {
                seatCount--;
                seatSelect12 = false;
                btn_seat12.BackColor = Color.White;
            }
        }

        private void btn_seat13_Click(object sender, EventArgs e)
        {
            if (getSum() > seatCount && seatSelect13 == false)
            {
                seatCount++;
                seatSelect13 = true;
                btn_seat13.BackColor = Color.Gray;
            }
            else if (getSum() >= seatCount && seatSelect13 == true)
            {
                seatCount--;
                seatSelect13 = false;
                btn_seat13.BackColor = Color.White;
            }
        }

        private void btn_seat14_Click(object sender, EventArgs e)
        {
            if (getSum() > seatCount && seatSelect14 == false)
            {
                seatCount++;
                seatSelect14 = true;
                btn_seat14.BackColor = Color.Gray;
            }
            else if (getSum() >= seatCount && seatSelect14 == true)
            {
                seatCount--;
                seatSelect14 = false;
                btn_seat14.BackColor = Color.White;
            }
        }

        private void btn_seat15_Click(object sender, EventArgs e)
        {
            if (getSum() > seatCount && seatSelect15 == false)
            {
                seatCount++;
                seatSelect15 = true;
                btn_seat15.BackColor = Color.Gray;
            }
            else if (getSum() >= seatCount && seatSelect15 == true)
            {
                seatCount--;
                seatSelect15 = false;
                btn_seat15.BackColor = Color.White;
            }
        }
        #endregion
    }
}
