// See https://aka.ms/new-console-template for more information
using ClientSystem;

ClientSystem.ClientSystem clientSystem = new();
clientSystem.Login(201807042, "이무현", "포로");

// 제한 시간 내에 다른 학번으로 로그인 시도 시 저장 취소
// clientSystem.Login(201807043, "이무현", "포로");

Thread.Sleep(1000);
clientSystem.SendMessage("hello server");
Thread.Sleep(1000);
clientSystem.SendWhisperMessage(123,"this is Whisper");
Thread.Sleep(3000);
clientSystem.Logout();
Thread.Sleep(1000);
//clientSystem.Login(201807042, "이무현", "포로");

while (true)
{
	Thread.Sleep(1000);
	
}
