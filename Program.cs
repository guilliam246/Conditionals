using System;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isGoldCustomer = true;

           //float price;
           // if (isGoldCustomer)
           //    price = 19.95f;
           // else
           //     price = 29.95f;

            //The below is the same as above just simpler

            float price = (isGoldCustomer) ? 19.95f : 29.95f;
        }
    }
}
