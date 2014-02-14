﻿using System;

namespace ConsoleApplication1
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape()
        {
        }

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be a positive number!");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be a positive number!");
                }
                this.height = value;
            }
        }

        public abstract double CalculateSurface();
        
    }
}
