using System;
using System.Linq;

namespace _03.StudentsNames
{
    class StudentNames
    {
        static void Main()
        {
            Student[] students = new Student[5];
            students[0] = new Student("Petar", "Nikolov");
            students[1] = new Student("Iva", "Mileva");
            students[2] = new Student("Nikolai", "Petrov");
            students[3] = new Student("Dobrin", "Dobrev");
            students[4] = new Student("Maria", "Zaneva");

            var filteredStudentsList =
                from student in students
                where string.Compare(student.FirstName, student.LastName) < 0
                select student;
            foreach (var item in filteredStudentsList)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
    }
}
