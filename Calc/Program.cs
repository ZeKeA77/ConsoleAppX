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
            while (true)
            {
                Console.WriteLine("Miniräknare");
                Console.WriteLine("Tryck 1 för addera");
                Console.WriteLine("Tryck 2 för substrahera");
                Console.WriteLine("Tryck 3 för dividera");
                Console.WriteLine("Tryck 4 för multiplicera");
                Console.Write("TRYCK PÅ 0 FÖR ATT AVSLUTA\t");

                int choice = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nFörsta siffran:\t");
                int numA = Convert.ToInt32(Console.ReadLine());
                Console.Write("Andra siffran:\t");
                int numB = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;

                    case 1:

                        Console.Clear();
                        Console.WriteLine($"\n\t{numA} + {numB} blir: {Counter.Addera(numA, numB)}\n");
                        break;

                    case 2:

                        Console.Clear();
                        Console.WriteLine($"\n\t{numA} - {numB} blir: {Counter.Substrahera(numA, numB)}\n");
                        break;

                    case 3:

                        Console.Clear();

                        if (Counter.Dividera(numA, numB) == 0)
                        {
                            Console.WriteLine($"\n\t{numA} / {numB} returnerar ett nollvärde! Försök igen\n");
                        }
                        else
                        {
                            Console.WriteLine($"\n\t{numA} / {numB} blir: {Counter.Dividera(numA, numB)}\n");
                        }

                        
                        break;

                    case 4:

                        Console.Clear();
                        Console.WriteLine($"\n\t{numA} * {numB} blir: {Counter.Multiplicera(numA, numB)}\n");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Fel testa ett tal mellan 1 och 4");
                        break;
                }
            }

        }

        
    }

    public class Counter
    {


        public static int Addera(int numA, int numB)
        {
            int result = numA + numB;
            return result;
        }

        public static int Substrahera(int numA, int numB)
        {
            int result = numA - numB;
            return result;
        }

        public static int Dividera(int numA, int numB)
        {
            int result = numA / numB;
            return result;
            

        }

        public static int Multiplicera(int numA, int numB)
        {
            int result = numA * numB;
            return result;
        }

    }
}

