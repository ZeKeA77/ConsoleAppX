namespace VendingMachine
{

    internal class Menu
    {
        public Menu()
        {

        }

        public void MenuChoice(string MenuChoice)
        {
            if (MenuChoice == "Start")
            {
                Console.WriteLine("\n\n\t\tVälkommen till varuautomaten");
                Console.WriteLine("\t\tHär följer våra produkter:\n");
            }
            else if (MenuChoice == "Spacer")
            {
                Console.WriteLine("\n\t\t------------------------\n");
            }
            else if (MenuChoice == "Vending")
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\tVaruautomaten\n");
            }
            else if (MenuChoice == "KeepInsertingCoin")
            {
                Console.Write("\t\tVill du lägga in pengar? (j/n)");
            }
            else if (MenuChoice == "InsufficientCoins")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t\tDu har inte tillräckligt med pengar\n");
                Console.ResetColor();
            }
            else if (MenuChoice == "ChooseToBuy")
            {
                Console.Write("\t\tVälj produkt att köpa ");
            }
            else if (MenuChoice == "InsertCoin")
            {
                Console.WriteLine("\n\t\tTillåtna valörer är: 1, 5, 10, 20, 50, 100, 500, 1000");
                Console.Write("\n\t\tLägg in pengar: ");

            }
            else if (MenuChoice == "ProductExplain")
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\tProduktbeskrivning\n");
            }
            else if (MenuChoice == "Explain")
            {
                Console.Write("\n\t\tVälj produkt för beskrivning ");

            }
            else if (MenuChoice == "WrongFunds")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("\t\tFel inmatning!");
                Console.WriteLine("\t\tTillåtna valörer är: 1, 5, 10, 20, 50, 100, 500, 1000");
                Console.WriteLine();
                Console.ResetColor();
            }
            else if (MenuChoice == "AskToBuy")
            {
                Console.WriteLine("\n\t\t(P) Lägg in pengar");
                Console.WriteLine("\t\t(H) Handla något");
                Console.WriteLine("\t\t(B) Beskrivning av produkt");
                Console.WriteLine("\t\t(A) Avsluta");
                Console.Write("\t\t");
            }
            else if (MenuChoice == "ShotDown")
            {
                Console.Clear();
                Console.WriteLine("\t\tTack för att du handlar hos oss");
                Console.WriteLine("\t\tHa en bra dag.");
            }
        }
    }
}
