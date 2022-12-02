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
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnO = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTimeLimit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(447, 341);
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
            this.label2.Location = new System.Drawing.Point(214, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "답";
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(214, 145);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(477, 23);
            this.tbQuestion.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "문제";
            // 
            // btnO
            // 
            this.btnO.Location = new System.Drawing.Point(214, 189);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(282, 124);
            this.btnO.TabIndex = 24;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.btnO_Click);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(502, 189);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(280, 124);
            this.btnX.TabIndex = 25;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(696, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "제한시간";
            // 
            // cbTimeLimit
            // 
            this.cbTimeLimit.FormattingEnabled = true;
            this.cbTimeLimit.Items.AddRange(new object[] {
            "없음",
            "15",
            "20",
            "25",
            "30"});
            this.cbTimeLimit.Location = new System.Drawing.Point(697, 145);
            this.cbTimeLimit.Name = "cbTimeLimit";
            this.cbTimeLimit.Size = new System.Drawing.Size(85, 23);
            this.cbTimeLimit.TabIndex = 26;
            this.cbTimeLimit.Text = "직접 입력";
            this.cbTimeLimit.TextUpdate += new System.EventHandler(this.cbTimeLimit_TextUpdate);
            // 
            // FormOXGameSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 517);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTimeLimit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.tbQuestion);
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
        private TextBox tbQuestion;
        private Label label1;
        private Button btnO;
        private Button btnX;
        private Label label4;
        private ComboBox cbTimeLimit;
    }
}