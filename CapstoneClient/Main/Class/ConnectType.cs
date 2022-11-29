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
        public static string ClassName = "";
        public static string ProfessorName = "";

        public static void InitializeProfessor(string className, string name)
        {
            ConnectInfo.ClassName = className;
            ConnectInfo.ProfessorName = name;
        }
    }
}
