using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Events
{
    internal class Person
    {

        public  string Name { get; set; }

        public int Salary { get; set; }

        public Person(string name,int salary) 
        {
            Name = name;
            Salary = salary;
        }

        public delegate bool Filter(Person p,int x);

    }
}
