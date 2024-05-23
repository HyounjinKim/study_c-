using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=127.0.0.1)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)));User Id=HR;Password=1234;";
        string strConnection = "DATA SOURCE=127.0.0.1; User Id=HR; Password=1234";

        OracleConnection conn;
        OracleCommand cmd;
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();

            // 주석 컨트롤+k+c
            // mbox tab tab
            //MessageBox.Show(strConnection);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new OracleConnection(strConnection);
                OracleDataAdapter adapter = new OracleDataAdapter();
                //cmd = new OracleCommand();
                //cmd.Connection = conn;

                conn.Open(); // DB 열기

                string sql = "select * from emp";

                adapter.SelectCommand = new OracleCommand(sql, conn);
                adapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

                conn.Close(); // DB 닫기
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            //MessageBox.Show("Test" + strConnection);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
