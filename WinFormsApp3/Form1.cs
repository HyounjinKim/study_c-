using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            /*
             * OracleDataAdapter -> select Close
             * OracleDataReader -> Close
             */
            try
            {
                OracleConnection con = new OracleConnection("data source=127.0.0.1; user id=hr;password=1234");
                //OracleConnection conn = new OracleConnection("DATA SOURCE=127.0.0.1; User Id=HR; Password=1234");
                con.Open();

                OracleCommand cmd = new OracleCommand("select * from 학생", con);
                OracleDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    listBox1.Items.Add(reader.GetString(0) + "\t" + reader.GetString(1) + "\t" + reader.GetString(2) + "\t" + reader.GetString(3) + "\t" + reader.GetString(4));
                    //MessageBox.Show(reader["학번"].ToString());
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("문자열입니다.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, "문자열 추가");
        }
    }
}
