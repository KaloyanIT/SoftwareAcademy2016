namespace SchoolSystem
{
    using System.Collections.Generic;

    public class School
    {
        private List<Class> classes;
        private string name;

        public School(string name)
        {
            this.Name = name;
            this.classes = new List<Class>();
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public void AddCourse(Class classes)
        {
            this.classes.Add(classes);
        }

        public List<Class> GetCourses()
        {
            return new List<Class>(this.classes);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}