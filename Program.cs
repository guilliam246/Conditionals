using System;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 12;

            if (number < 10)
            {
                Console.WriteLine("Number Valid");
            }
            else 
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
