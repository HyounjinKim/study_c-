using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace pr240310
{
    public class Database
    {
        string dbcon = "data source = 127.0.0.1; user id = khj; password = 1234;";

        // 검색 결과가 있으면 true 없으면 false 반환
        public bool selectTimeTable(DateTime dateTime)
        {
            OracleConnection con = new OracleConnection(dbcon);
            con.Open();
            string sql = "select * from 시간표 where 시작시간 > :dateTime ";
            OracleCommand cmd = new OracleCommand(sql, con);
            cmd.Parameters.Add(":dateTime", dateTime);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                con.Close();
                return true;
            }

            con.Close();
            return false;
        }


        // 전체 시간표 조회
        public DataTable TimeTable()
        {
            OracleConnection con = new OracleConnection(dbcon);
            con.Open();
            string sql = "select 시간표,상영관,to_char(시작시간,'mm-dd hh24:mi:ss') as 시작시간," +
                "to_char(종료시간,'mm-dd hh24:mi:ss')as 종료시간,영화번호 from 시간표 order by 시작시간";
            DataSet ds = new DataSet();
            OracleDataAdapter adapter = new OracleDataAdapter();
            OracleCommand cmd = new OracleCommand(sql, con);

            adapter.SelectCommand = cmd;
            adapter.Fill(ds);

            con.Close();
            return ds.Tables[0];
        }

        // 상영관 좌석 확인
        public DataTable theaterTable()
        {
            OracleConnection con = new OracleConnection(dbcon);
            con.Open();
            string sql = "select * from 상영관 order by 시간표";
            DataSet ds = new DataSet();
            OracleDataAdapter adapter = new OracleDataAdapter();
            OracleCommand cmd = new OracleCommand(sql, con);

            adapter.SelectCommand = cmd;
            adapter.Fill(ds);

            con.Close();
            return ds.Tables[0];
        }

        // 랜덤한 순서로 영화번호 리턴
        public List<int> movieNum()
        {
            List<int> list = new List<int>();

            OracleConnection con = new OracleConnection(dbcon);
            con.Open();
            string sql = "select 영화번호 from 영화 order by dbms_random.value";
            OracleCommand cmd = new OracleCommand(sql, con);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(int.Parse(dr.GetString(0)));
            }

            con.Close();
            return list;
        }

        // 검색결과에 맞는 상영시간 리턴
        public int moviePlayTime(int movieNum)
        {
            int num = 0;

            OracleConnection con = new OracleConnection(dbcon);
            con.Open();
            string sql = "select 러닝타임 from 영화 where 영화번호 = :movieNum";
            OracleCommand cmd = new OracleCommand(sql, con);
            cmd.Parameters.Add(":movieNum",movieNum);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                num = int.Parse(dr.GetString(0).Trim('분'));
            }

            con.Close();
            return num;
        }

        // 받은 값으로 시간표 만듬
        public void insertTimeTable(string theater,DateTime startTime,DateTime endTime,int movieNum)
        {
            OracleConnection con = new OracleConnection(dbcon);
            con.Open();
            string sql = "insert into 시간표 values (ttindex.nextval,:theater,:startTime,:endTime,:movieNum)";
            OracleCommand cmd = new OracleCommand(sql, con);

            cmd.Parameters.Add(":theater", theater);
            cmd.Parameters.Add(":startTime", startTime);
            cmd.Parameters.Add(":endTime", endTime);
            cmd.Parameters.Add(":movieNum", movieNum);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        // 좌석을 만들기위해 방금 만들어진 시간표 정보를 가지고옴
        public DataTable makeSeatInfo(int count)
        {
            OracleConnection con = new OracleConnection(dbcon);
            con.Open();
            string sql = "select 상영관,영화번호,시간표 from (select * from 시간표 order by 시간표 desc) where rownum < :count";
            DataSet ds = new DataSet();
            OracleDataAdapter adapter = new OracleDataAdapter();
            OracleCommand cmd = new OracleCommand(sql, con);
            cmd.Parameters.Add(":count",count);

            adapter.SelectCommand = cmd;
            adapter.Fill(ds);

            con.Close();
            return ds.Tables[0];
        }

        // 좌석 생성
        public void insertSeat(string theater,int movieNum,int timeTableIndex,int seatNum)
        {
            OracleConnection con = new OracleConnection(dbcon);
            con.Open();
            string sql = "insert into 상영관 (상영관,영화번호,좌석,시간표,idx) values (:theater,:movieNum,:seat,:timeTableIndex,seatidx.nextval)";
            OracleCommand cmd = new OracleCommand(sql, con);

            cmd.Parameters.Add(":theater", theater);
            cmd.Parameters.Add(":movieNum", movieNum);
            cmd.Parameters.Add(":seat", seatNum);
            cmd.Parameters.Add(":timeTableIndex", timeTableIndex);

            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}