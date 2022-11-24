using Main.Class;
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
    public partial class ChatMemberListItem : UserControl
    {
        public int Code { get; set; }
        public ChatMemberListItem()
        {
            InitializeComponent();
        }

        public ChatMemberListItem(object obj)
        {
            InitializeComponent();
            //this.object = obj;
        }
        private void ChatMemberListItem_Load(object sender, EventArgs e)
        {
            Initialize();
            if (ConnectInfo.Type == CONNECTTYPE.PROFESSOR) { btnRemove.Visible = true; }
        }
        public void Initialize()
        {
            this.Dock = DockStyle.Top;
            //object 속성을 기반으로 내용을 채우는 메서드
            this.lblName.Text = "유저명123456";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //삭제 요청 시 메시지를 띄우고, OK 클릭 시 이 객체에서 IsDeleted가 true인 객체를 전송함
            if (MessageBox.Show("정말로 퇴장시키시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
            }
            else
            {
            }
        }
    }
}
