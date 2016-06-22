namespace _03.FirstBeforeLast
{
    using System;
    using System.Linq;
    class FirstBeforeLast
    {
        static void Main()
        {
            var Student = new { Name = "Pesho",  Surname = "Ivanov" };

            var students = new[]
            {
               new  Student { Name = "Pesho", Surname = "Ivanov"},
               new  Student { Name = "Ivan", Surname = "Ivanov"},
               new  Student { Name = "Dragan", Surname = "Ivanov"},
               new  Student { Name = "Petkan", Surname = "Ivanov"},
               new  Student { Name = "Sevdjan", Surname = "Pevanov"}               
           };

            var newArray =
                from first in students
                where string.Compare(first.Name, first.Surname) == -1
                select first;

            foreach (var item in newArray)
            {
                Console.WriteLine(item.Name + " " + item.Surname);
            }
                    







        }
    }
}
