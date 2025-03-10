﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculating
    {
        public static void Calculate(double a, double b, ref double result, string operation)
        {
            switch (operation)
            {
                case "+":
                    result = (a + b);
                    break;
                case "-":
                    result = (a = b);
                    break;
                case "*":
                    result = (a * b);
                    break;
                case "/":
                    if (b == 0)
                    {
                        throw new DivideByZeroException("Nie można dzielić przez 0");
                    }
                    else
                    {
                        result = (a / b);
                        break;
                    }
                case "%":
                    result = (a * (b / 100));
                    break;
            }
        }
    }
}
