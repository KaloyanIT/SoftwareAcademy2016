using System;

//Problem 2. Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

class GravitationOnTheMoon
{
    static void Main()
    {        
        double weightEarth = double.Parse(Console.ReadLine());
        double weightMoon = weightEarth * 0.17;
        Console.WriteLine("{0:F3}", weightMoon);
    }
}

