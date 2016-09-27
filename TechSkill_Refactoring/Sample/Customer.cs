using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class Customer
    {
        private string _name;
        private List<Rental> _rentals = new List<Rental>();

        public Customer(string name)
        {
            this._name = name;
        }

        public void AddRental(Rental rental)
        {
            this._rentals.Add(rental);
        }

        public string GetName()
        {
            return this._name;
        }

        public string Statement()
        {
            double totlaAmount = 0;
            int frequentRenterPoints = 0;
            List<Rental> rentals = this._rentals;
            string result = "Rental Record for " + GetName() + "\n";

            double thisAmount = 0;
            foreach (Rental rentalItem in rentals)
            {
                thisAmount = GetAmountForRental(rentalItem);

                //常客積點
                frequentRenterPoints++;

                if (rentalItem.GetMovie().GetPriceCode() == Movie.NewRelease
                    && rentalItem.GetDaysRented()>1)
                {
                    frequentRenterPoints++;
                }

                //顯示此筆租借資料
                result += "\t" + rentalItem.GetMovie().GetTitle() + "\t" + thisAmount.ToString() + "\n";
                totlaAmount += thisAmount;
            }

            //結尾列印
            result += "Amount owed is " + totlaAmount.ToString() + "\n";
            result += "You earned " + frequentRenterPoints.ToString() + " frequent renter points";

            return result;
        }

        private double GetAmountForRental(Rental rentalItem)
        {
            double thisAmount = 0;
            switch (rentalItem.GetMovie().GetPriceCode())
            {
                case 0: //(Movie.Regular):
                    thisAmount += 2;
                    if (rentalItem.GetDaysRented() > 2)
                    {
                        thisAmount += (rentalItem.GetDaysRented() - 2)*1.5;
                    }
                    break;
                case 1: //Movie.NewRegular:
                    thisAmount += rentalItem.GetDaysRented()*3;
                    break;

                case 2:
                    thisAmount += 1.5;
                    if (rentalItem.GetDaysRented() > 3)
                    {
                        thisAmount += (rentalItem.GetDaysRented() - 3)*1.5;
                    }
                    break;
            }
            return thisAmount;
        }
    }
}
