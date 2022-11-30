using Main.Class;
using Main.Class.vo;
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
        public MdlMessage ?msg { get; set; }

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
            if (obj != null)
            {
                this.msg = obj as MdlMessage;
            }
        }

        private void DMCheck()
        {
            if (this.msg != null)
            {
                if (this.msg.IsWhisper == true)
                {
                    if (ConnectInfo.user != null)
                    {
                        lblName.Text = "(DM) " + "받는사람이름" + " <= " + ConnectInfo.user.name;
                        lblName.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void Rchat_Load(object sender, EventArgs e)
        {
            Initialize();
        }


        public void Initialize()
        {
            this.Dock = DockStyle.Top;

            if (ConnectInfo.user != null)
            {
                this.lblName.Text = ConnectInfo.user.name;
            }
            DMCheck();
            if(this.msg!=null)
            this.Message = msg.Content;
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
            lblContext.MaximumSize = new Size(ChatPanelSize / 3 * 2 - 50, 0);

            lblContext.Height = GetTextHeight(lblContext);
            lblContext.Width = GetTextWidth(lblContext);

            rbtnChat.Height = lblContext.Height + 17;
            rbtnChat.Width = lblContext.Width + 17;

            this.Height = rbtnChat.Bottom + 10;
            rbtnChat.Location = new Point(ChatPanelSize - rbtnChat.Width - 27, rbtnChat.Location.Y);
            lblContext.Location = new Point(ChatPanelSize - lblContext.Width - 35, lblContext.Location.Y);
            lblTime.Location = new Point(rbtnChat.Location.X - GetTextWidth(lblTime) - 25, rbtnChat.Location.Y + rbtnChat.Height - GetTextHeight(lblTime));
            lblName.Location = new Point(ChatPanelSize - GetTextWidth(lblName) - 26, lblName.Location.Y);
        }
    }
}
