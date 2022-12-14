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
            this.chWhisper = new System.Windows.Forms.ColumnHeader();
            this.chScreenHide = new System.Windows.Forms.ColumnHeader();
            this.chCapturable = new System.Windows.Forms.ColumnHeader();
            this.chChattable = new System.Windows.Forms.ColumnHeader();
            this.chSeeCharacter = new System.Windows.Forms.ColumnHeader();
            this.lblChatable = new System.Windows.Forms.Label();
            this.btnChatable = new System.Windows.Forms.Button();
            this.btnKick = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chWhisper,
            this.chScreenHide,
            this.chCapturable,
            this.chChattable,
            this.chSeeCharacter});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(644, 388);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // chWhisper
            // 
            this.chWhisper.Text = "귓속말 금지";
            this.chWhisper.Width = 80;
            // 
            // chScreenHide
            // 
            this.chScreenHide.Text = "화면 가리기";
            this.chScreenHide.Width = 80;
            // 
            // chCapturable
            // 
            this.chCapturable.Text = "캡처 가능";
            this.chCapturable.Width = 80;
            // 
            // chChattable
            // 
            this.chChattable.Text = "채팅  가능";
            this.chChattable.Width = 80;
            // 
            // chSeeCharacter
            // 
            this.chSeeCharacter.Text = "다른 캐릭터 보이기";
            this.chSeeCharacter.Width = 120;
            // 
            // lblChatable
            // 
            this.lblChatable.AutoSize = true;
            this.lblChatable.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChatable.Location = new System.Drawing.Point(673, 359);
            this.lblChatable.Name = "lblChatable";
            this.lblChatable.Size = new System.Drawing.Size(71, 15);
            this.lblChatable.TabIndex = 1;
            this.lblChatable.Text = "채팅 허용됨";
            // 
            // btnChatable
            // 
            this.btnChatable.Location = new System.Drawing.Point(673, 377);
            this.btnChatable.Name = "btnChatable";
            this.btnChatable.Size = new System.Drawing.Size(116, 23);
            this.btnChatable.TabIndex = 2;
            this.btnChatable.Text = "채팅 허용/금지";
            this.btnChatable.UseVisualStyleBackColor = true;
            this.btnChatable.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKick
            // 
            this.btnKick.Location = new System.Drawing.Point(835, 119);
            this.btnKick.Name = "btnKick";
            this.btnKick.Size = new System.Drawing.Size(83, 23);
            this.btnKick.TabIndex = 4;
            this.btnKick.Text = "강제 퇴장";
            this.btnKick.UseVisualStyleBackColor = true;
            this.btnKick.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(672, 15);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(66, 15);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "선택 학번: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(673, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "이름 변경";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(835, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "귓속말 금지";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(673, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "화면 가리기";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(673, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "캡처 금지";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(754, 33);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "채팅 금지";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(672, 119);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "캐릭터 숨기기";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // FormUserListPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 412);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnKick);
            this.Controls.Add(this.btnChatable);
            this.Controls.Add(this.lblChatable);
            this.Controls.Add(this.listView1);
            this.Name = "FormUserListPopup";
            this.Text = "학생 관리";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private ColumnHeader chID;
        private ColumnHeader chName;
        private Label lblChatable;
        private Button btnChatable;
        private Button btnKick;
        private Label lblID;
        private ColumnHeader chWhisper;
        private ColumnHeader chScreenHide;
        private ColumnHeader chCapturable;
        private ColumnHeader chChattable;
        private ColumnHeader chSeeCharacter;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}