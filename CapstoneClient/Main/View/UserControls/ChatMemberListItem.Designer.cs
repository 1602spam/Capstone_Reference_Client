namespace Main.View.UserControls
{
    partial class ChatMemberListItem
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
            this.rbtnProfile = new Main.View.UserControls.RoundButton();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtnProfile
            // 
            this.rbtnProfile.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtnProfile.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtnProfile.BorderColor = System.Drawing.Color.Black;
            this.rbtnProfile.BorderRadius = 20;
            this.rbtnProfile.BorderSize = 0;
            this.rbtnProfile.FlatAppearance.BorderSize = 0;
            this.rbtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnProfile.ForeColor = System.Drawing.Color.White;
            this.rbtnProfile.Location = new System.Drawing.Point(13, 9);
            this.rbtnProfile.Name = "rbtnProfile";
            this.rbtnProfile.Size = new System.Drawing.Size(40, 40);
            this.rbtnProfile.TabIndex = 0;
            this.rbtnProfile.TextColor = System.Drawing.Color.White;
            this.rbtnProfile.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(59, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Username123";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemove.Location = new System.Drawing.Point(192, 11);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(45, 37);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "삭제";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Visible = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ChatMemberListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.rbtnProfile);
            this.Name = "ChatMemberListItem";
            this.Size = new System.Drawing.Size(250, 57);
            this.Load += new System.EventHandler(this.ChatMemberListItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton rbtnProfile;
        private Label lblName;
        private Button btnRemove;
    }
}
