using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Lab
{
    class Student : Person
    {
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }

        public Student()
        {

        }

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public override string ToString()
        {
            return base.ToString() + $"studies in the {Program} program, will graduate in {Year} and pays {Fee:C2} in tuition!\n";
        }
    }
}
