namespace test_Form
{
    partial class Form1
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
            this.toolBar1 = new Canvas_module.ToolBar.ToolBar();
            this.drawBox1 = new Canvas_module.DrawBox.DrawBox();
            this.SuspendLayout();
            // 
            // toolBar1
            // 
            this.toolBar1.Location = new System.Drawing.Point(47, 43);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(669, 35);
            this.toolBar1.TabIndex = 5;
            // 
            // drawBox1
            // 
            this.drawBox1.BackColor = System.Drawing.Color.White;
            this.drawBox1.Location = new System.Drawing.Point(141, 157);
            this.drawBox1.Name = "drawBox1";
            this.drawBox1.Size = new System.Drawing.Size(336, 190);
            this.drawBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 546);
            this.Controls.Add(this.drawBox1);
            this.Controls.Add(this.toolBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Canvas_module.ToolBar.ToolBar toolBar1;
        private Canvas_module.DrawBox.DrawBox drawBox1;
    }
}