using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MyMath
    {
        public static int Abs(int a)
        {
            if (a > 0)
            {
                return a;
            }
            else
            {
                return -(a);
            }
        }
    }
}
