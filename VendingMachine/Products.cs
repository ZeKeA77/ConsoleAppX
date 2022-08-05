namespace VendingMachine
{
    public class Products
    {
        public string Cat { get; set; }
        public string Name { get; set; }
        public string Taste { get; set; }
        public int Price { get; set; }
        public int Id { get; set; }
        private static int _id = 0;

        public Products(string cat, string name, string taste, int price)
        {
            Cat = cat;
            Name = name;
            Taste = taste;
            Price = price;
            _id++;
            Id = _id;
        }

        public virtual void ProductDetails()
        {

        }
    }
}
