using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _05.BitArray64
{
    class BitArray64:IEnumerable<int>
    {
        private ulong number;
        private int[] bits = new int[64];

        public BitArray64(ulong number)
        {
            this.number = number;
            this.bits = ConvertToBits();
        }

        public ulong Number
        {
            get
            {
                return this.number;
            }
        }

        public int[] Bits
        {
            get
            {
                return this.ConvertToBits();
            }
        }

        public int[] ConvertToBits()
        {
            ulong tempNumber = this.number;
            for (int i = 0; i < 64; i++)
            {
                bits[i] = (int)tempNumber % 2;
                tempNumber /= 2;
            }
            Array.Reverse(bits);
            return bits;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (int bit in bits)
            {
                sb.Append(bit);
            }
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            BitArray64 tempObject = obj as BitArray64;
            if (obj == null)
            {
                return false;
            }

            return (this.Number.Equals(tempObject.Number));
        }

        public static bool operator ==(BitArray64 object1, BitArray64 object2)
        {
            return object1.Equals(object2);
        }

        public static bool operator !=(BitArray64 object1, BitArray64 object2)
        {
            return !object1.Equals(object2);
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode() ^ this.Bits.GetHashCode();
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new System.IndexOutOfRangeException();
                }
                return bits[index];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < bits.Length; i++)
            {
                yield return bits[i];
            }
        }

    }
}
