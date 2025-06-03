namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EducationManger educationManger = new EducationManger();

            educationManger.FilterOnSchool();
            educationManger.FilterOnStudent();
            educationManger.FilterOnSubject();

            educationManger.SortOnSchool();
            educationManger.SortOnStudent();

            educationManger.JoinStutentbySchool();

            educationManger.JoinSubjectswithStudents();
        }
    }
}
