namespace VendingMachine
{
    internal class Cookies : Products
    {
        public Cookies(string cat, string name, string taste, int price) : base(cat, name, taste, price)
        {

        }

        public override void Examine()
        {
            Console.WriteLine("\t\tBeskrivning: Kex - Kan innehålla nötter");
        }

        public override void Use()
        {
            Console.Write("\t\tVill du äta dina kex nu? (j/n) ");
        }

    }
}
