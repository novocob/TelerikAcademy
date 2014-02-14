using System;
using System.Text;

namespace GenericListTask
{
    class GenericList<T> where T : IComparable
    {
        private T[] ListOfElements;
        private int size;
        private int lastElementIndex;

        public GenericList(int size)
        {
            this.ListOfElements = new T[size];
            this.lastElementIndex = -1;
            this.size = size;
        }

        public void Add(T newElement)
        {
            if (this.lastElementIndex + 1 >= this.size)
            {
                IncreaseSizeOfList();
            }
                this.lastElementIndex++;
                this.ListOfElements[lastElementIndex] = newElement; 
        }

        public void Remove(int index)
        {
            if (index < 0 || index > this.lastElementIndex)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = index; i < lastElementIndex; i++)
            {
                this.ListOfElements[i] = this.ListOfElements[i + 1];
            }
            this.ListOfElements[lastElementIndex] = default(T);
            this.lastElementIndex--;
        }

        public void Insert(int index, T newElement)
        {
            if (index < 0 || index > this.lastElementIndex)
            {
                throw new IndexOutOfRangeException();
            }
            if (this.lastElementIndex + 1 >= this.size)
            {
                IncreaseSizeOfList();
            }
            for (int i = index; i <= lastElementIndex; i++)
            {
                this.ListOfElements[i+1] = this.ListOfElements[i];
            }
            this.ListOfElements[index] = newElement;
            this.lastElementIndex++;
        }

        public T GetElementAtIndex(int index)
        {
            if (index < 0 || index > this.lastElementIndex)
            {
                throw new IndexOutOfRangeException();
            }
            return this.ListOfElements[index];
        }

        public void IncreaseSizeOfList()
        {
            T[] newListOfElements = new T[this.size * 2];
            this.size *= 2;
            for (int i = 0; i <= this.lastElementIndex; i++)
            {
                newListOfElements[i] = ListOfElements[i];
            }
            this.ListOfElements = newListOfElements;
        }

        public void Clear()
        {
            T[] newListOfElements = new T[1];
            this.size = 1;
            this.lastElementIndex = -1;
            this.ListOfElements = newListOfElements;
        }

        public int Find(T element)
        {
            int index = -1;
            for (int i = 0; i <= this.lastElementIndex; i++)
            {
                if (this.ListOfElements[i].CompareTo(element) == 0)
                {
                    index = i;
                }
            }
            return index;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= this.lastElementIndex; i++)
            {
                sb.Append(this.ListOfElements[i] + " ");
            }
            return sb.ToString();
        }

        public T Min()
        {
            if (lastElementIndex == -1)
            {
                throw new InvalidOperationException("The list is empty.");
            }
            T minElement = this.ListOfElements[0];
            for (int i = 1; i <= lastElementIndex; i++)
            {
                if (minElement.CompareTo(this.ListOfElements[i]) > 0)
                {
                    minElement = this.ListOfElements[i];
                }
            }
            return minElement;
        }

        public T Max()
        {
            if (lastElementIndex == -1)
            {
                throw new InvalidOperationException("The list is empty.");
            }
            T maxElement = this.ListOfElements[0];
            for (int i = 1; i <= lastElementIndex; i++)
            {
                if (maxElement.CompareTo(this.ListOfElements[i]) < 0)
                {
                    maxElement = this.ListOfElements[i];
                }
            }
            return maxElement;
        }
    }  
}
