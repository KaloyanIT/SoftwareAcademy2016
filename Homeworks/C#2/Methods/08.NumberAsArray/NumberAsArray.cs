using System;
using System.Collections.Generic;
using System.Linq;

class NumberAsArray
{
    static void Main()
    {
        string lengths = Console.ReadLine();
        int firstLength = int.Parse(lengths[0].ToString());
        int secondLength = int.Parse(lengths[2].ToString());
        string firstArray = Console.ReadLine();
        string secondArray = Console.ReadLine();
        int lengthDifference, currentLength;
        var sum = new List<int>();
        if (firstLength >= secondLength)
        {
            currentLength = secondLength;
            lengthDifference = firstLength - secondLength;
        }
        else
        {
            currentLength = firstLength;
            lengthDifference = secondLength - firstLength;
        }
        var firstArrayString = firstArray.Split(' ').ToArray();
        var secondArrayString = secondArray.Split(' ').ToArray();
        int addToSum = 0, currentSum;
        for (int i = 0; i < currentLength; i++)
        {
            currentSum = int.Parse(firstArrayString[i]) + int.Parse(secondArrayString[i]);
            if (currentSum >= 10)
            {
                addToSum += currentSum%10;
                sum.Add(addToSum);
                addToSum = currentSum/10;
            }
            else
            {
                addToSum += currentSum;
                sum.Add(addToSum);
                addToSum = 0;
            }
        }
        bool isFirst = true;
        if (firstArrayString.Length > secondArrayString.Length)
        {
            isFirst = true;
        }
        else
        {
            isFirst = false;
        }

        if (isFirst)
        {
            while (currentLength < firstArrayString.Length)
            {
                sum.Add(int.Parse(firstArrayString[currentLength]));
                currentLength++;
            }
        }
        else
        {
            while (currentLength < secondArrayString.Length)
            {
                sum.Add(int.Parse(secondArrayString[currentLength]));
                currentLength++;
            }
        }


        foreach (var o in sum)
        {
            Console.Write(o + " ");
        }
    }
    
    
}