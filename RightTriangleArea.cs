using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightTriangleAreaLib
{
    public class RightTriangleArea
    {
        //Let's calculate area using Heron's Formula
        public double Area (double a, double b, double c)
        {
            //Calculating semiperimeter
            double semiperimeter = (a + b + c) / 2;

            //return result conform to Heron's formula
            return Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));

        }
    }
}
