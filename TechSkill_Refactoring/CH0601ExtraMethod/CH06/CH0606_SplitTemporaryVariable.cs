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
            double primaryAcc = _primaryForce/_mass; //// 第一個力造成的加速度

            int primaryTime = (int)Math.Min(time, _delay);
            result = 0.5*primaryAcc*primaryTime * primaryTime;

            int secondaryTime = (int)(time - _delay);

            if (secondaryTime>0)
            {
                double primaryVel = primaryAcc*_delay;
                double secondaryAcc = (_primaryForce + _secondaryForce)/_mass; //// 兩個力造成的加速度
                result += primaryVel*secondaryTime + 0.5* secondaryAcc * secondaryTime*secondaryTime;
            }


            return result;
        }
    }
}
