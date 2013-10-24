/* 13.Write a program that reads a list of words from a file words.txt 
 * and finds how many times each of the words is contained in another 
 * file test.txt. The result should be written in the file result.txt 
 * and the words should be sorted by the number of their occurrences 
 * in descending order. Handle all possible exceptions in your methods.*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

class CountWords
{
    static void Main()
    {
        try
        {
            StreamReader readerWords = new StreamReader(@"..\..\words.txt");
            StreamReader readerTest = new StreamReader(@"..\..\test.txt");
            StreamWriter writer = new StreamWriter(@"..\..\result.txt");
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            using (readerWords)
            {
                //the words form words.txt are put in a dictionary as keys
                string currentWord = readerWords.ReadLine();
                while (currentWord != null)
                {
                    dictionary.Add(currentWord, 0);
                    currentWord = readerWords.ReadLine();
                }
            }
            List<string> testWords = new List<string>(dictionary.Keys);

            using (readerTest)
            {
                string test = readerTest.ReadToEnd();
                foreach (string word in testWords)
                {
                    string regex = String.Format("\\b{0}\\b", word); //changes the pattern of regex using the current word
                    MatchCollection matches = Regex.Matches(test, regex);//finds how many times the current word exists
                    dictionary[word] += matches.Count; //saves in the dictionary the number of occurrences
                }
            }

            using (writer)
            {
                //writes in result.txt the content of the dictionary in descending order
                foreach (var wordCounter in dictionary.OrderByDescending(key => key.Value))
                {
                    writer.Write(wordCounter.Key);
                    writer.Write("-");
                    writer.WriteLine(wordCounter.Value);
                }
            }
        }

        catch (FileNotFoundException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (DirectoryNotFoundException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (ArgumentException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (OutOfMemoryException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (Exception exc)
        {
            Console.WriteLine(exc.Message);
        }
    }
}
