using System;

namespace _1a
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText
            (@"C:\Users\yip\learning-csharp\IFAssignments\1a\data.txt");
            //read file

            string[] numbers = text.Split(' ');
            string[] outputNumbers = text.Split(' ');
            //split string when spaces occur
            foreach (string number in numbers)
            {
                string outputNumber = number + "\r\n";
                Console.Write(outputNumber);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
