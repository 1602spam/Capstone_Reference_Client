using Main.Class;
using Main.View.Professor;
using Main.View.Student;
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
    public partial class FormRegistPopup : Form
    {
        private int connectType = 0;

        //connectType은 CONNECTTYPE.PROFESSOR 혹은 CONNECTTYPE.STUDENT
        //CONNECTTYPE.PROFESSOR일 경우 tbClass는 과목명, tbName은 교수명
        //CONNECTTYPE.STUDENT일 경우 tbClass는 과목코드, tbName은 학생명

        public FormRegistPopup(int connectType)
        {
            InitializeComponent();
            this.InitializePopup();

            this.connectType = connectType;

            if (CONNECTTYPE.PROFESSOR == this.connectType)
            {

            }
            else if (CONNECTTYPE.STUDENT == this.connectType)
            {
                lblClass.Text = "과목코드";
                lblName.Text = "학생명";
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (CONNECTTYPE.PROFESSOR == this.connectType)
            {
                //과목명 혹은 교수명이 공백일 때 알림
                if (tbName.Text.Trim() == "")
                {
                    MessageBox.Show("교수명을 입력하세요!", "알림");
                    return;
                }
                else if (tbClass.Text.Trim() == "")
                {
                    MessageBox.Show("과목명을 입력하세요!", "알림");
                    return;
                }

                //접속 정보를 송신하고 대기, 응답이 오면 새 창을 띄움
                if (!SendConnectRequestAndWait())
                {
                    return;
                }

                FormProfessor form = new();
                form.Load += new EventHandler(CloseWindow);
                form.FormClosed += new FormClosedEventHandler(CloseMainWindow);
                form.Show();
            }
            else //(CONNECTTYPE.STUDENT == this.connectType)
            {
                //학생명 또는 과목코드가 공백일 때 알림
                if (tbName.Text.Trim() == "")
                {
                    MessageBox.Show("학생명을 입력하세요!", "알림");
                    return;
                }
                else if (tbClass.Text.Trim() == "")
                {
                    MessageBox.Show("과목코드를 입력하세요!", "알림");
                    return;
                }

                //접속 정보를 송신하고 대기, 응답이 오면 새 창을 띄움
                if (!SendConnectRequestAndWait())
                {
                    return;
                }

                FormStudent form = new();
                form.Load += new EventHandler(CloseWindow);
                form.FormClosed += new FormClosedEventHandler(CloseMainWindow);
                form.Show();

            }
            
        }

        private void CloseWindow(object? sender, EventArgs e)
        {
            FormRegist.Instance.Visible = false;
            this.Close();
        }

        private void CloseMainWindow(object? sender, EventArgs e)
        {
            FormRegist.Instance.Close();
        }

        private bool SendConnectRequestAndWait()
        {
            if (CONNECTTYPE.PROFESSOR == this.connectType)
            {
                //교수 접속 정보 송신(과목명: tbClass.Text, 교수명: tbName.Text)
            }
            else //(CONNECTTYPE.STUDENT == this.connectType)
            {
                //학생 접속 정보 송신(과목코드: tbClass.Text, 학생명: tbName.Text)
            }
            //응답 대기
            Task.Delay(100).Wait();
            //처리 결과에 따라 값 설정

            return true;
        }
    }
}
