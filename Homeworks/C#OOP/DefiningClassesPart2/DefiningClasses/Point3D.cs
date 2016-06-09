namespace DefiningClasses
{
    using System;

    public struct Point3D
    {
        private static readonly Point3D NullPoint = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        
        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }
 
        public Point3D Point0
        {
            get
            {
                return NullPoint;
            }            
        }

        public override string ToString()
        {
            string output = string.Format("{0}{1}{2}", this.X, this.Y, this.Z);
            return output;
        }
    }
}
