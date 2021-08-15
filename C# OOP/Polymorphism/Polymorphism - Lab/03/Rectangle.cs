namespace Shapes
{
    public class Rectangle: Shape
    {
        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }
        private double height;
        private double width;

        public double Height
        {
            get => height;
            private set
            {
                this.height = value;
            }
        }

        public double Width
        {
            get => width;
            private set
            {
                this.width = value;
            }
        }

        public override double CalculatePerimeter()
        {
            return 2 * width + 2 * height;
        }

        public override double CalculateArea()
        {
            return height * width;
        }

        public override string Draw()
        {
            return base.Draw() + nameof(Rectangle);
        }
    }
}
