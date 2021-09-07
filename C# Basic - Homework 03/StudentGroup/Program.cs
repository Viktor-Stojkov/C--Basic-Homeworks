using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number betwen 1 and 2");
            int firstGroup = Convert.ToInt32(Console.ReadLine());
            int secondGroup = Convert.ToInt32(Console.ReadLine());

            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = { "Vase", "Vesna", "Sandra", "Viktor" };

            if (firstGroup == 1)
            {
                Console.WriteLine("The Students in G1 are: ");
                foreach (var name in studentsG1)
                {
                    Console.WriteLine(name);
                }
            }
            else if (secondGroup == 2)
            {
                Console.WriteLine("The Students in G2 are: ");
                foreach (var name in studentsG2)
                {
                    Console.WriteLine(name);
                }
            }
            else
            {
                Console.WriteLine("Wrong input care for the character or text will make Exception");
            }
        }
    }
}
