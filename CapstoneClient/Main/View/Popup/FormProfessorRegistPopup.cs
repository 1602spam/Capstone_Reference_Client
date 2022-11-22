using Main.View.Professor;
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
    public partial class FormProfessorRegistPopup : Form
    {
        public FormProfessorRegistPopup()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //과목명 혹은 교수명이 공백일 때 알림
            if (tbClass.Text.Trim() == "")
            {
                MessageBox.Show("과목명을 입력하세요!", "알림");
            }
            else if (tbName.Text.Trim() == "")
            {
                MessageBox.Show("교수명을 입력하세요!", "알림");
            }

            //오류 시 리턴
            if (tbClass.Text.Trim() == "wrong")
            {
                return;
            }
            FormProfessor form = new();
            form.ShowDialog();
            this.Close();
        }
    }
}
