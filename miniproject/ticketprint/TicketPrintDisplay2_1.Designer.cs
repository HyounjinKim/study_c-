﻿namespace miniproject.ticketprint
{
    partial class TicketPrintDisplay2_1
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
            btn_check = new Button();
            tb_phoneNum = new TextBox();
            lb_tkNum = new Label();
            btn_goPre = new Button();
            btn_goHome = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btn_check
            // 
            btn_check.Font = new Font("맑은 고딕", 25F);
            btn_check.Location = new Point(171, 482);
            btn_check.Name = "btn_check";
            btn_check.Size = new Size(247, 86);
            btn_check.TabIndex = 18;
            btn_check.Text = "조회";
            btn_check.UseVisualStyleBackColor = true;
            btn_check.Click += btn_check_Click;
            // 
            // tb_phoneNum
            // 
            tb_phoneNum.BackColor = Color.MidnightBlue;
            tb_phoneNum.Font = new Font("맑은 고딕", 35F);
            tb_phoneNum.ForeColor = Color.White;
            tb_phoneNum.Location = new Point(41, 364);
            tb_phoneNum.Name = "tb_phoneNum";
            tb_phoneNum.Size = new Size(500, 85);
            tb_phoneNum.TabIndex = 17;
            tb_phoneNum.TextAlign = HorizontalAlignment.Center;
            // 
            // lb_tkNum
            // 
            lb_tkNum.AutoSize = true;
            lb_tkNum.Font = new Font("맑은 고딕", 30F);
            lb_tkNum.ForeColor = Color.White;
            lb_tkNum.Location = new Point(171, 242);
            lb_tkNum.Name = "lb_tkNum";
            lb_tkNum.Size = new Size(247, 67);
            lb_tkNum.TabIndex = 16;
            lb_tkNum.Text = "전화 번호";
            // 
            // btn_goPre
            // 
            btn_goPre.Font = new Font("맑은 고딕", 25F);
            btn_goPre.Location = new Point(32, 665);
            btn_goPre.Name = "btn_goPre";
            btn_goPre.Size = new Size(242, 113);
            btn_goPre.TabIndex = 15;
            btn_goPre.Text = "이전 화면";
            btn_goPre.UseVisualStyleBackColor = true;
            btn_goPre.Click += btn_goPre_Click;
            // 
            // btn_goHome
            // 
            btn_goHome.Font = new Font("맑은 고딕", 25F);
            btn_goHome.Location = new Point(308, 665);
            btn_goHome.Name = "btn_goHome";
            btn_goHome.Size = new Size(242, 113);
            btn_goHome.TabIndex = 14;
            btn_goHome.Text = "메인 화면";
            btn_goHome.UseVisualStyleBackColor = true;
            btn_goHome.Click += btn_goHome_Click;
            // 
            // label1
            // 
            label1.Font = new Font("맑은 고딕", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(90, 75);
            label1.Name = "label1";
            label1.Size = new Size(400, 146);
            label1.TabIndex = 13;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // TicketPrintDisplay2_1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(582, 853);
            Controls.Add(btn_check);
            Controls.Add(tb_phoneNum);
            Controls.Add(lb_tkNum);
            Controls.Add(btn_goPre);
            Controls.Add(btn_goHome);
            Controls.Add(label1);
            Name = "TicketPrintDisplay2_1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TicketPrintDisplay2_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_check;
        private TextBox tb_phoneNum;
        private Label lb_tkNum;
        private Button btn_goPre;
        private Button btn_goHome;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}