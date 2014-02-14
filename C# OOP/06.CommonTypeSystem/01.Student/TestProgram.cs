using System;

namespace _01.Student
{
    class TestProgram
    {
        static void Main()
        {
            Student student1 = new Student("Ivan", "Ivanov", "Ivankov", "111155555","Sofia", "0888888888", "ivan@abv.bg", 
                "III", University.UASG, Faculty.Engineering, Specialty.CivilEngineer );
            Student student2 = new Student("Milen", "Milenov", "Milenkov", "222233333");
            Student student3 = new Student("Ivan", "Ivanov", "Ivankov", "111155555");

            //test task 1.
            Console.WriteLine("TEST TASK 1.");
            Console.WriteLine(student1.Equals(student2));
            Console.WriteLine(student1.Equals(student3));
            Console.WriteLine(student1 == student2);
            Console.WriteLine(student1 != student2);
            Console.WriteLine(student1.GetHashCode());
            Console.WriteLine(student1);
            
            //test task 2.
            Console.WriteLine("TEST TASK 2.");
            Student student4 = student2.Clone();
            student4.FirstName = "Gogo";
            Console.WriteLine(student4.FirstName);
            Console.WriteLine(student2.FirstName);

            //test task 3.
            Console.WriteLine();
            Console.WriteLine("TEST TASK 3.");
            Console.WriteLine(student1.CompareTo(student2));
            Console.WriteLine(student1.CompareTo(student3));
        }
    }
}
