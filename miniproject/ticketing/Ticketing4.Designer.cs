namespace miniproject.ticketing
{
    partial class Ticketing4
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
            btn_pay = new Button();
            label1 = new Label();
            btn_goPre = new Button();
            btn_goHome = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_seat1 = new Button();
            btn_seat2 = new Button();
            btn_seat3 = new Button();
            SuspendLayout();
            // 
            // btn_pay
            // 
            btn_pay.Font = new Font("맑은 고딕", 25F);
            btn_pay.Location = new Point(170, 556);
            btn_pay.Name = "btn_pay";
            btn_pay.Size = new Size(242, 113);
            btn_pay.TabIndex = 32;
            btn_pay.Text = "결제";
            btn_pay.UseVisualStyleBackColor = true;
            btn_pay.Click += btn_pay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(97, 23);
            label1.Name = "label1";
            label1.Size = new Size(111, 46);
            label1.TabIndex = 31;
            label1.Text = "label1";
            // 
            // btn_goPre
            // 
            btn_goPre.Font = new Font("맑은 고딕", 25F);
            btn_goPre.Location = new Point(31, 717);
            btn_goPre.Name = "btn_goPre";
            btn_goPre.Size = new Size(242, 113);
            btn_goPre.TabIndex = 29;
            btn_goPre.Text = "이전 화면";
            btn_goPre.UseVisualStyleBackColor = true;
            btn_goPre.Click += btn_goPre_Click;
            // 
            // btn_goHome
            // 
            btn_goHome.Font = new Font("맑은 고딕", 25F);
            btn_goHome.Location = new Point(309, 717);
            btn_goHome.Name = "btn_goHome";
            btn_goHome.Size = new Size(242, 113);
            btn_goHome.TabIndex = 30;
            btn_goHome.Text = "메인 화면";
            btn_goHome.UseVisualStyleBackColor = true;
            btn_goHome.Click += btn_goHome_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btn_seat1
            // 
            btn_seat1.BackColor = Color.White;
            btn_seat1.FlatStyle = FlatStyle.Flat;
            btn_seat1.Location = new Point(97, 155);
            btn_seat1.Name = "btn_seat1";
            btn_seat1.Size = new Size(69, 60);
            btn_seat1.TabIndex = 33;
            btn_seat1.Text = "button1";
            btn_seat1.UseVisualStyleBackColor = false;
            btn_seat1.Click += btn_seat1_Click;
            // 
            // btn_seat2
            // 
            btn_seat2.BackColor = Color.White;
            btn_seat2.FlatStyle = FlatStyle.Flat;
            btn_seat2.Location = new Point(232, 155);
            btn_seat2.Name = "btn_seat2";
            btn_seat2.Size = new Size(69, 60);
            btn_seat2.TabIndex = 34;
            btn_seat2.Text = "button1";
            btn_seat2.UseVisualStyleBackColor = false;
            btn_seat2.Click += btn_seat2_Click;
            // 
            // btn_seat3
            // 
            btn_seat3.BackColor = Color.White;
            btn_seat3.FlatStyle = FlatStyle.Flat;
            btn_seat3.Location = new Point(366, 155);
            btn_seat3.Name = "btn_seat3";
            btn_seat3.Size = new Size(69, 60);
            btn_seat3.TabIndex = 35;
            btn_seat3.Text = "button1";
            btn_seat3.UseVisualStyleBackColor = false;
            btn_seat3.Click += btn_seat3_Click;
            // 
            // Ticketing4
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(582, 853);
            Controls.Add(btn_seat3);
            Controls.Add(btn_seat2);
            Controls.Add(btn_seat1);
            Controls.Add(btn_pay);
            Controls.Add(label1);
            Controls.Add(btn_goPre);
            Controls.Add(btn_goHome);
            Name = "Ticketing4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticketing4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_pay;
        private Label label1;
        private Button btn_goPre;
        private Button btn_goHome;
        private System.Windows.Forms.Timer timer1;
        private Button btn_seat1;
        private Button btn_seat2;
        private Button btn_seat3;
    }
}