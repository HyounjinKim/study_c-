using shop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop
{
    public partial class AllFood : UserControl
    {
        ShopDB shopDB = new ShopDB();
        List<string> foodName = new List<string>();
        List<int> price = new List<int>();

        int x = 10;
        int y = 45;
        int i = 0;
        bool payPanel = false;
        int foodCount = 0;
        int locaY = 0;
        public AllFood()
        {
            InitializeComponent();
            foodList();
        }

        public void foodList()
        {
            DataTable dataTable = shopDB.foodSelect();
            foreach (DataRow dr in dataTable.Rows)
            {

                int idx = int.Parse(dr["idx"].ToString());
                string foodName = dr["상품명"].ToString();
                int price = int.Parse(dr["가격"].ToString());

                if (i != 0 && i % 3 == 0)
                {
                    x = 10;
                    y += 155;
                    makePanel(idx, foodName, price);
                    i++;
                }
                else
                {
                    makePanel(idx, foodName, price);
                    i++;
                }

            }
        }

        public void makePanel(int idx, string foodName, int price)
        {
            Panel panel1 = new Panel();
            PictureBox pb_foodIamage = new PictureBox();
            Label lb_price = new Label();
            Label lb_foodName = new Label();
            // 
            // panel1
            // 
            panel1.Controls.Add(lb_price);
            panel1.Controls.Add(lb_foodName);
            panel1.Controls.Add(pb_foodIamage);
            panel1.BackColor = Color.White;
            panel1.Location = new Point(x, y);
            panel1.Name = "panel1";
            panel1.Size = new Size(110, 140);
            panel1.TabIndex = 0;
            panel1.Tag = idx;
            panel1.Click += selectFood_Click;

            x += 125;

            pb_foodIamage.Dock = DockStyle.Top;
            pb_foodIamage.Location = new Point(0, 0);
            pb_foodIamage.Name = "pb_foodIamage";
            pb_foodIamage.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_foodIamage.Size = new Size(146, 128);
            pb_foodIamage.TabIndex = 0;
            pb_foodIamage.TabStop = false;
            pb_foodIamage.Tag = idx;
            pb_foodIamage.Click += selectFood_Click;
            switch (idx)
            {
                case 1:
                    pb_foodIamage.Image = Resources.콜라;
                    break;
                case 2:
                    pb_foodIamage.Image = Resources.사이다;
                    break;
                case 3:
                    pb_foodIamage.Image = Resources.커피;
                    break;
                case 4:
                    pb_foodIamage.Image = Resources.물;
                    break;
                case 5:
                    pb_foodIamage.Image = Resources.팝콘;
                    break;
                case 6:
                    pb_foodIamage.Image = Resources.핫도그;
                    break;
                case 7:
                    pb_foodIamage.Image = Resources.나초;
                    break;
                case 8:
                    pb_foodIamage.Image = Resources.버터오징어;
                    break;
                case 9:
                    pb_foodIamage.Image = Resources.레모네이드;
                    break;
                case 10:
                    pb_foodIamage.Image = Resources.복숭아에이드;
                    break;
                case 11:
                    pb_foodIamage.Image = Resources.캬라멜_팝콘;
                    break;
                case 12:
                    pb_foodIamage.Image = Resources.프레첼;
                    break;
            }

            lb_price.AutoSize = false;
            lb_price.Font = new Font("굴림", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
            lb_price.Location = new Point(10, 160);
            lb_price.TextAlign = ContentAlignment.MiddleCenter;
            lb_price.Name = "lb_price";
            lb_price.Size = new Size(110, 20);
            lb_price.TabIndex = 2;
            lb_price.Text = price + "원";
            lb_price.Tag = idx;
            lb_price.Dock = DockStyle.Bottom;
            lb_price.Click += selectFood_Click;

            lb_foodName.AutoSize = false;
            lb_foodName.Font = new Font("굴림", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
            lb_foodName.Location = new Point(10, 130);
            lb_foodName.TextAlign = ContentAlignment.MiddleCenter;
            lb_foodName.Name = "lb_foodName";
            lb_foodName.Size = new Size(110, 20);
            lb_foodName.TabIndex = 1;
            lb_foodName.Text = foodName;
            lb_foodName.Tag = idx;
            lb_foodName.Dock = DockStyle.Bottom;
            lb_foodName.Click += selectFood_Click;

            pn.Controls.Add(panel1);
        }

        private void selectFood_Click(object sender, EventArgs e)
        {
            DataTable dataTable;

            Panel panel = sender as Panel;
            PictureBox pictureBox = sender as PictureBox;
            Label label = sender as Label;


            if (panel != null)
            {
                dataTable = shopDB.foodSelect(int.Parse(panel.Tag.ToString()));
                foreach (DataRow row in dataTable.Rows)
                {
                    foodName.Add(row["상품명"].ToString());          
                    price.Add(int.Parse(row["가격"].ToString()));
                }
                Console.WriteLine(foodName.Count);
                for (int i = 0; i < foodName.Count;i++)
                {
                    payList(foodName[i], price[i]);
                }
                
            }
            else if (pictureBox != null)
            {
                //dataTable = shopDB.foodSelect(int.Parse(panel.Tag.ToString()));

            }
            else if (label != null)
            {
                //dataTable = shopDB.foodSelect(int.Parse(panel.Tag.ToString()));

            }
        }

        public void payList(string foodName, int price)
        {
            Panel panel = new Panel();
            

            if (payPanel == false)
            {
                Button button = new Button();
                Button buttonM = new Button();
                Button buttonP = new Button();
                Label lb_price = new Label();
                Label lb_foodName = new Label();
                Label lb_count = new Label();

                panel.BackColor = Color.White;
                panel.Location = new Point(10, 355);
                panel.Name = "panel1";
                panel.Size = new Size(360, 135);
                panel.TabIndex = 0;

                button.Font = new Font("굴림", 15F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(129)));
                button.Location = new Point(265, 30);
                button.Name = "button";
                button.Size = new Size(85, 75);
                button.TabIndex = 1;
                button.Text = "결제";
                button.UseVisualStyleBackColor = true;

                lb_foodName.AutoSize = true;
                lb_foodName.Font = new Font("굴림", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
                lb_foodName.Location = new Point(10, 10 + locaY);
                lb_foodName.TextAlign = ContentAlignment.MiddleCenter;
                lb_foodName.Name = "lb_foodName";
                lb_foodName.Size = new Size(70, 20);
                lb_foodName.TabIndex = 1;
                lb_foodName.Text = foodName;
                lb_foodName.Click += selectFood_Click;

                lb_price.AutoSize = true;
                lb_price.Font = new Font("굴림", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
                lb_price.Location = new Point(110, 10 + locaY);
                lb_price.TextAlign = ContentAlignment.MiddleCenter;
                lb_price.Name = "lb_price";
                lb_price.Size = new Size(70, 20);
                lb_price.TabIndex = 2;
                lb_price.Text = price + "원";
                lb_price.Click += selectFood_Click;

                buttonM.Font = new Font("굴림", 13F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(129)));
                buttonM.Location = new Point(170, 5 + locaY);
                buttonM.Name = "button";
                buttonM.Size = new Size(25, 25);
                buttonM.TabIndex = 1;
                buttonM.Text = "-";
                buttonM.UseVisualStyleBackColor = true;

                lb_count.AutoSize = true;
                lb_count.Font = new Font("굴림", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
                lb_count.Location = new Point(205, 10 + locaY);
                lb_count.TextAlign = ContentAlignment.MiddleCenter;
                lb_count.Name = "lb_count";
                lb_count.Size = new Size(30, 20);
                lb_count.TabIndex = 2;
                lb_count.Text = foodCount.ToString();
                lb_count.Click += selectFood_Click;

                buttonP.Font = new Font("굴림", 13F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(129)));
                buttonP.Location = new Point(230, 5 + locaY);
                buttonP.Name = "button";
                buttonP.Size = new Size(25, 25);
                buttonP.TabIndex = 1;
                buttonP.Text = "+";
                buttonP.UseVisualStyleBackColor = true;

                panel.Controls.Add(lb_foodName);
                panel.Controls.Add(lb_price);
                panel.Controls.Add(lb_count);
                panel.Controls.Add(buttonM);
                panel.Controls.Add(buttonP);
                panel.Controls.Add(button);
                Controls.Add(panel);

                locaY += 10;
                payPanel = true;
                Console.WriteLine(locaY);
            }
            else
            {
                Button buttonM = new Button();
                Button buttonP = new Button();
                Label lb_price = new Label();
                Label lb_foodName = new Label();
                Label lb_count = new Label();

                lb_foodName.AutoSize = true;
                lb_foodName.Font = new Font("굴림", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
                lb_foodName.Location = new Point(10, 10 + locaY);
                lb_foodName.TextAlign = ContentAlignment.MiddleCenter;
                lb_foodName.Name = "lb_foodName";
                lb_foodName.Size = new Size(70, 20);
                lb_foodName.TabIndex = 1;
                lb_foodName.Text = foodName;
                lb_foodName.Click += selectFood_Click;

                lb_price.AutoSize = true;
                lb_price.Font = new Font("굴림", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
                lb_price.Location = new Point(110, 10 + locaY);
                lb_price.TextAlign = ContentAlignment.MiddleCenter;
                lb_price.Name = "lb_price";
                lb_price.Size = new Size(70, 20);
                lb_price.TabIndex = 2;
                lb_price.Text = price + "원";
                lb_price.Click += selectFood_Click;

                buttonM.Font = new Font("굴림", 13F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(129)));
                buttonM.Location = new Point(170, 5 + locaY);
                buttonM.Name = "button";
                buttonM.Size = new Size(25, 25);
                buttonM.TabIndex = 1;
                buttonM.Text = "-";
                buttonM.UseVisualStyleBackColor = true;

                lb_count.AutoSize = true;
                lb_count.Font = new Font("굴림", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
                lb_count.Location = new Point(205, 10 + locaY);
                lb_count.TextAlign = ContentAlignment.MiddleCenter;
                lb_count.Name = "lb_count";
                lb_count.Size = new Size(30, 20);
                lb_count.TabIndex = 2;
                lb_count.Text = foodCount.ToString();
                lb_count.Click += selectFood_Click;

                buttonP.Font = new Font("굴림", 13F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(129)));
                buttonP.Location = new Point(230, 5 + locaY);
                buttonP.Name = "button";
                buttonP.Size = new Size(25, 25);
                buttonP.TabIndex = 1;
                buttonP.Text = "+";
                buttonP.UseVisualStyleBackColor = true;
                locaY += 20;

                panel.Controls.Add(lb_foodName);
                panel.Controls.Add(lb_price);
                panel.Controls.Add(lb_count);
                panel.Controls.Add(buttonM);
                panel.Controls.Add(buttonP);
                Controls.Add(panel);
            }
        }
    }
}
