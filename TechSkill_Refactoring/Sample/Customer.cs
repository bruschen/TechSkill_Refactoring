using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
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

            foreach (Rental rentalItem in rentals)
            {
                //常客積點
                frequentRenterPoints += rentalItem.GetFrequentRenterPoints();

                //顯示此筆租借資料
                result += "\t" + rentalItem.GetMovie().GetTitle() + "\t" + rentalItem.GetCharge().ToString() + "\n";
                totlaAmount += rentalItem.GetCharge();
            }

            //結尾列印
            result += "Amount owed is " + totlaAmount.ToString() + "\n";
            result += "You earned " + frequentRenterPoints.ToString() + " frequent renter points";

            return result;
        }

        
    }
}
