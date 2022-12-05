namespace Main.View.Popup
{
    partial class FormUserListPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.chID = new System.Windows.Forms.ColumnHeader();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.lblChatable = new System.Windows.Forms.Label();
            this.btnChatable = new System.Windows.Forms.Button();
            this.chIsLogin = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chIsLogin});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(498, 341);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            this.chID.Text = "학번";
            this.chID.Width = 120;
            // 
            // chName
            // 
            this.chName.Text = "이름";
            this.chName.Width = 80;
            // 
            // lblChatable
            // 
            this.lblChatable.AutoSize = true;
            this.lblChatable.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChatable.Location = new System.Drawing.Point(516, 12);
            this.lblChatable.Name = "lblChatable";
            this.lblChatable.Size = new System.Drawing.Size(71, 15);
            this.lblChatable.TabIndex = 1;
            this.lblChatable.Text = "채팅 허용됨";
            // 
            // btnChatable
            // 
            this.btnChatable.Location = new System.Drawing.Point(672, 8);
            this.btnChatable.Name = "btnChatable";
            this.btnChatable.Size = new System.Drawing.Size(116, 23);
            this.btnChatable.TabIndex = 2;
            this.btnChatable.Text = "채팅 허용/금지";
            this.btnChatable.UseVisualStyleBackColor = true;
            this.btnChatable.Click += new System.EventHandler(this.button1_Click);
            // 
            // chIsLogin
            // 
            this.chIsLogin.Text = "로그인 여부";
            this.chIsLogin.Width = 120;
            // 
            // FormUserListPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChatable);
            this.Controls.Add(this.lblChatable);
            this.Controls.Add(this.listView1);
            this.Name = "FormUserListPopup";
            this.Text = "FormUserListPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private ColumnHeader chID;
        private ColumnHeader chName;
        private Label lblChatable;
        private Button btnChatable;
        private ColumnHeader chIsLogin;
    }
}