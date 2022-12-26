using System;
using GoogleDriveSave;
using Json;
// See https://aka.ms/new-console-template for more information
namespace test
{

    internal class Program {
            static void Main(string[] args)
         {

          Console.WriteLine("start");
            Console.WriteLine("올릴파일에 절대주소를 입력하시오");
            string x = Console.ReadLine();
            Console.WriteLine("구글드라이브 도메인을 입력하시오");
            string y = Console.ReadLine();
            Console.WriteLine("json파일 절대주소를 입력하시오");
            string z = Console.ReadLine();



            string zz =  JsonFile.Move(z);
            if (zz==null)
            {
                return;
            }


            GoogleDrive.GoogleDriveSave(x, y,z);
        }

        
    }
}