using System;
using System.Text;
using static HangMan.Utilities;

string theWord = GetNewRandomWord().ToLower();
int theWordLength = theWord.Length;
char[] theWordArr = theWord.ToCharArray();
char[] printArray = new char[theWordLength];
StringBuilder sb = new StringBuilder();
int currentLettersRight = 0;
List<char> currentLettersGuessed = new List<char>();

int antLiv = 9;
int count = -1;

foreach (char character in theWord)
{
    count++;
    printArray[count] = '_';
}

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Välkommen till Hänga Gubbe!");
Console.WriteLine("Gissa på en bokstav eller hela ord!");
Console.ResetColor();

while (antLiv <= 10)
{
    Console.Write("Gissa här: ");
    string playerGuess = Console.ReadLine().ToLower();
    

    foreach (string s in sb.ToString().Split(' '))
    {
        Console.WriteLine($"Du har använd: {s}");
    }

    count = -1;
    

    if (playerGuess?.Length == 1)
    {
       
        if (antLiv == 0)
        {
            Looser(theWord);
            break;
        }
        else
        {

            if (theWord.Contains(playerGuess))
            {
                sb.Append(playerGuess);
                Console.ForegroundColor = ConsoleColor.Green;
                currentLettersGuessed.Add(playerGuess[0]);
                Console.WriteLine($"\nBokstaven '{playerGuess}' finns!");
                Console.WriteLine($"Du har {antLiv} liv kvar!");
                currentLettersRight = PrintWord(currentLettersGuessed, theWord);
                Console.Write("\n");
                Console.WriteLine(printArray);
                Console.ResetColor();

                if (currentLettersRight == theWordLength)
                { 
                    Winner(theWord);
                    break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Boolean alreadyGuessed = sb.ToString().Contains(playerGuess);
                if (alreadyGuessed)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Du har redan använt {playerGuess}");
                }
                else
                {
                    antLiv--;
                }

                sb.Append(playerGuess);
                Console.WriteLine();
                Console.WriteLine($"\nFel! '{playerGuess}' finns inte, försök igen!");
                Console.WriteLine($"Du har {antLiv} liv kvar!");
                Gallows(antLiv);
                currentLettersRight = PrintWord(currentLettersGuessed, theWord);
                Console.Write("\n");
                Console.WriteLine(printArray);
                Console.ResetColor();

                



                


            }

        }
    }
    else
    {
        if (antLiv == 0)
        {
            Looser(theWord);
            break;
        }
        else
        {
            if (playerGuess == theWord)
            {

                Winner(theWord);
                break;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                sb.Append(playerGuess);
                Console.WriteLine($"\n{playerGuess} är fel ord, försök igen!");
                Console.WriteLine($"Du har {antLiv} liv kvar!");
                currentLettersRight = PrintWord(currentLettersGuessed, theWord);
                Console.Write("\n");
                Console.WriteLine(printArray);
                antLiv--;
                Console.ResetColor();
            }
        }
    }
   

    

}
