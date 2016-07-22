namespace AnimalHierarchy
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, age)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = Sex.Male;
        }
    }
}