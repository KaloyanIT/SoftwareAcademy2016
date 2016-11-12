using System;
using System.Collections.Generic;

using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students.Data;
using Students.Models;
using Students.Models.Migrations;

namespace Students.App
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentsDbContext, Configuration>());
            using (var dbContext = new StudentsDbContext())
            {
                var student = new Student
                {
                    Name = "ivan",
                    StudentId = 1,
                    Number = 10
                };

                dbContext.Students.Add(student);

                //dbContext.Database.CreateIfNotExists();
            }
        }
    }
}
