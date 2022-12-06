namespace Canvas_module
{
    partial class PropertiesView
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Color = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_BackgroundColor = new System.Windows.Forms.Label();
            this.combobox_PenWidth = new System.Windows.Forms.ComboBox();
            this.button_SelectColor = new System.Windows.Forms.Button();
            this.button_SelectBackgroundColor = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.tb = new System.Windows.Forms.TrackBar();
            this.lblnum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "테두리 색";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "펜 두께";
            // 
            // label_Color
            // 
            this.label_Color.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Color.Location = new System.Drawing.Point(105, 23);
            this.label_Color.Name = "label_Color";
            this.label_Color.Size = new System.Drawing.Size(62, 25);
            this.label_Color.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "배경 ";
            // 
            // label_BackgroundColor
            // 
            this.label_BackgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_BackgroundColor.Location = new System.Drawing.Point(105, 56);
            this.label_BackgroundColor.Name = "label_BackgroundColor";
            this.label_BackgroundColor.Size = new System.Drawing.Size(62, 25);
            this.label_BackgroundColor.TabIndex = 4;
            // 
            // combobox_PenWidth
            // 
            this.combobox_PenWidth.FormattingEnabled = true;
            this.combobox_PenWidth.Location = new System.Drawing.Point(105, 85);
            this.combobox_PenWidth.Name = "combobox_PenWidth";
            this.combobox_PenWidth.Size = new System.Drawing.Size(71, 28);
            this.combobox_PenWidth.TabIndex = 5;
            // 
            // button_SelectColor
            // 
            this.button_SelectColor.Location = new System.Drawing.Point(195, 23);
            this.button_SelectColor.Name = "button_SelectColor";
            this.button_SelectColor.Size = new System.Drawing.Size(94, 29);
            this.button_SelectColor.TabIndex = 6;
            this.button_SelectColor.Text = "...";
            this.button_SelectColor.UseVisualStyleBackColor = true;
            this.button_SelectColor.Click += new System.EventHandler(this.button_SelectColor_Click);
            // 
            // button_SelectBackgroundColor
            // 
            this.button_SelectBackgroundColor.Location = new System.Drawing.Point(195, 58);
            this.button_SelectBackgroundColor.Name = "button_SelectBackgroundColor";
            this.button_SelectBackgroundColor.Size = new System.Drawing.Size(94, 29);
            this.button_SelectBackgroundColor.TabIndex = 7;
            this.button_SelectBackgroundColor.Text = "...";
            this.button_SelectBackgroundColor.UseVisualStyleBackColor = true;
            this.button_SelectBackgroundColor.Click += new System.EventHandler(this.button_SelectBackgroundColor_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(47, 198);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(94, 29);
            this.button_Save.TabIndex = 8;
            this.button_Save.Text = "저장";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(210, 198);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(94, 29);
            this.button_Cancel.TabIndex = 9;
            this.button_Cancel.Text = "취소";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(78, 136);
            this.tb.Maximum = 255;
            this.tb.Minimum = 1;
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(204, 56);
            this.tb.TabIndex = 10;
            this.tb.Value = 50;
            this.tb.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(287, 150);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(17, 20);
            this.lblnum.TabIndex = 11;
            this.lblnum.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "투명도";
            // 
            // PropertiesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 248);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_SelectBackgroundColor);
            this.Controls.Add(this.button_SelectColor);
            this.Controls.Add(this.combobox_PenWidth);
            this.Controls.Add(this.label_BackgroundColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_Color);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PropertiesView";
            this.Text = "속성";
            ((System.ComponentModel.ISupportInitialize)(this.tb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorDialog colorDialog1;
        private Label label1;
        private Label label2;
        private Label label_Color;
        private Label label4;
        private Label label_BackgroundColor;
        private ComboBox combobox_PenWidth;
        private Button button_SelectColor;
        private Button button_SelectBackgroundColor;
        private Button button_Save;
        private Button button_Cancel;
        private TrackBar tb;
        private Label lblnum;
        private Label label5;
    }
}