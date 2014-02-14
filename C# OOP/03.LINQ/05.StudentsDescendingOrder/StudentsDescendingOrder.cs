using System;
using System.Linq;

namespace _05.StudentsDescendingOrder
{
    class StudentsDescendingOrder
    {
        static void Main()
        {
            Student[] students = new Student[5];
            students[0] = new Student("Petar", "Nikolov", 20);
            students[1] = new Student("Iva", "Mileva", 25);
            students[2] = new Student("Petar", "Petrov", 18);
            students[3] = new Student("Dobrin", "Dobrev", 28);
            students[4] = new Student("Iva", "Zaneva", 22);
            
            //lambda expressions
            var sortedStudentsList = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
            foreach (Student student in sortedStudentsList)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();

            //LINQ
            var newStudentList =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;
            foreach (Student student in newStudentList)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }
}
