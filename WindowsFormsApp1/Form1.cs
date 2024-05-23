using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    class AA
    {
        public string name { get; set; }
        public int Cnt { get; set; }

    }

    public partial class Form1 : Form
    {
        List<AA> AAList = new List<AA>();

        string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=127.0.0.1)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)));User Id=hr;Password=1234;";

        public Form1()
        {
            InitializeComponent();
            select();

            foreach (AA aa in AAList)
            {
                Console.WriteLine(aa);
            }
            MakeLabels();
        }

        public void MakeLabels()
        {
            int y = 10;

            foreach (AA aa in AAList)
            {
                Label label1 = new Label();
                label1.AutoSize = true;
                label1.Location = new Point(10, y);
                label1.Name = "label1";
                label1.Size = new Size(50, 20);
                label1.TabIndex = 0;
                label1.Text = aa.name;
                label1.Font = new Font("배달의민족", 20);
                Controls.Add(label1);

                Label label2 = new Label();
                label2.AutoSize = true;
                label2.Location = new Point(100, y);
                label2.Name = "label1";
                label2.Size = new Size(50, 20);
                label2.TabIndex = 0;
                label2.Text = aa.Cnt.ToString();
                label2.Font = new Font("배달의민족", 20);
                Controls.Add(label2);
                y += 40;
            }
        }

        public void select()
        {
            AAList.Clear();
            OracleConnection conn = new OracleConnection (connectionString);
            conn.Open ();
            string sql = "select * from AA";
            OracleCommand cmd = new OracleCommand (sql, conn);
            OracleDataReader rdr = cmd.ExecuteReader ();
            
            while (rdr.Read ())
            {
                AAList.Add(new AA() { name = rdr.GetString(0), Cnt = rdr.GetInt32(1) });
            }
            rdr.Close();
            conn.Close ();
        }
    }
}
