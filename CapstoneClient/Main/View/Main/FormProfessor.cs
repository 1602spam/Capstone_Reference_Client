using Main.Class;
using Main.View.Popup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.View.Professor
{
	public partial class FormProfessor : Form
	{
		//레이블의 기본 문자열
		private string lblNameDef = "";         //교수명
		private string lblClassNameDef = "";    //수업명
		private string lblIPDef = "";         //IP

		//요구사항
		//1. 게임 시작 이벤트 발생 시		게임 버튼 비활성화
		//2. 게임 서버 창 꺼질 시			게임 버튼 활성화

		public FormProfessor()
		{
			InitializeComponent();
			this.InitializeMain();
			//레이블의 기본 문자열 설정
			lblNameDef = lblName.Text + " ";
			lblClassNameDef = lblClassName.Text + " ";
			lblIPDef = lblIP.Text + " " ;

			if (ConnectInfo.user != null)
			{
				lblName.Text = lblNameDef + ConnectInfo.user.name;
			}
			lblClassName.Text = lblClassNameDef + ConnectInfo.ClassName;
			lblIP.Text = lblIPDef + GetLocalIP();
		}

		private string GetLocalIP()
		{
			IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
			string IP = string.Empty;
			foreach (var i in host.AddressList)
			{
				if (i.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
				{
					IP = i.ToString();
					break;
				}
			}
			return IP;
		}

		private void btnChat_Click(object sender, EventArgs e)
		{
			openChat();
		}
		private void btnGame_Click(object sender, EventArgs e)
		{
			openGame();
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

		private void openGame()
		{
			var form = Application.OpenForms["FormGamePopup"];
			if (form == null)
			{
				form = new FormGamePopup();
			}
			form.StartPosition = FormStartPosition.CenterScreen;
			form.Show();
			form.Focus();
		}

		private void FormProfessor_FormClosed(object sender, FormClosedEventArgs e)
		{
			
		}
	}
}
