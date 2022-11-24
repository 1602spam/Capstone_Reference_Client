namespace Main.View.Professor
{
    partial class FormProfessor
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnChat = new System.Windows.Forms.Button();
            this.btnGame = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 10);
            this.lblName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "교수명:";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(3, 45);
            this.lblClassName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(46, 15);
            this.lblClassName.TabIndex = 1;
            this.lblClassName.Text = "수업명:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(3, 80);
            this.lblCode.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(58, 15);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "수업코드:";
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(25, 251);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(206, 50);
            this.btnChat.TabIndex = 3;
            this.btnChat.Text = "채팅";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnGame
            // 
            this.btnGame.Location = new System.Drawing.Point(25, 197);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(206, 48);
            this.btnGame.TabIndex = 4;
            this.btnGame.Text = "퀴즈";
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblName);
            this.flowLayoutPanel1.Controls.Add(this.lblClassName);
            this.flowLayoutPanel1.Controls.Add(this.lblCode);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(27, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(204, 105);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // FormProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 390);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.btnChat);
            this.Name = "FormProfessor";
            this.Text = "FormProfessor";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblName;
        private Label lblClassName;
        private Label lblCode;
        private Button btnChat;
        private Button btnGame;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}