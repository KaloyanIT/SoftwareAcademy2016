using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Students.Test
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestStudentNameThatShouldNotBeEmpty()
        {
            Student student = new Student();

            student.Name = string.Empty;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestStudentNameThatShouldNotBeNull()
        {
            var student = new Student();

            student.Name = null;
        }

        [TestMethod]
        public void CheckExcpectedValueOfStudentName()
        {
            var name = "Pesho";
            var student = new Student();
            student.Name = "Pesho";

            Assert.AreEqual(name, student.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumberShouldBeBetween10000And99999SmallNumber()
        {
            Student student = new Student();

            student.UniqueNumber = 5;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumberShouldBeBetween10000And99999BigNumber()
        {
            Student student = new Student();

            student.UniqueNumber = 9999999;
        }

        [TestMethod]
        public void CheckExcpectedValueOfStudentUniqueNumber()
        {
            var value = 10500;
            var student = new Student();

            student.UniqueNumber = value;

            Assert.AreEqual(value, student.UniqueNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentsInCourseShouldBeLessThan30()
        {
            Course course = new Course();
            var pedal = new Student();

            for (int i = 0; i < 32; i++)
            {
                course.AddStudent(pedal);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentListShouldNotBeNull()
        {
            var course = new Course();

            course.StudentList = null;
        }

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentNullException))]
        //public void StudentListЦCountShouldNotBeMoreThan30()
        //{
        //    var course = new Course();

            
        //}
    }
}
