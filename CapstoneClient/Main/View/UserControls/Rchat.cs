using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Main.View.UserControls
{
    public partial class Rchat : UserControl
    {
        public int ChatPanelSize { get; set; }
        public string? Message
        {
            get
            {
                return lblContext.Text;
            }
            set
            {
                lblContext.Text = value;
                ChatLocation();
            }
        }

        public Rchat(int chatPanelSize, string str)
        {
            InitializeComponent();
            this.ChatPanelSize = chatPanelSize;
            Message = str;
        }

        public Rchat(int chatPanelSize, object obj)
        {
            InitializeComponent();
            this.ChatPanelSize = chatPanelSize;
            //this.object = obj;
        }

        private void Rchat_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        public void Initialize()
        {
            this.Dock = DockStyle.Top;
            //object 속성을 기반으로 내용을 채우는 메서드
            this.lblName.Text = "내 이름";
            //this.Message = "메시지";
            this.lblTime.Text = DateTime.Now.ToString("tt hh시 mm분");
        }

        public static int GetTextHeight(Label lbl)
        {
            using (Graphics g = lbl.CreateGraphics())
            {
                SizeF size = g.MeasureString(lbl.Text, lbl.Font);
                return (int)Math.Ceiling(size.Height);
            }
        }

        public static int GetTextWidth(Label lbl)
        {
            using (Graphics g = lbl.CreateGraphics())
            {
                SizeF size = g.MeasureString(lbl.Text, lbl.Font);
                return (int)Math.Ceiling(size.Width);
            }
        }

        private void ChatLocation()
        {
            lblContext.MaximumSize = new Size(ChatPanelSize / 3 * 2, 0);

            lblContext.Height = GetTextHeight(lblContext);
            lblContext.Width = GetTextWidth(lblContext);

            rbtnChat.Height = lblContext.Height + 17;
            rbtnChat.Width = lblContext.Width + 17;

            this.Height = rbtnChat.Bottom + 10;
            rbtnChat.Location = new Point(ChatPanelSize - rbtnChat.Width - 27, rbtnChat.Location.Y);
            lblContext.Location = new Point(ChatPanelSize - lblContext.Width - 35, lblContext.Location.Y);
            lblTime.Location = new Point(rbtnChat.Location.X - GetTextWidth(lblTime) - 5, rbtnChat.Location.Y + rbtnChat.Height - GetTextHeight(lblTime));
            lblName.Location = new Point(ChatPanelSize - GetTextWidth(lblName) - 37, lblName.Location.Y);
        }
    }
}
