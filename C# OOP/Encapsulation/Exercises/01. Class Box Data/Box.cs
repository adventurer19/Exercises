using System;
using System.Collections.Generic;
using System.Text;

namespace Box
{
    public class Box
    {
        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        private double length;
        private double width;
        private double height;

     
        public double Length
        {
            get => length;
            private set
            {
                if (value < 0)
                {
                    ExepCatch(nameof(this.Length));
                }

                length = value;
            }
        }
        public double Width
        {
            get => width;
            private set
            {
                if (value < 0)
                {
                    ExepCatch(nameof(this.Width));
                }

                width = value;
            }
        }
        public double Height
        {
            get => height;
            private set
            {
                if (value < 0)
                {
                    ExepCatch(nameof(this.Height));
                }

                height = value;
            }
        }

        void ExepCatch(string text)
        {
            throw new ArgumentException($"{text} cannot be zero or negative.");
        }
        public double SurfaceArea()
        {
            return 2 * length * width + 2 * length * height + 2 * width * height;
        }
        public double LateralSurfaceArea()
        {
            return 2 * length * height + 2 * width * height;
        }
        public double Volume()
        {
            return length * width * height;
        }
        
    }
}
