namespace Test2
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
            button1 = new Button();
            userControl11 = new maindisplay.UserControl1();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("맑은 고딕", 20F);
            button1.Location = new Point(-2, 0);
            button1.Name = "button1";
            button1.Size = new Size(687, 954);
            button1.TabIndex = 0;
            button1.Text = "아무곳이나 눌러주세요.";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // userControl11
            // 
            userControl11.BackColor = Color.MidnightBlue;
            userControl11.Location = new Point(-2, 0);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(687, 650);
            userControl11.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 953);
            Controls.Add(userControl11);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private maindisplay.UserControl1 userControl11;
    }
}
