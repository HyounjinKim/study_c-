namespace miniproject.ticketing
{
    public partial class Ticketing4 : Form
    {
        #region 변수
        int sum = 0;
        int adult = 0;
        int teen = 0;
        int dis = 0;
        int old = 0;
        int seatCount = 0;
        bool seatSelect1 = false;
        bool seatSelect2 = false;
        bool seatSelect3 = false;
        int adultPrice = 14000;
        int teenPrice = 8000;
        int disPrice = 4000;
        int oldtPrice = 5000;
        #endregion

        #region 겟셋
        public void setSum(int sum,int adult,int teen,int dis,int old)
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
        public int getOld()
        {
            return old;
        }
        #endregion 겟셋
        public Ticketing4()
        {
            InitializeComponent();
            timer1.Start();

        }

        // 결제 버튼
        // Ticketing3에서 나온 sum값으로 결제기능 만들어야함
        // DB정보로 예매된 좌석 버튼선택 못하게하고 선택한 버튼 색바뀌게 해야함
        // sum 값으로 sum값 초과되게 좌석 버튼 누르면 안눌리게 해야함
        private void btn_pay_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((getAdult() * adultPrice) + (getTeen() * teenPrice) + (getDis() * disPrice) + (getOld() * oldtPrice)).ToString());
            MessageBox.Show("결제완료");
            Hide();
        }

        // 시계
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        // 이전화면 가는 버튼
        private void btn_goPre_Click(object sender, EventArgs e)
        {
            Ticketing3 ticketing3 = new Ticketing3();
            Hide();
            ticketing3.ShowDialog();
        }

        // 메인화면 가는 버튼
        private void btn_goHome_Click(object sender, EventArgs e)
        {
            MainDisplay mainDisplay = new MainDisplay();
            Hide();
            mainDisplay.ShowDialog();
        }

        public void peopleSum(int a, int b, int c, int d)
        {
            sum = a + b + c + d;
            setSum(sum,a,b,c,d);
        }

        #region 좌석버튼
        private void btn_seat1_Click(object sender, EventArgs e)
        {
            if (getSum() > seatCount && seatSelect1 == false)
            {
                seatCount++;
                seatSelect1 = true;
                btn_seat1.BackColor = Color.Gray;
            }
            else if(getSum() >= seatCount && seatSelect1 == true)
            {
                seatCount--;
                seatSelect1=false;
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
        #endregion
    }
}
