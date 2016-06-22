namespace _06.DivisibleBy7And3
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Divisble
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {3, 21, 35, 7, 18, 28, 45, 23, 63};

            var divisbleLINQ =
                from num in array
                where (num % 3 == 0 && num % 7 == 0)
                select num;

            var divisble = array.Where(n => n % 3 == 0 && n % 7 == 0).ToList();
            

            foreach (var item in divisbleLINQ)
            {
                Console.WriteLine(item);
            }

            foreach (var nums in divisble)
            {
                Console.WriteLine(nums);
            }

        }
    }
}
