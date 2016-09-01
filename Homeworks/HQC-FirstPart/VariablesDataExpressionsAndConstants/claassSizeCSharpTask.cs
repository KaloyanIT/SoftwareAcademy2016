public class Size
{
    public double width, height;
    public Size(double width, double height)
    {
        this.width = width;
        this.Viso4ina = height;
    }

    public static Size GetRotatedSize(Size currentSize, double figureAngle)
    {
        return new Size(
                        Math.Abs(Math.Cos(figureAngle)) * s.width + Math.Abs(Math.Sin(figureAngle)) * s.height,
                        Math.Abs(Math.Sin(figureAngle)) * s.width + Math.Abs(Math.Cos(figureAngle)) * s.height
        );
    }
}