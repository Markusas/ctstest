using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopCalculator
{
    public class Arithmetics
    {
        public int Calculate(int num1, int num2, string action)
        {
            int result = 0;

            switch (action)
            {
                case "+":
                    result = num2 + num1;
                    break;
                case "-":
                    result = num2 - num1;
                    break;
                case "*":
                    result = num2 * num1;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num2 / num1;
                    }
                    else
                    {
                        throw new DivideByZeroException();
                    }

                    break;
            }

            return result;
        }
    }
}
