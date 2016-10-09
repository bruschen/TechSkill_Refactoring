using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH0601ExtraMethod
{
    public class SampleExtraMethod
    {
        private object _name;

        public void PrintOwing(double amount)
        {
            double outStanding = 0.0;

            PrintBanner();

            PrintDetail(amount);
        }

        private void PrintDetail(double amount)
        {
            Console.WriteLine("Name:" + _name);
            Console.WriteLine("amount" + amount.ToString());
        }

        private void PrintBanner()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("****Customer  Owes *******");
            Console.WriteLine("**************************");
        }
    }
}
