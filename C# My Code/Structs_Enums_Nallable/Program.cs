namespace Structs_Enums
{
    internal class Program
    {

        public enum Days
        {
            sat = 1, sun = 2, mon = 3, tus, wed, the, frd = 90
        }

        public struct Exc 
        {
            private int _day;


            public int Day { get { return _day; } set { _day = value; } }

            public Exc(int day) 
            {
                _day = day;
            }


            public void count() 
            {
                Console.WriteLine(_day);
            }
        }


        static void Main(string[] args)
        {
            // enum
            Days frd = Days.wed;
            Console.WriteLine( (int)Days.frd);

            // struct
            Exc exc = new Exc(4);

            exc.Day = (int)frd;
            exc.count();


            // Nullable
            int? x = null;
            int y = 9;

            x = x ?? 0;

            Console.WriteLine(x + y);

            y = x ?? 0;
            Console.WriteLine(y);

        }
    }
}
