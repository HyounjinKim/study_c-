using ex240220.database;
using ex240220.file;
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

namespace ex240220
{
    
    public partial class Form1 : Form
    {
        private static string cons = "Data Source=127.0.0.1;User Id=hr;Password=1234;";
        FileControl fc = new FileControl();
        FileTBDataBase ftdb = new FileTBDataBase();

        private string selectedString = "";

        //List<string> list = new List<string>();

        public Form1()
        {
            InitializeComponent();

            //List<string> list = fc.read();
            List<string> list = ftdb.read();
            listBox1.DataSource = null;
            listBox1.DataSource = list;
        }

        private void 불러오기(object sender, EventArgs e)
        {
           //List<string> list = fc.read();
           List<string> list = ftdb.read();
            listBox1.DataSource = null;
            listBox1.DataSource = list;
        }

        private void 파일쓰기(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("글자를 입력하세요.");
                return;
            }
            //list.Add(textBox1.Text);
            //fc.write(textBox1.Text,list);

            ftdb.insert(textBox1.Text);
            List<string> list =  ftdb.read();

            listBox1.DataSource = null;
            listBox1.DataSource = list;
            textBox1.Text = "";
        }

        private void 수정하기(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("글자를 입력하세요.");
                return;
            }

            ftdb.update(selectedString,textBox1.Text);
            
            button1.PerformClick();
            textBox1.Text = "";
        }

        private void 삭제하기(object sender, EventArgs e)
        {
            ftdb.delete(textBox1.Text);
            button1.PerformClick();
            textBox1.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(listBox1.SelectedIndex);
            Console.WriteLine(listBox1.SelectedItem);

            if (listBox1.SelectedItem != null)
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
                selectedString = listBox1.SelectedItem.ToString();
            } 
        }

    }
}
