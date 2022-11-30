using Main.Class;
using Main.View.Attachment;
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

namespace Main.View.Attachments
{
    public partial class FormGameSelect : Form
    {
        public FormGameSelect()
        {
            InitializeComponent();
            this.InitializeAttachment();
        }

        private void btnSelectChoice_Click(object sender, EventArgs e)
        {
            OpenChoiceSetting();
        }

        private void btnSelectAnswer_Click(object sender, EventArgs e)
        {
            OpenAnswerSetting();
        }
        private void btnSelectOX_Click(object sender, EventArgs e)
        {
            OpenOXSetting();
        }
        private void OpenChoiceSetting()
        {
            var f1 = Application.OpenForms["FormChoiceGameSetting"];
            if (f1 != null)
                return;

            var f2 = Application.OpenForms["FormAnswerGameSetting"];
            if (f2 != null)
            {
                f2.Close();
            }
            var f3 = Application.OpenForms["FormOXGameSetting"];
            if (f3 != null)
            {
                f3.Close();
            }
            
            FormChoiceGameSetting form = new();
            panMain.Controls.Add(form);
            form.Show();

            btnSelectChoice.BackColor = Color.FromArgb(253, 253, 255);
            btnSelectAnswer.BackColor = Color.FromArgb(225, 225, 225);
            btnSelectOX.BackColor = Color.FromArgb(225, 225, 225);
        }

        private void OpenAnswerSetting()
        {
            var f1 = Application.OpenForms["FormAnswerGameSetting"];
            if (f1 != null)
                return;

            var f2 = Application.OpenForms["FormChoiceGameSetting"];
            if (f2 != null)
            {
                f2.Close();
            }
            var f3 = Application.OpenForms["FormOXGameSetting"];
            if (f3 != null)
            {
                f3.Close();
            }

            FormAnswerGameSetting form = new();
            panMain.Controls.Add(form);
            form.Show();

            btnSelectChoice.BackColor = Color.FromArgb(225, 225, 225);
            btnSelectAnswer.BackColor = Color.FromArgb(253, 253, 255);
            btnSelectOX.BackColor = Color.FromArgb(225, 225, 225);
        }

        private void OpenOXSetting()
        {
            var f1 = Application.OpenForms["FormOXGameSetting"];
            if (f1 != null)
                return;

            var f2 = Application.OpenForms["FormChoiceGameSetting"];
            if (f2 != null)
            {
                f2.Close();
            }
            var f3 = Application.OpenForms["FormAnswerGameSetting"];
            if (f3 != null)
            {
                f3.Close();
            }

            FormOXGameSetting form = new();
            panMain.Controls.Add(form);
            form.Show();

            btnSelectChoice.BackColor = Color.FromArgb(225, 225, 225);
            btnSelectAnswer.BackColor = Color.FromArgb(225, 225, 225);
            btnSelectOX.BackColor = Color.FromArgb(253, 253, 255);
        }

        private void FormGameSelect_Load(object sender, EventArgs e)
        {
            FormChoiceGameSetting form = new();
            panMain.Controls.Add(form);
            form.Show();
            btnSelectChoice.BackColor = Color.FromArgb(253, 253, 255);
            btnSelectAnswer.BackColor = Color.FromArgb(225, 225, 225);
            btnSelectOX.BackColor = Color.FromArgb(225, 225, 225);
        }


    }
}
