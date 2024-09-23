using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace Week_6_File_Practice
{
    internal class Program
    {
        static void WriteToFile(string filename, string content)
        {
            File.WriteAllText(filename, content);
        }

        static void ReadFromFile(string filename)
        {
            if (File.Exists(filename))
            {
                string content = File.ReadAllText(filename);

                Console.WriteLine("File content: \n" +content);
            }
            else
            {
                Console.WriteLine("File is not found");
            }
        }
        static void AppendToFIle(string filename, string content)
        {
            if (File.Exists(filename))
            {
                File.AppendAllText(filename, content);
            }
            else
            {
                Console.WriteLine("File is not found");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me what to save to the file");
            string content = Console.ReadLine();
            WriteToFile(@"C: \temp\output.txt", content);


            ReadFromFile(@"C: \temp\output.txt");


            Console.ReadKey();
        }
    }
}
