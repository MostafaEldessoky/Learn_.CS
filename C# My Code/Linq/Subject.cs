using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Subject
    { 
        public List<string> Subjects { get; set; }

        public int SchoolId { get; set; }

        public Subject(int schoolid, params string[] mysubjects)
        {
            Subjects = new List<string>();
            SchoolId = schoolid;

            foreach (string mysubject in mysubjects)
            { 
                Subjects.Add(mysubject);
            }
        }

        public void ShowProp()
        {
            int i = 0;
            Console.WriteLine("Start List of Subject for this objects");
            foreach (string subject in Subjects)
            { 
                i++;
                Console.WriteLine($"{i} " + subject);
            }
            Console.WriteLine("End List of Subject for this objects.");
        }

    }
}
