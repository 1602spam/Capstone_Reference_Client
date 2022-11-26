using Main.Class;
using Main.Class.vo;
using Main.View.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Runtime.InteropServices.ObjectiveC;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.View.Popup
{
    public partial class FormChatPopup : Form
    {
        public List<Lchat> Lchats = new();
        public List<Rchat> Rchats = new();

        private int idLocation = 0;

        private String lblLocationDef = "";

        public FormChatPopup()
        {
            InitializeComponent();
            lblLocationDef = lblLocation.Text;
            lblLocation.Text += " 전체에게";
            lblLocationToAll.Visible = false;
            this.InitializePopup();
            if(ConnectInfo.user!=null)
                ConnectInfo.user.MessageEvent += OnMessageReceived;
            //메시지 추가 이벤트 발생 시 호출할 메서드 등록
            //Event += AddChat;
        }
        
        private void OnMessageReceived(string name, string content, bool isMe, bool isWhisper)
        {
            MdlMessage msg = new(name, content, isMe, isWhisper);
            //메시지 추가 이벤트 발생 시에
            //객체 속성 중 송신자를 비교해서 다른 사람이면 AddLChat(message,onTop), 나 자신이라면 AddRChat(message,onTop)을 호출함
            if (isMe)
                AddRChat(msg, false);
            else
                AddLChat(msg, false);
        }

        private void AddLChat(object message, bool onTop)
        {
            Lchat lchat = new Lchat(panMessage.Width, message);
            Lchats.Add(lchat);
            panMessage.Controls.Add(lchat);
            if(onTop) {lchat.SendToBack();} else {lchat.BringToFront();}
        }

        private void AddRChat(object message, bool onTop)
        {
            Rchat rchat = new Rchat(panMessage.Width, rtbChat.Text);
            Rchats.Add(rchat);
            panMessage.Controls.Add(rchat);
            if(onTop) {rchat.SendToBack();} else {rchat.BringToFront();}
        }

        private void AddLChat()
        {
            //테스트용으로 채팅창 문자열대로 객체를 만들고 표시함
            Lchat lchat = new Lchat(panMessage.Width, rtbChat.Text);
            Lchats.Add(lchat);
            panMessage.Controls.Add(lchat);
            lchat.BringToFront();
        }

        private void AddRChat()
        {
            //테스트용으로 채팅창 문자열대로 객체를 만들고 표시함
            Rchat rchat = new Rchat(panMessage.Width, rtbChat.Text);
            Rchats.Add(rchat);
            panMessage.Controls.Add(rchat);
            rchat.BringToFront();
        }

        private void SendChat()
        {
            //채팅 보내기 버튼 클릭 시
            if (rtbChat.Text.Trim().Length == 0)
                return;

            rtbChat.Text = rtbChat.Text.Trim();

            //메시지 객체화해서 전송
            if(ConnectInfo.user!=null)
                ConnectInfo.user.SendMessage(rtbChat.Text);

            //채팅창 초기화
            rtbChat.Text = String.Empty;
            //채팅창 포커스
            rtbChat.Focus();
            //메시지 패널 맨 아래를 표시하도록 함
            panMessage.AutoScrollPosition = new Point(0, 9999999);
        }

        private void btnChatList_Click(object sender, EventArgs e)
        {
            //채팅 참여자 목록 버튼 클릭 시
            OpenChatList();
        }

        public void SetLocation(int id)
        {
            if (-1 != id)
            {
                this.idLocation = id;
                lblLocationToAll.Visible = true;
                lblLocation.Text = lblLocationDef + " (DM) " + "유저명";
                lblLocation.ForeColor = Color.Blue;
            }
            else
            {
                this.idLocation = id;
                lblLocationToAll.Visible = false;
                lblLocation.Text = lblLocationDef + " 전체에게";
                lblLocation.ForeColor = Color.Black;
            }
        }

        private void OpenChatList()
        {
            //채팅 참여자 목록 열기
            var form = Application.OpenForms["FormChatListPopup"];
            if (form == null)
            {
                form = new FormChatListPopup();
            }
            this.FormClosed += delegate (object? sender, FormClosedEventArgs e) { form.Close(); };
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show();
            form.Focus();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendChat();
        }

        private void lblLocationToAll_Click(object sender, EventArgs e)
        {
            SetLocation(0);
        }
    }
}
