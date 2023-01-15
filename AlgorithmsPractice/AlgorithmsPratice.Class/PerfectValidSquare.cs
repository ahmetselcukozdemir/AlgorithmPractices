using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlgorithmsPratice.Class
{
    public class PerfectValidSquare
    {
        public bool IsPerfectSquare(int num)
        {
            long a = 1;
            long b = num;
            while (a <= b)
            {
                long middle = (b - a) / 2 + a;

                if (middle * middle == num) return true;
                if (middle * middle > num) b = middle - 1;
                else a = middle + 1;
            }

            return false;
        }
    }
}
