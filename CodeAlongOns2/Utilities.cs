using System;
using static System.Console;
namespace StringManipulation
{
    public class Utilities
    {
        public Utilities()
        {
        }

        public static List<string> DiscardWords(string[] words)
        {
            List<string> chosenWords = new();

            bool satisfied = false;
            while (!satisfied)
            {
                foreach (string word in words)
                {
                    Clear();
                    WriteLine($"Discard '{word}'? Hit 'y' (keep with all other keys.)");
                    char keyDiscard = ReadKey().KeyChar;
                    if (keyDiscard != 'y')
                    {
                        chosenWords.Add(word);
                    }
                }
                Clear();
                foreach (string word in chosenWords)
                {
                    WriteLine(word);
                }
                WriteLine("Are you satisfied with the selection? (y / n)");
                char keySatisfied = ReadKey().KeyChar;
                if (keySatisfied == 'y')
                {
                    satisfied = true;
                    Clear();
                }
            }
            return chosenWords;
        }

        public static Dictionary<string, string> WordsToDictionary(List<string> chosenWords)
        {
            Dictionary<string, string> glossary = new Dictionary<string, string>();

            foreach (string word in chosenWords)
            {
                WriteLine($"Enter a Swedish tranlsation for '{word}'. Skip word with straight 'enter'");
                string? translation = ReadLine();
                if (translation != "")
                {
                    glossary.Add($"{word}", $"{translation}");
                }
                else
                {
                    glossary.Add($"{word}", $"_");
                }
            }
            return glossary;
        }

        public static void ReadAllPosts(Dictionary<string, string> glossary)
        {
            Clear();
            WriteLine("Glossary:");
            foreach (KeyValuePair<string, string> word in glossary)
            {
                WriteLine($"{word.Key}: {word.Value}");
            }
            ReadKey();
            Clear();
        }

        public static Dictionary<string, string> EnterTranslation(Dictionary<string, string> glossary)
        {
            var englishWords = glossary.Keys;
            Dictionary<int, string> pairing = new();
            int indexValue = 0;
            foreach (var item in englishWords)
            {
                if (glossary[item] == "_")
                {
                    pairing.Add(++indexValue, item);
                }
            }

            foreach (var item in pairing)
            {
                WriteLine($"{item.Key}. {item.Value}");
            }
            string? wordToEnter = ReadKey().KeyChar.ToString();

            int number = int.Parse(wordToEnter);
            glossary[pairing[number]] = ReadLine();

            return glossary;
        }

    }
}
