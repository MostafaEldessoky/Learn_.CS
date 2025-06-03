using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal interface ITransferMoney
    {
        public Boolean TranasferMoney(string to,int amount);

        public Boolean FindAccount(string to, int amount);

    }
}
