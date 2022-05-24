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
                case Seasons.Summer:
                    Console.WriteLine( "We have a promotion"); //this means that both cases will show this message
                    break;

                default:
                    Console.WriteLine("I Dont know that season");
                    break;
                   

            }
        }
    }
}
