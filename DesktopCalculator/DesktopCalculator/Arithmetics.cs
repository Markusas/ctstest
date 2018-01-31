using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopCalculator
{
    public class Arithmetics
    {
        public double Calculate(double num1, double num2, string action)
        {
            double result = 0;

            switch (action)
            {
                case "+":
                    result = num2 + num1;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num2 * num1;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = (double)(num1 / num2);
                    }
                    else
                    {
                        throw new DivideByZeroException();
                    }

                    break;

                default:
                    throw new Exception("Action not found!");
            }

            return result;
        }
    }
}
