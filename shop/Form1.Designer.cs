﻿namespace shop
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.allFood1 = new shop.AllFood();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // allFood1
            // 
            this.allFood1.AutoScroll = true;
            this.allFood1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allFood1.Location = new System.Drawing.Point(0, 0);
            this.allFood1.Margin = new System.Windows.Forms.Padding(0);
            this.allFood1.Name = "allFood1";
            this.allFood1.Size = new System.Drawing.Size(454, 626);
            this.allFood1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 56);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.allFood1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private AllFood allFood1;
        private System.Windows.Forms.Panel panel1;
    }
}

