using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class EducationManger
    {
        enum subjects
        {
            Math,
            Physics,
            chemistry,
            Arabic,
            English
        }

        public List<School> Schools { get; set; } = new List<School>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Subject> Subjects { get; set; } = new List<Subject>();


        School school1 = new School("Ain Shames University", 1);
        School school2 = new School("Cairo University", 2);
        School school3 = new School("Helwan University", 3);

        Student student1 = new Student("mostafa", 1, 29,1);
        Student student2 = new Student("mohamed", 2, 23, 2);
        Student student3 = new Student("ali", 3, 26,3);
        Student student4 = new Student("eman", 4, 24,1);
        Student student5 = new Student("sarah", 5, 22,2);
        Student student6 = new Student("alaa", 6, 27,3);
        Student student7 = new Student("ibrahem", 7, 28,1);
        Student student8 = new Student("salma", 8, 25,2);

        Subject subject1 = new Subject(1,subjects.Math.ToString(), subjects.Physics.ToString(), subjects.chemistry.ToString());
        Subject subject2 = new Subject(2,subjects.Physics.ToString(), subjects.Math.ToString(), subjects.English.ToString());
        Subject subject3 = new Subject(3,subjects.English.ToString(), subjects.Arabic.ToString());

        public EducationManger()
        {
            Schools.Add(school1);
            Schools.Add(school2);
            Schools.Add(school3);

            Students.Add(student1);
            Students.Add(student2);
            Students.Add(student3);
            Students.Add(student4);   
            Students.Add(student5);
            Students.Add(student6);
            Students.Add(student7);
            Students.Add(student8);

            Subjects.Add(subject1);
            Subjects.Add(subject2);
            Subjects.Add(subject3);

            school1.ShowProp();
            school2.ShowProp();
            school2.ShowProp();
            school3.ShowProp();

            student1.ShowProp();
            student2.ShowProp();
            student3.ShowProp();
            student4.ShowProp();
            student5.ShowProp();
            student6.ShowProp();
            student7.ShowProp();
            student8.ShowProp();

            subject1.ShowProp();
            subject2.ShowProp();
            subject3.ShowProp();
        }

        // selection
        public void FilterOnSubject()
        {
            IEnumerable<Subject> subjects = from subject in Subjects select subject;

            foreach (Subject subject in subjects)
            {
                Console.WriteLine(subject.Subjects.Count);
            }
        }
        // filtering
        public void FilterOnStudent()
        {
            IEnumerable<Student> students = from student in Students where student.Age > 25 select student;

            foreach (Student student in students) 
            {
                Console.WriteLine(student.Name);
            }
        }
        public void FilterOnSchool()
        {
            IEnumerable<School> schools = from school in Schools where school.Name == "Ain Shames University" select school;

            foreach (School school in schools)
            {
                Console.WriteLine(school.Id);
            }
        }

        // sorting
        public void SortOnStudent()
        {
            IEnumerable<Student> students = from student in Students orderby student.Age where student.Id > 0 select student;

            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
            }
        }
        public void SortOnSchool()
        {
            IEnumerable<School> schools = from school in Schools orderby school.Name select school;

            foreach (School school in schools)
            {
                Console.WriteLine(school.Id);
            }
        }

        // joining 
        public void JoinStutentbySchool()
        {
            IEnumerable<Student> students = from i in Students join j in Schools on i.SchoolId equals j.Id where j.Id == 1 select i;

            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
            }
        }

        // create new object with combination of objects
        public void JoinSubjectswithStudents()
        {
            var SubjectStudents = from i in Students join j in Subjects on i.SchoolId equals j.SchoolId orderby i.Age descending where i.Name.Length > 3 select new {stname = i.Name,sbj = j.Subjects};

            foreach (var subjectstudent in SubjectStudents)
            {
                string s = "";
                foreach (string sbj in subjectstudent.sbj)
                { s = s +" "+ sbj; }
                Console.WriteLine(subjectstudent.stname + " " + s);
            }
        }
    }
}
