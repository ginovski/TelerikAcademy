namespace SurfaceCalculations
{
    public abstract class Shape
    {
        public Shape(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height { get; private set; }

        public double Width { get; private set; }

        public abstract double CalculateSurface();
    }
}
