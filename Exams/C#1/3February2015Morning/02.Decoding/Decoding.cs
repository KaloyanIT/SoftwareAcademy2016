using System;
using System.Text;

class Decoding
{
    static void Main()
    {
        int salt = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        byte[] bytes = Encoding.ASCII.GetBytes(input);
        double[] encodedChars = new double[bytes.Length];
        
        //foreach (byte b in bytes)
        //{
        //    Console.WriteLine(b);
        //}

        for (int position = 0; position < input.Length; position++)
        {
            double currentCharCode = (double)bytes[position];
            bool isLetter = (currentCharCode > 64 && currentCharCode < 91) ||
                        (currentCharCode > 96 && currentCharCode < 123);
            bool isDigit = currentCharCode > 47 && currentCharCode < 58;
            

            if (input[position] == '@')
            {
                break;
            }
            if (isLetter)
            {
                encodedChars[position] = (currentCharCode*salt) + 1000;
            }
            if (isDigit)
            {
                encodedChars[position] = currentCharCode + salt + 500;
            }
            if(isDigit == false && isLetter == false)
            {
                encodedChars[position] = currentCharCode - salt;
            }        
        }

        for (int number = 0; number < encodedChars.Length - 1; number++)
        {
            if (number % 2 == 0)
            {
                double currentNumber = encodedChars[number] /= (double)100;
                Console.WriteLine("{0:0.00}", currentNumber);
            }
            else
            {
                encodedChars[number] *= 100;
                Console.WriteLine(encodedChars[number]);
            }
        }
    }
}

