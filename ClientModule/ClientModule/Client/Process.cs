using ClientToServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Protocol;
using ReceiveResult = System.Collections.Generic.KeyValuePair<byte, object?>;
using static Protocol.LoginProtocol;
using static Protocol.MessageProtocol;

namespace ClientSystem
{
	public partial class ClientSystem
	{
		private partial void WakeUp()
		{
			Console.WriteLine("Wakeup\t: Receive event is occurred.");

			Console.WriteLine("\t: Semaphore Attempt");
			// 세마포어 획득을 시도
			if (!semaphore.WaitOne(10))
				return;

			Console.WriteLine("Wakeup\t: Semaphore is assigned.---------------------------");
			// Receive 큐가 빌때까지 반복
			while (!server.IsEmpty())
			{
				result = server.Receive();
				switch (result.Key)
				{
					case DataType.MESSAGE:
						MessageProcess(result);
						break;
					case DataType.LOGIN:
						LoginProcess(result);
						break;
					case DataType.USER:
						UserProcess(result);
						break;
					case DataType.GAME_START:
						GameStart();
						break;
					default:
						break;
				}
			}

			// 세마포어 반환
			Console.WriteLine("Wakeup\t: Semaphore is returned.---------------------------\n\n");
			semaphore.Release();
		}

		private void LoginProcess(ReceiveResult result)
		{
			LoginProtocol.LOGIN? login = result.Value as LoginProtocol.LOGIN;
			Console.WriteLine("Receive\t: Login");
			Console.WriteLine("Attempt\t: Login");

			do
			{
				// 빈 객체라면 종료
				if (login == null)
					break;
				if (isLogin)
					break;
				if (login.studentID != studentID)
					break;
				//if (true != login.name.Equals(name))
				//	break;
				Console.WriteLine("Success\t: Login\n");
				seqNo = login.seqNo;
				isLogin = true;
				userList[studentID] = nickName;
				return;
			}
			while (false);
			Console.WriteLine("Fail\t: Login\n");
		}

		private void MessageProcess(ReceiveResult reuslt)
		{
			MessageProtocol.MESSAGE? message = result.Value as MessageProtocol.MESSAGE;
			bool isMe = false;
			bool isWhisper = false;
			string? nick;

			// 빈 객체라면 종료
			if (message == null)
				return;
			Console.WriteLine("Receive\t: Message");

			if (message.studentID == this.studentID)
				isMe = true;

			if (message.targetID != 0)
				isWhisper = true;

			Console.WriteLine("isMe\t : " + isMe  + " \t \tisWhisper\t : "+ isWhisper);
			Console.WriteLine("content\t: " + message.content);
			Console.WriteLine();

			userList.TryGetValue(message.studentID, out nick);
			if (null == nick)
			{
				userList[message.studentID] = "UNKNOWN";
				// 서버에 정보 요청
				server.Send(Generater.Generate(new UserProtocol.USER(message.studentID)));
			}

			nick = userList[message.studentID];
			
			// 이벤트가 등록되어있다면 뒤의 문장 호출
			messageEvent?.Invoke(nick, message.content, isMe, isWhisper);
		}

		private void UserProcess(ReceiveResult result)
		{
			UserProtocol.USER? user = result.Value as UserProtocol.USER;
			Console.WriteLine("Receive\t: User");
			// 빈 객체라면 종료
			if (user == null)
				return;

			// 삭제신호
			if (-1 == user.seqNo)
			{
				Console.WriteLine("Student Id\t: " + user.studentID + "\t\t User Leaved");
				DeleteUser(user.studentID);
			}

			Console.WriteLine("Receive\t: UserInfo");
			Console.WriteLine("StudentId\t: " + user.studentID + " \t\tUserName : " + user.name + "\n");

			// 유저에 대한 변경 사항이므로 저장 (생성, 수정)
			ModifyUser(user.studentID, user.name);
		}
		private void ModifyUser(int targetID, string name)
		{
			// 없다면
			if (!userList.ContainsKey(targetID))
				userList.Add(targetID, name);
			else
				userList[targetID] = name;

			userListEvent?.Invoke(studentID, name, false);

			foreach (var item in userList)
			{
				Console.WriteLine(item.Key + "\t" + item.Value);
			}
		}
		private void DeleteUser(int targetID)
		{
			// 있다면
			if (userList.ContainsKey(targetID))
			{
				userListEvent?.Invoke(studentID, userList[targetID], true);
				userList.Remove(targetID);
			}
		}

		private void GameProcess()
		{
			gameEvent?.Invoke();
		}
	}
}
