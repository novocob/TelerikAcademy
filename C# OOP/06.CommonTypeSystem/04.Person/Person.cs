using System;
using System.Text;
using System.Collections.Generic;

namespace _04.Person
{
    [Serializable]
    public class Person
    {
        private byte? age;
        private string name;
        

        public byte? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if ((value == string.Empty) || (value == null))
                {
                    throw new ArgumentException("Invalid name!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public List<Courses> Courses { get; set; }



        public Person(byte? age, string name)
        {
            this.Age = age;
            this.Name = name;
            this.Courses = new List<Courses>();
        }

        public Person(string name)
            : this(null, name)
        {
        }

        public void AddCourse(Courses course)
        {
            this.Courses.Add(course);
        }

        public void RemoveCourse(Courses course)
        {
            this.Courses.Remove(course);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Name: {0}", this.Name));
            if (this.Age == null)
            {
                sb.Append("Age: no information");
            }
            else
            {
                sb.Append(string.Format("Age: {0}", this.Age));
            }

            return sb.ToString();
        }
    }
}

