namespace MobilePhone
{
    using System;
    using System.Text;

    public class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType batteryType;

        public Battery(string model)
        {
            this.Model = model;
        }

        public Battery(string model, int hoursIdle = 0, int hoursTalk = 0)
            : this(model)
        {
            this.HoursTalk = hoursTalk;
            this.HoursIdle = hoursIdle;
        }

        public Battery(string model, int hoursIdle = 0, int hoursTalk = 0, BatteryType batteryType = 0)
            : this(model, hoursIdle, hoursTalk)
        {
            this.BatteryType = batteryType;
        }

        public string Model {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be empty");
                }

                this.model = value;
            }
        }

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("HoursIdle cannot be less than zero");
                }

                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("HoursTalk cannot be less than zero");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }

        public override string ToString()
        {
            var info = new StringBuilder();

            info.AppendFormat("\n\t Model: {0}\n\t ", this.Model);
            info.AppendFormat("HoursIdle: {0}\n\t ", this.HoursIdle);
            info.AppendFormat("HoursTalk: {0}\n\t ", this.HoursTalk);
            info.AppendFormat("Battery Type: {0}", this.BatteryType);

            return info.ToString();
        }
    }
}
