using ServerSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Class
{
    public static class CONNECTTYPE
    {
        public const int PROFESSOR = 1;
        public const int STUDENT = 2;
    }

    public static class ConnectInfo
    {
        public static ClientSystem.ClientSystem? user;
        public static int Type = 0; //CONNECTTYPE을 참조
        public static int SeqID = 0;
        public static string Name = "";
        public static int ID = 0; //학번도 -1이면 교수로 하는 거 어떨까요
        public static string ClassName = "";
        public static string ProfessorName = "";

        public static void InitializeStudent(int id, string name)
        {
            ConnectInfo.ID = id;
            ConnectInfo.Name = name;
        }

        public static void InitializeProfessor(string className, string name)
        {
            ConnectInfo.ClassName = className;
            ConnectInfo.ProfessorName = name;
        }
    }
}
