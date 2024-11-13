using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation c1 = new Calculation();
            Console.WriteLine(c1.Multiply(8, 7));
            Console.WriteLine(c1.Add(20, 40));

        }
    }
}
