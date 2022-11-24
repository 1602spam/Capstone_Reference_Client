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
	//public delegate void MessageListen(Message message);

	public class ClientSystem
	{
		public Server server;

		private ReceiveResult result;

		// 객체에 접근하는 객체의 수를 제한(Send)
		private readonly Semaphore semaphore;

		private int seqNo;
		private int StudentId;


		public ClientSystem()
		{
			Console.WriteLine("Clinet Start");
			setAddress();
			
			server = Server.Instance;
			server.receiveEvent += Wakeup;

			// 수신 종료 시 이벤트를 등록
			server.stopEvent += Stop;

			semaphore = new(1, 1);
		}

		public static void setAddress(string addr = "127.0.0.1")
		{
			if (null == Server.setAddress)
			{
				Server.setAddress = addr;
			}
		}

		private void Wakeup()
		{
			Console.WriteLine("Wakeup\t: Receive event is occurred.");

			Console.WriteLine("\t: Semaphore Attempt\n");
			// 세마포어 획득을 시도
			if (!semaphore.WaitOne(10))
				return;

			Console.WriteLine("Wakeup\t: Semaphore is assigned.");
			// Receive 큐가 빌때까지 반복
			while (!server.IsEmpty())
			{
				result = server.Receive();
			}

			// 세마포어 반환
			Console.WriteLine("Wakeup\t: Semaphore is returned.\n");
			semaphore.Release();
		}

		// 어떠한 이유에든 수신이 종료되면 발생할 메소드
		private void Stop()
		{
			Console.WriteLine("\t: Stop Signal Generation");

			// 수신 이벤트를 해제
			server.receiveEvent -= Wakeup;

			// 수신 종료 이벤트를 해제
			server.stopEvent -= Stop;

			Console.WriteLine("Server Disconnect\n");
		}


		public void Login(int studentID, string name, string nick)
		{
			//server.Send(Generater.Generate(new UserProtocol.USER(0,studentID,name,nick)));
			server.Send(Generater.Generate(new LoginProtocol.LOGIN("201807042","")));
		}
		public void SendMessage(int tergetSeq, string content)
		{
			MessageProtocol.MESSAGE message = new();

			server.Send(Generater.Generate(message));
		} 
	}
}
