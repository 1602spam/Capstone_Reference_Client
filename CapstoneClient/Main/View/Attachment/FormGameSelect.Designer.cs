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
            this.panMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(59, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "게임 선택";
            // 
            // btnSelectChoice
            // 
            this.btnSelectChoice.Location = new System.Drawing.Point(279, 12);
            this.btnSelectChoice.Name = "btnSelectChoice";
            this.btnSelectChoice.Size = new System.Drawing.Size(118, 51);
            this.btnSelectChoice.TabIndex = 1;
            this.btnSelectChoice.Text = "다지선다";
            this.btnSelectChoice.UseVisualStyleBackColor = true;
            this.btnSelectChoice.Click += new System.EventHandler(this.btnSelectChoice_Click);
            // 
            // btnSelectAnswer
            // 
            this.btnSelectAnswer.Location = new System.Drawing.Point(403, 12);
            this.btnSelectAnswer.Name = "btnSelectAnswer";
            this.btnSelectAnswer.Size = new System.Drawing.Size(116, 51);
            this.btnSelectAnswer.TabIndex = 2;
            this.btnSelectAnswer.Text = "주관식";
            this.btnSelectAnswer.UseVisualStyleBackColor = true;
            this.btnSelectAnswer.Click += new System.EventHandler(this.btnSelectAnswer_Click);
            // 
            // panMain
            // 
            this.panMain.Location = new System.Drawing.Point(10, 71);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(780, 319);
            this.panMain.TabIndex = 3;
            // 
            // FormGameSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.btnSelectAnswer);
            this.Controls.Add(this.btnSelectChoice);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGameSelect";
            this.Text = "FormGameSelect";
            this.Load += new System.EventHandler(this.FormGameSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Button btnSelectChoice;
        private Button btnSelectAnswer;
        private Panel panMain;
    }
}