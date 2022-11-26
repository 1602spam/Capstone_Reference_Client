namespace Main.View.Popup
{
    partial class FormGameInvitation
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "게임 초대 창";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(304, 263);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "초대";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(395, 263);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(75, 23);
            this.btnDecline.TabIndex = 2;
            this.btnDecline.Text = "거절";
            this.btnDecline.UseVisualStyleBackColor = true;
            // 
            // FormGameInvitation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label1);
            this.Name = "FormGameInvitation";
            this.Text = "FormGameInvitation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnConfirm;
        private Button btnDecline;
    }
}