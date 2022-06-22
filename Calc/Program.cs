// See https://aka.ms/new-console-template for more information
// Sjukt enkel kalkylator

namespace Calc
{
    public class Calculator
    {

        static void Main()
        {
            Menyn();
        }

        public static void Menyn()
        {
            while (true)
            {
                int numA;
                int numB;

                // Meny
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Miniräknare");
                Console.WriteLine("1 för att + addera");
                Console.WriteLine("2 för att - substrahera");
                Console.WriteLine("3 för att / dividera");
                Console.WriteLine("4 för att * multiplicera");
                Console.Write("0 för att avsluta\t");
                Console.ForegroundColor = ConsoleColor.Gray;

                int choice = Convert.ToInt32(Console.ReadLine());
                
                switch (choice)
                {
                    case 0: // Avsluta

                        Console.Clear();
                        Environment.Exit(0);
                        break;

                    case 1: // Adderad

                        Console.Clear();

                        Console.Write("\nFörsta siffran:\t");
                        numA = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Andra siffran:\t");
                        numB = Convert.ToInt32(Console.ReadLine());

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"\n\t{numA} + {numB} blir: {Counter.Addera(numA, numB)}\n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        
                        break;

                    case 2: // Substrahera

                        Console.Clear();
                        
                        Console.Write("\nFörsta siffran:\t");
                        numA = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Andra siffran:\t");
                        numB = Convert.ToInt32(Console.ReadLine());

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"\n\t{numA} - {numB} blir: {Counter.Substrahera(numA, numB)}\n");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        break;

                    case 3: // Dividera

                        Console.Clear();

                        Console.Write("\nFörsta siffran:\t");
                        numA = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Andra siffran:\t");
                        numB = Convert.ToInt32(Console.ReadLine());

                        // Kolla efter nollvärde som svar
                        if (Counter.Dividera(numA, numB) == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"\n\t{numA} / {numB} returnerar ett nollvärde! Försök igen\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"\n\t{numA} / {numB} blir: {Counter.Dividera(numA, numB)}\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }

                        break;

                    case 4: // Multiplicera

                        Console.Clear();

                        Console.Write("\nFörsta siffran:\t");
                        numA = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Andra siffran:\t");
                        numB = Convert.ToInt32(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"\n\t{numA} * {numB} blir: {Counter.Multiplicera(numA, numB)}\n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Fel testa ett tal mellan 1 och 4");
                        break;
                }
            }

        }

        
    }

   

    public class Counter // Beräkningarna
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

