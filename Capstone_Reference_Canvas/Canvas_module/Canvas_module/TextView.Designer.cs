namespace Canvas_module
{
    partial class TextView
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
            this.savebutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(607, 32);
            this.savebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(104, 36);
            this.savebutton.TabIndex = 0;
            this.savebutton.Text = "저장";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.textBox1.Location = new System.Drawing.Point(40, 76);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(671, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "텍스트 박스에 들어갈 내용을 입력하세요.";
            // 
            // TextView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 136);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.savebutton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TextView";
            this.Text = "텍스트 입력하기";
            this.Load += new System.EventHandler(this.TextView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button savebutton;
        private TextBox textBox1;
        private Label label1;
    }
}