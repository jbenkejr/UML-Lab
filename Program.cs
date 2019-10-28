using System;
using System.Collections.Generic;

namespace UML_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Bill", "1234 Main Street");

            Student student1 = new Student("Mohammad", "4321 Main Street", "Computer Science", 2020, 23465);
            Student student2 = new Student("Jason", "543 School Street", "Math", 2025, 22222);
            Student student3 = new Student("Jill", "876 Homework Street", "Biology", 2099, 2343465);

            Staff staff1 = new Staff("Clarence", "839 Do Homework St", "UofM", 6000);
            Staff staff2 = new Staff("Amanda", "2345 Come to Class St", "MSU", 14000);

            List<Person> peopleList = new List<Person> { person1, student1, student2, student3, staff1, staff2 };

            foreach (Person p in peopleList)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
