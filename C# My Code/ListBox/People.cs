using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ListBox
{
    public class People
    {
        public string Name { get; set; }

        public int Age { get; set; }


        public People(string name,int age) 
        { 
            Name = name;
            Age = age;
        }

        public string GetInfo()
        {
            return Name + " is " + Age + " years old";
        }
    }
}
