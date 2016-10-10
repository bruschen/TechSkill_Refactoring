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
            //price = baseprice- discountPrice +shipping
            double basePrice = _quantity*_itemPrice;
            double quantityDiscount = Math.Max(0, _quantity - 500)*_itemPrice*0.0;
            double shippingPrice = Math.Min(basePrice*0.1, 100.0);

            return basePrice -
                   quantityDiscount +
                   shippingPrice;

        }
    }
}
