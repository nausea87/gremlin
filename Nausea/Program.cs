namespace Nausea
{
    class Program
    {
        public static void Main()
        {
            try
            {
                string path = @".\resources\myfile.csv";
                using StreamReader sr = new(path);
                char[] separators = { ',' };
                string contentToRead;

                while ((contentToRead = sr.ReadLine()) != null)
                {
                    int counter = 0;
                    string nameToLookFor = "myfile";
                    string[] subs = contentToRead.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var sub in subs)
                    {
                        if (sub.Contains(nameToLookFor))
                        {
                            int pos = sub.IndexOf('.');
                            string name = sub.Substring(0, pos);

                            counter++;
                            Console.WriteLine($"#{counter}, {name}");
                        }
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