using System.Drawing;
using System;
using System.Web;

namespace BadProgramming
{
    public class Class1
    {
        public double Calculate(double am, int t, int y)
        {
            double result = 0;
            double disc = (y > 5) ? (double)5 / 100 : (double)y / 100;
            if (t == 1)
            {
                result = am;
            }
            else if (t == 2)
            {
                // 100 - (0.1 * 100) = 100 - 10 = 90
                result = (am - (0.1 * am)) - disc * (am - (0.1 * am));
            }
            else if (t == 3)
            {
                result = (0.7 * am) - disc * (0.7 * am);
            }
            else if (t == 4)
            {
                result = (am - (0.5 * am)) - disc * (am - (0.5 * am));
            }
            return result;
        }
    }
}


/*
To use this class:

Class1 bad = new();
double result = bad.Calculate(500, 2, 7);
Console.WriteLine(result);
*/
