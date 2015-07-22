namespace AbstractionAndEncapsulation.Validation
{
    using System;

    public static class FiguresValidator
    {
        public static void ValidateSide(double side, string field)
        {
            if (side <= 0)
            {
                throw new ArgumentOutOfRangeException(string.Format("{0} cannot be less or equal to zero", field));
            }
        }
    }
}
