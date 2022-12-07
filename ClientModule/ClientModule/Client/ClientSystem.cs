using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

using ClientToServer;
using Protocol;
using static Protocol.MessageProtocol;
using ReceiveResult = System.Collections.Generic.KeyValuePair<byte, object?>;

namespace ClientSystem
{
	public delegate void MessageListen(string nick, string content, int studentID, bool isMe, bool isWhisper);
	public delegate void ModifyUserListListen(int StudentId, string name, bool delete);
	public delegate void GameStartListen();
	public delegate void ExitListen();

	public partial class ClientSystem
	{
		public Server server;

		private ReceiveResult result;

		// 객체에 접근하는 객체의 수를 제한(Send)
		private readonly Semaphore semaphore;

		private int seqNo = 0;
		public int studentID = 0;
		public string name = "";
		public string nickName = "";
		public bool isLogin = false;

		// userCode, nickName
		public Dictionary<int, string> userList;

		private event MessageListen? messageEvent;
		public event MessageListen MessageEvent
		{
			add { messageEvent += value; }
			remove { messageEvent -= value; }
		}

		private event ModifyUserListListen? userListEvent;
		public event ModifyUserListListen UserListEvent
		{
			add { userListEvent += value; }
			remove { userListEvent -= value; }
		}

		private event GameStartListen? gameEvent;
		public event GameStartListen GameEvent
		{
			add { gameEvent += value; }
			remove { gameEvent -= value; }
		}

		private event ExitListen? exitEvent;
		public event ExitListen ExitEvent
		{
			add { exitEvent += value; }
			remove { exitEvent -= value; }
		}

		public ClientSystem()
		{
			Console.WriteLine("Clinet Start");
			setAddress();

			server = Server.Instance;

			server.receiveEvent += WakeUp;

			// 수신 종료 시 이벤트를 등록
			server.stopEvent += Stop;

			semaphore = new(1, 1);

			userList = new();

			// 연결 설정하는 동안 무조건 대기
			Thread.Sleep(100);
		}

		public static void setAddress(string addr = "127.0.0.1")
		{
			Server.setAddress = addr;
		}

		private partial void WakeUp();

		// 어떠한 이유에든 수신이 종료되면 발생할 메소드
		private void Stop()
		{
			Console.WriteLine("\t: Stop Signal Generation");

			exitEvent?.Invoke();

			// 수신 이벤트를 해제
			server.receiveEvent -= WakeUp;

			// 수신 종료 이벤트를 해제
			server.stopEvent -= Stop;

			//server.StopReceive();

			Console.WriteLine("Server Disconnect\n");
			// throw new Exception();
		}

		public void Login(int studentID, string name, string nickName)
		{
			// 이미 로그인 상태라면
			if (isLogin)
				return;

			this.studentID = studentID;
			this.name = name;
			this.nickName = nickName;

			server.Send(Generater.Generate(new LoginProtocol.LOGIN(0, studentID, name, nickName)));
		}

		public void LoginOwner(string name)
		{
			// 이미 로그인 상태라면
			if (isLogin)
				return;

			this.studentID = -1;
			this.name = name;
			this.nickName = name;

			server.Send(Generater.Generate(new LoginProtocol.LOGIN(0, studentID, name, nickName)));
		}

		public void Logout()
		{
			server.Send(Generater.Generate(new LogoutProtocol.LOGOUT(this.seqNo, studentID)));
			server.StopReceive();
		}

		//메시지 보내기
		public void SendMessage(string content)
		{
			if (!isLogin)
				return;
			MessageProtocol.MESSAGE message = new(this.studentID, 0, content, this.seqNo);

			server.Send(Generater.Generate(message));
		}
		// 유저 강퇴
		public void KickUser(int StudentId)
		{
			UserProtocol.USER user = new UserProtocol.USER();
			if (!isLogin)
				return;
			user.studentID = studentID;
			user.seqNo = -1;

			server.Send(Generater.Generate(user));
		}

		// 귓속말
		public void SendWhisperMessage(int targetID, string content)
		{
			if (!isLogin)
				return;
			MessageProtocol.MESSAGE message = new(this.studentID, targetID, content, this.seqNo);

			server.Send(Generater.Generate(message));
		}
		public void StartGame()
		{
			GameStartProtocol.GameStart gs = new GameStartProtocol.GameStart();
			gs.meanless = 96;
			server.Send(Generater.Generate(gs));
		}
	}
}
