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
            //// Extra Method without local variable
            PrintBanner();

            double outStanding = GetOutStanding();

            //// Extra Method with local variable
            PrintDetail(outStanding);
        }

        private double GetOutStanding()
        {
            double outStanding = 0.0;
            for (int i = 0; i < 10; i++)
            {
                outStanding += i;
            }

            return outStanding;
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
