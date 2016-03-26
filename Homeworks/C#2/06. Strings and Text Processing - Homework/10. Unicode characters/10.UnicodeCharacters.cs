namespace UnicodeCharecters
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    //•	Write a program that converts a string to a sequence of C# Unicode character literals.
    //•	Use format strings.

    class UnicodeCharacters
    {
        static void Main()
        {
            string str = "Text";
            byte[] unibyte = Encoding.Unicode.GetBytes(str);
            var bytes = new List<byte>();
            for (int i = 0; i < unibyte.Length; i++)
            {
                if (unibyte[i] == 0)
                {
                    continue;
                }
                else
                {
                    bytes.Add(unibyte[i]);
                }
            }
            string uniString = string.Empty;
            foreach (byte b in bytes)
            {
                uniString += string.Format("{0}{1}", @"\u", b.ToString("X"));

            }
            Console.WriteLine(uniString);
           
        }
    }
}

