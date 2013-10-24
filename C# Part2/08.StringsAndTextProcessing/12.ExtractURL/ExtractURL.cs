/* 12.Write a program that parses an URL address given in the format: 
 * [protocol]://[server]/[resource] and extracts from it the 
 * [protocol], [server] and [resource] elements. 
 * For example from the URL http://www.devbg.org/forum/index.php 
 * the following information should be extracted:
    [protocol] = "http"
    [server] = "www.devbg.org"
    [resource] = "/forum/index.php" */

using System;

class Program
{
    static void Main()
    {
        string URL = "http://www.devbg.org/forum/index.php";

        int indexProtocol = URL.IndexOf(@"://");
        string protocol = URL.Substring(0, indexProtocol);
        int indexServer = URL.IndexOf(@"/", indexProtocol + 3);
        string server = URL.Substring(indexProtocol + 3, indexServer - indexProtocol - 3);
        string recource = URL.Substring(indexServer);
        Console.WriteLine("protocol : " + protocol);
        Console.WriteLine("server : " + server);
        Console.WriteLine("recource : " + recource);
    }
}
