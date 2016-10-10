using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH0601ExtraMethod.CH06
{
    public class CH0608_ReplaceMethodWithMethodObject
    {
        public int Account(int inputVal, int quantity, int yearToDate)
        {
            int importantValue1 = (inputVal*quantity) + Delta();
            int importantValue2 = (inputVal*yearToDate) + 100;

            if ((yearToDate-importantValue1)>100)
            {
                importantValue2 -= 20;
            }

            int importantValue3 = importantValue2*7;

            return importantValue3 - 2*importantValue1;
        }

        private int Delta()
        {
            throw new NotImplementedException();
        }
    }
}
