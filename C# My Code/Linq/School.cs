using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class School
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public School(string name,int id) 
        {
            Name = name;
            Id = id;
        }

        public void ShowProp()
        {
            Console.WriteLine($"{Id}-School {Name}");
        }
    }
}
