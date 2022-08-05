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
