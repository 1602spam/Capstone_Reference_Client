using Main.View.Popup;

namespace Main
{
    public partial class FormRegist : Form
    {
        public FormRegist()
        {
            InitializeComponent();
        }

        private void btnLaunchProfessor_Click(object sender, EventArgs e)
        {
            FormProfessorRegistPopup form = new();
            form.ShowDialog();
        }

        private void btnLaunchStudent_Click(object sender, EventArgs e)
        {
            FormStudentRegistPopup form = new();
            form.ShowDialog();
        }
    }
}