using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Students.Data
{
    public class Course
    {
        private ICollection<Student> students;
        public Course()
        {
            this.students = new HashSet<Student>();
        }

        public int CourseId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Materials { get; set; }

        public virtual Homework Homework { get; set; }

        public ICollection<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }
    }
}