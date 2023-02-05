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
                string line;
                string name = "myfile";

                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(name))
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("");
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