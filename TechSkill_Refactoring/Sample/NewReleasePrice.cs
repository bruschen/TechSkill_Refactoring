using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class NewReleasePrice :Price
    {
        public override int GetPriceCode()
        {
            return Movie.NewRelease;
        }

        public override double GetCharge(int daysRented)
        {
            return daysRented*3;
        }

        public override int GetFrequentRenterPoints(int daysRented)
        {
            return 2;
        }
    }
}
