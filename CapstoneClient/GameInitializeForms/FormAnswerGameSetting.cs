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
                }
#pragma warning restore CS8602 // null 가능 참조에 대한 역참조입니다.
            }
            else
            {
                lbAnswer.Items.Add(tbAddAnswer.Text);
                tbAddAnswer.Clear();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            OpenGame();
        }

        private void OpenGame()
        {
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
    }
}
