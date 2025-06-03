using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_OOP
{
    internal abstract class Vehicle : IDrive, IParking
    {
        // parametars 

        private int _hp; private string _color; private string _name;

        // property

        public int Hp 
        {   
            get 
            {  
                return _hp; 
            }
        }

        public string Color
        {
            get {  return _color; }
                
            set 
            {
                if (_color != value)
                { 
                    _color = value; 
                }
            }    
        }

        public string Name
        {
            get
            {
                if (_name != null)
                {
                    return _name;
                }
                else
                {
                    return "No Name for this Object";
                }
            }
        }

        // Constractor 

        public Vehicle(int hp, string color, string name) 
        {
            _hp = hp;
            _color = color;
            _name = name;
        }

        // privet methods

        private void print()
        {
            Console.WriteLine($"this object has \nhp = {Hp} \ncolor = {Color} \nname = {Name}");
        }

        // public methods 

        public virtual void Data()
        {
            print();
        }

        public abstract void Drive(string name);

        public abstract void Parking(string name);

    }
}
