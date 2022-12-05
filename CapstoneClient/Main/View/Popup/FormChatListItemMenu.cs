using Main.Class;
using ServerSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.View.Popup
{
    public partial class FormChatListItemMenu : Form
    {
        private int id;
        public FormChatListItemMenu(int id)
        {
            InitializeComponent();
            this.id = id;

            if (ConnectInfo.Type == CONNECTTYPE.PROFESSOR)
            {
                Button rem = new();
                rem.Text = "강제 퇴장";
                panButton.Controls.Add(rem);
                rem.Dock = DockStyle.Top;
                rem.FlatStyle = FlatStyle.Flat;
                rem.FlatAppearance.BorderSize = 0;
                rem.TextAlign = ContentAlignment.MiddleLeft;
                rem.Click += RemoveRequest;
            }

            Button dm = new();
            dm.Text = "귓속말 보내기";
            panButton.Controls.Add(dm);
            dm.Dock = DockStyle.Top;
            dm.FlatStyle = FlatStyle.Flat;
            dm.FlatAppearance.BorderSize = 0;
            dm.TextAlign = ContentAlignment.MiddleLeft;
            dm.Click += delegate (object? s, EventArgs e)
            {
                var form = Application.OpenForms["FormChatPopup"];
                if (form != null)
                {
                    FormChatPopup? f = form as FormChatPopup;
                    if (f != null)
                        f.SetLocation(id);
                }
                FocusChat();
                this.Close();
            };

            this.Height = panButton.Height;
        }

        private void RemoveRequest(object? s, EventArgs e)
        {
            this.Deactivate -= FormChatListItemMenu_Deactivate;
            //삭제 요청 시 메시지를 띄우고, OK 클릭 시 이 객체에서 IsDeleted가 true인 객체를 전송함
            if (MessageBox.Show("정말로 퇴장시키시겠습니까?", "알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //유저정보 송신
                if (ConnectInfo.user!=null)
                    ClientContainer.Instance.RemoveUser(ClientContainer.Instance.loginDict[ConnectInfo.user.studentID],id);
                FocusChatList();
                this.Close();
            }
            else
            {
                FocusChatList();
                this.Close();
            }
        }

        private void FocusChatList() {
            var form = Application.OpenForms["FormChatListPopup"];
            if (form == null)
            {
                this.Close();
                return;
            }
            form.Focus();
        }

        private void FocusChat()
        {
            var form = Application.OpenForms["FormChatPopup"];
            if (form == null)
            {
                this.Close();
                return;
            }
            form.Focus();
        }

        private void FormChatListItemMenu_Deactivate(object? sender, EventArgs e)
        {
            FocusChatList();
            this.Close();
        }

        private void FormChatListItemMenu_Load(object sender, EventArgs e)
        {
            Point p = new Point(Cursor.Position.X, Cursor.Position.Y);
            this.Location = p;
        }
    }
}
