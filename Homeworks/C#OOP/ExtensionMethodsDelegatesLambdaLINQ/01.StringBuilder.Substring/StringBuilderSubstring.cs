namespace _01.StringBuilder.Substring
{
    using System.Text;
    public class StringBuilderSubstring
    {
        static void Main()
        {
            string a = "ssss";
            StringBuilder text = new StringBuilder(a);
            var b = a.Substring(1, 3);
            System.Console.WriteLine(b);
        }
    }
}
