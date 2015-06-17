namespace SchoolClasses
{
    using System;

    public class Discipline : INameable, ICommentable
    {
        private string name;
        private string comment;
        private int numberOfLectures;
        private int numberOfExcercises;

        public Discipline(string name, int numberOfLectures, int numberOfExcercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExcercises = numberOfExcercises;
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

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Lectures cannot be less than zero");
                }

                this.numberOfLectures = value;
            }
        }

        public int NumberOfExcercises
        {
            get
            {
                return this.numberOfExcercises;
            }
            private set
            {

                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Excercises cannot be less than zero");
                }

                this.numberOfExcercises = value;
            }
        }

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
