namespace Point3D
{
    public struct Point
    {
        private static readonly Point zeroPoint = new Point(0, 0, 0);

        public int X { get; private set; }

        public int Y { get; private set; }

        public int Z { get; private set; }

        public static Point ZeroPoint 
        {
            get
            {
                return zeroPoint;
            }
        }

        public Point(int x, int y, int z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return this.X + ", " + this.Y + ", " + this.Z;
        }
    }
}
