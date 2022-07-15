using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Cookies : Products
    {
        public Cookies(string cat, string name, string taste, int price) : base(cat, name, taste, price)
        {
            
        }

        public override void ProductDetails()
        {
            Console.WriteLine("\t\tBeskrivning: Kex - Kan innehålla nötter");
        }

    }
}
