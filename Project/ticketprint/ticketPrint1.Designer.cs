
using Project.maindisplay;

namespace Project.ticketprint
{
    partial class ticketPrint1
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
            timer_tkPrint = new System.Windows.Forms.Timer(components);
            pn_ticketPrint = new Panel();
            btn_ticketingHome = new Button();
            btn_phoneNum = new Button();
            btn_ticketingNum = new Button();
            lb_tkPrint_time = new Label();
            pn_ticketPrint.SuspendLayout();
            SuspendLayout();
            // 
            // timer_tkPrint
            // 
            timer_tkPrint.Tick += timer_tkPrint_Tick;
            // 
            // pn_ticketPrint
            // 
            pn_ticketPrint.Controls.Add(btn_ticketingHome);
            pn_ticketPrint.Controls.Add(btn_phoneNum);
            pn_ticketPrint.Controls.Add(btn_ticketingNum);
            pn_ticketPrint.Controls.Add(lb_tkPrint_time);
            pn_ticketPrint.Location = new Point(0, 0);
            pn_ticketPrint.Name = "pn_ticketPrint";
            pn_ticketPrint.Size = new Size(585, 855);
            pn_ticketPrint.TabIndex = 0;
            // 
            // btn_ticketingHome
            // 
            btn_ticketingHome.Font = new Font("맑은 고딕", 25F);
            btn_ticketingHome.Location = new Point(167, 677);
            btn_ticketingHome.Name = "btn_ticketingHome";
            btn_ticketingHome.Size = new Size(246, 100);
            btn_ticketingHome.TabIndex = 7;
            btn_ticketingHome.Text = "메인화면";
            btn_ticketingHome.UseVisualStyleBackColor = true;
            btn_ticketingHome.Click += btn_ticketingHome_Click_1;
            // 
            // btn_phoneNum
            // 
            btn_phoneNum.Font = new Font("맑은 고딕", 25F);
            btn_phoneNum.Location = new Point(327, 259);
            btn_phoneNum.Name = "btn_phoneNum";
            btn_phoneNum.Size = new Size(200, 350);
            btn_phoneNum.TabIndex = 5;
            btn_phoneNum.Text = "전화\r\n번호\r\n검색";
            btn_phoneNum.UseVisualStyleBackColor = true;
            // 
            // btn_ticketingNum
            // 
            btn_ticketingNum.Font = new Font("맑은 고딕", 25F);
            btn_ticketingNum.Location = new Point(57, 259);
            btn_ticketingNum.Name = "btn_ticketingNum";
            btn_ticketingNum.Size = new Size(200, 350);
            btn_ticketingNum.TabIndex = 6;
            btn_ticketingNum.Text = "예매\r\n번호\r\n검색";
            btn_ticketingNum.UseVisualStyleBackColor = true;
            // 
            // lb_tkPrint_time
            // 
            lb_tkPrint_time.Font = new Font("맑은 고딕", 20F);
            lb_tkPrint_time.ForeColor = Color.White;
            lb_tkPrint_time.Location = new Point(145, 77);
            lb_tkPrint_time.Name = "lb_tkPrint_time";
            lb_tkPrint_time.Size = new Size(300, 158);
            lb_tkPrint_time.TabIndex = 4;
            lb_tkPrint_time.Text = "label1";
            lb_tkPrint_time.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ticketPrint1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            Controls.Add(pn_ticketPrint);
            Name = "ticketPrint1";
            Size = new Size(585, 855);
            pn_ticketPrint.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer_tkPrint;
        private Button btn_phoneNum;
        private Button btn_ticketingNum;
        private Label lb_tkPrint_time;
        public Panel pn_ticketPrint;
        public Button btn_ticketingHome;
    }
}
