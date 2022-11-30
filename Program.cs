using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goalNumber = int.Parse(Console.ReadLine());

            int sumOfNumber = 0;

            while (sumOfNumber < goalNumber)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                sumOfNumber += currentNumber;
            }

            Console.WriteLine(sumOfNumber);
        }
    }
}
