// See https://aka.ms/new-console-template for more information
using ClientSystem;



// 일반 사용자
ClientSystem.ClientSystem clientSystem = new();
//clientSystem.Login(201807042, "이무현", "포로");

// 관리자
//clientSystem.LoginOwner("이무현");

// 제한 시간 내에 다른 학번으로 로그인 시도 시 저장 취소
clientSystem.Login(Convert.ToInt32(Console.ReadLine()), "Lee mu hyeon", "포로");
 
//Thread.Sleep(1000);
//clientSystem.SendMessage("hello server");
Thread.Sleep(1000);
clientSystem.SendWhisperMessage(123,"this is Whisper");

Thread.Sleep(1000);
// 일반 사용자
//ClientSystem.ClientSystem clientSystem2 = new();
//clientSystem2.Login(5, "테스트 계정", "테스트");


// 로그아웃
Thread.Sleep(3000);
//clientSystem.Logout();
//Thread.Sleep(1000);
//clientSystem.Login(201807042, "이무현", "포로");

while (true)
{
	Thread.Sleep(1000);
}
