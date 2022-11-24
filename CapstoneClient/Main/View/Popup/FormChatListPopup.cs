using Main.Class;
using Main.View.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.View.Popup
{
    public partial class FormChatListPopup : Form
    {

        List<ChatMemberListItem> ChatMemberListItems = new();

        public FormChatListPopup()
        {
            InitializeComponent();
            this.InitializePopup();
            //멤버 추가 이벤트 발생 시 호출할 메서드 등록
            //Event += AddMember;

            //테스트용 멤버 추가
            AddMember(new ChatMemberListItem());
            AddMember(new ChatMemberListItem());
            AddMember(new ChatMemberListItem());
            AddMember(new ChatMemberListItem());
        }

        private void OnMemberReceived(object member)
        {
            //멤버 추가 이벤트 발생 시 호출됨
            ChatMemberListItem newMember = (ChatMemberListItem)member;
            //기존 유저를 패널과 리스트에서 찾았다면 ReplaceMemberByIndex를 호출
            int index = ChatMemberListItems.FindIndex(ChatMemberListItem => ChatMemberListItem.Code == newMember.Code);
            //찾지 못했다면 멤버 컴포넌트를 패널과 리스트 말미에 추가함
            if (-1 == index)
            {
                //newMember의 IsDeleted 코드가 false라면 AddMember 호출
                AddMember(newMember);
            }
            else
            {
                ReplaceMemberByIndex(index, newMember);
            }
        }

        private void ReplaceMemberByIndex(int i, ChatMemberListItem newMember)
        {
            //멤버 갱신 이벤트 발생 시 동일한 유저 코드를 찾았다면
            //패널과 리스트에서 해당 유저의 인덱스를 삭제하고
            //newMember의 IsDeleted 코드가 false라면 AddMemberByIndex를 호출
        }

        private void AddMember(ChatMemberListItem member)
        {
            //패널과 리스트 말미에 멤버를 추가함
            ChatMemberListItem item = new();
            ChatMemberListItems.Add(item);
            panChatMemberList.Controls.Add(item);
            item.BringToFront();
        }
    }
}