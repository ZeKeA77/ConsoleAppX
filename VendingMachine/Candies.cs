using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Candies : Products
    {
        public Candies(string cat, string name, string taste, int price) : base(cat, name, taste, price)
        {
            
        }

        public override void ProductDetails()
        {
            Console.WriteLine("\t\tBeskrivning: Godis");
        }


    }
}
