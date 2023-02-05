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
    }
}
