using Oracle.ManagedDataAccess.Client;
using System;
using System.Reflection;

namespace miniproject
{
    public class DBsql
    {
        string dbconnect = "data source = 127.0.0.1; user id = khj; password = 1234;";
        public static List<int> ints = new List<int>();
        
        public void test()
        {
            ints = timetableIndex();
        }
        
        public void dbLoad()
        {
            OracleConnection con = new OracleConnection(dbconnect);
            con.Open();

            con.Close();
        }

        public List<int> timetableIndex() 
        {
            List<int> list = new List<int>();

            OracleConnection con = new OracleConnection(dbconnect);
            con.Open();
            string sql = "select rownum, A.* from ( select * from 시간표 order by 시작시간 ) A where rownum < 4";
            OracleCommand cmd = new OracleCommand(sql, con);
            OracleDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                list.Add(int.Parse(rdr.GetString(1)));
            }

            return list;
        }

        public void movieSelect(Label lb1,Label lb2,Label lb3,int index)
        {
            OracleConnection con = new OracleConnection(dbconnect);
            con.Open();
            string sql = $"select a.영화번호,영화명,to_char(시작시간,'AM HH:MI'),줄거리 from 영화 a\r\njoin 시간표 b\r\non a.영화번호 = b.영화번호 where 시간표 = {index}";
            OracleCommand cmd = new OracleCommand(sql, con);
            OracleDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                lb1.Text = rdr.GetString(1);
                lb2.Text = rdr.GetString(2);
                lb3.Text = rdr.GetString(3);
            }

            con.Close();
            rdr.Close();

        }

        public List<string> seatInfo(int index, Label lb1,Label lb2)
        {
            List<string> list = new List<string>();

;           OracleConnection con = new OracleConnection(dbconnect);
            con.Open();
            string sql = $"select 상영관,(select count(좌석) from 좌석 where 시간표 = {index} and 예매확인 = 'n') as 좌석수 from 좌석 where 시간표 = {index} and rownum < 2";
            OracleCommand cmd = new OracleCommand( sql, con);
            OracleDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                lb1.Text = rdr.GetString(0);
                lb2.Text = "좌석수" + rdr.GetString(1);
                list.Add(rdr.GetString(0));
                list.Add(rdr.GetString(1));
            }

            con.Close();
            rdr.Close();

            return list;
        }

        public List<int> seatSold(int ttindex,string theater_num)
        {
            List<int> list = new List<int>();

            OracleConnection con = new OracleConnection(dbconnect);
            con.Open();
            string sql = $"select 상영관,좌석,예매확인 from 좌석 where 시간표 = {ttindex} and 예매확인 = 'y' and 상영관 = '{theater_num}'";
            OracleCommand cmd = new OracleCommand(sql, con);
            OracleDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                list.Add(int.Parse(rdr.GetString(1)));
            }

            return list;
        }

        public int price(int adult,int teen, int dis,int old)
        {
            int price = 0;
            List<int> list = new List<int>();

            OracleConnection con = new OracleConnection(dbconnect);
            string sql = "select * from price";
            con.Open();
            OracleCommand cmd = new OracleCommand(sql,con);
            OracleDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                list.Add(rdr.GetInt32(2));
            }
            price = (list[0] * adult) + (list[1] * teen) + (list[2] * dis) + (list[3] * old);

            return price;
        }

        public void ticketingInfo(int index,Label lb1,Label lb2,Label lb3)
        {
            OracleConnection con = new OracleConnection(dbconnect);
            con.Open();
            string sql = $"select 영화명,to_char(시작시간,'am hh:mi'),to_char(종료시간,'am hh:mi'),b.상영관 from 시간표 a\r\njoin 영화 b on a.영화번호 = b.영화번호 where 시간표 = {index}";
            OracleCommand cmd = new OracleCommand(sql,con);
            OracleDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lb1.Text = rdr.GetString(0);
                lb2.Text = rdr.GetString(1) + " ~ " + rdr.GetString(2);
                lb3.Text = rdr.GetString(3);
            }


        }
    }
}
