﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTAOOPPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle rect = new Rectangle(10.0, 20.0);
            //double area = rect.GetArea();
            //Console.WriteLine("Area of the Rectangle is: {0}", area);

            Rectangle rect = new Rectangle();
            rect.Length = 10.0;
            rect.Width = 20.0;
            double area = rect.GetArea();
            Console.WriteLine("Area of Rectangle = {0}", area);


        }
    }
}
