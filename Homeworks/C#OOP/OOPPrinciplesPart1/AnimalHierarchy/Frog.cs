namespace AnimalHierarchy
{
    public class Frog : Animal
    {
        public Frog(string name, int age, Sex sex) : base(name, age, sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
    }
}