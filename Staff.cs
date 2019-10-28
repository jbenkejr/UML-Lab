using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Lab
{
    class Staff : Person
    {
        public string School { get; set; }
        public double Pay { get; set; }

        public Staff()
        {

        }

        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            School = school;
            Pay = pay;
        }

        public override string ToString()
        {
            return base.ToString() + $"teaches at {School} and makes {Pay:C2} per semester!\n";
        }
    }
}
