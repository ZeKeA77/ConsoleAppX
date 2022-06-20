// See https://aka.ms/new-console-template for more information

namespace Calc
{
    public class Menu
    {

        static void Main()
        {
            Menyn();
        }

        public static void Menyn()
        {
            Console.WriteLine("SKRIV IN ÖNSKAD UPPGIFT (1-4)");
            Console.Write("TRYCK PÅ 0 FÖR ATT AVSLUTA\t");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    Console.Clear();
                    Environment.Exit(0);

                    break;

                case 1:
                    Counter.Plussa();
                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                default:
                    Console.WriteLine("FEL TESTA MELLAN 1-4");
                    break;
            }

        }
    }
}

