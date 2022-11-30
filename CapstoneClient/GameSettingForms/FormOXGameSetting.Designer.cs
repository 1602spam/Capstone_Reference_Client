namespace Main.View.Attachment
{
    partial class FormOXGameSetting
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnO = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTimeLimit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(439, 332);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(110, 50);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "확인";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "답";
            // 
            // btnO
            // 
            this.btnO.Location = new System.Drawing.Point(206, 180);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(282, 118);
            this.btnO.TabIndex = 24;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.btnO_Click);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(494, 180);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(280, 118);
            this.btnX.TabIndex = 25;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "문제";
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(206, 125);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(477, 23);
            this.tbQuestion.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(688, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "제한시간";
            // 
            // cbTimeLimit
            // 
            this.cbTimeLimit.FormattingEnabled = true;
            this.cbTimeLimit.Items.AddRange(new object[] {
            "15",
            "20",
            "25",
            "30"});
            this.cbTimeLimit.Location = new System.Drawing.Point(689, 125);
            this.cbTimeLimit.Name = "cbTimeLimit";
            this.cbTimeLimit.Size = new System.Drawing.Size(85, 23);
            this.cbTimeLimit.TabIndex = 28;
            this.cbTimeLimit.Text = "직접 입력";
            // 
            // FormOXGameSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTimeLimit);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOXGameSetting";
            this.Text = "FormAnswerGameSetting";
            this.Load += new System.EventHandler(this.FormOXGameSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnConfirm;
        private Label label2;
        private Button btnO;
        private Button btnX;
        private Label label1;
        private TextBox tbQuestion;
        private Label label4;
        private ComboBox cbTimeLimit;
    }
}