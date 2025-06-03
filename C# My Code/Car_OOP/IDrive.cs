using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_OOP
{
    internal interface IDrive
    {
        string Name { get; }

        void Drive(string name);
    }
}
