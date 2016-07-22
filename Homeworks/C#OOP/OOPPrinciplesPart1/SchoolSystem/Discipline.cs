namespace SchoolSystem
{
    using System;

    public class Discipline : Person
    {
        private int exercises;
        private int lectures;
        private uint uniqueNumber;
      
        public Discipline(string name, uint uniqueNumber, int lecures, int exercises)
            : base(name)
        {
            this.UniqueNumber = uniqueNumber;
            this.NumberOfLectures = lecures;
            this.NumberOfExercises = exercises;
        }

        public int NumberOfExercises
        {
            get { return this.exercises; }
            set { this.exercises = value; }
        }

        public int NumberOfLectures
        {
            get { return this.lectures; }
            set { this.lectures = value; }
        }

        public uint UniqueNumber
        {
            get { return this.uniqueNumber; }
            set { this.uniqueNumber = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}). Lectures: {2}, Exercises: {3}", this.Name, this.UniqueNumber, this.NumberOfLectures, this.NumberOfExercises);
        }
    }
}