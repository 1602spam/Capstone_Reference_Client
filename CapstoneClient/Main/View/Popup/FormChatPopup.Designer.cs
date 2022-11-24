namespace Main.View.Popup
{
    partial class FormChatPopup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChatList = new System.Windows.Forms.Button();
            this.panMessage = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChatList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnChatList
            // 
            this.btnChatList.Location = new System.Drawing.Point(297, 3);
            this.btnChatList.Name = "btnChatList";
            this.btnChatList.Size = new System.Drawing.Size(97, 44);
            this.btnChatList.TabIndex = 0;
            this.btnChatList.Text = "채팅 인원 목록";
            this.btnChatList.UseVisualStyleBackColor = true;
            this.btnChatList.Click += new System.EventHandler(this.btnChatList_Click);
            // 
            // panMessage
            // 
            this.panMessage.AutoScroll = true;
            this.panMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMessage.Location = new System.Drawing.Point(0, 50);
            this.panMessage.Name = "panMessage";
            this.panMessage.Size = new System.Drawing.Size(404, 342);
            this.panMessage.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblLocation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 392);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 21);
            this.panel2.TabIndex = 2;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.SystemColors.Control;
            this.lblLocation.Location = new System.Drawing.Point(2, 3);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(62, 15);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "전송 대상:";
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSend.Location = new System.Drawing.Point(334, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(65, 114);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "전송";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtbChat
            // 
            this.rtbChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbChat.Dock = System.Windows.Forms.DockStyle.Left;
            this.rtbChat.Location = new System.Drawing.Point(5, 5);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbChat.Size = new System.Drawing.Size(318, 114);
            this.rtbChat.TabIndex = 0;
            this.rtbChat.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSend);
            this.panel3.Controls.Add(this.rtbChat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 413);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(404, 124);
            this.panel3.TabIndex = 5;
            // 
            // FormChatPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 537);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panMessage);
            this.Controls.Add(this.panel1);
            this.Name = "FormChatPopup";
            this.Text = "FormChatPopup";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnChatList;
        private Panel panMessage;
        private Panel panel2;
        private Label lblLocation;
        private Button btnSend;
        private RichTextBox rtbChat;
        private Panel panel3;
    }
}