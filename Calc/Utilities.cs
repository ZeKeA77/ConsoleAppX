using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Utilities
    {
        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n\t\tMiniräknare\n");
            Console.WriteLine("\t\tTryck 1 för att + addera");
            Console.WriteLine("\t\tTryck 2 för att - substrahera");
            Console.WriteLine("\t\tTryck 3 för att / dividera");
            Console.WriteLine("\t\tTryck 4 för att * multiplicera");
            Console.Write("\t\tTryck 0 för att avsluta\t");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static int Add(int numA, int numB)
        {

            int result = numA + numB;
            return result;
        }

        public static int Subtract(int numA, int numB)
        {
            int result = numA - numB;
            return result;
        }

        public static int Divide(double numA, double numB)
        {
            double result = numA / numB;

            return (int)result;

        }

        public static int Multiply(double numA, double numB)
        {
            double result = numA * numB;
            return (int)result;
        }



    }

}