namespace DefiningClasses
{
    using System;

    public static class CalculateDistance
    {
        public static double CalculateDistanceBetweenTwoPoints(Point3D firstPoint, Point3D secondPoint)
        {
            double firstCurrentDistance = (firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X);
            double secondCurrentDistance = (firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y);
            double thirdcurrentDistance = (firstPoint.Z - secondPoint.Z) * (firstPoint.Z - secondPoint.Z);
            double distance = Math.Sqrt(firstCurrentDistance + secondCurrentDistance + thirdcurrentDistance);

            return distance;
        }
    }
}
