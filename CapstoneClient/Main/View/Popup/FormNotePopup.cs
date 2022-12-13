using Canvas_module;
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

namespace Main.View.Popup
{
    public partial class FormNotePopup : Form
    {
        public FormNotePopup()
        {
            InitializeComponent();
            this.InitializePopup();

            MainView form = new MainView();
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
        }
    }
}
