using static Calc.Utilities;



while (true)
{
    int numA;
    int numB;
    int choice;
    // Meny
    do
    {
        Menu();
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

            string tt = Console.ReadLine();
            string[] ttNum = tt.Split(",");
            List<int> nums = new List<int>();
            int numx = 0;

            Console.Write("\n\t\tMed:\t");
            numB = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            foreach (string s in ttNum)
            {
                if (Int32.TryParse(s, out numx))
                    nums.Add(numx);
                Console.WriteLine($"\n\t\t\t{numx} plus {numB} blir: {Add(numx, numB)}\n");
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            break;

        case 2: // Substrahera

            Console.Clear();
            Console.Write("\n\n\t\tDu valde substraktion:\n\n");
            Console.Write("\n\t\tSubstrahera:\t");

            string ttx = Console.ReadLine();
            string[] ttNumb = ttx.Split(",");
            List<int> numsb = new List<int>();
            int numxb = 0;

            Console.Write("\n\t\tMed:\t");
            numB = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            foreach (string s in ttNumb)
            {
                if (Int32.TryParse(s, out numxb))
                    numsb.Add(numxb);
                Console.WriteLine($"\n\t\t\t{numxb} minus {numB} blir: {Subtract(numxb, numB)}\n");
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            break;

        case 3: // Dividera

            Console.Clear();

            Console.Write("\n\n\t\tDu valde division:\n\n");


            Console.Write("\n\t\tDividera:\t");
            numA = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\t\tMed:\t");
            numB = Convert.ToInt32(Console.ReadLine());

            if (numA == 0 || numB == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n\t\t\t{numA}  går inte att dividera med {numB} \n");
                Console.WriteLine("\t\t\tFörsök igen");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\t\t\t{numA}  dividerat med {numB} blir: {Divide(numA, numB)}\n");
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
            Console.WriteLine($"\n\t\t\t{numA} * {numB} blir: {Multiply(numA, numB)}\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            break;

        default:
            Console.Clear();
            break;
    }
}
