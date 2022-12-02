using Capstone_Reference_Game_Module;
using Capstone_Reference_GameServer;
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

namespace Main.View.Attachment
{
    public partial class FormOXGameSetting : Form
    {

        private int answer = 1;

        public FormOXGameSetting()
        {
            InitializeComponent();
            this.InitializeAttachment();
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            ActivateO();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            ActivateX();
        }

        private void ActivateO()
        {
            btnO.BackColor = Color.FromArgb(253, 253, 255);
            btnX.BackColor = Color.FromArgb(225, 225, 225);
            this.answer = 1;
        }
        
        private void ActivateX()
        {
            btnO.BackColor = Color.FromArgb(225, 225, 225);
            btnX.BackColor = Color.FromArgb(253, 253, 255);
            this.answer = 2;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbQuestion.Text.Trim() == String.Empty)
            {
                MessageBox.Show("질문을 입력하세요.", "알림");
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(cbTimeLimit.Text, "[^0-9]") && cbTimeLimit.Text!="없음")
            {
                MessageBox.Show("제한시간을 입력해주세요.");
            }
            else
            {
                OpenGame();
            }
        }

        private void OpenGame()
        {
            //질문
            string question = tbQuestion.Text;

            //정답이 O면 1, X면 2
            //this.answer

            //시간제한
            int time;
            if (cbTimeLimit.Text == "없음")
            { time = 0; }
            else
            { int.TryParse(cbTimeLimit.Text, out time); }

            Game game = new();
            game.StartOXQuiz(question,time,answer);

            game.JoinAsServer();

            game.JoinAsClient("127.0.0.1", "12345", "jin");
            game.JoinAsClient("127.0.0.1", "123456", "jin2");
            game.JoinAsClient("127.0.0.1", "123457", "jin3");
            game.JoinAsClient("127.0.0.1", "123458", "jin4");

            var f = Application.OpenForms["FormGamePopup"];
            if (f != null)
            {
                f.Close();
            }
            this.Close();
        }

        private void FormOXGameSetting_Load(object sender, EventArgs e)
        {
            ActivateO();
        }

        private void cbTimeLimit_TextUpdate(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(cbTimeLimit.Text, "[^0-9]"))
            {
                MessageBox.Show("제한시간에는 숫자만 입력할 수 있습니다.", "알림");
                cbTimeLimit.Text = cbTimeLimit.Text.Remove(cbTimeLimit.Text.Length - 1);
            }
        }
    }
}
