using static StringManipulation.BaseText;
using static StringManipulation.Utilities;
using static System.Console;


string[] completeWords = GetBaseText().Split(' ');                      //Get text and split into words
List<string> chosenWords = DiscardWords(completeWords);                 //Discard words of no interest
Dictionary<string, string> glossary = WordsToDictionary(chosenWords);   //Add words to dictionary

// Work with dictionary
// 1. Get dictionary
// 2. Enter translation
// 3. Improve translation

WriteLine("Work with dictionary");
WriteLine("1. Read all posts");
WriteLine("2. Enter translation");
WriteLine("3. Improve translation");
char choice = ReadKey().KeyChar;
switch (choice)
{
    case '1':
        ReadAllPosts(glossary);
        break;
    case '2':
        EnterTranslation(glossary);
        break;
    default: break;
}

ReadAllPosts(glossary);


//Continue adding translations



//WriteLine($"Enter a translation for '{word.Key}':");