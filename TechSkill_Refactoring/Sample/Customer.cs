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
            
            List<Rental> rentals = this._rentals;
            string result = "Rental Record for " + GetName() + "\n";

            foreach (Rental rentalItem in rentals)
            {
                //顯示此筆租借資料
                result += "\t" + rentalItem.GetMovie().GetTitle() + "\t" + rentalItem.GetCharge().ToString() + "\n";
            }

            ////add footer lines
            result += "Amount owed is " + GetTotalCharge().ToString() + "\n";
            result += "You earned " + GetTotalFrequentRenterPoints().ToString() + " frequent renter points";

            return result;
        }

        /// <summary>
        /// 取得常客積點總額
        /// </summary>
        /// <returns></returns>
        private int GetTotalFrequentRenterPoints()
        {
            int frequentRenterPoints = 0;

            List<Rental> rentals = this._rentals;
            foreach (Rental rentalItem in rentals)
            {
                frequentRenterPoints += rentalItem.GetFrequentRenterPoints();
            }

            return frequentRenterPoints;
        }

        /// <summary>
        /// 取得租金計算總額
        /// </summary>
        /// <returns></returns>
        private double GetTotalCharge()
        {
            double totlaAmount = 0;

            List<Rental> rentals = this._rentals;
            foreach (Rental rentalItem in rentals)
            {
                totlaAmount += rentalItem.GetCharge();
            }

            return totlaAmount;
        }
    }
}
