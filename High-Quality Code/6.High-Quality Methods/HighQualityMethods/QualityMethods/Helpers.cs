namespace QualityMethods
{
    using System;

    public static class Helpers
    {
        public static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides must be positive");
            }

            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }

        public static string DigitToText(int digit)
        {
            switch (digit)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    throw new ArgumentException("Value must be a digit [0-9]");
            }
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("There must be at least one number.");
            }

            int max = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        public static void PrintNumberWithPrecision(double number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        public static void PrintNumberAsPercentage(double number)
        {
            {
                Console.WriteLine("{0:p0}", number);
            }
        }

        public static void PrintNumberRightAligned(double number)
        {
            Console.WriteLine("{0,8}", number);
        }

        public static double CalculateDistance(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            double pointXDistance = (secondPointX - firstPointX) * (secondPointX - firstPointX);
            double pointYDistance = (secondPointY - firstPointY) * (secondPointY - firstPointY);
            double distance = Math.Sqrt(pointXDistance + pointYDistance);

            return distance;
        }

        public static bool IsLineVertical(double firstPointX, double secondPointX)
        {
            return firstPointX == secondPointX;
        }

        public static bool IsLineHorizontal(double firstPointY, double secondPointY)
        {
            return firstPointY == secondPointY;
        }
    }
}
