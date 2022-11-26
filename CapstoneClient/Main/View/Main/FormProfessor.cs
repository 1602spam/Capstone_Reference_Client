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

namespace Main.View.Professor
{
    public partial class FormProfessor : Form
    {
        //레이블의 기본 문자열
        private string lblNameDef = "";         //교수명
        private string lblClassNameDef = "";    //수업명
        private string lblCodeDef = "";         //수업코드

        public FormProfessor()
        {
            InitializeComponent();
            this.InitializeMain();
            //레이블의 기본 문자열 설정
            lblNameDef = lblName.Text;
            lblClassNameDef = lblClassName.Text;
            lblCodeDef = lblCode.Text;
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            openChat();
        }
        private void btnGame_Click(object sender, EventArgs e)
        {
            openGame();
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

        private void openGame()
        {
            var form = Application.OpenForms["FormGamePopup"];
            if (form == null)
            {
                form = new FormGamePopup();
            }
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            form.Focus();
        }

        private void FormProfessor_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
