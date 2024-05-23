namespace Project
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
            btn_first_display = new Button();
            mainDisplay1 = new maindisplay.MainDisplay();
            ticketPrint11 = new ticketprint.ticketPrint1();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btn_first_display
            // 
            btn_first_display.BackColor = Color.White;
            btn_first_display.FlatAppearance.BorderColor = Color.White;
            btn_first_display.FlatAppearance.MouseDownBackColor = Color.White;
            btn_first_display.FlatAppearance.MouseOverBackColor = Color.White;
            btn_first_display.FlatStyle = FlatStyle.Flat;
            btn_first_display.Font = new Font("맑은 고딕", 25F);
            btn_first_display.Location = new Point(0, 0);
            btn_first_display.Name = "btn_first_display";
            btn_first_display.Size = new Size(585, 855);
            btn_first_display.TabIndex = 0;
            btn_first_display.Text = "눌러주세요";
            btn_first_display.UseVisualStyleBackColor = false;
            btn_first_display.Click += btn_first_display_Click;
            // 
            // mainDisplay1
            // 
            mainDisplay1.BackColor = Color.MidnightBlue;
            mainDisplay1.Location = new Point(0, 0);
            mainDisplay1.Name = "mainDisplay1";
            mainDisplay1.Size = new Size(585, 855);
            mainDisplay1.TabIndex = 1;
            // 
            // ticketPrint11
            // 
            ticketPrint11.BackColor = Color.MidnightBlue;
            ticketPrint11.Location = new Point(0, 0);
            ticketPrint11.Name = "ticketPrint11";
            ticketPrint11.Size = new Size(585, 855);
            ticketPrint11.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 853);
            Controls.Add(ticketPrint11);
            Controls.Add(mainDisplay1);
            Controls.Add(btn_first_display);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_first_display;
        private maindisplay.MainDisplay mainDisplay1;
        private ticketprint.ticketPrint1 ticketPrint11;
        private System.Windows.Forms.Timer timer1;
    }
}
