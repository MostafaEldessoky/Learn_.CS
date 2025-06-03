using System.Text.RegularExpressions;

namespace Math_DateTime_Regex_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //math class
            MathClass obj1 = new MathClass(6.4f,1.2f,"cos");
            obj1.prog();

            MathClass obj2 = new MathClass(6.4f, 1.2f, "sin");
            obj2.prog();

            MathClass obj3 = new MathClass(6.4f, 1.2f, "tan");
            obj3.prog();

            // random class
            Random n = new Random(100);

            for (int i = 0; i < 100; i++) 
            {
                Console.WriteLine( n.Next(i+0,i+ 9));
            }

            // DateTime class
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);

            DateTime dateTime = new DateTime(1995,5,7,2,7,5);
            Console.WriteLine(dateTime);

            // regex
            Console.WriteLine("enter your pattern");
            string s = Console.ReadLine();
            Regex reg = new Regex(s);
            Console.WriteLine("enter the string");
            string h = Console.ReadLine();

            Console.WriteLine( reg.Matches(h).Count());

        }
    }
}
