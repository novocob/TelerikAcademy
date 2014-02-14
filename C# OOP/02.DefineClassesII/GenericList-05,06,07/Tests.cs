using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListTask
{
    class Tests
    {
        static void Main()
        {
            //test Add and GetElementAtIndex
            GenericList<string> list = new GenericList<string>(1);
            list.Add("Zero");
            list.Add("One");
            string temp = list.GetElementAtIndex(1);
            Console.WriteLine(temp);
            list.Add("Two");
            temp = list.GetElementAtIndex(2);
            Console.WriteLine(temp);
            Console.WriteLine();

            //test Remove and Insert
            list.Remove(1);
            list.Insert(1, "Three");
            temp = list.GetElementAtIndex(1);
            Console.WriteLine(temp);
            temp = list.GetElementAtIndex(2);
            Console.WriteLine(temp);
            Console.WriteLine();

            //test Clear
            list.Clear();
            list.Add("Four");
            list.Add("Five");
            list.Add("Six");
            temp = list.GetElementAtIndex(0);
            Console.WriteLine(temp);
            temp = list.GetElementAtIndex(1);
            Console.WriteLine(temp);
            temp = list.GetElementAtIndex(2);
            Console.WriteLine(temp);
            Console.WriteLine();

            //test Find
            Console.WriteLine(list.Find("Six"));
            Console.WriteLine(list.Find("Seven"));
            Console.WriteLine();

            //test ToString
            Console.WriteLine(list.ToString());
            


            
            
        }
    }
}
