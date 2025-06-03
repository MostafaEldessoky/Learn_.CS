using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_OOP
{
    internal interface IFuel
    {
        Boolean Fuel {  get; set; }

        int Amount { get; set; }

        int CurrentFuel { get; set; }

        void NeedToFuel(int currentfuel);

        void FuelNow(int amount);
    }
}
