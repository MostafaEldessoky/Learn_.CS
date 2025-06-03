namespace Car_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMW obj1 = new BMW(200,"black","X6",10000,"5000$",false,0,300);
            Reno obj2 = new Reno(100, "white", "megan", 100000, "3000$", true, 0, 450);
            Honda obj3 = new Honda(80, "red", "borchi", 1000, "300$", true, 0, 150);
            Ducati obj4 = new Ducati(60, "blue", "volve", 10000, "150$", false, 0, 90);

            List<Vehicle> vehicles = new List<Vehicle>() {obj1,obj2,obj3,obj4 };

            foreach (Vehicle vehicle in vehicles) 
            {
                vehicle.Data();
            }
        }
    }
}
