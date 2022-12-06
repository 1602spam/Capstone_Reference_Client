using Capstone_Reference_Game_Module;
using Capstone_Reference_GameServer;
using ServerSystem;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Main.Class
{
    public static class CONNECTTYPE
    {
        public const int PROFESSOR = 1;
        public const int STUDENT = 2;
    }

    public static class ConnectInfo
    {
        public static ServerSystem.ServerSystem? server;
        public static ClientSystem.ClientSystem? user;
        public static int Type = 0; //CONNECTTYPE을 참조
        public static string ClassName = "";
        public static string ProfessorName = "";
        public static string IP = "";
        public static void InitializeProfessor(string className, string name)
        {
            ConnectInfo.ClassName = className;
            ConnectInfo.ProfessorName = name;
        }
    }

    public class Game
    {
        public void JoinAsClient()
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "Capstone_Reference_Game.exe";

            if (ConnectInfo.user != null)
            {
                psi.ArgumentList.Add(ConnectInfo.IP);
                psi.ArgumentList.Add(ConnectInfo.user.studentID.ToString());
                psi.ArgumentList.Add(ConnectInfo.user.name);
            }
            Process.Start(psi);
        }

        public void JoinAsClient(string ip, string id, string name)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "Capstone_Reference_Game.exe";

            if (ConnectInfo.user != null)
            {
                psi.ArgumentList.Add(ip);
                psi.ArgumentList.Add(id);
                psi.ArgumentList.Add(name);
            }
            Process.Start(psi);
        }

        public void JoinAsServer()
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "Capstone_Reference_Game.exe";

            Process.Start(psi);
        }

        public void StartChoiceQuiz(string title, int time, List<string> answers, int index)
        {
            GameConfiguration config = new GameConfiguration()
            {
                Title = title,
                Time = time,
                Answer = index + 1,
                QuizType = QuizTypes.MULTIPLE_QUIZ,
                Questions = answers
            };
            GameServerForm form = new GameServerForm(config);
            form.Start();
            form.Show();

            if (ConnectInfo.user != null)
                ConnectInfo.user.StartGame();
        }

        public void StartOXQuiz(string title, int time, int answer)
        {
            GameConfiguration config = new GameConfiguration()
            {
                Title = title,
                Time = time,
                Answer = answer,
                QuizType = QuizTypes.OX_QUIZ
            };
            GameServerForm form = new GameServerForm(config);
            form.Start();
            form.Show();

            if (ConnectInfo.user != null)
                ConnectInfo.user.StartGame();
            //ClientContainer.Instance.StartGame(ClientContainer.Instance.loginDict[ConnectInfo.user.studentID]);
        }

        public void StartAnswerQuiz(string title, int time)
        {
            GameConfiguration config = new GameConfiguration()
            {
                Title = title,
                Time = time,
                QuizType = QuizTypes.DESCRIPTIVE_QUIZ
            };
            GameServerForm form = new GameServerForm(config);
            form.Start();
            form.Show();

            if(ConnectInfo.user!=null)
                ConnectInfo.user.StartGame();
            //ClientContainer.Instance.StartGame(ClientContainer.Instance.loginDict[ConnectInfo.user.studentID]);
        }
    }
}