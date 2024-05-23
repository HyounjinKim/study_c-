using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex240220.database
{
    public class FileTBDataBase
    {
        //private static string cons = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=127.0.0.1)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)));User Id=hr;Password=1234;";
        private static string cons = "Data Source=127.0.0.1;User Id=hr;Password=1234;";

        private static OracleConnection con = null;

        public static OracleConnection connect()
        {
            if (con == null)
            {
                con = new OracleConnection(cons);
                con.Open();
            }
            else
            {
                con.Open();
            }
            return con;
        }

        public void insert(string text)
        {
            OracleConnection con = connect();
            string sql = "insert into filetb values (:value1)";
            using (OracleCommand command = new OracleCommand(sql,con))
            {
                command.Parameters.Add(":value1", text);
                int rowId = command.ExecuteNonQuery();
                Console.WriteLine($"{rowId} 행을 삽입했습니다.");
            }
            
            con.Close();
        }

        internal List<string> read()
        {
            List<string> list = new List<string>();

            OracleConnection con = connect();
            string sql = "select * from filetb";
            OracleCommand cmd = new OracleCommand(sql,con);
            OracleDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(rdr["str"].ToString());
            }
            

            con.Close();

            return list;
        }

        public void update(string org,string dst)
        {
            OracleConnection con = connect();

            string sql = $"update filetb set str = '{dst}' where str = '{org}'";
            OracleCommand cmd = new OracleCommand(sql, con);

            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void delete(string dst)
        {
            OracleConnection con = connect();

            string sql = $"delete from filetb where str = '{dst}'";
            OracleCommand cmd = new OracleCommand(sql, con);

            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
