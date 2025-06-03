using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Math_DateTime_Regex_Random
{
    internal class MathClass
    {
        private float _x; private float _y; private string _options;

        public float X 
        {   get 
            { return _x; } 
            set
            { _x = value; } 
        }

        public float Y 
        { 
            get 
            { return _y; } 
            set
            { _y = value; } 
        }

        public string Options 
        { 
            get 
            { return _options; } 
            set 
            {
                if (value == "cos" || value == "sin")
                {
                    _options = value;
                }
                else
                {
                    _options = "invaled input";
                }
            
            } 
        }

        public MathClass(float x, float y, string options) 
        { 
            _x = x;
            _y = y;
            Options = options;
        }

        private double calc()
        {
            if (_options == "sin")
            {

                return _x * Math.Sin( _y );
            }
            else if (_options == "cos")
            {
                return _x * Math.Cos(_y);
            }
            else
            {
                return 0.0; 
            }
        }

        public void prog()
        {
            if (calc() == 0.0)
            {
                Console.WriteLine($"{_options}");
            }
            else
            {
                Console.WriteLine($"your output is {calc()}");
            }

        }


    }
}
