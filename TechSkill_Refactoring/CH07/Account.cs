using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CH07
{
    public class Account
    {
        private AccountType _accountType;
        private int _daysOverDrawn;

        

        public double BankChange()
        {
            double result = 4.5;

            if (_daysOverDrawn > 0)
            {
                result += this._accountType.OverDraftCharge();
            }

            return result;

        }
    }
}
