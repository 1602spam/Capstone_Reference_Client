namespace Main.View.UserControls
{
    partial class ChatListItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatListItem));
            this.rbtnProfile = new Main.View.UserControls.RoundButton();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtnProfile
            // 
            this.rbtnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.rbtnProfile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.rbtnProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbtnProfile.BackgroundImage")));
            this.rbtnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbtnProfile.BorderColor = System.Drawing.Color.Black;
            this.rbtnProfile.BorderRadius = 15;
            this.rbtnProfile.BorderSize = 0;
            this.rbtnProfile.FlatAppearance.BorderSize = 0;
            this.rbtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnProfile.ForeColor = System.Drawing.Color.White;
            this.rbtnProfile.Location = new System.Drawing.Point(3, 3);
            this.rbtnProfile.Name = "rbtnProfile";
            this.rbtnProfile.Size = new System.Drawing.Size(30, 30);
            this.rbtnProfile.TabIndex = 0;
            this.rbtnProfile.TextColor = System.Drawing.Color.White;
            this.rbtnProfile.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(39, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Username123";
            // 
            // ChatListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.rbtnProfile);
            this.Name = "ChatListItem";
            this.Size = new System.Drawing.Size(250, 37);
            this.Load += new System.EventHandler(this.ChatMemberListItem_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChatListItem_MouseClick);
            this.MouseLeave += new System.EventHandler(this.ChatListItem_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ChatListItem_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton rbtnProfile;
        private Label lblName;
    }
}
