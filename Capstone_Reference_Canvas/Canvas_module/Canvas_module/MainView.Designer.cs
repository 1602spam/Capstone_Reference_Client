namespace Canvas_module
{
    partial class MainView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save_pngtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CapturetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.PropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointertoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangletoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EllipsetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penciltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolBar1 = new Canvas_module.ToolBar.ToolBar();
            this.drawBox1 = new Canvas_module.DrawBox.DrawBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.drawToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1601, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.save_pngtoolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem,
            this.CapturetoolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.fileToolStripMenuItem.Text = "파일";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.newToolStripMenuItem.Text = "새로 만들기";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.openToolStripMenuItem.Text = "불러오기";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.saveToolStripMenuItem.Text = "저장하기";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // save_pngtoolStripMenuItem
            // 
            this.save_pngtoolStripMenuItem.Name = "save_pngtoolStripMenuItem";
            this.save_pngtoolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.save_pngtoolStripMenuItem.Text = "png로 저장하기";
            this.save_pngtoolStripMenuItem.Click += new System.EventHandler(this.save_pngtoolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(214, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.exitToolStripMenuItem.Text = "종료";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // CapturetoolStripMenuItem
            // 
            this.CapturetoolStripMenuItem.Name = "CapturetoolStripMenuItem";
            this.CapturetoolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.CapturetoolStripMenuItem.Text = "캡쳐화면 가져오기";
            this.CapturetoolStripMenuItem.Click += new System.EventHandler(this.CapturetoolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAllToolStripMenuItem,
            this.UnselectAllToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.DeleteAllToolStripMenuItem,
            this.toolStripSeparator2,
            this.UndoToolStripMenuItem,
            this.RedoToolStripMenuItem1,
            this.toolStripSeparator3,
            this.PropertiesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.editToolStripMenuItem.Text = "편집";
            // 
            // SelectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.SelectAllToolStripMenuItem.Text = "전체 선택";
            this.SelectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // UnselectAllToolStripMenuItem
            // 
            this.UnselectAllToolStripMenuItem.Name = "UnselectAllToolStripMenuItem";
            this.UnselectAllToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.UnselectAllToolStripMenuItem.Text = "전체 해제";
            this.UnselectAllToolStripMenuItem.Click += new System.EventHandler(this.UnselectAllToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.DeleteToolStripMenuItem.Text = "삭제하기";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // DeleteAllToolStripMenuItem
            // 
            this.DeleteAllToolStripMenuItem.Name = "DeleteAllToolStripMenuItem";
            this.DeleteAllToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.DeleteAllToolStripMenuItem.Text = "전체 삭제하기";
            this.DeleteAllToolStripMenuItem.Click += new System.EventHandler(this.DeleteAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.UndoToolStripMenuItem.Text = "실행 취소";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // RedoToolStripMenuItem1
            // 
            this.RedoToolStripMenuItem1.Name = "RedoToolStripMenuItem1";
            this.RedoToolStripMenuItem1.Size = new System.Drawing.Size(187, 26);
            this.RedoToolStripMenuItem1.Text = "다시 실행";
            this.RedoToolStripMenuItem1.Click += new System.EventHandler(this.RedoToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(184, 6);
            // 
            // PropertiesToolStripMenuItem
            // 
            this.PropertiesToolStripMenuItem.Enabled = false;
            this.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem";
            this.PropertiesToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.PropertiesToolStripMenuItem.Text = "속성 실행하기";
            this.PropertiesToolStripMenuItem.Click += new System.EventHandler(this.PropertiesToolStripMenuItem_Click);
            // 
            // drawToolStripMenuItem
            // 
            this.drawToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointertoolStripMenuItem,
            this.rectangletoolStripMenuItem,
            this.EllipsetoolStripMenuItem,
            this.linetoolStripMenuItem,
            this.penciltoolStripMenuItem,
            this.TextBoxToolStripMenuItem});
            this.drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            this.drawToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.drawToolStripMenuItem.Text = "도구";
            // 
            // pointertoolStripMenuItem
            // 
            this.pointertoolStripMenuItem.Name = "pointertoolStripMenuItem";
            this.pointertoolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.pointertoolStripMenuItem.Text = "선택하기";
            this.pointertoolStripMenuItem.Click += new System.EventHandler(this.pointertoolStripMenuItem_Click);
            // 
            // rectangletoolStripMenuItem
            // 
            this.rectangletoolStripMenuItem.Name = "rectangletoolStripMenuItem";
            this.rectangletoolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.rectangletoolStripMenuItem.Text = "사각형";
            // 
            // EllipsetoolStripMenuItem
            // 
            this.EllipsetoolStripMenuItem.Name = "EllipsetoolStripMenuItem";
            this.EllipsetoolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.EllipsetoolStripMenuItem.Text = "원";
            this.EllipsetoolStripMenuItem.Click += new System.EventHandler(this.EllipsetoolStripMenuItem_Click);
            // 
            // linetoolStripMenuItem
            // 
            this.linetoolStripMenuItem.Name = "linetoolStripMenuItem";
            this.linetoolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.linetoolStripMenuItem.Text = "선";
            this.linetoolStripMenuItem.Click += new System.EventHandler(this.linetoolStripMenuItem_Click);
            // 
            // penciltoolStripMenuItem
            // 
            this.penciltoolStripMenuItem.Name = "penciltoolStripMenuItem";
            this.penciltoolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.penciltoolStripMenuItem.Text = "연필";
            this.penciltoolStripMenuItem.Click += new System.EventHandler(this.penciltoolStripMenuItem_Click);
            // 
            // TextBoxToolStripMenuItem
            // 
            this.TextBoxToolStripMenuItem.Name = "TextBoxToolStripMenuItem";
            this.TextBoxToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.TextBoxToolStripMenuItem.Text = "텍스트박스";
            this.TextBoxToolStripMenuItem.Click += new System.EventHandler(this.TextBoxToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.helpToolStripMenuItem.Text = "도움말";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.AddExtension = false;
            this.saveFileDialog1.Filter = "PNG 파일 (*.PNG)|*.PNG";
            this.saveFileDialog1.FilterIndex = 2;
            this.saveFileDialog1.Title = "PNG 파일 저장하기";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PNG 파일 (*.PNG)|*.PNG";
            this.openFileDialog1.Title = "PNG 파일 불러오기";
            // 
            // toolBar1
            // 
            this.toolBar1.Location = new System.Drawing.Point(0, 31);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(1284, 35);
            this.toolBar1.TabIndex = 1;
            // 
            // drawBox1
            // 
            this.drawBox1.BackColor = System.Drawing.Color.White;
            this.drawBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.drawBox1.Location = new System.Drawing.Point(0, 61);
            this.drawBox1.Name = "drawBox1";
            this.drawBox1.Size = new System.Drawing.Size(1601, 608);
            this.drawBox1.TabIndex = 3;
            // 
            // MainView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1601, 669);
            this.Controls.Add(this.drawBox1);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "DrawTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem drawToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem SelectAllToolStripMenuItem;
        private ToolStripMenuItem UnselectAllToolStripMenuItem;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private ToolStripMenuItem DeleteAllToolStripMenuItem;
        private ToolStripMenuItem UndoToolStripMenuItem;
        private ToolStripMenuItem RedoToolStripMenuItem1;
        private ToolStripMenuItem PropertiesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem pointertoolStripMenuItem;
        private ToolStripMenuItem rectangletoolStripMenuItem;
        private ToolStripMenuItem EllipsetoolStripMenuItem;
        private ToolStripMenuItem linetoolStripMenuItem;
        private ToolStripMenuItem penciltoolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolBar.ToolBar toolBar1;
        private ToolStripMenuItem save_pngtoolStripMenuItem;
        private ToolStripMenuItem CapturetoolStripMenuItem;
        private DrawBox.DrawBox drawBox1;
        private ToolStripMenuItem TextBoxToolStripMenuItem;
    }
}