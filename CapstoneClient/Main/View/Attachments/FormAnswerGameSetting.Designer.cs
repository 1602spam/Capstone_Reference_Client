namespace Main.View.Attachment
{
    partial class FormAnswerGameSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTimeLimit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "문제";
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(214, 218);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(477, 23);
            this.tbQuestion.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(450, 258);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(110, 50);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "확인";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(696, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 8;
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
            this.cbTimeLimit.Location = new System.Drawing.Point(697, 218);
            this.cbTimeLimit.Name = "cbTimeLimit";
            this.cbTimeLimit.Size = new System.Drawing.Size(85, 23);
            this.cbTimeLimit.TabIndex = 7;
            this.cbTimeLimit.Text = "직접 입력";
            this.cbTimeLimit.TextUpdate += new System.EventHandler(this.cbTimeLimit_TextUpdate);
            // 
            // FormAnswerGameSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTimeLimit);
            this.Controls.Add(this.btnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAnswerGameSetting";
            this.Text = "FormChoiceGameSetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbQuestion;
        private Button btnConfirm;
        private Label label4;
        private ComboBox cbTimeLimit;
    }
}