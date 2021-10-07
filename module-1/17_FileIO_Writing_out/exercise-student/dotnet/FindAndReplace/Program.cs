using System;
using System.IO;

namespace FindAndReplace
{
    public class Program
    {
		public static void Main(string[] args)
		{
            //Prompt user for the search word
            Console.WriteLine("Enter the word to search for: ");
            string searchWord = Console.ReadLine();

            //Prompt the user for word to replace the search word with
            Console.WriteLine($"Enter the replacement word for the {searchWord}: ");
            string newWord = Console.ReadLine();

            //Prompt the user to enter the source file
            Console.WriteLine($"Enter the source file to replace {searchWord} with {newWord}: \n");
            string srcPath = Console.ReadLine();
            bool srcIsValid = File.Exists(srcPath);

            //Prompt the user for the destination file
            Console.WriteLine("Enter the destination file path: \n");
            string destPath = Console.ReadLine();

            if (srcIsValid)
            {
                try
                {
                    // Open the existing file with the typo using a StreamReader
                    using (StreamReader sr = new StreamReader(srcPath))
                    {
                        // Open a StreamWriter where we will output the file
                        using (StreamWriter sw = new StreamWriter(destPath))
                        {
                            // For each line in the input file, read it in
                            while (!sr.EndOfStream)
                            {
                                // Read an individual line
                                string line = sr.ReadLine();

                                // Replace the occurence of the word langauge with language
                                string replacedLine = line.Replace(searchWord, newWord);

                                // Write the new line to the output file
                                sw.WriteLine(replacedLine);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("couldnt do it, sorry");
                }
            }
            else
            {
                Console.WriteLine("Invalid file path for the source file");
            }
        }
    }
}
