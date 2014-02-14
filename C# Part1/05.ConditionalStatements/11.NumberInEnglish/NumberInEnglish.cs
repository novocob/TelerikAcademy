/*  * Write a program that converts a number in the range [0...999] 
 * to a text corresponding to its English pronunciation. Examples:
	0  "Zero"
	273  "Two hundred and seventy three"
	400  "Four hundred"
	501  "Five hundred and one"
	711  "Seven hundred and eleven"    */

using System;
class NumberInEnglish
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number [0..999] :");
        int codeRead = 0;
        int counter = 0;
        char[]digits = new char[3];

        //Въвежда в масив цифрите от конзолата
        do
        {
            codeRead = Console.Read();
            if ((codeRead != 13) && (codeRead != 10))
            {
                digits[counter] = (char)codeRead;
                counter += 1;
            }

        } while (codeRead != 10);

        //Преподрежда стойностите в масива, в случай, че е въведено
        //едноцифрено или двуцифрено число
        if (counter == 2)
        {
            digits[2] = digits[1];
            digits[1] = digits[0];
            digits[0] = ' ';
        }

        if (counter == 1)
        {
            digits[2] = digits[0];
            digits[1] = ' ';
            digits[0] = ' ';
        }

        //Отпечатва стотиците
        switch (digits[0])
        {
            case '1': Console.Write("one hundred "); break;
            case '2': Console.Write("two hundred "); break;
            case '3': Console.Write("three hundred "); break;
            case '4': Console.Write("four hundred "); break;
            case '5': Console.Write("five hundred "); break;
            case '6': Console.Write("six hundred "); break;
            case '7': Console.Write("seven hundred "); break;
            case '8': Console.Write("eight hundred "); break;
            case '9': Console.Write("nine hundred "); break;
        }

        //Проверка дали има нужда от "and" 
        if ((digits[0] != ' ') && ((digits[1] != '0') || (digits[2] != '0')))
        {
            Console.Write("and ");
        }

        //Ако десетицата е 1 е частен случай, затова използвам if else
        if (digits[1] == '1')
        {
            switch (digits[2])
            {
                case '0': Console.Write("ten"); break;
                case '1': Console.Write("eleven"); break;
                case '2': Console.Write("twelve"); break;
                case '3': Console.Write("thirteen"); break;
                case '4': Console.Write("fourteen"); break;
                case '5': Console.Write("fifteen"); break;
                case '6': Console.Write("sixteen"); break;
                case '7': Console.Write("seventeen"); break;
                case '8': Console.Write("eighteen"); break;
                case '9': Console.Write("nineteen"); break;
            }
        }
        else
        {
            //отпечатва десетиците
            switch (digits[1])
            {
                case '2': Console.Write("twenty "); break;
                case '3': Console.Write("thirty "); break;
                case '4': Console.Write("fourty "); break;
                case '5': Console.Write("fifty "); break;
                case '6': Console.Write("sixty "); break;
                case '7': Console.Write("seventy "); break;
                case '8': Console.Write("eighty "); break;
                case '9': Console.Write("ninety "); break;
            }
            //отпечатва единиците
            switch (digits[2])
            {
                case '1': Console.Write("one"); break;
                case '2': Console.Write("two"); break;
                case '3': Console.Write("three"); break;
                case '4': Console.Write("four"); break;
                case '5': Console.Write("five"); break;
                case '6': Console.Write("six"); break;
                case '7': Console.Write("seven"); break;
                case '8': Console.Write("eight"); break;
                case '9': Console.Write("nine"); break;
            }
        }
        //проверка за "zero"
        if ((digits[0] == ' ') && (digits[1] == ' ') &&(digits[2] == '0'))
        {
            Console.Write("zero");
        }
        Console.WriteLine();
    }
}
