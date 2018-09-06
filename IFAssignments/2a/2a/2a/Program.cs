using System;

namespace _2a
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, sum = 0, score = 0, highest = Int32.MinValue, lowest = Int32.MaxValue, convertedNumber = 0;

            string[] numbers = System.IO.File.ReadAllText
            (@"C:\Users\yip\learning-csharp\IFAssignments\2a\data2.txt").Split(' ');
            //read file

            foreach (string number in numbers)
            {
                n++;
                convertedNumber = Int32.Parse(number);
                sum = sum + convertedNumber;
                if (convertedNumber > highest) highest = convertedNumber;
                if (convertedNumber < lowest) lowest = convertedNumber;
            }

            Console.Write("Number of numbers: "); Console.Write(n); Console.Write("\n");
            Console.Write("Sum of numbers: "); Console.Write(sum); Console.Write("\n");
            Console.Write("Highest: "); Console.Write(highest); Console.Write("\n");
            Console.Write("Lowest: "); Console.Write(lowest); Console.Write("\n");
            Console.ReadKey();
        }
    }
}
