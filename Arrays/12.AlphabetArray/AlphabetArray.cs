/*  12. Write a program that creates an array containing all letters 
 *  from the alphabet (A-Z). Read a word from the console and 
 *  print the index of each of its letters in the array. */

using System;
class AlphabetArray
{
    static void Main()
    {
        char[] letters = new char[26];
        for (int i = 0; i < 26; i++)
        {
            letters[i] = (char)(65 + i);
        }
        Console.Write("Enter a word with capital letters: ");
        string word = Console.ReadLine();
        for (int i = 0; i < word.Length; i++)
        {
            for (int k = 0; k < letters.Length; k++ )
            {
                if (word[i] == letters[k])
                {
                    Console.WriteLine("{0} -> {1}", word[i], k);
                    break;
                }
            }
        }
    }
}

