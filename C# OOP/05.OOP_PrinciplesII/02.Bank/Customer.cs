using System;

namespace _02.Bank
{
    public abstract class Customer
    {
        private string idNumber;
        private string name;

        public string ID
        {
            get
            {
                return this.idNumber;
            }
            set
            {
                this.idNumber = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public Customer(string name, string idNumber)
        {
            this.ID = idNumber;
            this.Name = name;
        }
    }
}
