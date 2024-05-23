namespace WinFormsApp7
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Location = new Point(24, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 348);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Location = new Point(224, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(174, 348);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Location = new Point(420, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(174, 348);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MidnightBlue;
            panel4.Location = new Point(614, 78);
            panel4.Name = "panel4";
            panel4.Size = new Size(174, 348);
            panel4.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20F);
            label1.Location = new Point(35, 18);
            label1.Name = "label1";
            label1.Size = new Size(111, 46);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}
