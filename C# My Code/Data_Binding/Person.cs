using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Binding_1
{
    internal class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person(string name, int age) 
        { 
            Name = name;
            Age = age;
        }

        public string messege() 
        { 
            return Name + " is " + Age + " years old";
        }
    }
}
