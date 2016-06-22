namespace _04.AgeRange
{
    using System.Linq;
    public class AgeRanger
    {
        
        static void Main(string[] args)
        {
            var students = new[]
            {
                new Student {FirstName = "Pesho", LastName = "Ivanov", Age = 19 },
                new Student {FirstName = "Dragan", LastName = "Ivanov", Age = 17 },
                new Student {FirstName = "Petkan", LastName = "Ivanov", Age = 32 },
                new Student {FirstName = "Ivan", LastName = "Ivanov", Age = 22 },
                new Student {FirstName = "Stoqn", LastName = "Ivanov", Age = 25 },
                new Student {FirstName = "Batal", LastName = "Ivanov", Age = 7 }
            };

            var studentsInAgeRange =
                from someStudent in students
                where someStudent.Age >= 18 && someStudent.Age <= 24
                select someStudent;

            foreach (var item in studentsInAgeRange)
            {
                System.Console.WriteLine(item.FirstName);
            }

        }
    }
}
