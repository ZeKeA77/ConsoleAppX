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
