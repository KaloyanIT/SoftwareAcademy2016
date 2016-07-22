namespace SchoolSystem
{
    using System;
    using Interfaces;

    public abstract class Person : ICommentable
    {
        private string name;
        private string comment;

        public Person(string name)
        {
            this.Name = name;
        }

        public string Comment
        {
            get
            {
                if (string.IsNullOrWhiteSpace(this.comment))
                {
                    return "No comment yet!";
                }

                return this.comment;
            }

            set
            {
                this.comment = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.ValidateName(value);
                this.name = value;
            }
        }
        
        private void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException();
            }
        }
    }
}