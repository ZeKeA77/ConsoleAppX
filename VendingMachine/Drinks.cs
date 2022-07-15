using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Drinks : Products
    {
        
        public Drinks(string cat, string name, string taste, int price) : base(cat, name, taste, price)
        {

        }

        public override void ProductDetails()
        {
            Console.WriteLine("\t\tBeskrivning: Kolsyrad - Läskedryck");
        }


    }
}
