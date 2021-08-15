using System;

namespace Shapes
{
    public class Circle: Shape
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        private double radius;
        public double Radius
        {
            get => radius;
            private set { radius = value; }
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);

        }

        public override string Draw()
        {
            return base.Draw() + nameof(Circle);
        }
    }
}
