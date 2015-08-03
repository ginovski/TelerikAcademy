// Refactor the following code to use proper variable naming and simplified expressions:
namespace SizeProject
{
    using System;

    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public static Size GetRotatedSize(Size size, double figureAngle)
        {
            double figureAngleCos = Math.Abs(Math.Cos(figureAngle));
            double figureAngleSin = Math.Abs(Math.Sin(figureAngle));

            double width = (figureAngleCos * size.width) + (figureAngleSin * size.height);
            double height = (figureAngleSin * size.width) + (figureAngleCos * size.height);

            return new Size(width, height);
        }
    }
}
