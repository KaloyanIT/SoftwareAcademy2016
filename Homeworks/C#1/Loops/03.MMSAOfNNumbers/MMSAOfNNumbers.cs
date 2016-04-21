using System;

class MMSAOfNNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        double currentMin;
        double min = double.MaxValue;
        double max = double.MinValue;
        double currentMax;
        
        for (int i = 0; i < n; i++)
        {
            double currentNum = double.Parse(Console.ReadLine());
            sum += currentNum;
            currentMin = currentNum;
            if (currentMin < min)
            {
                min = currentMin;
            }
            currentMax = currentNum;
            if (currentMax > max)
            {
                max = currentMax;
            }
        }
        double avg = sum / n;
        Console.WriteLine("min={0:F2}", min);
        Console.WriteLine("max={0:F2}", max);
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("avg={0:F2}", avg);
    }
}

