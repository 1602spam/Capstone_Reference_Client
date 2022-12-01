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

namespace Main.View.Student
{
    public partial class FormStudent : Form
    {
        //레이블의 기본 문자열
        private string lblNameDef = "";             //학생명
        private string lblClassNameDef = "";        //수업명
        private string lblProfessorNameDef = "";    //교수명
        private string lblIDDef = "";
        public FormStudent()
        {
            InitializeComponent();
            this.InitializeMain();
            //레이블의 기본 문자열 설정
            lblNameDef = lblName.Text + " ";
            lblClassNameDef = lblClassName.Text + " ";
            lblProfessorNameDef = lblProfessorName.Text + " ";
            lblIDDef = lblID.Text + " ";

            if (ConnectInfo.user != null)
            {
                lblName.Text = lblNameDef + ConnectInfo.user.name;
                lblID.Text = lblIDDef + ConnectInfo.user.studentID;
                if (ConnectInfo.user.userList.Keys.Contains(-1))
                {
                    lblProfessorName.Text = lblProfessorNameDef + ConnectInfo.user.userList.GetValueOrDefault(-1);
                }
            }
            lblClassName.Text = lblClassNameDef + ConnectInfo.ClassName;

            //게임 초대 이벤트 발생 시 수락 거절 창 띄우는 메서드 등록
            //Event += openGameInvitation(object obj)
        }
        private void btnChat_Click(object sender, EventArgs e)
        {
            openChat();
        }
        private void btnNote_Click(object sender, EventArgs e)
        {
            openNote();
        }

        private void openGameInvitation(object obj)
        {
            var form = Application.OpenForms["FormGameInvitation"];
            if (form != null)
                form.Close();

            var newform = new FormGameInvitation();
            newform.StartPosition = FormStartPosition.CenterScreen;
            newform.Show();
            newform.Focus();
        }

        private void openChat()
        {
            var form = Application.OpenForms["FormChatPopup"];
            if (form == null)
            {
                form = new FormChatPopup();
            }
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            form.Focus();
        }

        private void openNote()
        {
            var form = Application.OpenForms["FormNotePopup"];
            if (form == null)
            {
                form = new FormNotePopup();
            }
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            form.Focus();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(153 - 10, 180 - 10, 209 - 10);
        }
    }
}
