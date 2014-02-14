using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace _04.Person
{
    class TestProgram
    {
        static void Main()
        {
            Person t1 = new Person(25, "Ivan Ivanov");
            Person testPerson2 = new Person("Minka Minkova");

            t1.AddCourse(Courses.chemistry);
            t1.AddCourse(Courses.literature);
            foreach (var course in t1.Courses)
            {
                Console.WriteLine(course);
            }
            Console.WriteLine();

            Serializer temp = new Serializer();
            temp.Serialize(t1);
            Person des = temp.Deserialize();
            Console.WriteLine(des.Age);
            Console.WriteLine(des.Name);
            foreach (var course in des.Courses)
            {
                Console.WriteLine(course);
            }
            
        }
    }

    class Serializer
    {
        public void Serialize(Person t1)
        {
            
            BinaryFormatter f = new BinaryFormatter();
            using (Stream stream = new FileStream(
                @"..\..\x.bin", FileMode.Create))
            {
                f.Serialize(stream, t1);
            }
        }

        public Person Deserialize()
        {
            BinaryFormatter f = new BinaryFormatter();
            using (Stream stream = new FileStream(
                @"..\..\x.bin", FileMode.Open))
            {
                Person fe = (Person)
                            f.Deserialize(stream);
                return fe;
            }
            
        }
	}

}
    



