namespace Main.View.Popup
{
    partial class FormChatListItemMenu
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
            this.panButton = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panButton
            // 
            this.panButton.AutoScroll = true;
            this.panButton.AutoScrollMinSize = new System.Drawing.Size(0, 25);
            this.panButton.AutoSize = true;
            this.panButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panButton.Location = new System.Drawing.Point(0, 0);
            this.panButton.Name = "panButton";
            this.panButton.Size = new System.Drawing.Size(120, 0);
            this.panButton.TabIndex = 0;
            // 
            // FormChatListItemMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(120, 91);
            this.Controls.Add(this.panButton);
            this.Name = "FormChatListItemMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormChatListItemButton";
            this.Deactivate += new System.EventHandler(this.FormChatListItemMenu_Deactivate);
            this.Load += new System.EventHandler(this.FormChatListItemMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panButton;
    }
}