/* 21.Write a program that reads a string from the console 
 *    and prints all different letters in the string along with 
 *    information how many times each letter is found. */

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter string : ");
        string text = Console.ReadLine();
        int[] letters = new int[123];
        for (int i = 0; i < text.Length; i++)
        {
            if (((text[i] > 64) && (text[i] < 91)) || ((text[i] > 96) && (text[i] < 123))) //searches for English capital and small letters
            {
                letters[text[i]]++;
            }
        }
        for (int i = 65; i < 123; i++)
        {
            if (letters[i] > 0)
            {
                Console.WriteLine("Letter \"{0}\" is found {1} times.", (char)i, letters[i]);
            }
        }
    }
}
