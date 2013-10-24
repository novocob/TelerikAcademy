/* 03. Write a program that enters file name along with 
 *     its full file path (e.g. C:\WINDOWS\win.ini), 
 *     reads its contents and prints it on the console. 
 *     Find in MSDN how to use System.IO.File.ReadAllText(…).
 *     Be sure to catch all possible exceptions and print user-friendly error messages. */

using System;
using System.Text;
using System.IO;

class ReadAllText
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Enter a file name along with its full file path : ");
                string filePath = Console.ReadLine();
                string readText = File.ReadAllText(filePath);
                Console.WriteLine(readText);
                break;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Path is a zero-length string, contains only white space, or contains one or more invalid characters.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory not found.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file specified in path was not found.");
            }
            catch (IOException)
            {
                Console.WriteLine("Error occured while opening the file.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("The file is read-only or");
                Console.WriteLine("The operation is not supported in the current platform or");
                Console.WriteLine("The entered path is to a directory or");
                Console.WriteLine("You don't have the permission for this operation.");
            }
        }
    }
}

