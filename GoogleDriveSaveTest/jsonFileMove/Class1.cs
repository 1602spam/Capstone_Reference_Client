namespace Json
{
    public class JsonFile
    {



        public static string Move(string jsonKeyPath)
        {
            

            string jsonfileName = Path.GetFileName(jsonKeyPath);
            string path = Environment.CurrentDirectory + "/" + jsonfileName;


            try
            {
                File.Move(jsonKeyPath, path);
                return path;
            }
            catch (Exception)
            {
                Console.WriteLine("json키에 위치가 올바르지않습니다.");
                return null;
            }



        }
    }
}