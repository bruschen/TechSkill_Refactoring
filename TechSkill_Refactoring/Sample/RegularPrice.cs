using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class RegularPrice:Price
    {
        public override int GetPriceCode()
        {
            return Movie.Regular;
        }

        public override double GetCharge(int daysRented)
        {
            double rentalAmount = 2;
            if (daysRented > 2)
            {
                rentalAmount += (daysRented - 2) * 1.5;
            }

            return rentalAmount;
        }
    }
}
