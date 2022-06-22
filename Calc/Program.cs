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
                int choice;
                // Meny
                do
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\n\t\tMiniräknare\n");
                    Console.WriteLine("\t\tTryck 1 för att + addera");
                    Console.WriteLine("\t\tTryck 2 för att - substrahera");
                    Console.WriteLine("\t\tTryck 3 för att / dividera");
                    Console.WriteLine("\t\tTryck 4 för att * multiplicera");
                    Console.Write("\t\tTryck 0 för att avsluta\t");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                } while (choice != 0 && choice != 1 && choice != 2 && choice != 3 && choice != 4);

                switch (choice)
                {
                    case 0: // Avsluta  

                        Console.Clear();
                        Environment.Exit(0);
                        break;

                    case 1: // Adderad

                        Console.Clear();
                        
                        Console.Write("\n\n\t\tDu valde addition:\n\n");

                        Console.Write("\n\t\tAddera:\t");
                        numA = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\n\t\tMed:\t");
                        numB = Convert.ToInt32(Console.ReadLine());

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"\n\t\t\t{numA} plus {numB} blir: {Counter.Addera(numA, numB)}\n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        
                        break;

                    case 2: // Substrahera

                        Console.Clear();

                        Console.Write("\n\n\t\tDu valde substraktion:\n\n");

                        Console.Write("\n\t\tSubstrahera:\t");
                        numA = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\n\t\tMed:\t");
                        numB = Convert.ToInt32(Console.ReadLine());

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"\n\t\t\t{numA} minus {numB} blir: {Counter.Substrahera(numA, numB)}\n");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        break;

                    case 3: // Dividera

                        Console.Clear();

                        Console.Write("\n\n\t\tDu valde division:\n\n");

                        Console.Write("\n\t\tDividera:\t");
                        numA = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\n\t\tMed:\t");
                        numB = Convert.ToInt32(Console.ReadLine());

                        try
                        {
                            if (Counter.Dividera(numA, numB) == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"\n\t\t\t{numA}  dividerat med {numB} blir: 0\n");
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine($"\n\t\t\t{numA} dividerat med {numB} blir: {Counter.Dividera(numA, numB)}\n");
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"\n\t\t\t{numA} går inte att dividera med 0, testa igen!");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        
                        break;
                       
                    case 4: // Multiplicera

                        Console.Clear();

                        Console.Write("\n\n\t\tDu valde multiplikation:\n\n");

                        Console.Write("\n\t\tMultiplicera:\t");
                        numA = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\n\t\tMed:\t");
                        numB = Convert.ToInt32(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"\n\t\t\t{numA} * {numB} blir: {Counter.Multiplicera(numA, numB)}\n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;

                    default:
                        Console.Clear();
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

