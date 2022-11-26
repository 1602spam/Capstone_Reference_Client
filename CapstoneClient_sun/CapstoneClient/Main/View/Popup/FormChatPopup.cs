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
    public partial class FormChatPopup : Form
    {
        public FormChatPopup()
        {
            InitializeComponent();
        }

        private void btnChatList_Click(object sender, EventArgs e)
        {
            openChatList();
        }

        private void openChatList()
        {
            var form = Application.OpenForms["FormChatListPopup"];
            if (form == null)
            {
                form = new FormChatListPopup();
            }
            this.FormClosed += delegate (object? sender, FormClosedEventArgs e) { form.Close(); };
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show();
            form.Focus();
        }
    }
}
