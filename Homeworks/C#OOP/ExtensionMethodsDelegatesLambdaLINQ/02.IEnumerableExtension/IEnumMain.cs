namespace _02.IEnumerableExtension
{
        
    using System.Collections.Generic;

    public class IEnumMain
    {
        static void Main()
        {
            IEnumerable<int> item = new List<int> { 5, 2, 3, 4, 5, 5 };
            System.Console.WriteLine(item.Sum());
            System.Console.WriteLine(item.Minimal());
            System.Console.WriteLine(item.Maximal());
            System.Console.WriteLine(item.Average());
            System.Console.WriteLine(item.Product());
        }
    }
}
