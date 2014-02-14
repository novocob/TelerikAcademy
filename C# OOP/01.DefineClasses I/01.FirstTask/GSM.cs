using System;
using System.Collections.Generic;
using System.Text;

namespace _01.FirstTask
{
    class GSM
    {
        //fields
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery = new Battery();
        private Display display;
        private List<Call> callHistory = new List<Call>();

        private static GSM IPhone4S = new GSM("iPhone 4s", "Apple", 940, "n/a", new Battery("n/a", 200, 8, BatteryType.LiIon), new Display(3.5, "16.7M")); 

        //constructors
        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery baterry, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = new Battery();
            this.Display = new Display();
        }

        //properties
        public static GSM iPhone4S
        {
            get { return IPhone4S; }
        }

        public string Model
        {
            get { return this.model; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid model!");
                }
                else
                {
                    this.model = value;
                }
            }
        }
        public string Manufacturer
        {
            get {return this.manufacturer;}
            set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                else
                {
                this.manufacturer = value ;
                }
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price is not valid!");
                }
                else
                {
                    this.price = value;
                }
            }
        }
        public string Owner
        {
            get { return this.owner; }
            set 
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Invalid name!");
                }
                else
                {
                    this.owner = value;
                }
            }
        }
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }
       
        //methods
        public void AddCall(Call newCall)
        {
            callHistory.Add(newCall);
        }
        public void DeleteCall(int index)
        { 
            callHistory.RemoveAt(index);   
        }
        public void ClearCallHistory()
        {
            callHistory.Clear();
        }

        //override ToString()
        public override string ToString()
        {
            StringBuilder gsmInfo = new StringBuilder();
            gsmInfo.AppendLine("GSM information:");
            gsmInfo.AppendLine(string.Format("Model: {0}", this.Model));
            gsmInfo.AppendLine(string.Format("Manufacturer: {0}", this.Manufacturer));
            gsmInfo.AppendLine(string.Format("Price: {0}", this.Price));
            gsmInfo.AppendLine(string.Format("Owner: {0}", this.Owner));
            gsmInfo.AppendLine(string.Format("Battery: "));
            gsmInfo.AppendLine(string.Format("  Model: {0}", this.battery.Model));
            gsmInfo.AppendLine(string.Format("  Hours Idle: {0}", this.battery.HoursIdle));
            gsmInfo.AppendLine(string.Format("  Hours Talk: {0}", this.battery.HoursTalk));

            return gsmInfo.ToString();
        }
    }
}
