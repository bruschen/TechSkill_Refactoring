using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class Movie
    {
        public static int Childrens = 2;
        public static int Regular = 0;
        public static int NewRelease = 1;

        private string _title;
        private int _priceCode;

        public Movie(string title, int priceCode)
        {
            this._title = title;
            this._priceCode = priceCode;
        }

        public int GetPriceCode()
        {
            return this._priceCode;
        }

        public void SetPriceCode(int value)
        {
            this._priceCode = value;
        }

        public string GetTitle()
        {
            return this._title;
        }

        public double GetRentalAmount(int daysRented)
        {
            double rentalAmount = 0;
            switch (GetPriceCode())
            {
                case 0: //(Movie.Regular):
                    rentalAmount += 2;
                    if (daysRented > 2)
                    {
                        rentalAmount += (daysRented - 2) * 1.5;
                    }
                    break;
                case 1: //Movie.NewRegular:
                    rentalAmount += daysRented * 3;
                    break;

                case 2:
                    rentalAmount += 1.5;
                    if (daysRented > 3)
                    {
                        rentalAmount += (daysRented - 3) * 1.5;
                    }
                    break;
            }
            return rentalAmount;
        }

        /// <summary>
        /// 計算常客積點
        /// </summary>
        /// <param name="rentalItem"></param>
        /// <returns></returns>
        public int GetFrequentRenterPoints(int daysRented)
        {
            if (GetPriceCode() == Movie.NewRelease
                && daysRented > 1)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
    }
}
