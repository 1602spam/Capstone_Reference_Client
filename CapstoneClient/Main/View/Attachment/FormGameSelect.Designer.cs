namespace Main.View.Attachments
{
    partial class FormGameSelect
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSelectChoice = new System.Windows.Forms.Button();
            this.btnSelectAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(40, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(59, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "게임 선택";
            // 
            // btnSelectChoice
            // 
            this.btnSelectChoice.Location = new System.Drawing.Point(63, 138);
            this.btnSelectChoice.Name = "btnSelectChoice";
            this.btnSelectChoice.Size = new System.Drawing.Size(93, 83);
            this.btnSelectChoice.TabIndex = 1;
            this.btnSelectChoice.Text = "다지선다";
            this.btnSelectChoice.UseVisualStyleBackColor = true;
            // 
            // btnSelectAnswer
            // 
            this.btnSelectAnswer.Location = new System.Drawing.Point(188, 138);
            this.btnSelectAnswer.Name = "btnSelectAnswer";
            this.btnSelectAnswer.Size = new System.Drawing.Size(82, 83);
            this.btnSelectAnswer.TabIndex = 2;
            this.btnSelectAnswer.Text = "주관식";
            this.btnSelectAnswer.UseVisualStyleBackColor = true;
            // 
            // FormGameSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelectAnswer);
            this.Controls.Add(this.btnSelectChoice);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGameSelect";
            this.Text = "FormGameSelect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Button btnSelectChoice;
        private Button btnSelectAnswer;
    }
}