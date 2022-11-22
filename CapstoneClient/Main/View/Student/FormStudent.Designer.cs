namespace Main.View.Student
{
    partial class FormStudent
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
            this.lblProfessorName = new System.Windows.Forms.Label();
            this.btnNote = new System.Windows.Forms.Button();
            this.btnChat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(100, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "학생명:";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(100, 122);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(46, 15);
            this.lblClassName.TabIndex = 1;
            this.lblClassName.Text = "수업명:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(100, 182);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(58, 15);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "수업코드:";
            // 
            // lblProfessorName
            // 
            this.lblProfessorName.AutoSize = true;
            this.lblProfessorName.Location = new System.Drawing.Point(100, 152);
            this.lblProfessorName.Name = "lblProfessorName";
            this.lblProfessorName.Size = new System.Drawing.Size(46, 15);
            this.lblProfessorName.TabIndex = 3;
            this.lblProfessorName.Text = "교수명:";
            // 
            // btnNote
            // 
            this.btnNote.Location = new System.Drawing.Point(331, 87);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(100, 75);
            this.btnNote.TabIndex = 4;
            this.btnNote.Text = "필기";
            this.btnNote.UseVisualStyleBackColor = true;
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(444, 240);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(100, 75);
            this.btnChat.TabIndex = 5;
            this.btnChat.Text = "채팅";
            this.btnChat.UseVisualStyleBackColor = true;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.btnNote);
            this.Controls.Add(this.lblProfessorName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lblName);
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Label lblClassName;
        private Label lblCode;
        private Label lblProfessorName;
        private Button btnNote;
        private Button btnChat;
    }
}