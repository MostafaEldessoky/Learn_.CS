using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int SchoolId { get; set; }

        public Student(string name,int id, int age,int schoolid)
        { 
            Name = name;
            Id = id;
            Age = age;
            SchoolId = schoolid;
        }

        public void ShowProp()
        {
            Console.WriteLine($"{Id}-Student {Name} with Age {Age}");
        }
    }
}
