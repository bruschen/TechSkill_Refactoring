﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class Rental
    {
        private Movie _movie;
        private int _daysRented;

        public Rental(Movie movie, int daysRented)
        {
            this._movie = movie;
            this._daysRented = daysRented;
        }

        public int GetDaysRented()
        {
            return this._daysRented;
        }

        public Movie GetMovie()
        {
            return this._movie;
        }

        /// <summary>
        /// 計算一筆租片費用
        /// </summary>
        /// <param name="rental"></param>
        /// <returns></returns>
        public double GetCharge()
        {
            double rentalAmount = 0;
            rentalAmount = this._movie.GetRentalAmount(this._daysRented);
            return rentalAmount;
        }

        /// <summary>
        /// 計算常客積點
        /// </summary>
        /// <param name="rentalItem"></param>
        /// <returns></returns>
        public int GetFrequentRenterPoints()
        {
            if (this.GetMovie().GetPriceCode() == Movie.NewRelease
                && this.GetDaysRented() > 1)
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
