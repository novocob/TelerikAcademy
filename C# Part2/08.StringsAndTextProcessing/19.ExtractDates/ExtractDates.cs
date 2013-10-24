/* 19. Write a program that extracts from a given text all dates 
 * that match the format DD.MM.YYYY. 
 * Display them in the standard date format for Canada. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ExtractDates
{
    static void Main()
    {
        string text = @"I was born at 14.06.1980. My sister was born at 3.7.1984. 
                        In 5/1999 I graduated my high school. The law says (see section 7.3.12) 
                        that we are allowed to do this (section 7.4.2.9).";

        //^(19|20)\d\d[- /.](0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])$
        string pattern = @"([1-9]|0[1-9]|[12][0-9]|3[01])[-/.](0[1-9]|1[012]|[1-9])[-/.](19|20)\d\d";
        Regex rgx = new Regex(pattern);
        foreach (Match match in rgx.Matches(text))
        {
            Console.WriteLine(match);
        }
    }
}
