﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linecomparison
{
    internal class CompareTwoLine
    {
        public double LengthOfLine(int x1, int x2, int y1, int y2)
        {
            double lengthOfLine = Math.Sqrt((Math.Pow(x2 - x1, 2)) + Math.Pow(y2 - y1, 2));
            return lengthOfLine;
        }


       public static void CheckBothLine()
        {
            int x1, x2, m1, m2, y1, y2, n1, n2;
            Console.WriteLine("Enter the value for x1 and x2 co-ordinate for Line1");
            x1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for y1 and y2 co-ordinate for Line1");
            y1 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value for m1 and m2 co-ordinate for Line2");
            m1 = Convert.ToInt32(Console.ReadLine());
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for n1 and n2 co-ordinate for line2");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());

            CompareTwoLine c = new CompareTwoLine();
            double lengthOfLine1 = c.LengthOfLine(x1, x2, y1, y2);
            double lengthOfLine2 = c.LengthOfLine(m1, m2, n1, n2);
            Console.WriteLine("Length of 1st line end points::{0}", lengthOfLine1);
            Console.WriteLine("Length of 2nd line end points::{0}", lengthOfLine2);

            if (lengthOfLine1 == lengthOfLine2) //comparing both lenght
            {
                Console.WriteLine("both are equal ");
                Console.ReadLine();
            }
            else if (lengthOfLine1 > lengthOfLine2) //comparing greter than both of varibales
            {
                Console.WriteLine("line first is greater than line second");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("line second is greater than line first");
                Console.ReadLine();
            }
        }
    }
}