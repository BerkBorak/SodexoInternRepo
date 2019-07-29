using System;
using System.IO;
namespace SameInReverse
{
    
    class Program
    {
        private static readonly string inputFile = "SameInReverse.sdx";
        private static readonly string outputFile = "SameInReverseFound.sdx";
        static void Main(string[] args)
        {
            Palindrome longestPali = new Palindrome(File.ReadAllText(inputFile));
            CreateFileWithText(outputFile, longestPali.GetLongestPali());
        }
        // Creates and fills a file
        public static void CreateFileWithText(string fileName, string content)
        {
            try
            {
                if (File.Exists(fileName)) // Checks if file exists, if it does, deletes it.
                {
                    File.Delete(fileName);
                }
                using (StreamWriter sw = File.CreateText(fileName)) // Creates the file and initializes a file stream.
                {
                    sw.Write(content); // Writes the content into the file.
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString()); // Outputs the exception to the console.
            }
        }
    }

            
        
    
}
