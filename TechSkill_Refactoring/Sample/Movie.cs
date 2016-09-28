using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class Movie
    {
        public const int Childrens = 2;
        public const int Regular = 0;
        public const int NewRelease = 1;

        private string _title;
        private int _priceCode;
        private Price _price;

        public Movie(string title, int priceCode)
        {
            this._title = title;
            SetPriceCode(priceCode);
        }

        public int GetPriceCode()
        {
            return this._priceCode;
        }

        public void SetPriceCode(int value)
        {
            switch (value)
            {
                case Regular:
                    _price= new RegularPrice();
                    break;
                case Childrens:
                    _price = new ChildrensPrice();
                    break;
                case NewRelease:
                    _price = new NewReleasePrice();
                    break;
                default:
                    throw new Exception("Incorrect Price Code");
            }

            this._priceCode = value;
        }

        public string GetTitle()
        {
            return this._title;
        }

        public double GetCharge(int daysRented)
        {
            return this._price.GetCharge(daysRented);
        }

        /// <summary>
        /// 計算常客積點
        /// </summary>
        /// <param name="rentalItem"></param>
        /// <returns></returns>
        public int GetFrequentRenterPoints(int daysRented)
        {
            return _price.GetFrequentRenterPoints(daysRented);
        }
    }
}
