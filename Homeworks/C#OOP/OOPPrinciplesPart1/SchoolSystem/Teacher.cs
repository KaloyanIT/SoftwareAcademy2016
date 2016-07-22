namespace SchoolSystem
{
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;   

    public class Teacher : Person
    {
        private List<Discipline> disciplines;

        public Teacher(string name, IEnumerable<Discipline> disciplines) : base(name)
        {
            this.disciplines = disciplines.ToList();
        }

        public List<Discipline> GetDisciplines()
        {
            return new List<Discipline>(this.disciplines);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}