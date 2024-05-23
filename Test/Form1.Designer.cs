namespace Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_first_display = new Button();
            pb_movie_poster = new PictureBox();
            label1 = new Label();
            panel_first_menu = new Panel();
            panel_ticketPrint = new Panel();
            label2 = new Label();
            btn_tp_home = new Button();
            btn_tp_pre = new Button();
            btn_ticketing = new Button();
            btn_menu_ticketPrint = new Button();
            label_time = new Label();
            panel_ticketing = new Panel();
            btn_ticketing_hom = new Button();
            btn_ticketing_pre = new Button();
            label3 = new Label();
            time = new System.Windows.Forms.Timer(components);
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pb_movie_poster).BeginInit();
            panel_first_menu.SuspendLayout();
            panel_ticketPrint.SuspendLayout();
            panel_ticketing.SuspendLayout();
            SuspendLayout();
            // 
            // btn_first_display
            // 
            btn_first_display.FlatAppearance.BorderColor = Color.White;
            btn_first_display.FlatAppearance.MouseDownBackColor = Color.White;
            btn_first_display.FlatAppearance.MouseOverBackColor = Color.White;
            btn_first_display.FlatStyle = FlatStyle.Flat;
            btn_first_display.Font = new Font("맑은 고딕", 18F);
            btn_first_display.Location = new Point(0, 0);
            btn_first_display.Name = "btn_first_display";
            btn_first_display.Size = new Size(700, 1000);
            btn_first_display.TabIndex = 0;
            btn_first_display.Text = "아무곳이나 눌러서 진행하세요.";
            btn_first_display.UseVisualStyleBackColor = true;
            btn_first_display.Click += button1_Click;
            // 
            // pb_movie_poster
            // 
            pb_movie_poster.BackColor = Color.RosyBrown;
            pb_movie_poster.BackgroundImageLayout = ImageLayout.Center;
            pb_movie_poster.Location = new Point(0, 0);
            pb_movie_poster.Name = "pb_movie_poster";
            pb_movie_poster.Size = new Size(682, 953);
            pb_movie_poster.TabIndex = 1;
            pb_movie_poster.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 15F);
            label1.Location = new Point(142, 784);
            label1.Name = "label1";
            label1.Size = new Size(317, 35);
            label1.TabIndex = 2;
            label1.Text = "상영중인 영화 이미지 출력";
            // 
            // panel_first_menu
            // 
            panel_first_menu.BackColor = Color.MidnightBlue;
            panel_first_menu.Controls.Add(panel_ticketPrint);
            panel_first_menu.Controls.Add(btn_ticketing);
            panel_first_menu.Controls.Add(btn_menu_ticketPrint);
            panel_first_menu.Controls.Add(label_time);
            panel_first_menu.Controls.Add(panel_ticketing);
            panel_first_menu.Location = new Point(0, 0);
            panel_first_menu.Name = "panel_first_menu";
            panel_first_menu.Size = new Size(685, 656);
            panel_first_menu.TabIndex = 2;
            // 
            // panel_ticketPrint
            // 
            panel_ticketPrint.Controls.Add(label2);
            panel_ticketPrint.Controls.Add(btn_tp_home);
            panel_ticketPrint.Controls.Add(btn_tp_pre);
            panel_ticketPrint.Location = new Point(1, 0);
            panel_ticketPrint.Name = "panel_ticketPrint";
            panel_ticketPrint.Size = new Size(682, 656);
            panel_ticketPrint.TabIndex = 4;
            panel_ticketPrint.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 20F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(229, 246);
            label2.Name = "label2";
            label2.Size = new Size(224, 46);
            label2.TabIndex = 2;
            label2.Text = "티켓예매화면";
            // 
            // btn_tp_home
            // 
            btn_tp_home.Font = new Font("맑은 고딕", 15F);
            btn_tp_home.Location = new Point(590, 561);
            btn_tp_home.Name = "btn_tp_home";
            btn_tp_home.Size = new Size(80, 80);
            btn_tp_home.TabIndex = 1;
            btn_tp_home.Text = "홈";
            btn_tp_home.UseVisualStyleBackColor = true;
            btn_tp_home.Click += btn_home_Click;
            // 
            // btn_tp_pre
            // 
            btn_tp_pre.Font = new Font("맑은 고딕", 15F);
            btn_tp_pre.Location = new Point(12, 561);
            btn_tp_pre.Name = "btn_tp_pre";
            btn_tp_pre.Size = new Size(80, 80);
            btn_tp_pre.TabIndex = 0;
            btn_tp_pre.Text = "이전";
            btn_tp_pre.UseVisualStyleBackColor = true;
            btn_tp_pre.Click += btn_pre_Click;
            // 
            // btn_ticketing
            // 
            btn_ticketing.Font = new Font("맑은 고딕", 20F);
            btn_ticketing.Location = new Point(376, 213);
            btn_ticketing.Name = "btn_ticketing";
            btn_ticketing.Size = new Size(250, 350);
            btn_ticketing.TabIndex = 2;
            btn_ticketing.Text = "영화예매";
            btn_ticketing.UseVisualStyleBackColor = true;
            btn_ticketing.Click += btn_ticketing_Click;
            // 
            // btn_menu_ticketPrint
            // 
            btn_menu_ticketPrint.Font = new Font("맑은 고딕", 20F);
            btn_menu_ticketPrint.Location = new Point(67, 213);
            btn_menu_ticketPrint.Name = "btn_menu_ticketPrint";
            btn_menu_ticketPrint.Size = new Size(250, 350);
            btn_menu_ticketPrint.TabIndex = 1;
            btn_menu_ticketPrint.Text = "예매 티켓 발권";
            btn_menu_ticketPrint.UseVisualStyleBackColor = true;
            btn_menu_ticketPrint.Click += btn_menu_ticketPrint_Click;
            // 
            // label_time
            // 
            label_time.AutoSize = true;
            label_time.Font = new Font("맑은 고딕", 20F);
            label_time.ForeColor = Color.White;
            label_time.Location = new Point(230, 65);
            label_time.Name = "label_time";
            label_time.Size = new Size(88, 46);
            label_time.TabIndex = 0;
            label_time.Text = "time";
            label_time.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_ticketing
            // 
            panel_ticketing.Controls.Add(btn_ticketing_hom);
            panel_ticketing.Controls.Add(btn_ticketing_pre);
            panel_ticketing.Controls.Add(label3);
            panel_ticketing.Location = new Point(0, 0);
            panel_ticketing.Name = "panel_ticketing";
            panel_ticketing.Size = new Size(685, 656);
            panel_ticketing.TabIndex = 4;
            panel_ticketing.Visible = false;
            // 
            // btn_ticketing_hom
            // 
            btn_ticketing_hom.Font = new Font("맑은 고딕", 15F);
            btn_ticketing_hom.Location = new Point(590, 561);
            btn_ticketing_hom.Name = "btn_ticketing_hom";
            btn_ticketing_hom.Size = new Size(80, 80);
            btn_ticketing_hom.TabIndex = 2;
            btn_ticketing_hom.Text = "홈";
            btn_ticketing_hom.UseVisualStyleBackColor = true;
            btn_ticketing_hom.Click += btn_ticketing_hom_Click;
            // 
            // btn_ticketing_pre
            // 
            btn_ticketing_pre.Font = new Font("맑은 고딕", 15F);
            btn_ticketing_pre.Location = new Point(12, 561);
            btn_ticketing_pre.Name = "btn_ticketing_pre";
            btn_ticketing_pre.Size = new Size(80, 80);
            btn_ticketing_pre.TabIndex = 1;
            btn_ticketing_pre.Text = "이전";
            btn_ticketing_pre.UseVisualStyleBackColor = true;
            btn_ticketing_pre.Click += btn_ticketing_pre_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 20F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(229, 246);
            label3.Name = "label3";
            label3.Size = new Size(224, 46);
            label3.TabIndex = 0;
            label3.Text = "영화예매화면";
            // 
            // time
            // 
            time.Interval = 1000;
            time.Tick += time_Tick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "flower.png");
            imageList1.Images.SetKeyName(1, "test1.png");
            imageList1.Images.SetKeyName(2, "test2.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(682, 953);
            Controls.Add(label1);
            Controls.Add(panel_first_menu);
            Controls.Add(pb_movie_poster);
            Controls.Add(btn_first_display);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pb_movie_poster).EndInit();
            panel_first_menu.ResumeLayout(false);
            panel_first_menu.PerformLayout();
            panel_ticketPrint.ResumeLayout(false);
            panel_ticketPrint.PerformLayout();
            panel_ticketing.ResumeLayout(false);
            panel_ticketing.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Btn_tp_home_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btn_first_display;
        private PictureBox pb_movie_poster;
        private Label label1;
        private Panel panel_first_menu;
        private Label label_time;
        private System.Windows.Forms.Timer time;
        private Button btn_ticketing;
        private Button btn_menu_ticketPrint;
        private Panel panel_ticketing;
        private Label label3;
        private Button btn_ticketing_hom;
        private Button btn_ticketing_pre;
        private Panel panel_ticketPrint;
        private Label label2;
        private Button btn_tp_home;
        private Button btn_tp_pre;
        private ImageList imageList1;
    }
}
