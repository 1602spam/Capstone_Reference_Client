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

        private bool isO = true;

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
            this.isO = true;
        }
        
        private void ActivateX()
        {
            btnO.BackColor = Color.FromArgb(225, 225, 225);
            btnX.BackColor = Color.FromArgb(253, 253, 255);
            this.isO = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            OpenGame();
        }

        private void OpenGame()
        {
        }

        private void FormOXGameSetting_Load(object sender, EventArgs e)
        {
            ActivateO();
        }
    }
}
