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
            Console.WriteLine("Miniräknare");
            Console.WriteLine("Tryck 1 för addera");
            Console.WriteLine("Tryck 2 för substrahera");
            Console.WriteLine("Tryck 3 för dividera");
            Console.WriteLine("Tryck 4 för multiplicera");
            Console.Write("TRYCK PÅ 0 FÖR ATT AVSLUTA\t");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Första siffran:\t");
            int numA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Andra siffran:\t");
            int numB = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.Clear();
                    Environment.Exit(0);
                    break;

                case 1:

                    Console.Clear();
                    Console.WriteLine($"\n\t{numA} + {numB} blir: {Counter.addera(numA, numB)}\n");
                    Menu.Menyn();
                    break;

                case 2:
                    
                    Console.Clear();
                    Console.WriteLine($"\n\t{numA} - {numB} blir: {Counter.substrahera(numA, numB)}\n");
                    Menu.Menyn();
                    break;

                case 3:

                    Console.Clear();
                    Console.WriteLine($"\n\t{numA} / {numB} blir: {Counter.dividera(numA, numB)}\n");
                    Menu.Menyn();
                    break;

                case 4:

                    Console.Clear();
                    Console.WriteLine($"\n\t{numA} * {numB} blir: {Counter.multiplicera(numA, numB)}\n");
                    Menu.Menyn();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("FEL TESTA MELLAN 1-4");
                    Menu.Menyn();
                    break;
            }

        }

        
    }
}

