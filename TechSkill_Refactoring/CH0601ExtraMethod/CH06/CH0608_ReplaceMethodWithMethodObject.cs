using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH0601ExtraMethod.CH06
{
    public class CH0608_ReplaceMethodWithMethodObject
    {
        public int Gamma(int inputVal, int quantity, int yearToDate)
        {
            return new CH0608_ReplaceMethodWithMethodObject2(this, inputVal, quantity, yearToDate).Compute();
        }

        public int Delta()
        {
            throw new NotImplementedException();
        }
    }
}
