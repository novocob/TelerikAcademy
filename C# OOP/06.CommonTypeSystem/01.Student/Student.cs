using System;
using System.Text;

namespace _01.Student
{
    class Student:ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }
        public Specialty Specialty { get; set; }

        public Student(string firstName, string middleName, string lastName, string sSN, string address, string mobilePhone,
            string email, string course, University university, Faculty faculty, Specialty specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = sSN;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }

        public Student(string firstName, string middleName, string lastName, string sSN)
            : this(firstName, middleName, lastName, sSN, null, null, null, null, University.None, Faculty.None, Specialty.None)
        {
        }

        public override bool Equals(object param)
        {
            if (!(param is Student))
            {
                return false;
            }
            Student student = param as Student;
            if (student.FirstName != this.FirstName || student.MiddleName != this.MiddleName ||
                student.LastName != this.LastName || student.SSN != this.SSN)
            {
                return false;
            }
            return true;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("first name: {0}", this.FirstName));
            sb.AppendLine(string.Format("middle name: {0}", this.MiddleName));
            sb.AppendLine(string.Format("last name: {0}", this.LastName));
            sb.AppendLine(string.Format("university: {0}", this.University));
            sb.AppendLine(string.Format("faculty: {0}", this.Faculty));
            sb.AppendLine(string.Format("specialty: {0}", this.Specialty));
            sb.AppendLine(string.Format("course: {0}", this.Course));
            sb.AppendLine(string.Format("SSN: {0}", this.SSN));
            sb.AppendLine(string.Format("address: {0}", this.Address));
            sb.AppendLine(string.Format("mobile phone: {0}", this.MobilePhone));
            sb.AppendLine(string.Format("email: {0}", this.Email));
            
            return sb.ToString();
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.SSN.GetHashCode();
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return student1.Equals(student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !student1.Equals(student2);
        }

        public Student Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address,
                    this.MobilePhone, this.Email, this.Course, this.University, this.Faculty, this.Specialty);

        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student studentX)
        {
            if (studentX == null)
            {
                return 1;
            }

            
            else 
            {
                if (this.FirstName != studentX.FirstName)
                {
                    return this.FirstName.CompareTo(studentX.FirstName);
                }
                else if (this.MiddleName != studentX.MiddleName)
                {
                    return this.MiddleName.CompareTo(studentX.MiddleName);
                }
                else if (this.LastName != studentX.LastName)
                {
                    return this.LastName.CompareTo(studentX.LastName);
                }
                else if (this.SSN != studentX.SSN)
                {
                    return this.SSN.CompareTo(studentX.SSN);
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
