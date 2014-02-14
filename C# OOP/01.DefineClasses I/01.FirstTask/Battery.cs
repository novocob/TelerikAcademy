using System;
using System.Text;

namespace _01.FirstTask
{
    class Battery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType batteryType;

        //constructors
        public Battery()
        {
        }
      
        public Battery(string model)
        {
            this.model = model;
        }

        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType batteryType)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = batteryType;
        }

        //properties
        public string Model
        {
            get { return this.model; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Battery model is not valid!");
                }
                else
                {
                    this.model = value;
                }
            }
        }
        public double HoursIdle
        {
            get { return this.hoursIdle; }
            set 
            {
                if (this.hoursIdle < 0)
                {
                    throw new ArgumentException("Hours must be non negative");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }
        public double HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (this.hoursTalk < 0)
                {
                    throw new ArgumentException("Hours must be non negative");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }
    }
}
