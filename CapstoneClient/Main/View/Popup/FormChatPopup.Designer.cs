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
            this.flChat = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChatList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnChatList
            // 
            this.btnChatList.Location = new System.Drawing.Point(127, 3);
            this.btnChatList.Name = "btnChatList";
            this.btnChatList.Size = new System.Drawing.Size(97, 44);
            this.btnChatList.TabIndex = 0;
            this.btnChatList.Text = "채팅 인원 목록";
            this.btnChatList.UseVisualStyleBackColor = true;
            this.btnChatList.Click += new System.EventHandler(this.btnChatList_Click);
            // 
            // flChat
            // 
            this.flChat.Dock = System.Windows.Forms.DockStyle.Top;
            this.flChat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flChat.Location = new System.Drawing.Point(0, 50);
            this.flChat.Name = "flChat";
            this.flChat.Size = new System.Drawing.Size(227, 400);
            this.flChat.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.rtbChat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 450);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(227, 87);
            this.panel2.TabIndex = 2;
            // 
            // rtbChat
            // 
            this.rtbChat.Dock = System.Windows.Forms.DockStyle.Left;
            this.rtbChat.Location = new System.Drawing.Point(5, 5);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.Size = new System.Drawing.Size(146, 77);
            this.rtbChat.TabIndex = 0;
            this.rtbChat.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSend.Location = new System.Drawing.Point(157, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(65, 77);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "전송";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // FormChatPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 537);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flChat);
            this.Controls.Add(this.panel1);
            this.Name = "FormChatPopup";
            this.Text = "FormChatPopup";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnChatList;
        private FlowLayoutPanel flChat;
        private Panel panel2;
        private Button btnSend;
        private RichTextBox rtbChat;
    }
}