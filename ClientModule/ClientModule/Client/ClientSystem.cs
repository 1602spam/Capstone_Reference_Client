using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClientToServer;
using Protocol;
using ReceiveResult = System.Collections.Generic.KeyValuePair<byte, object?>;

namespace ClientSystem
{
	public delegate void MessageListen(string nick, string content, bool isMe, bool isWhisper);

	public partial class ClientSystem
	{
		public Server server;

		private ReceiveResult result;

		// 객체에 접근하는 객체의 수를 제한(Send)
		private readonly Semaphore semaphore;

		private int seqNo = 0;
		private int studentID = 0;
		private string name = "";
		private string nickName = "";
		public bool isLogin = false;

		// userCode, nickName
		public Dictionary<int, string> userList;

		private event MessageListen? messageEvent;
		public event MessageListen MessageEvent
		{
			add		{ messageEvent += value; }
			remove	{ messageEvent -= value; }
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

			// 수신 이벤트를 해제
			server.receiveEvent -= WakeUp;

			// 수신 종료 이벤트를 해제
			server.stopEvent -= Stop;

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

		public void Logout()
		{
			server.Send(Generater.Generate(new LogoutProtocol.LOGOUT(this.seqNo,studentID)));
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

		// 귓속말
		public void SendWhisperMessage(int targetID,string content)
		{
			MessageProtocol.MESSAGE message = new(this.studentID, targetID, content, this.seqNo);

			server.Send(Generater.Generate(message));
		}


	}
}
