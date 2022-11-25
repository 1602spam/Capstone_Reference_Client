using Main.Class;
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
    public partial class ChatListItem : UserControl
    {
        public ChatListItem()
        {
            InitializeComponent();
        }

        public ChatListItem(object obj)
        {
            InitializeComponent();
            //this.object = obj;
        }

        private void ChatMemberListItem_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        public void Initialize()
        {
            this.Dock = DockStyle.Top;
            //object 속성을 기반으로 내용을 채우는 메서드
            this.lblName.Text = "유저명123456";
        }

        private void ChatListItem_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                openItemMenu();
            }
        }
        private void openItemMenu()
        {
            var form = Application.OpenForms["FormChatListItemMenu"];
            if (form != null)
                form.Close();

            var newform = new FormChatListItemMenu();
            newform.Show();
            newform.Focus();
        }

        private void ChatListItem_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void ChatListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(220, 220, 220);
        }
    }
}
