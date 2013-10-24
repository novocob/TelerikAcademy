/* 20.Write a program that extracts from a given 
   text all palindromes, e.g. "ABBA", "lamal", "exe". */

using System;

class ExtractPalindromes
{
    static void Main()
    {
        string text = @".exe is a common filename extension denoting an executable file. ABBA is a pop group.";
        char[] separators = new char[] { ' ', '.', ',', '!', '?', '-' };
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        bool isPalindrome = true;
        foreach (string word in words)
        {
            if (word.Length <= 2) continue;
            for (int i = 0; i <= word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome)
            {
                Console.WriteLine(word);
            }
            isPalindrome = true;
        }
    }
}

