using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorData
{
   public static class NumbersExtantion
    {
        public static float ToOneValue(this int number)
        {
            if(number == 0)
            {
                return number;
            }
            else
            {
                return 100 / (float)number;
            }
        }
    }
}
