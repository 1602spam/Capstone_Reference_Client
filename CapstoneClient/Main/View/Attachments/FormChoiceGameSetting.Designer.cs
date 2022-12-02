namespace Main.View.Attachment
{
    partial class FormChoiceGameSetting
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTimeLimit = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbAnswer = new System.Windows.Forms.CheckedListBox();
            this.tbAddAnswer = new System.Windows.Forms.TextBox();
            this.btnAddAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "문제";
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(214, 145);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(477, 23);
            this.tbQuestion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "보기";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(447, 341);
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
            this.label4.Location = new System.Drawing.Point(696, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 8;
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
            this.cbTimeLimit.TabIndex = 7;
            this.cbTimeLimit.Text = "직접 입력";
            this.cbTimeLimit.TextUpdate += new System.EventHandler(this.cbTimeLimit_TextUpdate);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(757, 289);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(25, 24);
            this.btnRemove.TabIndex = 29;
            this.btnRemove.Text = "x";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbAnswer
            // 
            this.lbAnswer.FormattingEnabled = true;
            this.lbAnswer.Location = new System.Drawing.Point(214, 189);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(568, 94);
            this.lbAnswer.TabIndex = 28;
            this.lbAnswer.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lbAnswer_ItemCheck);
            this.lbAnswer.SelectedIndexChanged += new System.EventHandler(this.lbAnswer_SelectedIndexChanged);
            this.lbAnswer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbAnswer_MouseDown);
            // 
            // tbAddAnswer
            // 
            this.tbAddAnswer.Location = new System.Drawing.Point(214, 289);
            this.tbAddAnswer.Name = "tbAddAnswer";
            this.tbAddAnswer.Size = new System.Drawing.Size(477, 23);
            this.tbAddAnswer.TabIndex = 27;
            // 
            // btnAddAnswer
            // 
            this.btnAddAnswer.Location = new System.Drawing.Point(697, 289);
            this.btnAddAnswer.Name = "btnAddAnswer";
            this.btnAddAnswer.Size = new System.Drawing.Size(54, 24);
            this.btnAddAnswer.TabIndex = 26;
            this.btnAddAnswer.Text = "추가";
            this.btnAddAnswer.UseVisualStyleBackColor = true;
            this.btnAddAnswer.Click += new System.EventHandler(this.btnAddAnswer_Click);
            // 
            // FormChoiceGameSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbAnswer);
            this.Controls.Add(this.cbTimeLimit);
            this.Controls.Add(this.tbAddAnswer);
            this.Controls.Add(this.btnAddAnswer);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChoiceGameSetting";
            this.Text = "FormChoiceGameSetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbQuestion;
        private Label label2;
        private Button btnConfirm;
        private Label label4;
        private ComboBox cbTimeLimit;
        private Button btnRemove;
        private CheckedListBox lbAnswer;
        private TextBox tbAddAnswer;
        private Button btnAddAnswer;
    }
}