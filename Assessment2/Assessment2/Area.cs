using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment2
{
    public class Area
    {
        
        public static double AreaOfCircle(double redius)
        {

            double A = 3.14 * (redius * redius);
            return A;
        }

        public static double AreaOfTriangle(double height,double base1)
        {

            double A = (height * base1) / 2;
            return A;
        }

        public double AreOfTrapezium (double base1, double base2, double height)
        {
            double A = ((base1 + base2) / 2) * height;
            return A;
        }


    }
}
