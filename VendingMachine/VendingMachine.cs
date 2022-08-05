namespace VendingMachine
{
    public class VendingMachine
    {
        CoinBox coinbox = new CoinBox();
        Menu menu = new Menu();

        public List<Products> ProductList { get; set; }

        public VendingMachine()
        {
            ProductList = new List<Products>();
            CreateProductList();
        }

        public void StartTheMachine()
        {
            menu.MenuChoice("Start");
            ShowListOfProducts();

            Boolean keepAlive = false;

            while (!keepAlive)
            {
                char choice;
                do
                {
                    menu.MenuChoice("AskToBuy");
                    choice = Convert.ToChar(Console.ReadLine());
                }
                while (choice != 'p' && choice != 'h' && choice != 'a' && choice != 'b');

                switch (choice)
                {
                    case 'h': // -- Buy something


                        if (coinbox.AvailableFunds < 10)
                        {
                            menu.MenuChoice("Vending");
                            menu.MenuChoice("InsufficientCoins");
                            menu.MenuChoice("Spacer");
                        }
                        else
                        {
                            Console.Clear();
                            menu.MenuChoice("Vending");
                            ShowListOfProducts();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"\n\t\tTillgängligt belopp: {coinbox.AvailableFunds}:-");
                            Console.ResetColor();
                            menu.MenuChoice("ChooseToBuy");

                            int buyP = int.Parse(Console.ReadLine());

                            foreach (var item in ProductList)
                            {
                                if (buyP == item.Id)
                                {
                                    if (item.Price >= coinbox.AvailableFunds)
                                    {
                                        menu.MenuChoice("Vending");
                                        menu.MenuChoice("InsufficientCoins");
                                        menu.MenuChoice("Spacer");
                                    }
                                    else
                                    {
                                        int x = coinbox.AvailableFunds - item.Price;
                                        Console.Clear();
                                        menu.MenuChoice("Vending");
                                        Console.WriteLine($"\t\tTack för att du köpte en {item.Name}");
                                        Console.WriteLine($"\t\tDu har {x}:- kvar");
                                        menu.MenuChoice("Spacer");
                                        coinbox.AvailableFunds -= item.Price;

                                        WhatToDo(item.Id, item.Cat);
                                        break;
                                    }
                                }
                            }
                        }

                        break;
                    case 'b': // -- Product description
                        Console.Clear();
                        menu.MenuChoice("Vending");
                        ShowListOfProducts();
                        menu.MenuChoice("Explain");

                        int val = int.Parse(Console.ReadLine());

                        foreach (var item in ProductList)
                        {
                            if (val == item.Id)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                menu.MenuChoice("ProductExplain");
                                Console.WriteLine($"\t\tNamn: {item.Name}");
                                Console.WriteLine($"\t\tKategori: {item.Cat}");
                                Console.WriteLine($"\t\tSmak: {item.Taste}");
                                item.Examine();
                                Console.WriteLine($"\t\tPris: {item.Price}");
                                Console.ResetColor();
                                menu.MenuChoice("Spacer");
                            }
                        }

                        break;
                    case 'p': // -- Insert coin

                        Boolean noMoreCoins = false;
                        while (!noMoreCoins)
                        {
                            char money;
                            do
                            {
                                Console.Clear();
                                menu.MenuChoice("Vending");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"\n\t\tTillgängligt belopp: {coinbox.AvailableFunds}:-");
                                Console.ResetColor();
                                menu.MenuChoice("KeepInsertingCoin");
                                money = Convert.ToChar(Console.ReadLine());
                            }
                            while (money != 'n' && money != 'j');

                            switch (money)
                            {
                                case 'n':
                                    noMoreCoins = true;
                                    break;
                                case 'j':
                                    menu.MenuChoice("InsertCoin");
                                    coinbox.MoneyDeposited(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                default:
                                    Console.WriteLine("hej");
                                    break;
                            }


                        }

                        break;
                    case 'a': // -- Exit
                        menu.MenuChoice("ShotDown");

                        if (coinbox.AvailableFunds > 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            coinbox.FundsToReturn();
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\t\tInga pengar i retur");
                            Console.ResetColor();
                        }
                        keepAlive = true;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }


        }

        public void WhatToDo(int itemId, string itemCat)
        {

            char choice;
            Console.ForegroundColor = ConsoleColor.Blue;
            do
            {
                foreach (var item in ProductList)
                {
                    if (itemId == item.Id)
                    {
                        item.Use();
                    }
                }

                choice = Convert.ToChar(Console.ReadLine());

            } while (choice != 'j' && choice != 'n');

            switch (choice)
            {
                case 'j':
                    Console.WriteLine("\t\tHoppas det smakar!");
                    break;
                case 'n':
                    Console.WriteLine("\t\tDå får du spara till senare!");
                    break;
            }
            Console.ResetColor();

            RemoveFromProductList(itemId - 1);



        }

        public void RemoveFromProductList(int itemToRemove)
        {
            ProductList.RemoveAt(itemToRemove);
        }

        public void CreateProductList()
        {
            Drinks drink1 = new Drinks("Drink", "CocaCola", "Smakar cola", 15);
            Drinks drink2 = new Drinks("Drink", "Fanta", "Smakar apelsin", 12);
            Drinks drink3 = new Drinks("Drink", "Zingo", "Smakar jordgubbar", 10);

            Candies candie1 = new Candies("Candie", "Bilar", "Blandade smaker", 25);
            Candies candie2 = new Candies("Candie", "Toppar", "Blandat jordgubb/lakrits", 23);
            Candies candie3 = new Candies("Candie", "Bridge", "Blandade smaker", 30);

            Cookies cookie1 = new Cookies("Cookie", "Oreo", "Chokladsmak", 45);
            Cookies cookie2 = new Cookies("Cookie", "Singoalla", "Hallonsmak", 50);
            Cookies cookie3 = new Cookies("Cookie", "Marie", "Vaniljsmak", 22);


            ProductList.Add(drink1);
            ProductList.Add(drink2);
            ProductList.Add(drink3);

            ProductList.Add(candie1);
            ProductList.Add(candie2);
            ProductList.Add(candie3);

            ProductList.Add(cookie1);
            ProductList.Add(cookie2);
            ProductList.Add(cookie3);


        }

        public void ShowListOfProducts()
        {
            foreach (var item in ProductList)
            {
                if (item.Cat == "Drink")
                {
                    Console.Write($"\t\t({item.Id}) |");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($" {item.Name}");
                    Console.ResetColor();
                    Console.Write($"\t -> Pris: {item.Price}:-\n");
                }
                else if (item.Cat == "Candie")
                {
                    Console.Write($"\t\t({item.Id}) |");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($" {item.Name}");
                    Console.ResetColor();
                    Console.Write($"\t -> Pris: {item.Price}:-\n");
                }
                else
                {
                    Console.Write($"\t\t({item.Id}) |");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write($" {item.Name}");
                    Console.ResetColor();
                    Console.Write($"\t -> Pris: {item.Price}:-\n");
                }
            }
        }
    }
}
