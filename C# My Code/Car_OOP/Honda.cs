using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_OOP
{
    internal class Honda : Motorcycle, IFuel
    {

        private Boolean _fuel; private int _amount; private int _currentfuel;

        public Boolean Fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public int CurrentFuel
        {
            get { return _currentfuel; }
            set { _currentfuel = value; }
        }

        public Honda(int hp = 0, string color = "", string name = "", int km = 0, string bill = "", Boolean fuel = true, int amount = 0, int currentfuel = 10) : base(hp, color, name, km, bill)
        {
            _amount = amount;
            _currentfuel = currentfuel;
            _fuel = fuel;
        }

        public override void Data()
        {
            Console.WriteLine($"this is {Name} \nit's hp is {Hp} \nit's color is {Color} \nit's km is {Km} \nit's bill is {Bill}");
        }
        public override void Drive(string name)
        {
            Console.WriteLine($"my car {name} as {Name} is now Driving");
        }

        public override void Parking(string name)
        {
            Console.WriteLine($"my car {name} as {Name} is now Parking");
        }

        public override void GoToMaintenance(int km)
        {
            Console.WriteLine($"it is {km} time to Go  To Maintenance");
        }

        public override void DoMaintenance()
        {
            Console.WriteLine($"Maintenance done!");
        }
        public void NeedToFuel(int currentfuel)
        {
            Console.WriteLine($"hey you have fuel = {currentfuel} now");
        }

        public void FuelNow(int amount)
        {
            Console.WriteLine($"you put fuel = {amount} now");
        }

    }
}
