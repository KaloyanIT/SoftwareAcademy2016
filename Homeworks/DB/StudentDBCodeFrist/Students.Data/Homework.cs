using System;
using System.Data;

namespace Students.Data
{
    public class Homework
    {
        public int HomeworkId { get; set; }

        public string Content { get; set; }

        public DateTime? TimeSet { get; set; }
    }
}