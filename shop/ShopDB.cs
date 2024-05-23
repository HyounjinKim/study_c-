using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
    public class ShopDB
    {
        string dbcon = "data source = localhost;user id = khj;password = 1234";

        public DataTable foodSelect(int idx = 0)
        {
            string sql = "";
            OracleCommand cmd = null;
            OracleConnection con = new OracleConnection(dbcon);
            con.Open();
            if (idx == 0)
            {
                sql = "select * from 음식 order by 분류 desc,idx";
                cmd = new OracleCommand(sql, con);
            }
            else
            {
                sql = "select 상품명,가격 from 음식 where idx = :idx";
                cmd = new OracleCommand(sql, con);
                cmd.Parameters.Add("idx",idx);
            }
            
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.SelectCommand = cmd;
            da.Fill(ds);
            
            con.Close();
            return ds.Tables[0];
        }
    }
}
