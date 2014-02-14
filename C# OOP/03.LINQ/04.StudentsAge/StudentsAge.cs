using System;
using System.Linq;

namespace _04.StudentsAge
{
    class StudentsAge
    {
        static void Main()
        {
            Student[] students = new Student[5];
            students[0] = new Student("Petar", "Nikolov", 20);
            students[1] = new Student("Iva", "Mileva", 25);
            students[2] = new Student("Nikolai", "Petrov", 18);
            students[3] = new Student("Dobrin", "Dobrev", 28);
            students[4] = new Student("Maria", "Zaneva", 22);

            var filterdStudentList =
                from student in students
                where (student.Age > 17) && (student.Age < 25)
                select student;

            foreach (var item in filterdStudentList)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
    }
}
