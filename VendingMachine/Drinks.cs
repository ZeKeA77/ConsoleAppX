namespace VendingMachine
{
    public class Drinks : Products
    {

        public Drinks(string cat, string name, string taste, int price) : base(cat, name, taste, price)
        {

        }

        public override void Examine()
        {
            Console.WriteLine("\t\tBeskrivning: Kolsyrad - Läskedryck");
        }

        public override void Use()
        {
            Console.Write("\t\tVill du dricka den nu? (j/n) ");
        }


    }
}
