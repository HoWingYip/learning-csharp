using System;

namespace _2b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, sum = 0, aboveavg = 0, convertedNumber = 0;
            string[] numbers = System.IO.File.ReadAllText
            (@"C:\Users\yip\learning-csharp\IFAssignments\2a\data2.txt").Split(' ');

            foreach (string number in numbers)
            {
                n++;
                convertedNumber = Int32.Parse(number);
                sum = sum + convertedNumber;
            }

            foreach (string number in numbers)
            {
                convertedNumber = Int32.Parse(number);
                if (convertedNumber > sum / n) aboveavg++;
            }

            Console.Write("Number of numbers above average: "); Console.Write(aboveavg); Console.Write("\n");
            Console.ReadKey();
        }
    }
}
