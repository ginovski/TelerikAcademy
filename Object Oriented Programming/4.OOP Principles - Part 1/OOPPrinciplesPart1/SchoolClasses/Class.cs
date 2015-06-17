namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Class : INameable, ICommentable
    {
        private string name;
        private string comment;

        public Class(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }

                this.name = value;
            }
        }
            
        public ICollection<Student> Students { get; set; }

        public ICollection<Teacher> Teachers { get; set; }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Comment cannot be null or empty");
                }

                this.comment = value;
            }
        }
    }
}
