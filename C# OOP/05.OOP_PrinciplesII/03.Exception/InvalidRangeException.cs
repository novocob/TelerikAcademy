using System;

namespace _03.Exception
{
    class InvalidRangeException<T> : ApplicationException
    {
        private T min;
        private T max;

        public T Min
        {
            get { return this.min; }
            set { this.min = value; }
        }
        public T Max
        {
            get { return this.max; }
            set { this.max = value; }
        }

        public InvalidRangeException(T min, T max, string message, System.Exception innerException)
            : base(message, innerException)
        {
            this.Min = min;
            this.Max = max;
        }

        public InvalidRangeException(T min, T max)
            : this(min, max, null, null)
        {
        }

        public InvalidRangeException(T min, T max, string message)
            : this(min, max, message, null)
        {
        }
    }
}
