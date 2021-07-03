using System.IO;

namespace MovieStars.Service
{
    public static class FileService
    {
        public static string GetPath()
        {
            string filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

            var filePathSplit = filePath.Split('\\');

            var myFilePath = "";

            for (int i = 0; i < filePathSplit.Length - 2; i++)
            {
                myFilePath += filePathSplit[i] + "\\";
            }

            myFilePath += "Resorse\\input.txt";

            if (!(File.Exists(myFilePath)))
            {
                using (FileStream fs = File.Create(myFilePath))
                {
                    fs.Close();
                }
            }

            return myFilePath;
        }

        public static string GetAllText(string Path)
        {
            return File.ReadAllText(Path);
        }
    }
}
