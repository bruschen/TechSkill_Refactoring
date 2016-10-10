using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH0601ExtraMethod.CH06
{
    public class CH0607_RemoveAssignmentToParameters
    {
        public int Discount(int inputVal, int quantity, int yearToDate)
        {
            int result = inputVal;

            if (inputVal>50)
            {
                result -= 2;
            }

            if (quantity>100)
            {
                result -= 1;
            }

            if (yearToDate >10000)
            {
                result -= 4;
            }

            return result;
        }


    }
}
