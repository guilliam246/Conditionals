using System;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hight = 33;
            var width = 22;

            if (hight > width )
            {
                Console.WriteLine("This is a portrait image");
            }
            else 
            {
                Console.WriteLine("This is a landscape image");
            }
        }
    }
}
