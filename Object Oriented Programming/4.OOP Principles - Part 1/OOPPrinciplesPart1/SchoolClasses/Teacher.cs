namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Teacher : Person, ICommentable
    {
        public Teacher(string name) : base(name)
        {
        }

        public ICollection<Discipline> Disciplines { get; set; }
    }
}
