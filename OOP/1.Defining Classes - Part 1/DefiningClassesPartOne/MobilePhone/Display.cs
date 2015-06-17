namespace MobilePhone
{
    using System;
    using System.Text;

    public class Display
    {
        private string size;
        private int numberOfColors;

        public Display(string size = null, int numberOfColors = 0)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public string Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        public int NumberOfColors 
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            var info = new StringBuilder();

            info.AppendFormat("\n\t Size: {0}\n\t ", this.Size);
            info.AppendFormat("Number of colors: {0}", this.NumberOfColors);

            return info.ToString();
        }
    }
}
