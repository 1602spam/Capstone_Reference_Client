using Main.Class;
using Main.Class.vo;
using Main.View.Popup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.View.UserControls
{
    public partial class Lchat : UserControl
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
                SetChatLocation();
            }
        }

        public MdlMessage? msg { get; set; }

        public Lchat(int chatPanelSize, string str)
        {
            InitializeComponent();
            this.ChatPanelSize = chatPanelSize;
            Message = str;
        }

        public Lchat(int chatPanelSize, object obj)
        {
            InitializeComponent();
            this.ChatPanelSize = chatPanelSize;
            //this.object = obj;
            this.msg = obj as MdlMessage;
        }

        private void DMCheck()
        {
            if (this.msg != null)
                if(this.msg.IsWhisper==true)
                {
                    if (ConnectInfo.user != null)
                    {
                        lblName.Text = "(DM) " + msg.Name + " => " + ConnectInfo.user.name;
                        lblName.ForeColor = Color.Blue;
                    }
                }
        }

        private void Lchat_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        public void Initialize()
        {
            this.Dock = DockStyle.Top;
            this.lblTime.Text = DateTime.Now.ToString("tt hh시 mm분");
            //object 속성을 기반으로 내용을 채우는 메서드
            if (this.msg != null)
            {
                this.Message = msg.Content;
                this.lblName.Text = msg.Name;
            }
            DMCheck();
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

        private void SetChatLocation()
        {
            // 패널의 최대크기
            lblContext.MaximumSize = new Size(ChatPanelSize / 3 * 2 - 50, 0);

            // 메시지 내용 레이블의 높이, 넓이 지정
            lblContext.Height = GetTextHeight(lblContext);
            lblContext.Width = GetTextWidth(lblContext);

            // 패널의 높이, 넓이 지정
            rbtnChat.Height = lblContext.Height + 17;
            rbtnChat.Width = lblContext.Width + 17;

            // 배경패널의 높이 지정
            //this.Height = rbtnChat.Bottom + 10;

            // 시간 레이블의 위치 지정
            lblTime.Location = new Point(rbtnChat.Location.X + rbtnChat.Width, rbtnChat.Location.Y + rbtnChat.Height - GetTextHeight(lblTime) + 2);
            this.Height = lblTime.Bottom + 10;
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms["FormChatPopup"];
            if (form != null)
            {
                FormChatPopup? f = form as FormChatPopup;
                if (f != null)
                {
                    if (ConnectInfo.user != null) {
                        //메시지의 id
                        int id = -1;
                        }
                    //f.SetLocation(id);
                }
            }
        }
    }
}
