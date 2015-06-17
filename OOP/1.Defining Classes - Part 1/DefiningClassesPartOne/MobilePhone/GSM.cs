// Problem 1. Define class

// Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).
// Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        // Problem 6. Static field

        // Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
        private static GSM iPhone4S = new GSM("IPhone4S", "Apple", 500, "Somebody", new Battery("Bateriya", 500, 300), new Display("1900x1080", 1024));

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        // Problem 9. Call history

        // Add a property CallHistory in the GSM class to hold a list of the performed calls.
        // Try to use the system class List<Call>.
        private List<Call> callHistory;

        // Problem 2. Constructors

        // Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
        // Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.CallHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, decimal price = 0, string owner = null)
            : this(model, manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, decimal price = 0, string owner = null,
            Battery battery = null, Display display = null)
            : this(model, manufacturer, price, owner)
        {
            this.Battery = battery;
            this.Display = display;
        }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        // Problem 5. Properties

        // Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
        // Ensure all fields hold correct data at any given time.
        public string Model
        {
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

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer cannot be empty");
                }

                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be less than zero");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return new List<Call>(this.callHistory);
            }
            private set
            {
                this.callHistory = value;
            }
        }

        // Problem 10. Add/Delete calls

        // Add methods in the GSM class for adding and deleting calls from the calls history.
        // Add a method to clear the call history.       
        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public Call DeleteCall(Call call)
        {
            this.callHistory.Remove(call);

            return call;
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        // Problem 11. Call price

        // Add a method that calculates the total price of the calls in the call history.
        // Assume the price per minute is fixed and is provided as a parameter.
        public decimal CalculateCallPrice(decimal pricePerMinute)
        {
            decimal secondsAsMinutes = 0;
            foreach (var call in this.callHistory)
            {
                secondsAsMinutes += ((decimal)(call.Duration) / 60);
            }

            return secondsAsMinutes * pricePerMinute;
        }

        // Problem 4. ToString

        // Add a method in the GSM class for displaying all information about it.
        // Try to override ToString().
        public override string ToString()
        {
            var info = new StringBuilder();

            info.AppendFormat("Model: {0}\n", this.Model);
            info.AppendFormat("Manufacturer: {0}\n", this.Manufacturer);
            info.AppendFormat("Price: {0:C}\n", this.Price);
            info.AppendFormat("Owner: {0}\n", this.Owner);
            info.AppendFormat("Battery: {0}\n", this.Battery);
            info.AppendFormat("Display: {0}", this.Display);

            return info.ToString();
        }
    }
}
