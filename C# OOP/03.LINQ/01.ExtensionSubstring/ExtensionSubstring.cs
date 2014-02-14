using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExtensionSubstring
{
    public static class ExtensionSubstring
    {
        //two parameters - int index, int length
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            if ((index < 0) || (length < 0) || (index + length > sb.Length))
            {
                throw new ArgumentOutOfRangeException("Index or length is out of range!");
            }
            sb.Remove(index + length, sb.Length - index - length);
            sb.Remove(0, index);
            return sb;
        }

        // one parameter - int index
        public static StringBuilder Substring(this StringBuilder sb, int index)
        {
            if (index < 0 || index > sb.Length)
            {
                throw new ArgumentOutOfRangeException("Index is out of range!");
            }
            sb.Remove(0, index);
            return sb;
        }


        static void Main()
        {
            //test
            StringBuilder sb = new StringBuilder("0123456789");
            Console.WriteLine(sb);
            sb.Substring(3, 3);
            Console.WriteLine(sb);
            sb = new StringBuilder("0123456789");
            sb.Substring(5);
            Console.WriteLine(sb);
           
        }
    }
}
