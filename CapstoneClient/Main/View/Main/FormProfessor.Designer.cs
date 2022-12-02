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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfessor));
            this.lblName = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbQuiz = new System.Windows.Forms.PictureBox();
            this.pbChat = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChat)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblName.Location = new System.Drawing.Point(516, 10);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 13, 4, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "교수명:";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.BackColor = System.Drawing.Color.Transparent;
            this.lblClassName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClassName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblClassName.Location = new System.Drawing.Point(516, 41);
            this.lblClassName.Margin = new System.Windows.Forms.Padding(4, 13, 4, 13);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(58, 20);
            this.lblClassName.TabIndex = 1;
            this.lblClassName.Text = "수업명:";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.BackColor = System.Drawing.Color.Transparent;
            this.lblIP.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblIP.Location = new System.Drawing.Point(13, 17);
            this.lblIP.Margin = new System.Windows.Forms.Padding(4, 13, 4, 13);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(35, 28);
            this.lblIP.TabIndex = 2;
            this.lblIP.Text = "IP:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pbQuiz);
            this.panel1.Controls.Add(this.pbChat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 418);
            this.panel1.TabIndex = 5;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Main.Properties.Resources.line;
            this.pictureBox1.Location = new System.Drawing.Point(12, 398);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(765, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pbQuiz
            // 
            this.pbQuiz.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbQuiz.ErrorImage")));
            this.pbQuiz.Image = global::Main.Properties.Resources.Quiz1;
            this.pbQuiz.Location = new System.Drawing.Point(448, -151);
            this.pbQuiz.Name = "pbQuiz";
            this.pbQuiz.Size = new System.Drawing.Size(204, 448);
            this.pbQuiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQuiz.TabIndex = 1;
            this.pbQuiz.TabStop = false;
            this.pbQuiz.Click += new System.EventHandler(this.pbQuiz_Click);
            this.pbQuiz.MouseEnter += new System.EventHandler(this.pbQuiz_MouseEnter);
            this.pbQuiz.MouseLeave += new System.EventHandler(this.pbQuiz_MouseLeave);
            // 
            // pbChat
            // 
            this.pbChat.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbChat.ErrorImage")));
            this.pbChat.Image = global::Main.Properties.Resources.Chat2;
            this.pbChat.Location = new System.Drawing.Point(139, -100);
            this.pbChat.Name = "pbChat";
            this.pbChat.Size = new System.Drawing.Size(204, 448);
            this.pbChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbChat.TabIndex = 0;
            this.pbChat.TabStop = false;
            this.pbChat.Click += new System.EventHandler(this.pbChat_Click);
            this.pbChat.MouseEnter += new System.EventHandler(this.pbChat_MouseEnter);
            this.pbChat.MouseLeave += new System.EventHandler(this.pbChat_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lblIP);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Controls.Add(this.lblClassName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 418);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(789, 71);
            this.panel3.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(789, 489);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProfessor";
            this.Text = "FormProfessor";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChat)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblName;
        private Label lblClassName;
        private Label lblIP;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pbQuiz;
        private PictureBox pbChat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private PictureBox pictureBox1;
    }
}