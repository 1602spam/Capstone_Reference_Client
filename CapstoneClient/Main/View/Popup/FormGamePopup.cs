using Main.Class;
using Main.View.Attachments;
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
    public partial class FormGamePopup : Form
    {
        public FormGamePopup()
        {
            InitializeComponent();
            this.InitializePopup();
        }

        private void OpenGameSelect()
        {
            FormGameSelect form = new FormGameSelect();
            panMain.Controls.Add(form);
            form.Show();
        }

        private void FormGamePopup_Load(object sender, EventArgs e)
        {
            if (ConnectInfo.Type == CONNECTTYPE.PROFESSOR)
            { OpenGameSelect(); }
        }
    }
}
