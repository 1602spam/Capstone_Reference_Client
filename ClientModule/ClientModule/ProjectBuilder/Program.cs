// See https://aka.ms/new-console-template for more information
using ClientSystem;

ClientSystem.ClientSystem clientSystem = new();

clientSystem.Login(201807042, "이무현", "포로");
Thread.Sleep(1000);
clientSystem.SendMessage(0, "");
Thread.Sleep(1000);



while (true)
{
	Thread.Sleep(1000);
	
}
