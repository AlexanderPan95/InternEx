using System;
using System.IO;

namespace Mentoring
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void WriteToFile(string filePath)
        {
            string path = $@"C:\Users\alex\Desktop\readFromFile.txt";
            string existText = ReadFromFile(path);
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine($@"{existText} {Console.ReadLine()}");
            }

            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }

        public static string ReadFromFile(string path)
        {
            string readText = File.ReadAllText(path);

            return readText;
        }

    }
}