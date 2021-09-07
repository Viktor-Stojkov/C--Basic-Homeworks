using System;

namespace Homework_SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 4, 3, 7, 3, 2, 8 };
            int even = 0;
            int odd = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
               
                if (i % 2 != 0)
                {
                    even += intArray[i];
                }
                else 
                {
                    odd += intArray[i];
                }
            }
            Console.WriteLine($"The result for Even is {even}");
            Console.WriteLine($"The result for Odd is {odd}");

            Console.ReadLine();
        }
    }
}
