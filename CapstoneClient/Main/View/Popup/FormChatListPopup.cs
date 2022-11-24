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

namespace Main.View.Popup
{
    public partial class FormChatListPopup : Form
    {

        public FormChatListPopup()
        {
            InitializeComponent();
            this.InitializePopup();
            //멤버 추가 이벤트 발생 시 호출할 메서드 등록
            //Event += AddMember;
        }

        private void OnMemberReceived(object member)
        {
            //멤버 추가 이벤트 발생 시 호출됨
            //기존 유저를 패널과 리스트에서 찾았다면 ReplaceMember를 호출
            //int index = List.FindIndex(object => object.code == "1");
            //찾지 못했다면 멤버 컴포넌트를 패널과 리스트 말미에 추가함
        }

        private void ReplaceMember(int i, object newMember)
        {
            //멤버 갱신 이벤트 발생 시 동일한 유저 코드를 찾았다면
            //패널과 리스트에서 해당 유저의 인덱스를 삭제하고
            //신규 유저의 IsDeleted 코드가 false라면 AddMemberByIndex를 호출
        }

        private void AddMember(object member)
        {
            //패널과 리스트 말미에 멤버를 추가함
        }

        private void AddMemberByIndex(int i, object member)
        {
            //패널과 리스트에서 해당 인덱스에 멤버를 추가함
        }
    }
}
