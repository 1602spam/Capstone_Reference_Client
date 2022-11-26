namespace Main.View.UserControls
{
    partial class Rchat
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
            this.lblContext = new System.Windows.Forms.Label();
            this.rbtnChat = new Main.View.UserControls.RoundButton();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblContext
            // 
            this.lblContext.AutoSize = true;
            this.lblContext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblContext.Location = new System.Drawing.Point(95, 30);
            this.lblContext.Name = "lblContext";
            this.lblContext.Size = new System.Drawing.Size(49, 15);
            this.lblContext.TabIndex = 10;
            this.lblContext.Text = "Context";
            // 
            // rbtnChat
            // 
            this.rbtnChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rbtnChat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rbtnChat.BorderColor = System.Drawing.Color.Black;
            this.rbtnChat.BorderRadius = 5;
            this.rbtnChat.BorderSize = 0;
            this.rbtnChat.Enabled = false;
            this.rbtnChat.FlatAppearance.BorderSize = 0;
            this.rbtnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnChat.ForeColor = System.Drawing.Color.White;
            this.rbtnChat.Location = new System.Drawing.Point(86, 22);
            this.rbtnChat.Name = "rbtnChat";
            this.rbtnChat.Size = new System.Drawing.Size(137, 30);
            this.rbtnChat.TabIndex = 9;
            this.rbtnChat.TextColor = System.Drawing.Color.White;
            this.rbtnChat.UseVisualStyleBackColor = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(11, 37);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(69, 15);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "0000.00.00";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(165, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 15);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Username";
            // 
            // Rchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblContext);
            this.Controls.Add(this.rbtnChat);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblName);
            this.Name = "Rchat";
            this.Size = new System.Drawing.Size(226, 60);
            this.Load += new System.EventHandler(this.Rchat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblContext;
        private RoundButton rbtnChat;
        private Label lblTime;
        private Label lblName;
    }
}
