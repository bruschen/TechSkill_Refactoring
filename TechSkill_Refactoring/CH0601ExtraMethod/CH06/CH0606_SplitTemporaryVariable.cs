using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH0601ExtraMethod.CH06
{
    public class CH0606_SplitTemporaryVariable
    {
        private double _primaryForce;
        private double _mass;
        private double _delay;
        private double _secondaryForce;

        public double GetDistanceTravelled(int time)
        {
            double result;
            double acc = _primaryForce/_mass;

            int primaryTime = (int)Math.Min(time, _delay);
            result = 0.5*acc*primaryTime * primaryTime;
            int secondaryTime = (int)(time - _delay);

            if (secondaryTime>0)
            {
                double primaryVel = acc*_delay;
                acc = (_primaryForce + _secondaryForce)/_mass;
                result += primaryVel*secondaryTime + 0.5*acc*secondaryTime*secondaryTime;
            }


            return result;
        }
    }
}
