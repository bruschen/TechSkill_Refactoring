using System;

namespace CH07
{
    internal class AccountType
    {
        public int daysOverDrawn { get; private set; }

        internal bool IsPremium()
        {
            throw new NotImplementedException();
        }

        public double OverDraftCharge()
        {
            if (this.IsPremium())
            {
                double result = 10;

                if (daysOverDrawn > 7)
                {
                    result += (daysOverDrawn - 7) * 0.85;
                }

                return result;
            }

            else
            {
                return daysOverDrawn * 1.75;
            }
        }
    }
}