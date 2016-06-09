namespace DefiningClasses
{
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> pointSequence;

        public Path()
        {
            this.pointSequence = new List<Point3D>();
        }

        public List<Point3D> PointSeqence
        {
            get
            {
                return this.pointSequence;
            }

            set
            {
                this.pointSequence = value;
            }
        }

        public void AddPoint(Point3D point)
        {
            this.pointSequence.Add(point);
        }

        public void PrintPoints()
        {
            foreach (var item in this.pointSequence)
            {
                System.Console.WriteLine("X:{0} Y:{1} Z:{2}", item.X, item.Y, item.Z);
            }
        }
    }
}
