using Canvas_module;
using Main.Class;
using Main.View.Popup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.View.Student
{
	public partial class FormStudent : Form
	{
		//레이블의 기본 문자열
		private string lblNameDef = "";             //학생명
		private string lblClassNameDef = "";        //수업명
		private string lblProfessorNameDef = "";    //교수명
		private string lblIDDef = "";
		MainView? form;


		public FormStudent()
		{
			InitializeComponent();
			this.InitializeMain();
			//레이블의 기본 문자열 설정
			lblNameDef = lblName.Text + " ";
			lblClassNameDef = lblClassName.Text + " ";
			lblProfessorNameDef = lblProfessorName.Text + " ";
			lblIDDef = lblID.Text + " ";

			if (ConnectInfo.user != null)
			{
				ConnectInfo.user.GameEvent += openGame;
				ConnectInfo.user.ExitEvent += CloseWindow;
				lblName.Text = lblNameDef + ConnectInfo.user.name;
				lblID.Text = lblIDDef + ConnectInfo.user.studentID;
				if (ConnectInfo.user.userList.Keys.Contains(-1))
				{
					lblProfessorName.Text = lblProfessorNameDef + ConnectInfo.user.userList.GetValueOrDefault(-1);
				}
			}
			lblClassName.Text = lblClassNameDef + ConnectInfo.ClassName;

			form = new();
		}

		public void openGame()
		{
			Game game = new();
			if(ConnectInfo.user!=null)
				game.JoinAsClient("127.0.0.1", ConnectInfo.user.studentID.ToString(), ConnectInfo.user.name);
		}
		private void CloseWindow()
		{
			//MessageBox.Show("강제 퇴장 되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			this.Close();
		}
		private void btnChat_Click(object sender, EventArgs e)
		{
			openChat();
		}
		private void btnNote_Click(object sender, EventArgs e)
		{
			openNote();
		}

		private void openGameInvitation(object obj)
		{
			var form = Application.OpenForms["FormGameInvitation"];
			if (form != null)
				form.Close();

			var newform = new FormGameInvitation();
			newform.StartPosition = FormStartPosition.CenterScreen;
			newform.Show();
			newform.Focus();
		}

		private void openChat()
		{
			var form = Application.OpenForms["FormChatPopup"];
			if (form == null)
			{
				form = new FormChatPopup();
			}
			form.StartPosition = FormStartPosition.CenterScreen;
			form.Show();
			form.Focus();
		}

		private void openNote()
		{
			if (null == form)
			{
				form = new();
			}

			//form = Application.OpenForms["MainView"];

			form.Visible = true;
            form.Show();
            form.Focus();
			/*
            form.Visible = !form.Visible;
			if (form.Visible == true)
			{
				form.Show();
				form.Focus();
			}
			*/
		}

		private void FormStudent_Load(object sender, EventArgs e)
		{
			panel2.BackColor = Color.FromArgb(153 - 10, 180 - 10, 209 - 10);
		}
	}
}
