﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            // 円の半径を設定
            c.r = 4.0;
            Console.WriteLine("半径" + c.r + "の円の長さは" + c.Circumference());
            Console.WriteLine("半径{0}の円の面積は{1}", c.r, c.Area());
        }
    }
}
