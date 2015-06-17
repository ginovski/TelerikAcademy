namespace Point3D
{
    using System.Collections.Generic;

    public class Path
    {
        public List<Point> Storage { get; private set; }

        public Path()
        {
            this.Storage = new List<Point>();
        }

        public void Add(Point element)
        {
            Storage.Add(element);
        }
    }
}
