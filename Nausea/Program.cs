namespace Nausea
{
    class Program
    {
        public static void Main()
        {
            try
            {                
                string path = FindFile.GetFilePath();
                using StreamReader sr = new(path);
                char[] separators = { ',', ' ', '\n', '\t' };
                string contentToRead;

                while ((contentToRead = sr.ReadToEnd()) != null)
                {
                    int occurrences = 0;
                    string nameToLookFor = "myfile";
                    string[] subs = contentToRead.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var sub in subs)
                    {
                        if (sub.Contains(nameToLookFor))
                        {
                            int pos = sub.IndexOf('.');
                            string name = sub.Substring(0, pos);

                            occurrences++;
                            Console.WriteLine($"#{occurrences}, {name}");
                        }
                        // Alternativly show where !sub.Contains(nameToLookFor)
                        //else Console.WriteLine(sub);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}