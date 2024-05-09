using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public static class Calculator
    {
        public static float Add(float num1, float num2) => num1 + num2;

        public static float Subtract(float num1, float num2) => num1 - num2;

        public static float Divide(float num1, float num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException("Non si può dividere per 0!");

            return num1 / num2;
        }

        public static float Multiply(float num1, float num2) => num1 * num2;
    }
}
