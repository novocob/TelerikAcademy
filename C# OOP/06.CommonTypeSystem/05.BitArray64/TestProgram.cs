using System;

namespace _05.BitArray64
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            BitArray64 object1 = new BitArray64(38945);
            BitArray64 object2 = new BitArray64(1459870);
            BitArray64 object3 = new BitArray64(38945);
            Console.WriteLine("The ulong value is: {0}", object1.Number);
            Console.WriteLine("Check ToString(): " + object1);
            Console.WriteLine("Check Equals: " + object1.Equals(object3));
            Console.WriteLine("Check == : " + (object1 == object3));
            Console.WriteLine("Check GetHashCode : " + object1.GetHashCode());
            Console.WriteLine("Check [] :" + object1[63]);
            Console.Write("Check iteration: ");
            foreach (var bit in object1)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
        }
    }
}
