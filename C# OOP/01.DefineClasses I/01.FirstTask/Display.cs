using System;

namespace _01.FirstTask
{
    class Display
    {
        private double size;
        private string colors;

        //constructors
        public Display()
        {
        }

        public Display(double size)
        {
            this.size = size;
        }

        public Display(double size, string colors)
        {
            this.size = size;
            this.colors = colors;
        }

        //properties
        public double Size
        {
            get { return this.size; }
            set
            {
                if (this.size < 0)
                {
                    throw new ArgumentException("Size must be non negative");
                }
                else
                {
                    this.size = value;
                }
            }
        }
        public string Colors
        {
            get { return this.colors; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Invalid colors!");
                }
                else
                {
                    this.colors = value;
                }
            }
        }
    }
}
