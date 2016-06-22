namespace _01.StringBuilder.Substring
{
    using System.Text;
    public static class StringBuilderExtensions
    {
        public static string Substring(this StringBuilder currenString, int startIndex, int length)
        {
            StringBuilder newString = new StringBuilder(length);
            int a = 0;
            for (int i = startIndex; i < length; i++)
            {
                newString[a] = currenString[i];
                a++;
            }
            return newString.ToString();
        }
    }
}
