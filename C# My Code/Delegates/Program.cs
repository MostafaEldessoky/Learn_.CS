namespace Delegates_Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //delegate definition
            Run(print);

            // anonymous definition
            Run(y);

            // lambda definition
            Run(x => { Console.WriteLine("hello from lambda method"); });

            // delegate total example 
            Person p1 = new Person("mostafa",11000);
            Person p2 = new Person("mohamed", 6000);
            Person p3 = new Person("eldesouky", 24000);
            Person p4 = new Person("eman", 3000);

            List<Person> ps = new List<Person>() {p1,p2,p3,p4 };

            PersonFilter(ps,flt,6000);

            PersonFilter(ps, felt, 11000);

        }

        //delegate definition
        public delegate void run(int x);

        public static void Run (run x )
        {
            x(5);
        }

        public static void print(int x)
        {
            Console.WriteLine("hello from delegate method");
        }

        // anonymous definition
        static run y = delegate (int x)
        { Console.WriteLine("hello from anonymous method"); };

        // delegate total example 

        public static void PersonFilter(List<Person> l,Person.Filter f,int x)
        {
            foreach (Person p in l)
            {
                if (f(p,x))
                {
                    Console.WriteLine(p.Name,p.Salary);
                }
            }

        }

        static Person.Filter flt = delegate (Person p,int x)
        {
            if (p.Salary > x)
            {
                return true;
            }
            else
            {
                return false;
            }
        };

        public static bool felt(Person p,int x)
        {
            if (p.Salary < x)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
