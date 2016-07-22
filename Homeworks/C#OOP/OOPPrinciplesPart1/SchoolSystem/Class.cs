namespace SchoolSystem
{
    using System.Collections.Generic;
    using Interfaces;

    public class Class : ICommentable
    {
        private List<Teacher> teachers;
        private string comment;
        private string name;
        private string uniqueTextIdentifier;

        public Class(string name)
        {
            this.Name = name;
            this.teachers = new List<Teacher>();
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
       
        public string Comment { get; set; }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public List<Teacher> GetTeachers()
        {
            return new List<Teacher>(this.teachers);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}