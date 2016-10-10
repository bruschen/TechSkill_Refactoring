using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH0601ExtraMethod
{
    public class CH0605_IntroduceExplainingVariable
    {
        private double _quantity;
        private double _itemPrice;

        public double price()
        {
            return _quantity*_itemPrice -
                   Math.Max(0, _quantity - 500)*_itemPrice*0.05 +
                   Math.Min(_quantity*_itemPrice*0.1, 100.0);

        }
    }
}
