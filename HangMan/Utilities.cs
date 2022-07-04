using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    internal class Utilities
    {
        public static string GetNewRandomWord()
        {
            Random rnd = new Random();
            string[] secretWord = { "flaska", "hund", "pizza", "mus", "Argentina", "tangent", "Hängmatta", "yxa", "pengar", "fläkt", "samsung" };
            int i = rnd.Next(secretWord.Length);
            var secret = secretWord[i];

            return secret;
        }

       

        public static int PrintWord(List<char> guessedLetters, String randomWord)
        {
            int counter = 0;
            int rightLetters = 0;
            Console.Write("\r\n");
            foreach (char c in randomWord)
            {
                if (guessedLetters.Contains(c))
                {
                    Console.Write(c);
                    rightLetters++;
                }
                else
                {
                    Console.Write(" ");
                }
                counter++;
            }
            return rightLetters;
        }

        public static string Gallows(int gallowLives)
        {
            string gallowBuild = "";

            if(gallowLives == 9)
            {
                Console.Write("\n\n     ||\n");
                Console.Write("     ||\n");
                Console.Write("     ||\n");
                Console.Write("     ||\n");
                Console.Write("     ||\n");
                Console.Write("============\n");
            }
            else if (gallowLives == 8)
            {
                Console.Write("\n\n     ======\n");
                Console.Write("     ||\n");
                Console.Write("     ||\n");
                Console.Write("     ||\n");
                Console.Write("     ||\n");
                Console.Write("     ||\n");
                Console.Write("============\n");
            }
            else if (gallowLives == 7)
            {
                Console.Write("\n\n     ======\n");
                Console.Write("     ||   |\n");
                Console.Write("     ||\n");
                Console.Write("     ||\n");
                Console.Write("     ||\n");
                Console.Write("     ||\n");
                Console.Write("============\n");
            }
            else if (gallowLives == 6)
            {
                Console.Write("\n\n     ======\n");
                Console.Write("     ||   |\n");
                Console.Write("     ||   O\n");
                Console.Write("     ||\n");
                Console.Write("     ||\n");
                Console.Write("     ||\n");
                Console.Write("============\n");
            }
            else if (gallowLives == 5)
            {
                Console.Write("\n\n     ======\n");
                Console.Write("     ||   |\n");
                Console.Write("     ||   O\n");
                Console.Write("     ||   |\n");
                Console.Write("     ||\n");
                Console.Write("     ||\n");
                Console.Write("============\n");
            }
            else if (gallowLives == 4)
            {
                Console.Write("\n\n     ======\n");
                Console.Write("     ||   |\n");
                Console.Write("     ||   O\n");
                Console.Write("     ||  /|\n");
                Console.Write("     ||\n");
                Console.Write("     ||\n");
                Console.Write("============\n");
            }
            else if (gallowLives == 3)
            {
                Console.Write("\n\n     ======\n");
                Console.Write("     ||   |\n");
                Console.Write("     ||   O\n");
                Console.Write("     ||  /|\\ \n");
                Console.Write("     ||\n");
                Console.Write("     ||\n");
                Console.Write("============\n");
            }
            else if (gallowLives == 2)
            {
                Console.Write("\n\n     ======\n");
                Console.Write("     ||   |\n");
                Console.Write("     ||   O\n");
                Console.Write("     ||  /|\\ \n");
                Console.Write("     ||  /\n");
                Console.Write("     ||\n");
                Console.Write("============\n");
            }
            else if (gallowLives == 1)
            {
                Console.Write("\n\n     ======\n");
                Console.Write("     ||   |\n");
                Console.Write("     ||   O\n");
                Console.Write("     ||  /|\\ \n");
                Console.Write("     ||  / \\ \n");
                Console.Write("     ||\n");
                Console.Write("============\n");
            }

            return gallowBuild;
        }

        public static void Winner(String secretWord)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\n\nRätt ord är: {secretWord}");
            Console.WriteLine("Du har vunnit!!");
            Console.ResetColor();
            Console.ReadKey();
        }

        public static void Looser(String secretWord)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nTyvärr du har förlorat");
            Console.WriteLine($"Rätt ord ska vara: {secretWord}");
            Console.ReadKey();
        }
 
 
    }
}
