namespace Canvas_module.DrawBox
{
	partial class DrawBox
	{
		/// <summary> 
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 구성 요소 디자이너에서 생성한 코드

		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawBox));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SelectAlltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnselectAlltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAlltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.UndotoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedotoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PropertiestoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAlltoolStripMenuItem,
            this.UnselectAlltoolStripMenuItem,
            this.DeletetoolStripMenuItem,
            this.DeleteAlltoolStripMenuItem,
            this.toolStripSeparator1,
            this.UndotoolStripMenuItem,
            this.RedotoolStripMenuItem,
            this.toolStripSeparator2,
            this.PropertiestoolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 184);
            // 
            // SelectAlltoolStripMenuItem
            // 
            this.SelectAlltoolStripMenuItem.Name = "SelectAlltoolStripMenuItem";
            this.SelectAlltoolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.SelectAlltoolStripMenuItem.Text = "전체 선택";
            this.SelectAlltoolStripMenuItem.Click += new System.EventHandler(this.SelectAlltoolStripMenuItem_Click);
            // 
            // UnselectAlltoolStripMenuItem
            // 
            this.UnselectAlltoolStripMenuItem.Name = "UnselectAlltoolStripMenuItem";
            this.UnselectAlltoolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.UnselectAlltoolStripMenuItem.Text = "전체 해제";
            this.UnselectAlltoolStripMenuItem.Click += new System.EventHandler(this.UnselectAlltoolStripMenuItem_Click);
            // 
            // DeletetoolStripMenuItem
            // 
            this.DeletetoolStripMenuItem.Name = "DeletetoolStripMenuItem";
            this.DeletetoolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.DeletetoolStripMenuItem.Text = "삭제하기";
            this.DeletetoolStripMenuItem.Click += new System.EventHandler(this.DeletetoolStripMenuItem_Click);
            // 
            // DeleteAlltoolStripMenuItem
            // 
            this.DeleteAlltoolStripMenuItem.Name = "DeleteAlltoolStripMenuItem";
            this.DeleteAlltoolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.DeleteAlltoolStripMenuItem.Text = "전체 삭제하기";
            this.DeleteAlltoolStripMenuItem.Click += new System.EventHandler(this.DeleteAlltoolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // UndotoolStripMenuItem
            // 
            this.UndotoolStripMenuItem.Name = "UndotoolStripMenuItem";
            this.UndotoolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.UndotoolStripMenuItem.Text = "실행 취소";
            this.UndotoolStripMenuItem.Click += new System.EventHandler(this.UndotoolStripMenuItem_Click);
            // 
            // RedotoolStripMenuItem
            // 
            this.RedotoolStripMenuItem.Name = "RedotoolStripMenuItem";
            this.RedotoolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.RedotoolStripMenuItem.Text = "다시 실행";
            this.RedotoolStripMenuItem.Click += new System.EventHandler(this.RedotoolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // PropertiestoolStripMenuItem
            // 
            this.PropertiestoolStripMenuItem.Name = "PropertiestoolStripMenuItem";
            this.PropertiestoolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.PropertiestoolStripMenuItem.Text = "속성 설정하기";
            this.PropertiestoolStripMenuItem.Click += new System.EventHandler(this.PropertiestoolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(898, 549);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // DrawBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.pictureBox1);
            this.Name = "DrawBox";
            this.Size = new System.Drawing.Size(927, 576);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawBox_Paint_1);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DrawBox_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawBox_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawBox_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawBox_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem SelectAlltoolStripMenuItem;
		private ToolStripMenuItem UnselectAlltoolStripMenuItem;
		private ToolStripMenuItem DeletetoolStripMenuItem;
		private ToolStripMenuItem DeleteAlltoolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem UndotoolStripMenuItem;
		private ToolStripMenuItem RedotoolStripMenuItem;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripMenuItem PropertiestoolStripMenuItem;
		private PictureBox pictureBox1;
	}
}
