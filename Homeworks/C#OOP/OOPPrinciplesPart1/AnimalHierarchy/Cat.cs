namespace AnimalHierarchy
{
    public class Cat : Animal
    {
        public Cat(string name, int age, Sex sex) : base(name, age, sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public Cat(string name, int age) : base(name, age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}