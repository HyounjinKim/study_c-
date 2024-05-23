using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace pr240310
{
    public partial class CreateTimeTable : Form
    {
        Database db = new Database();

        public CreateTimeTable()
        {
            InitializeComponent();
            timeTable();
        }


        // 시간표 조회
        public void timeTable()
        {
            DateTime dateTime = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 9, 20, 0);
            DataTable dt = db.TimeTable(dateTime);

            dataGridView1.DataSource = dt;

        }

        public void theaterTable()
        {
            DataTable dt = db.theaterTable();

            dataGridView1.DataSource = dt;

        }

        // 시간표 테이블 검색
        private void button2_Click(object sender, EventArgs e)
        {
            timeTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            theaterTable();
        }

        // 같은 날에 만들어져 있는 시간표가 있는지 확인 후 시간표 생성
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month,
                                             dateTimePicker1.Value.Day, 9, 20, 0);

            // dateTime과 맞는 시간표가 있는지 확인
            if (db.selectTimeTable(dateTime) == true)
            {
                MessageBox.Show("시간표가 이미 만들어져 있거나 지난 날의 시간표는 만들 수 없습니다.");
            }

            else
            {
                makeTimeTable();
            }
        }

        // 시간표 생성 함수
        public void makeTimeTable()
        {
            List<int> playTime = new List<int>();
            List<int> movieNum = new List<int>();
            List<int> timeTable = new List<int>();
            List<int> movieNums = new List<int>();

            // 랜덤한 순서의 영화번호 받음
            movieNum = db.movieNum();

            for (int i = 0; i < movieNum.Count; i++)
            {
                // 영화번호로 상영시간을 받아옴
                playTime.Add(db.moviePlayTime(movieNum[i]));
            }

            // 상영관마다 겹치는 영화를 줄이기 위해 순서를 바꿔줌
            for (int i = 0; i < playTime.Count; i++)
            {
                if (i != 0)
                {
                    int playTimeTemp = playTime[0];
                    int movieNumTemp = movieNum[0];
                    playTime.RemoveAt(0);
                    movieNum.RemoveAt(0);
                    playTime.Add(playTimeTemp);
                    movieNum.Add(movieNumTemp);
                }
                for (int j = 0; j < playTime.Count; j++)
                {
                    timeTable.Add(playTime[j]);
                    movieNums.Add(movieNum[j]);
                }
            }

            // 각 상영관마다 오픈시간,시작시간,종료시간을 따로 지정
            DateTime openTime1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 9, 20, 0);
            DateTime openTime2 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 9, 20, 0);
            DateTime openTime3 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 9, 20, 0);
            DateTime openTime4 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 9, 20, 0);
            DateTime openTime5 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 9, 20, 0);
            List<DateTime> startTime1 = new List<DateTime>();
            List<DateTime> startTime2 = new List<DateTime>();
            List<DateTime> startTime3 = new List<DateTime>();
            List<DateTime> startTime4 = new List<DateTime>();
            List<DateTime> startTime5 = new List<DateTime>();
            List<DateTime> endTime1 = new List<DateTime>();
            List<DateTime> endTime2 = new List<DateTime>();
            List<DateTime> endTime3 = new List<DateTime>();
            List<DateTime> endTime4 = new List<DateTime>();
            List<DateTime> endTime5 = new List<DateTime>();

            // 각 상영관의 시작시간,종료시간을 저장
            List<DateTime> allStartTime = new List<DateTime>();
            List<DateTime> allendTime = new List<DateTime>();

            TimeTableInfo timeTableInfo = new TimeTableInfo();

            // 시간표 정보를 담기위한 클래스리스트
            List<TimeTableInfo> timeTableList = new List<TimeTableInfo>();

            // 들어간 값이 몇개인지 저장하는 변수
            int movieNumCount = 0;

            // 각 시간표의 시작시간,종료시간을 계산하는 코드
            for (int i = 0; i < timeTable.Count; i++)
            {
                // i%5 값이 상영관에 해당
                switch (i % 5)
                {
                    case 0:
                        if (openTime1 < new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 23, 30, 0))
                        {
                            startTime1.Add(openTime1);
                            openTime1 = openTime1.AddMinutes(timeTable[i]);
                            endTime1.Add(openTime1);
                            openTime1 = openTime1.AddMinutes(30);

                            movieNumCount++;
                        }
                        break;
                    case 1:
                        if (openTime2 < new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 23, 30, 0))
                        {
                            startTime2.Add(openTime2);
                            openTime2 = openTime2.AddMinutes(timeTable[i]);
                            endTime2.Add(openTime2);
                            openTime2 = openTime2.AddMinutes(30);
                            movieNumCount++;
                        }
                        break;
                    case 2:
                        if (openTime3 < new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 23, 30, 0))
                        {
                            startTime3.Add(openTime3);
                            openTime3 = openTime3.AddMinutes(timeTable[i]);
                            endTime3.Add(openTime3);
                            openTime3 = openTime3.AddMinutes(30);
                            movieNumCount++;
                        }
                        break;
                    case 3:
                        if (openTime4 < new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 23, 30, 0))
                        {
                            startTime4.Add(openTime4);
                            openTime4 = openTime4.AddMinutes(timeTable[i]);
                            endTime4.Add(openTime4);
                            openTime4 = openTime4.AddMinutes(30);
                            movieNumCount++;
                        }
                        break;
                    case 4:
                        if (openTime3 < new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 23, 30, 0))
                        {
                            startTime5.Add(openTime5);
                            openTime5 = openTime5.AddMinutes(timeTable[i]);
                            endTime5.Add(openTime5);
                            openTime5 = openTime5.AddMinutes(30);
                            movieNumCount++;
                        }
                        break;
                }
            }

            // 각 상영관마다 저장한 정보를 합치는 코드
            for (int i = 0; i < startTime1.Count(); i++)
            {
                if (i < startTime1.Count)
                {
                    allStartTime.Add(startTime1[i]);
                    allendTime.Add(endTime1[i]);
                }
                if (i < startTime2.Count)
                {
                    allStartTime.Add(startTime2[i]);
                    allendTime.Add(endTime2[i]);
                }
                if (i < startTime3.Count)
                {
                    allStartTime.Add(startTime3[i]);
                    allendTime.Add(endTime3[i]);
                }
                if (i < startTime4.Count)
                {
                    allStartTime.Add(startTime4[i]);
                    allendTime.Add(endTime4[i]);
                }
                if (i < startTime5.Count)
                {
                    allStartTime.Add(startTime5[i]);
                    allendTime.Add(endTime5[i]);
                }

            }

            // 각 상영관마다 들어간 정보들을 클래스리스트에 저장 
            for (int i = 0; i < movieNumCount; i++)
            {
                switch (i % 5)
                {
                    case 0:
                        timeTableInfo = new TimeTableInfo()
                        {
                            theater = "1관",
                            startTime = allStartTime[i],
                            endTime = allendTime[i],
                            movieNum = movieNums[i]
                        };
                        timeTableList.Add(timeTableInfo);
                        break;
                    case 1:
                        timeTableInfo = new TimeTableInfo()
                        {
                            theater = "2관",
                            startTime = allStartTime[i],
                            endTime = allendTime[i],
                            movieNum = movieNums[i]
                        };
                        timeTableList.Add(timeTableInfo);
                        break;
                    case 2:
                        timeTableInfo = new TimeTableInfo()
                        {
                            theater = "3관",
                            startTime = allStartTime[i],
                            endTime = allendTime[i],
                            movieNum = movieNums[i]
                        };
                        timeTableList.Add(timeTableInfo);
                        break;
                    case 3:
                        timeTableInfo = new TimeTableInfo()
                        {
                            theater = "4관",
                            startTime = allStartTime[i],
                            endTime = allendTime[i],
                            movieNum = movieNums[i]
                        };
                        timeTableList.Add(timeTableInfo);
                        break;
                    case 4:
                        timeTableInfo = new TimeTableInfo()
                        {
                            theater = "5관",
                            startTime = allStartTime[i],
                            endTime = allendTime[i],
                            movieNum = movieNums[i]
                        };
                        timeTableList.Add(timeTableInfo);
                        break;
                }
            }

            // 클래스리스트에 들어간 정보들을 DB에 저장
            for (int i = 0; i < timeTableList.Count; i++)
            {
                /* 상영관,시작시간,종료시간,영화번호를 매개변수로 
                 * 시간표 테이블 인설트 구문 실행
                */
                db.insertTimeTable(timeTableList[i].theater, 
                    timeTableList[i].startTime, 
                    timeTableList[i].endTime, 
                    timeTableList[i].movieNum);
            }

            insertSeat(timeTableList.Count);

            // 클리어를 안하면 값이 남아 있음
            timeTableList.Clear();
        }

        // 만들어진 시간표의 좌석정보 만드는 함수
        public void insertSeat(int count)
        {
            DataTable dataTable = db.makeSeatInfo(count + 1);
            List<string> theater = new List<string>();
            List<int> movieNum = new List<int>();
            List<int> timeTableIndex = new List<int>();

            foreach (DataRow row in dataTable.Rows)
            {
                theater.Add(row["상영관"].ToString());
                movieNum.Add(int.Parse(row["영화번호"].ToString()));
                timeTableIndex.Add(int.Parse(row["시간표"].ToString()));
            }

            // 좌석 생성 코드
            for (int i = 0; i < theater.Count; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    db.insertSeat(theater[i], movieNum[i], timeTableIndex[i], j + 1);
                }

            }
            MessageBox.Show("시간표 추가 완료");
            timeTable();
        }
    }
}