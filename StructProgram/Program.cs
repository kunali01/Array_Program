﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructProgram
{
    internal class Program
    {
        public struct Coordinates
        {
            private int x;
            private int y;

            public Coordinates(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public void Print()
            {
                Console.WriteLine(x + "  " + y);
            }
        }

        //static void Main(string[] args)
        //{

        //    Coordinates c1 = new Coordinates(1, 2);
        //    c1.Print();

        //}
    }
}
