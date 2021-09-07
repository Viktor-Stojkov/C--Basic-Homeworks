using System;
using System.Linq;

namespace Homework_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Min and Max number from Array.");

            int[] minAndMax = { 2, 54, 65, 23, 45, 25, 6, 78, 24, 62 };
            foreach (var printNumbers in minAndMax)
            {
                Console.WriteLine(printNumbers);
            }
            Console.WriteLine($"\nMin number from the Array is: {minAndMax.Min()}");
            Console.WriteLine($"Max number from the Array is: {minAndMax.Max()}");

            Console.WriteLine();
        }
    }
}
