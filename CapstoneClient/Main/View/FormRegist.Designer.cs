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
            this.btnLaunchProfessor = new System.Windows.Forms.Button();
            this.btnLaunchStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLaunchProfessor
            // 
            this.btnLaunchProfessor.Location = new System.Drawing.Point(142, 129);
            this.btnLaunchProfessor.Name = "btnLaunchProfessor";
            this.btnLaunchProfessor.Size = new System.Drawing.Size(100, 75);
            this.btnLaunchProfessor.TabIndex = 0;
            this.btnLaunchProfessor.Text = "교수 접속";
            this.btnLaunchProfessor.UseVisualStyleBackColor = true;
            this.btnLaunchProfessor.Click += new System.EventHandler(this.btnLaunchProfessor_Click);
            // 
            // btnLaunchStudent
            // 
            this.btnLaunchStudent.Location = new System.Drawing.Point(342, 129);
            this.btnLaunchStudent.Name = "btnLaunchStudent";
            this.btnLaunchStudent.Size = new System.Drawing.Size(100, 75);
            this.btnLaunchStudent.TabIndex = 1;
            this.btnLaunchStudent.Text = "학생 접속";
            this.btnLaunchStudent.UseVisualStyleBackColor = true;
            this.btnLaunchStudent.Click += new System.EventHandler(this.btnLaunchStudent_Click);
            // 
            // FormRegist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnLaunchStudent);
            this.Controls.Add(this.btnLaunchProfessor);
            this.Name = "FormRegist";
            this.Text = "접속 유형 선택";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRegist_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnLaunchProfessor;
        private Button btnLaunchStudent;
    }
}