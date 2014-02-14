using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FirstTask
{
    class Call
    {
        //fields
        private DateTime dateTime;
        private string dialedNumber;
        private int duration;

        //constructors
        public Call(string dialedNumber, int duration)
        {
            this.dateTime = DateTime.Now;
            this.dialedNumber = dialedNumber;
            this.duration = duration;
        }

        //properties
        public DateTime DateTime
        {
            get { return this.dateTime; }
            set { this.dateTime = value; }
        }
        public string DialedNumber
        {
            get { return this.dialedNumber; }
            set { this.dialedNumber = value; }
        }
        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

    }
}
