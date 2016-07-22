using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var cat = new Cat("Pesho", 10);
            var animal = new Cat("Ivan", 12);

            var listOfAnimals = new List<Animal>();
            listOfAnimals.Add(cat);
            listOfAnimals.Add(animal);
            Console.WriteLine(listOfAnimals.CalculateAverageAge());
        }

        //public static int CalculateAverageAge(this List<Animal> animals)
        //{
        //    return 0;
        //}
    }
}
