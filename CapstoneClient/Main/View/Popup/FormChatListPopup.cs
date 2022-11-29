using Main.Class;
using Main.View.UserControls;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Protocol.MessageProtocol;

namespace Main.View.Popup
{
	public partial class FormChatListPopup : Form
	{
		delegate void MemberCallback();
		delegate void AddCallback(int id, string name);
		public FormChatListPopup()
		{
			InitializeComponent();
			this.InitializePopup();

			if (ConnectInfo.user != null)
			{
				foreach (var item in ConnectInfo.user.userList)
				{
					AddMember(item.Key, item.Value);
				}
				ConnectInfo.user.UserListEvent += OnMemberReceived;
			}
		}

		private void OnMemberReceived(int id, string name, bool delete)
		{
			//표시하라치면
			if (!delete)
			{
				AddMember(id, name);
			}
		}

		private void AddMember(int id, string name)
		{
			if (this.panChatMemberList.InvokeRequired)
			{
				AddCallback c = new (AddMember);
				this.Invoke(c);
			}
			else
			{
				ChatListItem item = new(id, name);
				panChatMemberList.Controls.Add(item);
				item.BringToFront();
				lblTitle.Text = "참가자(" + panChatMemberList.Controls.Count + ")";
			}
        }

		private void RefreshChatList()
		{
			if (this.panChatMemberList.InvokeRequired)
			{
				MemberCallback c = new MemberCallback(RefreshChatList);
				this.Invoke(c);
			}
			else
			{
				panChatMemberList.Controls.Clear();
				if (ConnectInfo.user != null)
				{
					foreach (var item in ConnectInfo.user.userList)
					{
						AddMember(item.Key, item.Value);
					}
				}
			}
        }
	}
}