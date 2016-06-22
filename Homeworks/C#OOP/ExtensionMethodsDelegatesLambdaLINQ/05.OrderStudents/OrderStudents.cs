namespace _05.OrderStudents
{
    using System.Linq;
    public class OrderStudents
    {
        static void Main()
        {
            var students = new[]
            {
                new Student {FirstName = "Pesho", LastName = "Ivanov"  },
                new Student {FirstName = "Dragan", LastName = "Ivanov" },
                new Student {FirstName = "Petkan", LastName = "Bivanov" },
                new Student {FirstName = "Ivan", LastName = "Ivanov" },
                new Student {FirstName = "Stoqn", LastName = "Ivanov"  },
                new Student {FirstName = "Batal", LastName = "Ivanov" }
            };

            var orderStudents = students.OrderBy(n => n.FirstName).ThenBy(n => n.LastName).ToList();

            foreach (var item in orderStudents)
            {
                System.Console.WriteLine(item.FirstName);
            }

            var orderListLINQ =
                from someStudent in students
                orderby someStudent.FirstName ascending
                select someStudent;
            System.Console.WriteLine("____________________________________________________________________");
            foreach (var student in orderListLINQ)
            {
                System.Console.WriteLine(student.FirstName);
            }         
        }
    }
}
