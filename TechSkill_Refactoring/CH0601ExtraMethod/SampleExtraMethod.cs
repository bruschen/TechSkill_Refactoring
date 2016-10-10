using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH0601ExtraMethod
{
    public class SampleExtraMethod
    {
        private double _quantity;
        private int _itemPrice;
        private object _name;

        public double PrintOwing(double amount)
        {
            //// Extra Method without local variable
            PrintBanner();

            double outStanding = GetOutStanding(amount * 1.2);

            //// Extra Method with local variable
            PrintDetail(outStanding);

            #region 6.5 Introduce explaining variable
            string plateform = string.Empty;
            string browser = string.Empty;
            int resize = 0;

            bool isMacOs = plateform.ToUpper().IndexOf("MAC") > -1;
            bool isIeBrowser = browser.ToUpper().IndexOf("IE") > -1;
            bool wasResized = resize > 0;

            if (isMacOs && isIeBrowser && wasResized && WasInitialized())
            {
                //// do something
            }

            

            #endregion

            return GetPrice();
        }

        private bool WasInitialized()
        {
            return true;
        }

        private double GetPrice()
        {
            return GeBasePrice()* GetDiscountFactory();
        }

        private double GetDiscountFactory()
        {
            double discountFactory;
            if (GeBasePrice() > 1000)
            {
                discountFactory = 0.95;
            }
            else
            {
                discountFactory = 0.98;
            }
            return discountFactory;
        }

        private int GeBasePrice()
        {
            return this._itemPrice * this._itemPrice;
        }

        private double GetOutStanding(double outStanding)
        {
            for (int i = 0; i < 10; i++)
            {
                outStanding += i;
            }

            return outStanding;
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
