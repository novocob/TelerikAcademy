/*  Sort 3 real values in descending 
 * order using nested if statements.    */

using System;
class SortInDescendingOrder
{
    static void Main()
    {
        Console.Write("Enter first number : ");
        double n1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second number : ");
        double n2 = double.Parse(Console.ReadLine());
        Console.Write("Enter third number : ");
        double n3 = double.Parse(Console.ReadLine());

        if ((n1 >= n2) && (n1 >= n3))
        {
            if (n2 >= n3)
            {
                Console.WriteLine("{0} {1} {2}", n1, n2, n3);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", n1, n3, n2);
            }
        }
        else if ((n1 >= n2) && (n1 <= n3))
        {
            Console.WriteLine("{0} {1} {2}", n3, n1, n2);
        }
        else if ((n1 <= n2) && (n1 <= n3))
        {
            if (n2 <= n3)
            {
                Console.WriteLine("{0} {1} {2}", n3, n2, n1);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", n2, n3, n1);
            }
        }
        else if ((n1 <= n2) && (n1 >= n3))
        {
            Console.WriteLine("{0} {1} {2}", n2, n1, n3);
        }
    }
}

