namespace WinFormsApp2
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
            label1 = new Label();
            tb = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            num1 = new TextBox();
            num2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lb_result = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(277, 78);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 83);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // tb
            // 
            tb.Location = new Point(146, 80);
            tb.Name = "tb";
            tb.Size = new Size(125, 27);
            tb.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(407, 190);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 0;
            button2.Text = "더하기";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(407, 225);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 0;
            button3.Text = "빼기";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(407, 260);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 0;
            button4.Text = "곱하기";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(407, 295);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 0;
            button5.Text = "나누기";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // num1
            // 
            num1.Location = new Point(276, 192);
            num1.Name = "num1";
            num1.Size = new Size(125, 27);
            num1.TabIndex = 4;
            // 
            // num2
            // 
            num2.Location = new Point(276, 227);
            num2.Name = "num2";
            num2.Size = new Size(125, 27);
            num2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 194);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 6;
            label2.Text = "첫번째 수";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 229);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 7;
            label3.Text = "두번째 수";
            // 
            // lb_result
            // 
            lb_result.AutoSize = true;
            lb_result.Location = new Point(297, 264);
            lb_result.Name = "lb_result";
            lb_result.Size = new Size(39, 20);
            lb_result.TabIndex = 7;
            lb_result.Text = "결과";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lb_result);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(tb);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox tb;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox num1;
        private TextBox num2;
        private Label label2;
        private Label label3;
        private Label lb_result;
    }
}
