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
            if (tbAddAnswer.Text.Trim() == null)
                return;

            lbAnswer.Items.Add(tbAddAnswer.Text);
            tbAddAnswer.Clear();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            OpenGame();
        }

        private void OpenGame()
        {
        }
    }
}
