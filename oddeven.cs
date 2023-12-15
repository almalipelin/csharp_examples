using System;
namespace oddeven
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.write("Enter a number: ");
            number = Convert.ToInt16(Console.Readline());

            if (number % 2 == 0)
            {
                Console.Write(number + " is an even number.");
            }
            else
            {
                Console.Write(number + " is an odd number.");
            }
            Console.Readkey();
        }
    }
}