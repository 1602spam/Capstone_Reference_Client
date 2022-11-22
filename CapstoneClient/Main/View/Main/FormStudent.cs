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
        private string lblCodeDef = "";             //수업코드
        private string lblProfessorNameDef = "";    //교수명
        public FormStudent()
        {
            InitializeComponent();
            //레이블의 기본 문자열 설정
            lblNameDef = lblName.Text;
            lblClassNameDef = lblClassName.Text;
            lblCodeDef = lblCode.Text;
            lblProfessorNameDef = lblProfessorName.Text;
        }
        private void btnChat_Click(object sender, EventArgs e)
        {
            openChat();
        }
        private void btnNote_Click(object sender, EventArgs e)
        {
            openNote();
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
    }
}
