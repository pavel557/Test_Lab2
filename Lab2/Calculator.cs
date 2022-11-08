using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Calculator : ICalculator
    {
        public double divide(double a, double b)
        {
            if (Math.Abs(b) < Math.Pow(10, -8))
            {
                throw new DivideByZeroException("DivideByZeroException");
            }
            return a / b;
        }

        public double multiply(double a, double b)
        {
            return a * b;
        }

        public double subtract(double a, double b)
        {
            return a - b;
        }

        public double sum(double a, double b)
        {
            return a + b;
        }
    }
}
