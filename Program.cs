using System;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var season = Seasons.Autumn;
            
            switch (season)
            {
                case Seasons.Autumn:
                    Console.WriteLine("Its Autumn");
                    break;
                
                case Seasons.Summer:
                    Console.WriteLine( "its Pefect time for the beach");
                    break;

                default:
                    Console.WriteLine("I Dont know that season");
                    break;
                   

            }
        }
    }
}
