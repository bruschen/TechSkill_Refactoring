using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class ChildrensPrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.Childrens;
        }

        public override double GetCharge(int daysRented)
        {
            double rentalAmount = 1.5;
            if (daysRented > 3)
            {
                rentalAmount += (daysRented - 3) * 1.5;
            }
            return rentalAmount;

        }
    }
}
