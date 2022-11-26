using Main.Class;
using Main.View.Popup;
using System.Data;
using System.Drawing;

namespace Main
{
    public partial class FormRegist : Form
    {

        int num = 0;
        public static FormRegist Instance = new();
        public FormRegist()
        {
            InitializeComponent();

            lblLaunchProfessor.Location = new Point(0, 191);
            pictureBox1.Controls.Add(lblLaunchProfessor);

            lblLaunchStudent.Location = new Point(0, 191);
            pictureBox2.Controls.Add(lblLaunchStudent);

            Instance = this;
        }


        
        //마우스가 영역안에 있을 경우 .gif 
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.gif_professor;
            lblProStudent1();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.gif_student;
            lblProFessor1();
        }

        //마우스가 영역나갈 경우 이미지 
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Img_professor;           
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Img_student;
        }




        //학생lbl 영역안에 있을경우 timer2실행
        private void lblLaunchStudent_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.gif_student;
         
            lblProStudent1();
            timer2.Enabled = true;

            lblProFessor1();
            timer1.Enabled = false;
        }
       
        //학생lbl 영역나갈 경우 timer2중지
        private void lblLaunchStudent_MouseLeave(object sender, EventArgs e)
        {

            pictureBox2.Image = Properties.Resources.Img_student;
            
            if (timer2.Enabled == true)
            {              
                timer2.Enabled = false;
                lblProStudent1();
            }
        }

        private void lblLaunchStudent_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            lblLaunchStudent.BackColor = Color.FromArgb(94, 2, 2);
            lblLaunchStudent.Size = new Size(375, 482);
            lblLaunchStudent.Location = new Point(0, 0);
            FormRegistPopup form = new(CONNECTTYPE.STUDENT);
            form.ShowDialog();
        }
       
        //교수lbl 영역안에 있을경우 timer1실행
        private void lblLaunchProfessor_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.gif_professor;

            lblProFessor1();
            timer1.Enabled = true;
         
            timer2.Enabled = false;
            lblProStudent1();

        }
      
        //교수lbl 영역나갈 경우 timer1중지
        private void lblLaunchProfessor_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Img_professor;

            
            if (timer1.Enabled == true)
            {              
                timer1.Enabled = false;
                lblProFessor1();
            }
        }

        private void lblLaunchProfessor_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            lblLaunchProfessor.BackColor = Color.FromArgb( 2, 31, 84);
            lblLaunchProfessor.Size = new Size(375, 482);
            lblLaunchProfessor.Location = new Point(0, 0);
            FormRegistPopup form = new(CONNECTTYPE.PROFESSOR);
            form.ShowDialog();
        }






        //교수lbl size 증가 
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num < 371)
            {

                num += 20;
                lblLaunchProfessor.Size = new Size(374, 110 + num);
                lblLaunchProfessor.Location = new Point(0, 191 - (num / 2));
            }
            else
            {
                lblLaunchProfessor.BackColor = Color.FromArgb(2, 31, 84);
            }
        }
        /// 학생lbl size 증가 
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (num < 371)
            {
                num += 20;

                lblLaunchStudent.Size = new Size(374, 110 + num);
                lblLaunchStudent.Location = new Point(0, 191 - (num / 2));
            }
            else
            {
                lblLaunchStudent.BackColor = Color.FromArgb(94, 2, 2);
            }

        }



        private void lblProFessor1()//기존 교수lbl 
        {
            num = 0;
            lblLaunchProfessor.BackColor = Color.FromArgb(120, 2, 31, 84);
            lblLaunchProfessor.Size = new Size(374, 110);
            lblLaunchProfessor.Location = new Point(0, 191);
        }

        private void lblProStudent1()//기존 학생lbl
        {
            num = 0;
            lblLaunchStudent.BackColor = Color.FromArgb(120, 94, 2, 2);
            lblLaunchStudent.Size = new Size(374, 110);
            lblLaunchStudent.Location = new Point(0, 191);
        }


    }
}