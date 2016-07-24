using System;
using System.Collections;
using System.Collections.Generic;

namespace Students
{
    public class Course
    {
        private IList<Student> studentList = new List<Student>();
        private int studentCount;

        public IList<Student> StudentList
        {
            get
            {
                return this.studentList;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.studentList = value;
            }
        }

        

        public void AddStudent(Student student)
        {
            if (this.studentList.Count >= 31)
            {
                throw new ArgumentOutOfRangeException("Students cannot be more than 30 in one course");
            }
            StudentList.Add(student);
        }

       
    }
}