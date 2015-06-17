// Problem 8. Calls

// Create a class Call to hold a call performed through a GSM.
// It should contain date, time, dialled phone number and duration (in seconds).
namespace MobilePhone
{
    using System;
    using System.Text;

    public class Call
    {
        private string date;
        private string time;
        private string dialedPhoneNumber;
        private int duration;

        public Call(string date, string time, string dialedPhoneNumber, int duration)
        {
            this.Date = date;
            this.Time = time;
            this.DialedPhoneNumber = dialedPhoneNumber;
            this.Duration = duration;
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Duration cannot be less than zero");
                }

                this.duration = value;
            }
        }

        public string DialedPhoneNumber
        {
            get
            {
                return this.dialedPhoneNumber;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Dialed number cannot be empty");
                }

                this.dialedPhoneNumber = value;
            }
        }

        public string Time
        {
            get
            {
                return this.time;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Time cannot be empty");
                }

                this.time = value;
            }
        }

        public string Date
        {
            get
            {
                return this.date;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Date cannot be empty");
                }

                this.date = value;
            }
        }

        public override string ToString()
        {
            var info = new StringBuilder();

            info.AppendFormat("Date: {0}\n", this.Date);
            info.AppendFormat("Time: {0}\n", this.Time);
            info.AppendFormat("Dialed phone number: {0}\n", this.DialedPhoneNumber);
            info.AppendFormat("Duration: {0}\n", this.Duration);

            return info.ToString();
        }
    }
}
