using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace codereview
{
    public partial class Form1 : Form
    {
        int i = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textfile = $@"D:\cs_work\codereview\txt\test{i}.txt";
            string num;
            i++;

            int aa = 0;
            int bb = 0;
            int cc = 0;
            int dd = 0;
            int ee = 0;
            int ff = 0;
            int gg = 0;
            int hh = 0;

            Random rand = new Random();

            aa = rand.Next(0, 10);
            bb = rand.Next(0, 10);
            cc = rand.Next(0, 10);
            dd = rand.Next(0, 10);
            ee = rand.Next(0, 10);
            ff = rand.Next(0, 10);
            gg = rand.Next(0, 10);
            hh = rand.Next(0, 10);
            while (true)
            {
                if (aa == 0)
                {
                    aa = rand.Next(0, 10);
                }
                break;
            }
            num = aa + "" + bb + cc + dd + ee + ff + gg + hh;
            MessageBox.Show(aa + "" + bb + cc + dd + ee + ff + gg + hh);

            // 파일이 존재하지 않으면
            if (!File.Exists(textfile))
            {
                using (StreamWriter sw = File.CreateText(textfile))
                {
                    sw.WriteLine("============================");
                    sw.WriteLine("∥\t\t\t\t\t\t\t   ∥");
                    sw.WriteLine($"∥\t\t예매번호 - {num}\t\t   ∥");
                    sw.WriteLine("∥\t\t\t\t\t\t\t   ∥");
                    sw.WriteLine("∥\t\t영화제목 - ㅇㅇㅇ\t\t   ∥");
                    sw.WriteLine("∥\t\t\t\t\t\t\t   ∥");
                    sw.WriteLine("∥\t\t시작시간 - 00:00:00\t\t   ∥");
                    sw.WriteLine("∥\t\t\t\t\t\t\t   ∥");
                    sw.WriteLine("∥\t\t종료시간 - 00:00:00\t\t   ∥");
                    sw.WriteLine("∥\t\t\t\t\t\t\t   ∥");
                    sw.WriteLine("∥\t\t상영관 - 0상영관\t\t\t   ∥");
                    sw.WriteLine("∥\t\t\t\t\t\t\t   ∥");
                    sw.WriteLine("∥\t\t좌석번호 - 00\t\t\t   ∥");
                    sw.WriteLine("∥\t\t\t\t\t\t\t   ∥");
                    sw.WriteLine("============================");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = $@"D:\cs_work\codereview\txt\test1.txt";
            string line;

            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string textfile = $@"D:\c#_work\codereview\txt\ccc.txt";

            if (!File.Exists(textfile))
            {
                using (StreamWriter sw = File.CreateText(textfile))
                {
                    for (int i = 1; i < 38; i++)
                    {
                        for (int j = 0; j < 15; j++)
                        {
                            sw.WriteLine(i+"관");
                        }
                    }
                    
                }
            }
        }
    }
}
