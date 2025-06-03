using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_OOP
{
    internal abstract class Car : Vehicle, IMaintenance
    {
        // parametars 

        private int _km; private string _bill;

        // propertys 

        public int Km 
        { 
            get
            {
                return _km;
            }
            set
            {
                KM(value);
            }
        }

        public string Bill
        {
            get
            {
                return _bill;
            }
            set
            {
                BILL(value);
            }
        }

        // costractors

        public Car(int hp, string color, string name,int km,string bill) : base(hp, color, name) 
        {
            _km = km;
            _bill = bill;
        }

        // privite methods

        private void KM(int km) 
        {
            _km = km * 10000;
        }

        private void BILL(string chach)
        {
            _bill = $"it is maintenance of {_km} you have to pay {chach} $";
        }
       
        // public methods

        public abstract void GoToMaintenance(int km);

        public abstract void DoMaintenance();


    }
}
