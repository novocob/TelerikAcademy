/* 12. Write a program that removes from a text file 
 *     all words listed in given another text file. 
 *     Handle all possible exceptions in your methods. */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class DeleteWordsFromList
{
    static void Main()
    {
        try
        {
            StreamReader srListOfWords = new StreamReader(@"..\..\ListOfWords.txt");
            StreamReader reader = new StreamReader(@"..\..\InputFile.txt");
            StreamWriter writer = new StreamWriter(@"..\..\OutputFile.txt");
            using (srListOfWords)
            {
                using (reader)
                {
                    using (writer)
                    {
                        //load all words from ListOfWords.txt in a List
                        List<string> listOfWords = new List<string>();
                        string currentWord = srListOfWords.ReadLine();
                        while (currentWord != null)
                        {
                            listOfWords.Add(currentWord);
                            currentWord = srListOfWords.ReadLine();
                        }

                        //read a line form InputFile.txt
                        string currentLine = reader.ReadLine();
                        while (currentLine != null)
                        {
                            //for every word in List, check if it exists in the current line
                            //and replace it with empty string.
                            foreach (string word in listOfWords)
                            {
                                string pattern = @"\b(" + word + @")\b";
                                currentLine = Regex.Replace(currentLine, pattern, String.Empty);
                            }
                            //write the current line in OutputFile.txt
                            writer.WriteLine(currentLine);
                            currentLine = reader.ReadLine();
                        }
                    }
                }
            }
            File.Delete(@"..\..\InputFile.txt");
            File.Copy(@"..\..\OutputFile.txt", @"..\..\InputFile.txt");
            File.Delete(@"..\..\OutputFile.txt");
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
