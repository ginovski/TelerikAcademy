namespace Point3D
{
    public static class Space
    {
        public static string CalculateDistance(Point firstPoint, Point secondPoint)
        {
            return (firstPoint.X - secondPoint.X) + ", " + (firstPoint.Y - secondPoint.Y) + ", " + (firstPoint.Z - secondPoint.Z);
        }
    }
}
