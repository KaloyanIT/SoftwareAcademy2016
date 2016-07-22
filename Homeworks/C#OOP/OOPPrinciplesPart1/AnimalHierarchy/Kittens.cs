namespace AnimalHierarchy
{
    public class Kittens : Cat
    {
        public Kittens(string name, int age) : base(name, age)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = Sex.Female;
        }
    }
}