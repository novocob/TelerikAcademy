﻿/* 15.Write a program that replaces in a HTML document given as 
   string all the tags <a href="…">…</a> with corresponding 
   tags [URL=…]…/URL]. Sample HTML fragment:

    <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training 
    course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>

    <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training 
    course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>       */

using System;

class ReplaceTags
{
    static void Main()
    {
        string htmlDoc = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        string modifiedDoc = htmlDoc.Replace("<a href=\"", "[URL=");
        modifiedDoc = modifiedDoc.Replace("\">", "]");
        modifiedDoc = modifiedDoc.Replace("</a>", "[/URL]");
        Console.WriteLine("Modified document:");
        Console.WriteLine(modifiedDoc);
    }
}
