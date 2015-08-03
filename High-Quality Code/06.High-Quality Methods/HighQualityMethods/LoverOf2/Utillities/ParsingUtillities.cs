namespace LoverOf2.Utillities
{
    using System;
    using System.Linq;

    public static class ParsingUtillities
    {
        public static int[] ParsePathPositions(string pathPositions)
        {
            return pathPositions.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        }
    }
}
