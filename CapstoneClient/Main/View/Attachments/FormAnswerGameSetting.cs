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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Main.View.Attachment
{
    public partial class FormAnswerGameSetting : Form
    {
        public FormAnswerGameSetting()
        {
            InitializeComponent();
            this.InitializeAttachment();
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            if (tbAddAnswer.Text.Trim() == String.Empty)
                return;

            //선택한 게 있으면
            int i = lbAnswer.SelectedIndex;
            if (i != -1)
            {
#pragma warning disable CS8602 // null 가능 참조에 대한 역참조입니다.
                if (lbAnswer.Items[i].ToString().Trim() != string.Empty)
                {
                    lbAnswer.Items.RemoveAt(i);
                    lbAnswer.Items.Insert(i, tbAddAnswer.Text);
                    tbAddAnswer.Clear();
                    btnRemove.Enabled = false;
                    btnAddAnswer.Text = "추가";
                }
#pragma warning restore CS8602 // null 가능 참조에 대한 역참조입니다.
            }
            else //선택한 게 없으면
            {
                if (lbAnswer.Items.Count < 5)
                {
                    lbAnswer.Items.Add(tbAddAnswer.Text);
                    tbAddAnswer.Clear();
                }
                else
                {
                    MessageBox.Show("보기는 최대 5개까지 등록할 수 있습니다.","알림");
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbQuestion.Text.Trim() == String.Empty)
            {
                MessageBox.Show("질문을 입력하세요.", "알림");
            }
            else if (lbAnswer.Items.Count < 1)
            {
                MessageBox.Show("최소 1개의 보기를 등록하세요.", "알림");
            }
            else if (lbAnswer.CheckedItems.Count != 1)
            {
                MessageBox.Show("정답이 체크되었는지 확인하세요.", "알림");
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(cbTimeLimit.Text, "[^0-9]"))
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
            //문제
            string question = tbQuestion.Text;

            //보기
            List<string> answers = new();
            foreach (string item in lbAnswer.Items)
            {
                answers.Add(item);
            }
            //정답 인덱스
            int index = lbAnswer.SelectedIndex;

            //시간제한
            string time = cbTimeLimit.Text;

            //주관식 게임 실행 함수
            //run();
            MessageBox.Show("미구현","알림");
        }

        private void lbAnswer_SelectedIndexChanged(object sender, EventArgs e)
        {
            InvalidateBtnRemove();
        }

        private void InvalidateBtnRemove()
        {
            int i = lbAnswer.SelectedIndex;
            if (i != -1)
            {
#pragma warning disable CS8602 // null 가능 참조에 대한 역참조입니다.
                if (lbAnswer.Items[i].ToString().Trim() != string.Empty)
                {
                    btnRemove.Enabled = true;
                    btnAddAnswer.Text = "수정";
                }
                else
                {
                    btnRemove.Enabled = false;
                    btnAddAnswer.Text = "추가";
                }
#pragma warning restore CS8602 // null 가능 참조에 대한 역참조입니다.
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int i = lbAnswer.SelectedIndex;
            if (i != -1)
            {
                lbAnswer.Items.RemoveAt(i);
                btnRemove.Enabled = false;
                btnAddAnswer.Text = "추가";
            }
        }

        private void lbAnswer_MouseDown(object sender, MouseEventArgs e)
        {
            if ((lbAnswer.ItemHeight * lbAnswer.Items.Count) < e.Y)
            {
                // listbox 선택이 해제 되었을 때
                lbAnswer.SelectedIndex = -1;
                btnRemove.Enabled = false;
                btnAddAnswer.Text = "추가";
            }
        }

        private void lbAnswer_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            lbAnswer.ItemCheck -= lbAnswer_ItemCheck;

            int j = e.Index;
            for (int i = 0; i < lbAnswer.Items.Count; i++)
            {
                if (i == j) { continue; }
                lbAnswer.SetItemChecked(i, false);
            }

            lbAnswer.ItemCheck += lbAnswer_ItemCheck;
        }

        private void cbTimeLimit_TextUpdate(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(cbTimeLimit.Text, "[^0-9]"))
            {
                MessageBox.Show("제한시간에는 숫자만 입력할 수 있습니다.","알림");
                cbTimeLimit.Text = cbTimeLimit.Text.Remove(cbTimeLimit.Text.Length - 1);
            }
        }
    }
}
