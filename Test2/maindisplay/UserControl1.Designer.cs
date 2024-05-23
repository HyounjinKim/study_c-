namespace Test2.maindisplay
{
    partial class UserControl1
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
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("맑은 고딕", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(190, 59);
            label1.Name = "label1";
            label1.Size = new Size(325, 137);
            label1.TabIndex = 0;
            label1.Text = "시간";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(83, 258);
            button1.Name = "button1";
            button1.Size = new Size(220, 362);
            button1.TabIndex = 1;
            button1.Text = "ㅇㅇ";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(397, 258);
            button2.Name = "button2";
            button2.Size = new Size(220, 362);
            button2.TabIndex = 1;
            button2.Text = "ㅇㅇ";
            button2.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "UserControl1";
            Size = new Size(700, 700);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
    }
}
