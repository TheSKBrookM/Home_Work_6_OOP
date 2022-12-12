using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Home_Work_6_4
{
    static class Calculator
    {
        static public double Add(double a, double b)
        {
            return a + b;
        }
        static public double Sub(double a, double b)
        {
            return a - b;
        }
        static public double Div(double a, double b)
        {
            if (b == 0)
            {
                return 0;
            }
            return a / b;
        }
        static public double Mul(double a, double b)
        {
            return a * b;
        }
    }
}
