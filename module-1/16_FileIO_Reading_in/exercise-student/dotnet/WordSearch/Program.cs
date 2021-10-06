using System;
using System.IO;

namespace WordSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1. Ask the user for the file path
            Console.WriteLine("What is the fully qualified name of the file that should be searched?");
            string fileName = Console.ReadLine().ToLower();

            //2. Ask the user for the search string
            Console.WriteLine("What is the search word you are looking for?");
            string searchWord = Console.ReadLine();
            //case sensitive word search
            Console.WriteLine("Should the search be case sensitive (Y or N)?");
            string caseSensitive = Console.ReadLine();
            bool isCaseSensitive = true;

            if (caseSensitive.ToUpper() == "N")
            {
                isCaseSensitive = false;
            }

            //3. Open the file
            int lineCounter = 1;
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {//4. Loop through each line in the file
                    while (!sr.EndOfStream)
                    {
                        lineCounter++;
                        string line = "";
                        line = sr.ReadLine();

                        //5. If the line contains the search string, print it out along with its line number
                        if (CheckLine(line, searchWord, caseSensitive))
                        {
                            Console.WriteLine($"Line {lineCounter}: {line}");
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            Console.ReadKey();

        }

        private static bool CheckLine(string line, string searchWord, string caseSensitive)
        {
            throw new NotImplementedException();
        }

        public static bool CheckLine(string line, string word, bool caseSensitive)
        {
            if (!caseSensitive)
            {
                line = line.ToLower();
                word = word.ToLower();
            }
            if (line.Contains(word))
            {
                return true;
            }
            return false;
        }
    }
}
