
using Project.ticketprint;

namespace Project.maindisplay
{
    partial class MainDisplay
    {

        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer_main = new System.Windows.Forms.Timer(components);
            pn_mainDisplay = new Panel();
            btn_ticketingCancle = new Button();
            btn_ticketPrint = new Button();
            btn_ticketing = new Button();
            lb_main_time = new Label();
            ticketPrint11 = new ticketPrint1();
            pn_mainDisplay.SuspendLayout();
            SuspendLayout();
            // 
            // timer_main
            // 
            timer_main.Interval = 1000;
            timer_main.Tick += timer_main_Tick;
            // 
            // pn_mainDisplay
            // 
            pn_mainDisplay.Controls.Add(btn_ticketingCancle);
            pn_mainDisplay.Controls.Add(btn_ticketPrint);
            pn_mainDisplay.Controls.Add(btn_ticketing);
            pn_mainDisplay.Controls.Add(lb_main_time);
            pn_mainDisplay.Location = new Point(0, 0);
            pn_mainDisplay.Name = "pn_mainDisplay";
            pn_mainDisplay.Size = new Size(585, 855);
            pn_mainDisplay.TabIndex = 4;
            // 
            // btn_ticketingCancle
            // 
            btn_ticketingCancle.Font = new Font("맑은 고딕", 25F);
            btn_ticketingCancle.Location = new Point(57, 669);
            btn_ticketingCancle.Name = "btn_ticketingCancle";
            btn_ticketingCancle.Size = new Size(470, 117);
            btn_ticketingCancle.TabIndex = 7;
            btn_ticketingCancle.Text = "예매 취소";
            btn_ticketingCancle.UseVisualStyleBackColor = true;
            // 
            // btn_ticketPrint
            // 
            btn_ticketPrint.Font = new Font("맑은 고딕", 25F);
            btn_ticketPrint.Location = new Point(327, 251);
            btn_ticketPrint.Name = "btn_ticketPrint";
            btn_ticketPrint.Size = new Size(200, 350);
            btn_ticketPrint.TabIndex = 6;
            btn_ticketPrint.Text = "티켓\r\n출력";
            btn_ticketPrint.UseVisualStyleBackColor = true;
            btn_ticketPrint.Click += btn_ticketPrint_Click_1;
            // 
            // btn_ticketing
            // 
            btn_ticketing.Font = new Font("맑은 고딕", 25F);
            btn_ticketing.Location = new Point(57, 251);
            btn_ticketing.Name = "btn_ticketing";
            btn_ticketing.Size = new Size(200, 350);
            btn_ticketing.TabIndex = 5;
            btn_ticketing.Text = "예매";
            btn_ticketing.UseVisualStyleBackColor = true;
            // 
            // lb_main_time
            // 
            lb_main_time.Font = new Font("맑은 고딕", 20F);
            lb_main_time.ForeColor = Color.White;
            lb_main_time.Location = new Point(145, 69);
            lb_main_time.Name = "lb_main_time";
            lb_main_time.Size = new Size(300, 158);
            lb_main_time.TabIndex = 4;
            lb_main_time.Text = "label1";
            lb_main_time.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ticketPrint11
            // 
            ticketPrint11.BackColor = Color.MidnightBlue;
            ticketPrint11.Location = new Point(0, 0);
            ticketPrint11.Name = "ticketPrint11";
            ticketPrint11.Size = new Size(585, 855);
            ticketPrint11.TabIndex = 5;
            // 
            // MainDisplay
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            Controls.Add(ticketPrint11);
            Controls.Add(pn_mainDisplay);
            Name = "MainDisplay";
            Size = new Size(585, 855);
            pn_mainDisplay.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer_main;
        private Panel pn_mainDisplay;
        private Button btn_ticketingCancle;
        private Button btn_ticketPrint;
        private Button btn_ticketing;
        private Label lb_main_time;
        private ticketPrint1 ticketPrint11;
    }
}
