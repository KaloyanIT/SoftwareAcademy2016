namespace AnimalHierarchy
{
    public class Dogs : Animal
    {
        public Dogs(string name, int age, Sex sex) : base(name, age, sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
    }
}