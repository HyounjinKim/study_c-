namespace miniproject.ticketing
{
    partial class Ticketing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_allMovie = new Button();
            btn_goHome = new Button();
            panel1 = new Panel();
            lb_summa1 = new Label();
            lb_sTime1 = new Label();
            lb_title1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lb_summa2 = new Label();
            lb_sTime2 = new Label();
            lb_title2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            lb_summa3 = new Label();
            lb_sTime3 = new Label();
            lb_title3 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(95, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 46);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btn_allMovie
            // 
            btn_allMovie.Font = new Font("맑은 고딕", 25F);
            btn_allMovie.Location = new Point(45, 450);
            btn_allMovie.Name = "btn_allMovie";
            btn_allMovie.Size = new Size(495, 195);
            btn_allMovie.TabIndex = 1;
            btn_allMovie.Text = "전체영화보기";
            btn_allMovie.UseVisualStyleBackColor = true;
            btn_allMovie.Click += btn_allMovie_Click;
            // 
            // btn_goHome
            // 
            btn_goHome.Font = new Font("맑은 고딕", 25F);
            btn_goHome.Location = new Point(167, 696);
            btn_goHome.Name = "btn_goHome";
            btn_goHome.Size = new Size(242, 113);
            btn_goHome.TabIndex = 9;
            btn_goHome.Text = "메인 화면";
            btn_goHome.UseVisualStyleBackColor = true;
            btn_goHome.Click += btn_goHome_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(lb_summa1);
            panel1.Controls.Add(lb_sTime1);
            panel1.Controls.Add(lb_title1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 300);
            panel1.TabIndex = 10;
            panel1.MouseClick += panel1_MouseClick;
            // 
            // lb_summa1
            // 
            lb_summa1.AutoSize = true;
            lb_summa1.ForeColor = Color.White;
            lb_summa1.Location = new Point(17, 265);
            lb_summa1.Name = "lb_summa1";
            lb_summa1.Size = new Size(50, 20);
            lb_summa1.TabIndex = 3;
            lb_summa1.Text = "label4";
            lb_summa1.MouseClick += panel1_MouseClick;
            // 
            // lb_sTime1
            // 
            lb_sTime1.AutoSize = true;
            lb_sTime1.ForeColor = Color.White;
            lb_sTime1.Location = new Point(17, 234);
            lb_sTime1.Name = "lb_sTime1";
            lb_sTime1.Size = new Size(50, 20);
            lb_sTime1.TabIndex = 2;
            lb_sTime1.Text = "label3";
            lb_sTime1.MouseClick += panel1_MouseClick;
            // 
            // lb_title1
            // 
            lb_title1.AutoSize = true;
            lb_title1.ForeColor = Color.White;
            lb_title1.Location = new Point(17, 204);
            lb_title1.Name = "lb_title1";
            lb_title1.Size = new Size(50, 20);
            lb_title1.TabIndex = 1;
            lb_title1.Text = "label2";
            lb_title1.MouseClick += panel1_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(17, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseClick += panel1_MouseClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(lb_summa2);
            panel2.Controls.Add(lb_sTime2);
            panel2.Controls.Add(lb_title2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(202, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(178, 300);
            panel2.TabIndex = 11;
            panel2.MouseClick += panel2_MouseClick;
            // 
            // lb_summa2
            // 
            lb_summa2.AutoSize = true;
            lb_summa2.ForeColor = Color.White;
            lb_summa2.Location = new Point(17, 265);
            lb_summa2.Name = "lb_summa2";
            lb_summa2.Size = new Size(50, 20);
            lb_summa2.TabIndex = 3;
            lb_summa2.Text = "label5";
            lb_summa2.MouseClick += panel2_MouseClick;
            // 
            // lb_sTime2
            // 
            lb_sTime2.AutoSize = true;
            lb_sTime2.ForeColor = Color.White;
            lb_sTime2.Location = new Point(17, 234);
            lb_sTime2.Name = "lb_sTime2";
            lb_sTime2.Size = new Size(50, 20);
            lb_sTime2.TabIndex = 2;
            lb_sTime2.Text = "label6";
            lb_sTime2.MouseClick += panel2_MouseClick;
            // 
            // lb_title2
            // 
            lb_title2.AutoSize = true;
            lb_title2.ForeColor = Color.White;
            lb_title2.Location = new Point(17, 204);
            lb_title2.Name = "lb_title2";
            lb_title2.Size = new Size(50, 20);
            lb_title2.TabIndex = 1;
            lb_title2.Text = "label7";
            lb_title2.MouseClick += panel2_MouseClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(17, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(140, 172);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.MouseClick += panel2_MouseClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(128, 128, 255);
            panel3.Controls.Add(lb_summa3);
            panel3.Controls.Add(lb_sTime3);
            panel3.Controls.Add(lb_title3);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(392, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(178, 300);
            panel3.TabIndex = 12;
            panel3.MouseClick += panel3_MouseClick;
            // 
            // lb_summa3
            // 
            lb_summa3.AutoSize = true;
            lb_summa3.ForeColor = Color.White;
            lb_summa3.Location = new Point(17, 265);
            lb_summa3.Name = "lb_summa3";
            lb_summa3.Size = new Size(50, 20);
            lb_summa3.TabIndex = 3;
            lb_summa3.Text = "label5";
            lb_summa3.MouseClick += panel3_MouseClick;
            // 
            // lb_sTime3
            // 
            lb_sTime3.AutoSize = true;
            lb_sTime3.ForeColor = Color.White;
            lb_sTime3.Location = new Point(17, 234);
            lb_sTime3.Name = "lb_sTime3";
            lb_sTime3.Size = new Size(50, 20);
            lb_sTime3.TabIndex = 2;
            lb_sTime3.Text = "label6";
            lb_sTime3.MouseClick += panel3_MouseClick;
            // 
            // lb_title3
            // 
            lb_title3.AutoSize = true;
            lb_title3.ForeColor = Color.White;
            lb_title3.Location = new Point(17, 204);
            lb_title3.Name = "lb_title3";
            lb_title3.Size = new Size(50, 20);
            lb_title3.TabIndex = 1;
            lb_title3.Text = "label7";
            lb_title3.MouseClick += panel3_MouseClick;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(17, 17);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(140, 172);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.MouseClick += panel3_MouseClick;
            // 
            // Ticketing
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(582, 853);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_goHome);
            Controls.Add(btn_allMovie);
            Controls.Add(label1);
            Name = "Ticketing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticekting";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button btn_allMovie;
        private Button btn_goHome;
        private Panel panel1;
        private Label lb_summa1;
        private Label lb_sTime1;
        private Label lb_title1;
        private Panel panel2;
        private Label lb_summa2;
        private Label lb_sTime2;
        private Label lb_title2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label lb_summa3;
        private Label lb_sTime3;
        private Label lb_title3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}