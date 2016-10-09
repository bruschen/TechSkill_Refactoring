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
            printBanner();

            Console.WriteLine("Name:" + _name);
            Console.WriteLine("amount"+amount.ToString());
        }

        private void printBanner()
        {
            throw new NotImplementedException();
        }
    }
}
