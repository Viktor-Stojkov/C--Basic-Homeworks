using System;

namespace Find_Numbers_each_other
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] findCorrectNumberEachOther = { 7, 9, 3, 3, 4, 3, 3, 3 };
            foreach (var name in findCorrectNumberEachOther)
            {
                Console.WriteLine(name);
            }
        }
    }
}
