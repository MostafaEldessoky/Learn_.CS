using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using System.Configuration;

namespace Shcool_Manger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["Shcool_Manger.Properties.Settings.ShcoolConnectionString"].ConnectionString;

        LinqToSqlDataContext datacontext;

        List<Shcool> shcools;
        List<Student> students;
        List<Subject> subjects;
        List<StudentSubject> studentsubjects;

        public MainWindow()
        {
            InitializeComponent();

            datacontext = new LinqToSqlDataContext(connectionstring);

            shcools = new List<Shcool>();
            students = new List<Student>();
            subjects = new List<Subject>();
            studentsubjects = new List<StudentSubject>();

            //InsertOnShcool();
            //InsertOnStudent();
            //InsertOnSubject();
            //InsertOnStudentSubject();
            //GetFromShcool();
            //GetFromStudent();
            //GetAllStudentsInShcool();
            //GetAllMaleInShcool();
            //GetAllSubjectInShcool();
            //UpdateStudent();
            //DeleteShcool();
        }

        public void InsertOnShcool()
        {
            shcools.Add(new Shcool() { Name = "Ain Shames" });
            shcools.Add(new Shcool() { Name = "Cairo" });
            shcools.Add(new Shcool() { Name = "Helwan" });

            datacontext.Shcools.InsertAllOnSubmit(shcools);

            datacontext.SubmitChanges();

            DataTable.ItemsSource = datacontext.Shcools;
        }

        public void InsertOnStudent()
        {
            students.Add(new Student() { Name = "Mostafa",Gender = "Male", Shcoolid = 1 });
            students.Add(new Student() { Name = "Ayman", Gender = "Male", Shcoolid = 2 });
            students.Add(new Student() { Name = "Sarah", Gender = "Female", Shcoolid = 3 });

            datacontext.Students.InsertAllOnSubmit(students);

            datacontext.SubmitChanges();

            DataTable.ItemsSource = datacontext.Students;
        }

        public void InsertOnSubject()
        {
            subjects.Add(new Subject() { Course = "Electronics" });
            subjects.Add(new Subject() { Course = "Mathematics" });
            subjects.Add(new Subject() { Course = "Communication System" });

            datacontext.Subjects.InsertAllOnSubmit(subjects);

            datacontext.SubmitChanges();
            
            DataTable.ItemsSource = datacontext.Subjects;
        }

        public void InsertOnStudentSubject()
        {
            studentsubjects.Add(new StudentSubject() { Studentid = 1, Subjectid = 1});
            studentsubjects.Add(new StudentSubject() { Studentid = 2, Subjectid = 2 });
            studentsubjects.Add(new StudentSubject() { Studentid = 3, Subjectid = 3 });

            Student student = datacontext.Students.First(st => st.Name == "Mostafa");
            Subject subject = datacontext.Subjects.First(sb => sb.Course == "Communication System");

            datacontext.StudentSubjects.InsertOnSubmit(new StudentSubject { Student = student, Subject = subject });
            datacontext.StudentSubjects.InsertAllOnSubmit(studentsubjects);

            datacontext.SubmitChanges();

            DataTable.ItemsSource = datacontext.StudentSubjects;
        }

        public void GetFromShcool()
        {
            Shcool shcool = datacontext.Shcools.First(sh=>sh.Name.Equals("Banha"));

            List<Shcool> shl = new List<Shcool> { shcool };

            DataTable.ItemsSource = shl;
        }
        public void GetFromStudent()
        {
            Student student = datacontext.Students.First(st => st.Name.Equals("Sarah"));

            IEnumerable<Subject> std = from i in student.StudentSubjects select i.Subject;

            DataTable.ItemsSource = std;
        }
        public void GetAllStudentsInShcool()
        {
            Shcool shcool = datacontext.Shcools.First(sh => sh.Name.Equals("Cairo"));

            IEnumerable<Student> std = from i in shcool.Students select i;

            DataTable.ItemsSource = std;
        }
        public void GetAllMaleInShcool()
        {
            IEnumerable<Student> st = from i in datacontext.Students join j in datacontext.Shcools on i.Shcoolid equals j.Id where i.Gender == "Male" select i;

            DataTable.ItemsSource = st;
        }

        public void GetAllSubjectInShcool()
        {
            var sbt = from i in datacontext.StudentSubjects join j in datacontext.Students on i.Studentid equals j.Id where j.Shcool.Name == "Cairo" select i.Subject;


            DataTable.ItemsSource = sbt;

        }

        public void UpdateStudent()
        {
            Student student = datacontext.Students.First(st => st.Name == "Mostafa");

            student.Name = "Moustafa";

            datacontext.SubmitChanges();

            DataTable.ItemsSource = datacontext.Students;
        }

        public void DeleteShcool()
        {
            Shcool shcool = datacontext.Shcools.First(sch => sch.Name == "Helwan");

            datacontext.Shcools.DeleteOnSubmit(shcool);

            datacontext.SubmitChanges();

            DataTable.ItemsSource = datacontext.Shcools;
        }
    }
}
