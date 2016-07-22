namespace StartUp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using StudentsAndWorkers;

    class StartUpWorkers
    {
        static void Main(string[] args)
        {
            var listOfStudents = new List<Student>();
            listOfStudents.Add(new Student("Ivan", "Draganov", 4));
            listOfStudents.Add(new Student("Ivan", "Draganov", 5));
            listOfStudents.Add(new Student("Ivan", "Draganov", 2));
            listOfStudents.Add(new Student("Ivan", "Draganov", 3));
            listOfStudents.Add(new Student("Ivan", "Draganov", 4));
            listOfStudents.Add(new Student("Ivan", "Draganov", 5));
            listOfStudents.Add(new Student("Ivan", "Draganov", 6));
            listOfStudents.Add(new Student("Ivan", "Draganov", 6));
            listOfStudents.Add(new Student("Ivan", "Draganov", 2));
            listOfStudents.Add(new Student("Ivan", "Draganov", 2));

            var sortStudents =
                from s in listOfStudents
                orderby s.Grade ascending
                select s;

            var listOfWorkers = new List<Worker>();
            listOfWorkers.Add(new Worker("Pesho", "Peshev", 500));
            listOfWorkers.Add(new Worker("Pesho", "Peshev", 800));
            listOfWorkers.Add(new Worker("Pesho", "Peshev", 900));
            listOfWorkers.Add(new Worker("Pesho", "Peshev", 1500));
            listOfWorkers.Add(new Worker("Pesho", "Peshev", 2500));
            listOfWorkers.Add(new Worker("Pesho", "Peshev", 1300));
            listOfWorkers.Add(new Worker("Pesho", "Peshev", 1200));
            listOfWorkers.Add(new Worker("Pesho", "Peshev", 900));
            listOfWorkers.Add(new Worker("Pesho", "Peshev", 300));
            listOfWorkers.Add(new Worker("Pesho", "Peshev", 600));
            listOfWorkers.Add(new Worker("Pesho", "Peshev", 700));

            var sortWorkers =
                from worker in listOfWorkers
                orderby worker.MoneyPerHour descending
                select worker;
            var listOfHumans = new List<Human>();
            List<Human> humans = listOfHumans.Concat(listOfWorkers)
                .Concat(listOfStudents)
                .ToList();

            var sortHumans = listOfHumans.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();


        }
    }
}
