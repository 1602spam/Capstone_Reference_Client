using Main.Class;
using Main.View.Popup;

namespace Main
{
    public partial class FormRegist : Form
    {
        public static FormRegist Instance = new();
        public FormRegist()
        {
            InitializeComponent();
            Instance = this;
        }

        private void btnLaunchProfessor_Click(object sender, EventArgs e)
        {
            FormRegistPopup form = new(CONNECTTYPE.PROFESSOR);
            form.ShowDialog();
        }

        private void btnLaunchStudent_Click(object sender, EventArgs e)
        {
            FormRegistPopup form = new(CONNECTTYPE.STUDENT);
            form.ShowDialog();
        }

        private void FormRegist_FormClosed(object sender, FormClosedEventArgs e)
        {
            //로그아웃 프로토콜 전송
        }
    }
}