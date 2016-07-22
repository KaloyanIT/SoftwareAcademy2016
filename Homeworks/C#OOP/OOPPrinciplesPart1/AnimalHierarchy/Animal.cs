using System;

namespace AnimalHierarchy
{
    public abstract class Animal : ISound
    {
        
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Animal(string name, int age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }


        public int Age { get; set; }

        public string Name { get; set; }

        public Sex Sex { get; set; }
        public string MakeSound(string text)
        {
            return text;
        }

        
    }
}