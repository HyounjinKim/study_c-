namespace shop
{
    partial class AllFood
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
            this.pn = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pn
            // 
            this.pn.AutoScroll = true;
            this.pn.Location = new System.Drawing.Point(0, 25);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(453, 408);
            this.pn.TabIndex = 0;
            // 
            // button
            // 
            
            // 
            // AllFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.pn);
            this.Name = "AllFood";
            this.Size = new System.Drawing.Size(454, 570);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn;
    }
}
