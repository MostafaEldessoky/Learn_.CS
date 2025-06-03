using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_OOP
{
    internal interface IMaintenance
    {
        public int Km {  get; set; }

        public string  Bill { get; set; }

        void GoToMaintenance(int km);

        void DoMaintenance();

    }
}
