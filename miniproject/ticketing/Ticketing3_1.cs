namespace miniproject.ticketing
{
    public partial class Ticketing3_1 : Form
    {
        #region 변수
        int adult = 0;
        int teen = 0;
        int dis = 0;
        int old = 0;
        int sum = 0;
        int seatIndex;
        string theaterNum;
        int ttindex;
        #endregion

        #region 겟셋
        public string getTheaterNum()
        {
            return theaterNum;
        }

        public void setTheaterNum(string theaterNum)
        {
            this.theaterNum = theaterNum;
        }

        public int getSeat()
        {
            return seatIndex;
        }

        public void setSeat(int seatIndex)
        {
            this.seatIndex = seatIndex;
        }

        public int getTtindex()
        {
            return ttindex;
        }

        public void setTtindex(int ttindex)
        {
            this.ttindex = ttindex;
        }
        #endregion

        DBsql dbsql = new DBsql();

        public Ticketing3_1()
        {
            InitializeComponent();
            timer1.Start();
            lb_index1.Text = adult.ToString();
            lb_index2.Text = teen.ToString();
            lb_index3.Text = dis.ToString();
            lb_index4.Text = old.ToString();

            btnEnabled();
        }

        public void timetable(int index)
        {
            setTtindex(index);
            lbSeat(getTtindex(),lb_theater,lb_currentseat);
        }

        public void lbSeat(int index,Label lb1,Label lb2)
        {
            List<string> list = new List<string>();
            list = dbsql.seatInfo(index,lb1,lb2);

            setTheaterNum(list[0]);
            setSeat(int.Parse(list[1]));
        }

        // 시계
        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToString();
        }

        // Ticketing4_1로 가는 버튼
        private void btn_seatChoice_Click(object sender, EventArgs e)
        {
            sum = adult + teen + dis + old;

            if (getSeat() < sum)
            {
                MessageBox.Show("좌석 수가 부족합니다.");
            }
            else if (sum > 0)
            {
                List<int> list = new List<int>();
                
                Ticketing4_1 ticketing4_1 = new Ticketing4_1();
                ticketing4_1.peopleSum(adult, teen, dis, old);
                ticketing4_1.setTtindex(getTtindex());
                list = dbsql.seatSold(getTtindex(),getTheaterNum()); //
                for (int i = 0; i < list.Count;i++)
                {
                    ticketing4_1.seatsold(list[i]);
                }
                
                Hide();
                ticketing4_1.ShowDialog();
            }
            else if (sum <= 0)
            {
                MessageBox.Show("인원을 선택해주세요.");
            }
        }

        // 이전화면 가는 버튼
        private void btn_goPre_Click(object sender, EventArgs e)
        {
            Ticketing ticketing = new Ticketing();
            Hide();
            ticketing.ShowDialog();
        }

        // 메인화면 가는 버튼
        private void btn_goHome_Click(object sender, EventArgs e)
        {
            MainDisplay mainDisplay = new MainDisplay();
            Hide();
            mainDisplay.ShowDialog();
        }

        #region btnindex

        private void btnEnabled()
        {
            if (adult == 0)
            {
                btn_index1M.Enabled = false;
                btn_index1M.BackColor = Color.Gray;
                btn_index1M.FlatAppearance.BorderColor = Color.Gray;
            }
            else if (adult > 0)
            {
                btn_index1M.Enabled = true;
                btn_index1M.BackColor = Color.White;
                btn_index1M.FlatAppearance.BorderColor = Color.White;
            }

            if (adult > 8)
            {
                btn_index1P.Enabled = false;
                btn_index1P.BackColor = Color.Gray;
                btn_index1P.FlatAppearance.BorderColor = Color.Gray;
            }
            else if (adult < 9)
            {
                btn_index1P.Enabled = true;
                btn_index1P.BackColor = Color.White;
                btn_index1P.FlatAppearance.BorderColor = Color.White;
            }

            if (teen == 0)
            {
                btn_index2M.Enabled = false;
                btn_index2M.BackColor = Color.Gray;
                btn_index2M.FlatAppearance.BorderColor = Color.Gray;
            }
            else if (teen > 0)
            {
                btn_index2M.Enabled = true;
                btn_index2M.BackColor = Color.White;
                btn_index2M.FlatAppearance.BorderColor = Color.White;
            }

            if (teen > 8)
            {
                btn_index2P.Enabled = false;
                btn_index2P.BackColor = Color.Gray;
                btn_index2P.FlatAppearance.BorderColor = Color.Gray;
            }
            else if (teen < 9)
            {
                btn_index2P.Enabled = true;
                btn_index2P.BackColor = Color.White;
                btn_index2P.FlatAppearance.BorderColor = Color.White;
            }

            if (dis == 0)
            {
                btn_index3M.Enabled = false;
                btn_index3M.BackColor = Color.Gray;
                btn_index3M.FlatAppearance.BorderColor = Color.Gray;
            }
            else if (dis > 0)
            {
                btn_index3M.Enabled = true;
                btn_index3M.BackColor = Color.White;
                btn_index3M.FlatAppearance.BorderColor = Color.White;
            }

            if (dis > 8)
            {
                btn_index3P.Enabled = false;
                btn_index3P.BackColor = Color.Gray;
                btn_index3P.FlatAppearance.BorderColor = Color.Gray;
            }
            else if (teen < 9)
            {
                btn_index3P.Enabled = true;
                btn_index3P.BackColor = Color.White;
                btn_index3P.FlatAppearance.BorderColor = Color.White;
            }

            if (old == 0)
            {
                btn_index4M.Enabled = false;
                btn_index4M.BackColor = Color.Gray;
                btn_index4M.FlatAppearance.BorderColor = Color.Gray;
            }
            else if (old > 0)
            {
                btn_index4M.Enabled = true;
                btn_index4M.BackColor = Color.White;
                btn_index4M.FlatAppearance.BorderColor = Color.White;
            }

            if (old > 8)
            {
                btn_index4P.Enabled = false;
                btn_index4P.BackColor = Color.Gray;
                btn_index4P.FlatAppearance.BorderColor = Color.Gray;
            }
            else if (old < 9)
            {
                btn_index4P.Enabled = true;
                btn_index4P.BackColor = Color.White;
                btn_index4P.FlatAppearance.BorderColor = Color.White;
            }
        }

        private void btn_index1M_Click(object sender, EventArgs e)
        {
            adult--;
            lb_index1.Text = adult.ToString();

            btnEnabled();
        }

        private void btn_index1P_Click(object sender, EventArgs e)
        {
            adult++;
            lb_index1.Text = adult.ToString();

            btnEnabled();
        }

        private void btn_index2M_Click(object sender, EventArgs e)
        {
            teen--;
            lb_index2.Text = teen.ToString();

            btnEnabled();
        }

        private void btn_index2P_Click(object sender, EventArgs e)
        {
            teen++;
            lb_index2.Text = teen.ToString();

            btnEnabled();
        }

        private void btn_index3M_Click(object sender, EventArgs e)
        {
            dis--;
            lb_index3.Text = dis.ToString();

            btnEnabled();
        }

        private void btn_index3P_Click(object sender, EventArgs e)
        {
            dis++;
            lb_index3.Text = dis.ToString();

            btnEnabled();
        }

        private void btn_index4M_Click(object sender, EventArgs e)
        {
            old--;
            lb_index4.Text = old.ToString();

            btnEnabled();
        }

        private void btn_index4P_Click(object sender, EventArgs e)
        {
            old++;
            lb_index4.Text = old.ToString();

            btnEnabled();
        }

        #endregion
    }
}
