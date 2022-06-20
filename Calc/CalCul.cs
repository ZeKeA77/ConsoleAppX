


    public class Counter
    {

        public static void Plussa()
        {
        Console.Write("Siffra 1 ");
        int numA = Convert.ToInt32(Console.ReadLine());

        Console.Write("Siffra 2 ");
        int numB = Convert.ToInt32(Console.ReadLine());

        int Svar = numA + numB;


        Console.WriteLine($"\n{numA} plus {numB} blir {Svar} \n\n");

        Console.ReadKey();



        }
    }
