/* 04.Write a program that downloads a file from Internet 
 *    (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
 *    and stores it the current directory. 
 *    Find in Google how to download files in C#. 
 *    Be sure to catch all exceptions and to free 
 *    any used resources in the finally block. */

using System;
using System.Net;
using System.IO;

class DownloadFile
{
    static void Main()
    {
        using(WebClient myWebClient = new WebClient())
        {
           try
           {
                string filePath = ReadValidFilePath();
                string fullPath = filePath + @"\Logo-BASD.jpg";
                myWebClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", fullPath);
                Console.WriteLine("The file is downloaded successfully.");
            }
            catch (WebException)
            {
                Console.WriteLine("The address is invalid.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The file could not be open or written!");
            }
        }
    }

    static string ReadValidFilePath()
    {
        while (true)
        {
            Console.WriteLine("Enter a full file path (without filename) : ");
            string filePath = Console.ReadLine();
            if (Directory.Exists(filePath))
            {
                return filePath;
            }
            else
            {
                Console.WriteLine("The path doesn't exist.");
            }
        }
    }
}

