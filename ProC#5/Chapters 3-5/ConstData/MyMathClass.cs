using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class MyMathClass
    {
        public const double PI = 3.14;
        // Read-only fields can be assigned in ctors, but nowhere else
        public readonly double roPI;

        public MyMathClass()
        {
            this.roPI = 3.14;
        }
    }
}
