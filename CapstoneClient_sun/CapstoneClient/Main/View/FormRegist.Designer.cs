namespace Main
{
    partial class FormRegist
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblLaunchStudent = new System.Windows.Forms.Label();
            this.lblLaunchProfessor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Main.Properties.Resources.Img_professor;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 481);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Main.Properties.Resources.Img_student;
            this.pictureBox2.Location = new System.Drawing.Point(376, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(375, 481);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblLaunchStudent
            // 
            this.lblLaunchStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(94)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.lblLaunchStudent.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLaunchStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblLaunchStudent.Location = new System.Drawing.Point(380, 192);
            this.lblLaunchStudent.Name = "lblLaunchStudent";
            this.lblLaunchStudent.Size = new System.Drawing.Size(375, 110);
            this.lblLaunchStudent.TabIndex = 4;
            this.lblLaunchStudent.Text = "학생 접속";
            this.lblLaunchStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLaunchStudent.Click += new System.EventHandler(this.lblLaunchStudent_Click);
            this.lblLaunchStudent.MouseEnter += new System.EventHandler(this.lblLaunchStudent_MouseEnter);
            this.lblLaunchStudent.MouseLeave += new System.EventHandler(this.lblLaunchStudent_MouseLeave);
            // 
            // lblLaunchProfessor
            // 
            this.lblLaunchProfessor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))), ((int)(((byte)(84)))));
            this.lblLaunchProfessor.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLaunchProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblLaunchProfessor.Location = new System.Drawing.Point(0, 192);
            this.lblLaunchProfessor.Name = "lblLaunchProfessor";
            this.lblLaunchProfessor.Size = new System.Drawing.Size(375, 110);
            this.lblLaunchProfessor.TabIndex = 5;
            this.lblLaunchProfessor.Text = "교수 접속";
            this.lblLaunchProfessor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLaunchProfessor.Click += new System.EventHandler(this.lblLaunchProfessor_Click);
            this.lblLaunchProfessor.MouseEnter += new System.EventHandler(this.lblLaunchProfessor_MouseEnter);
            this.lblLaunchProfessor.MouseLeave += new System.EventHandler(this.lblLaunchProfessor_MouseLeave);
            // 
            // FormRegist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(751, 481);
            this.Controls.Add(this.lblLaunchProfessor);
            this.Controls.Add(this.lblLaunchStudent);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegist";
            this.Text = "접속 유형 선택";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label lblLaunchStudent;
        private Label lblLaunchProfessor;
    }
}