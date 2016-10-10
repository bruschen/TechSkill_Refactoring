using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH0601ExtraMethod.CH06
{
    public class CH0608_ReplaceMethodWithMethodObject2
    {
        private CH0608_ReplaceMethodWithMethodObject _ch0608ReplaceMethodWithMethodObject;
        private int _inputVal;
        private int _quantity;
        private int _yearToDate;
        private int _importantValue1;
        private int _importantValue2;
        private int _importantValue3;

        public CH0608_ReplaceMethodWithMethodObject2(CH0608_ReplaceMethodWithMethodObject ch0608ReplaceMethodWithMethodObject, int inputVal, int quantity, int yearToDate)
        {
            this._ch0608ReplaceMethodWithMethodObject = ch0608ReplaceMethodWithMethodObject;
            this._inputVal = inputVal;
            this._quantity = quantity;
            this._yearToDate = yearToDate;
        }

        public int Compute()
        {
            this._importantValue1 = (_inputVal * _quantity) + _ch0608ReplaceMethodWithMethodObject.Delta();
            this._importantValue2 = (_inputVal * _yearToDate) + 100;

            if ((_yearToDate - this._importantValue1) > 100)
            {
                this._importantValue2 -= 20;
            }

            this._importantValue3 = this._importantValue2 * 7;

            return this._importantValue3 - 2 * this._importantValue1;
        }

    }
}

