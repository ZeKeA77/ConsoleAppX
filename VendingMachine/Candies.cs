namespace VendingMachine
{
    internal class Candies : Products
    {
        public Candies(string cat, string name, string taste, int price) : base(cat, name, taste, price)
        {

        }

        public override void Examine()
        {
            Console.WriteLine("\t\tBeskrivning: Godis");
        }

        public override void Use()
        {
            Console.Write("\t\tVill du äta dina godisar nu? (j/n) ");
        }
    }
}
