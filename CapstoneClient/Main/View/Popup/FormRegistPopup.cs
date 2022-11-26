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
        //CONNECTTYPE.PROFESSOR일 경우 tbClass는 수업명, tbName은 교수명
        //CONNECTTYPE.STUDENT일 경우 tbClass는 학번, tbName 학생명, tbIP는 IP

        public FormRegistPopup(int connectType)
        {
            InitializeComponent();
            this.InitializePopup();

            this.connectType = connectType;

            if (CONNECTTYPE.PROFESSOR == this.connectType)
            {
                lblIP.Visible = false;
                panIP.Visible = false;
            }
            else if (CONNECTTYPE.STUDENT == this.connectType)
            {
                this.Text = "학생으로 접속";
                lblClass.Text = "학번";
                lblName.Text = "학생명";
            }

            //접속 정보 수신 시 호출할 이벤트 등록
            //Event+=OnConnected;
        }

        private void OnConnected()
        {
            //static 클래스인 ConnectInfo의 값을 설정함
            ConnectInfo.Type = CONNECTTYPE.STUDENT;
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

                //테스트용, 접속 정보를 교수로 설정함
                ConnectInfo.Type = CONNECTTYPE.PROFESSOR;

                //접속 정보를 송신하고 대기, 응답이 오면 새 창을 띄움
                if (!SendConnectRequestAndWait())
                {
                    return;
                }

                FormProfessor form = new();
                form.Load += new EventHandler(CloseWindow);
                form.FormClosed += new FormClosedEventHandler(CloseMainWindow);
                form.Show();
                return;
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

                //테스트용, 접속 정보를 교수로 설정함
                ConnectInfo.Type = CONNECTTYPE.STUDENT;

                //접속 정보를 송신하고 대기, 응답이 오면 새 창을 띄움
                if (!SendConnectRequestAndWait())
                {
                    return;
                }

                FormStudent form = new();
                form.Load += new EventHandler(CloseWindow);
                form.FormClosed += new FormClosedEventHandler(CloseMainWindow);
                form.Show();
                return;
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
            btnConnect.Enabled = false;
            if (CONNECTTYPE.PROFESSOR == this.connectType)
            {
                ServerSystem.ServerSystem server = new();
                //ClientContainer.Instance.setOwner();
                Task.Delay(50).Wait();
                ClientSystem.ClientSystem user = new();
                //user.Login()
            }
            else //(CONNECTTYPE.STUDENT == this.connectType)
            {
                ClientSystem.ClientSystem user = new();
            }
            //응답 대기
            Task.Delay(50);
            btnConnect.Enabled = true;
            //처리 결과에 따라 true/false 리턴
            return true;
        }
    }
}
