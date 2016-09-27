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
        
    }
}
