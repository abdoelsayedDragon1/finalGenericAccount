using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class ClsCalculator
    {
        public static bool AreEqual<T>( T x, T y)
        {
           if (x.Equals (y))
            {
                return true;
            }
           else
            {
                return false;
            }
        }
    }
}
