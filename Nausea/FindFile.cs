namespace Nausea
{
    public class FindFile
    {
        public bool FindFileIfExists(string path)
        {
            if (!File.Exists(path))
                return false;

            return true;
        }

        public static string GetFilePath()
        {
            // Enter path to myfile.csv here
            string filePath = "C:\\Users\\nAuseA\\Desktop\\C#\\Nausea\\Nausea\\myfile.csv";
            return filePath;
        }
    }
}
