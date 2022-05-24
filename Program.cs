using System;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number1 = 14;
            var number2 = 22;

            if (number1 < number2 )
            {
                Console.WriteLine(number2);
            }
            else 
            {
                Console.WriteLine(number1);
            }
        }
    }
}
