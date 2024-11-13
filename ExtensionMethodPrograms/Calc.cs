using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodPrograms
{
    public static class Calc
    {
        public static int Multiply(this Calculation c1, int a, int b)
        {
            return a * b;
        }
    }

    

}

