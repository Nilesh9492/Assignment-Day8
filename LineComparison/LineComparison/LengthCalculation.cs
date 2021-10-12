using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class LengthCalculation
    {
        public double Findlength(double x1, double x2, double y1,double y2)
        {
                        
            double Distance;
            Distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Line length is " + Distance);
            return Distance;
        }

    }
}
